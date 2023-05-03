using Access;
using Npgsql;
using SysAux.Interfaces;
using SysAux.ObjetosDestinatario;
using SysAux.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.SolicitacaoProdut
{
    public class SolicitacaoProduto : ISolicitacao
    {

        private Destinatario destinatario;
        public int Id { get; set; }
        public Destinatario Destinatario
        {
            get
            {
                return destinatario;

            }
            set { destinatario = value; }
        }
        public int IdClienteDestinatario { get; set; }
        private List<ProdutoResponse> _produtos;
        public List<ProdutoResponse> Produtos
        {
            get
            {
                if (_produtos == null)
                {
                    _produtos = GetItensSolicitacao(Id);
                }
                return _produtos;
            }
            set
            {
                _produtos = value;
            }
        }
        public StatusSolicitacao Status { get; set; }
        public DateTime DataSolicitacao { get; set; }
        public string ArquivoOrigem { get; set; }
        public int IdMarketplace { get ; set; }

        public static SolicitacaoProduto ConvertSolicitacaoProduto(Solicitacao solicitacao) =>
             new SolicitacaoProduto
             {
                 Destinatario = solicitacao.Destinatario,
                 Produtos = solicitacao.Produtos,
                 Status = solicitacao.Status
             };



        private static bool ExisteDestinatario(long cpf)
        {
            try
            {
                if (Destinatario.Exists(cpf))
                {
                    return true;
                }
            }
            catch { }
            return false;
        }



        public bool Inserir()
        {
            bool result = false;
            if (Destinatario != null && Produtos?.Count > 0)
            {

                if (!ExisteDestinatario(Destinatario.CpfCnpj))
                {
                    IdClienteDestinatario = Destinatario.IdClienteDestinatario = Destinatario.InsertCliente();
                }
                else
                    Destinatario = Destinatario.ObterPorCPF(Destinatario.CpfCnpj);

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_solicitacao_produto (id_cliente_destinatario, status, data_solicitacao) " +
                    "VALUES (@id_cliente_destinatario, @status, @data_solicitacao) RETURNING id_solicitacao;");
                cmd.Parameters.AddWithValue(@"id_cliente_destinatario", Destinatario.IdClienteDestinatario);
                cmd.Parameters.AddWithValue(@"status", (int)Status);
                cmd.Parameters.AddWithValue(@"data_solicitacao", DateTime.Now);

                int id_solicitacao = Convert.ToInt32(PGAccess.ExecuteScalar(cmd).ToString() ??
                    throw new Exception("Erro ao cadastrar solicitação!"));

                if (id_solicitacao > 0)
                {
                    foreach (var prod in Produtos)
                    {
                        cmd = new NpgsqlCommand($"INSERT INTO sysgestao.tb_item_solicitacao" +
                            $" (id_solicitacao, id_produto, quantidade) VALUES (@id_solicitacao, @id_produto, @quantidade)");
                        cmd.Parameters.AddWithValue(@"id_solicitacao", id_solicitacao);
                        cmd.Parameters.AddWithValue(@"id_produto", prod.Id);
                        cmd.Parameters.AddWithValue(@"quantidade", prod.Quantidade);
                        PGAccess.ExecuteNonQuery(cmd);

                        Produto.Produto.BaixarEstoque(prod.Id, prod.Quantidade);
                    }
                    result = true;
                }
            }
            return result;
        }
        public static List<ProdutoResponse> GetItensSolicitacao(int idSolicitacao)
        {
            List<ProdutoResponse> result = new List<ProdutoResponse>();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_item_solicitacao WHERE id_solicitacao = $$" + idSolicitacao + "$$;");

            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(ConvertDataRowToProdutoResponse(row));
            }
            return result;
        }

        public static ProdutoResponse ConvertDataRowToProdutoResponse(DataRow dr)
        {

            ProdutoResponse result = null;
            int id = dr["id_produto"] != DBNull.Value ? Convert.ToInt32(dr["id_produto"].ToString()) : 0;
            if (id > 0)
                result = Produto.Produto.GetById(id);
            else
                throw new Exception("Ocorreu um erro ao carregar o produto!");

            int quantidade = dr["quantidade"] != DBNull.Value ? Convert.ToInt32(dr["quantidade"].ToString()) : 0;
            result.Quantidade = quantidade;
            return result;

        }

        public static IEnumerable<SolicitacaoProduto> GetSolicitacao(int limit = 0)
        {
            List<SolicitacaoProduto> result = new List<SolicitacaoProduto>();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_solicitacao_produto" + (limit > 0 ? $" LIMIT {limit};" : ";"));
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(ConvertDataRowToSolicitacaoProduto(row));
            }
            return result;
        }

        public static IEnumerable<SolicitacaoProduto> GetSolicitacaoByData(DateTime data, int limit = 0)
        {
            List<SolicitacaoProduto> result = new List<SolicitacaoProduto>();
            NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_solicitacao_produto WHERE data_solicitacao >= to_timestamp('" + data.ToString("dd/MM/yyyy") + "','dd/MM/yyyy')" + (limit > 0 ? $" LIMIT {limit};" : ";"));
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(ConvertDataRowToSolicitacaoProduto(row));
            }
            return result;
        }

        public static IEnumerable<SolicitacaoProduto> GetSolicitacaoByDestinatario(string data, int limit = 0)
        {
            List<SolicitacaoProduto> result = new List<SolicitacaoProduto>();
            NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_solicitacao_produto WHERE nome_destinatario LIKE $${data}%$$" + (limit > 0 ? $" LIMIT {limit};" : ";"));

            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(ConvertDataRowToSolicitacaoProduto(row));
            }

            if (!result.Any())
            {
                cmd = new NpgsqlCommand($"select * from sysgestao.tb_solicitacao_produto as s inner join sysgestao.tb_cliente_destinatario as c ON " +
                    $"s.id_cliente_destinatario = c.id_cliente_destinatario WHERE c.nome LIKE $${data}%$$;" + (limit > 0 ? $" LIMIT {limit};" : ";"));

                foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
                {
                    result.Add(ConvertDataRowToSolicitacaoProduto(row));
                }
            }
            return result;
        }


        public static SolicitacaoProduto ConvertDataRowToSolicitacaoProduto(DataRow dr)
        {
            SolicitacaoProduto result = new SolicitacaoProduto();

            result.Destinatario = new SysAux.ObjetosDestinatario.Destinatario();
            result.Destinatario.Nome = dr["nome_destinatario"] != DBNull.Value ? dr["nome_destinatario"].ToString() : "";

            if (result.Destinatario.Nome == string.Empty)
            {
                int idDestinatario;
                int.TryParse(dr["id_cliente_destinatario"]?.ToString(), out idDestinatario);

                result.Destinatario.IdClienteDestinatario = result.IdClienteDestinatario = idDestinatario;
            }


            result.Id = dr["id_solicitacao"] != DBNull.Value ? Convert.ToInt32(dr["id_solicitacao"].ToString()) : -1;
            result.Status = (StatusSolicitacao)Enum.Parse(typeof(StatusSolicitacao), dr["status"].ToString());
            result.DataSolicitacao = dr["data_solicitacao"] != DBNull.Value ? Convert.ToDateTime(dr["data_solicitacao"].ToString())
                : new DateTime();
            result.ArquivoOrigem = dr["arquivo_origem"].ToString();

            return result;

        }

        public Solicitacao ToSolicitacao()
        {
            return new Solicitacao
            {
                ArquivoOrigem = ArquivoOrigem,
                DataSolicitacao = DataSolicitacao,
                Destinatario = Destinatario,
                Id = Id,
                Produtos = Produtos,
                Status = Status
            };
        }
        #region OLD
        /*public bool Insert()
        {
            if (Destinatario != null && Produtos?.Count > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_solicitacao_produto (nome_destinatario, status, data_solicitacao) " +
                    "VALUES (@nome_destinatario, @status, @data_solicitacao) RETURNING id_solicitacao;");
                cmd.Parameters.AddWithValue(@"nome_destinatario", Destinatario.Nome);
                cmd.Parameters.AddWithValue(@"status", (int)Status);
                cmd.Parameters.AddWithValue(@"data_solicitacao", DateTime.Now);

                int id_solicitacao = Convert.ToInt32(PGAccess.ExecuteScalar(cmd).ToString() ??
                    throw new Exception("Erro ao cadastrar solicitação!"));

                if (id_solicitacao > 0)
                {
                    foreach (var prod in Produtos)
                    {
                        cmd = new NpgsqlCommand($"INSERT INTO sysgestao.tb_item_solicitacao" +
                            $" (id_solicitacao, id_produto, quantidade) VALUES (@id_solicitacao, @id_produto, @quantidade)");
                        cmd.Parameters.AddWithValue(@"id_solicitacao", id_solicitacao);
                        cmd.Parameters.AddWithValue(@"id_produto", prod.Id);
                        cmd.Parameters.AddWithValue(@"quantidade", prod.Quantidade);
                        PGAccess.ExecuteNonQuery(cmd);
                    }
                }
            }
            return false;
        }*/

        #endregion


        public static bool Excluir(int id)
        {
            bool result = false;
            if (id > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand($"DELETE FROM sysgestao.tb_item_solicitacao WHERE id_solicitacao = {id};");
                PGAccess.ExecuteNonQuery(cmd);

                cmd = new NpgsqlCommand($"DELETE FROM sysgestao.tb_solicitacao_produto WHERE id_solicitacao = {id};");
                PGAccess.ExecuteNonQuery(cmd);
                result = true;
            }
            return result;
        }



        public static IEnumerable<ISolicitacao> GetSolicitacao(int limit = 0, bool distinctDestinatario = false)
        {
            List<SolicitacaoProduto> result = new List<SolicitacaoProduto>();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_solicitacao_produto" + (limit > 0 ? $" LIMIT {limit};" : ";"));
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(ConvertDataRowToSolicitacaoProduto(row));
            }

            if (distinctDestinatario)
                return result.Distinct(new EqualityComparemDestinatarioSolicitacao());
            else
                return result;

        }

        public static List<ProdutoResponse> GetItensByDestinatario(Destinatario destinatario)
        {

            var result = new List<ProdutoResponse>();
            NpgsqlCommand cmd;

            if (destinatario.CpfCnpj > 0)
            {
                string query = "select x.codigo_sku, x.variacao, p.quantidade, x.descricao, d.nome " +
                    "from sysgestao.tb_item_solicitacao as p join sysgestao.tb_solicitacao_produto as S " +
                    "ON p.id_solicitacao = s.id_solicitacao " +
                    "inner join sysgestao.tb_produto as x on p.id_produto = x.id_produto " +
                    "inner join sysgestao.tb_cliente_destinatario as d ON d.id_cliente_destinatario = s.id_cliente_destinatario " +
                    $"WHERE d.cpfcnpj = {destinatario.CpfCnpj}";

                cmd = new NpgsqlCommand(query);
                foreach (DataRow dr in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
                {
                    result.Add( PreSolicitacao.ConvertDataRowToProdutoResponse(dr));
                }
            }

            else if (!result.Any())
            {
                string query = "select x.codigo_sku, x.variacao, p.quantidade, x.descricao, S.nome_destinatario" +
                  " from sysgestao.tb_item_solicitacao as p" +
                   "join sysgestao.tb_solicitacao_produto as S" +
                   "ON p.id_solicitacao = s.id_solicitacao" +
                   "inner join sysgestao.tb_produto as x on p.id_produto = x.id_produto" +
                   $"WHERE UPPER(S.nome_destinatario) LIKE UPPER('{destinatario.Nome}%')";

                cmd = new NpgsqlCommand(query);
                foreach (DataRow dr in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
                {
                    result.Add(PreSolicitacao.ConvertDataRowToProdutoResponse(dr));
                }
            }
            return result;



        }

        public bool VerificaEAtualizaTabelaDestinatario()
        {
            throw new NotImplementedException();
        }
    }




    public class EqualityComparemDestinatarioSolicitacao : EqualityComparer<SolicitacaoProduto>
    {
        public EqualityComparemDestinatarioSolicitacao()
        {

        }


        public override bool Equals(SolicitacaoProduto x, SolicitacaoProduto y)
        {
            return x.Destinatario.Nome == y.Destinatario.Nome;
        }

        public override int GetHashCode(SolicitacaoProduto obj)
        {
            return obj.Destinatario.Nome.GetHashCode();
        }
    }
}

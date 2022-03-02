using Access;
using Npgsql;
using SysAux.Interfaces;
using SysAux.ObjetosDestinatario;
using SysAux.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.SolicitacaoProdut
{
    public class SolicitacaoProduto : ISolicitacao
    {
        public int Id { get; set; }
        public Destinatario Destinatario { get; set; }

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

        public static SolicitacaoProduto ConvertSolicitacaoProduto(Solicitacao solicitacao) =>
             new SolicitacaoProduto
             {
                 Destinatario = solicitacao.Destinatario,
                 Produtos = solicitacao.Produtos,
                 Status = solicitacao.Status
             };

        public bool Inserir()
        {
            bool result = false;
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
            return result;
        }


        public static SolicitacaoProduto ConvertDataRowToSolicitacaoProduto(DataRow dr)
        {
            return new SolicitacaoProduto
            {
                Id = dr["id_solicitacao"] != DBNull.Value ? Convert.ToInt32(dr["id_solicitacao"].ToString()) : -1,
                Destinatario = new Destinatario
                {
                    Nome = dr["nome_destinatario"].ToString()
                },
                Status = (StatusSolicitacao)Enum.Parse(typeof(StatusSolicitacao), dr["status"].ToString()),
                DataSolicitacao = dr["data_solicitacao"] != DBNull.Value ? Convert.ToDateTime(dr["data_solicitacao"].ToString()) : new DateTime(),
                ArquivoOrigem = dr["arquivo_origem"].ToString()
            };
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

    }
}

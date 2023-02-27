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
    public class PreSolicitacao : ISolicitacao
    {
        public int Id { get; set; }

        private Destinatario _destinatario { get; set; }
        public Destinatario Destinatario
        {
            get
            {
                if ((_destinatario == null || _destinatario.Nome == string.Empty) && IdClienteDestinatario > 0)
                {
                    _destinatario = Destinatario.ObterPorID(IdClienteDestinatario);
                }
                return _destinatario;
            }
            set
            {
                _destinatario = value;
            }
        }

        private List<ProdutoResponse> _produtos;
        public List<ProdutoResponse> Produtos
        {
            get
            {
                if (_produtos == null)
                {
                    _produtos = GetItensPreSolicitacao(Id);
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
        public int IdClienteDestinatario { get; set; }



        public PreSolicitacao()
        {

        }


        public PreSolicitacao(DataRow dr)
        {
            Id = dr["id_pre_solicitacao"] != DBNull.Value ? Convert.ToInt32(dr["id_pre_solicitacao"].ToString()) : -1;
            DataSolicitacao = dr["data_solicitacao"] != null ? DateTime.Parse(dr["data_solicitacao"].ToString()) : new DateTime();
            ArquivoOrigem = dr["arquivo_origem"].ToString();

            Destinatario = new SysAux.ObjetosDestinatario.Destinatario();
            Destinatario.Nome = dr["nome_destinatario"].ToString();

            if (Destinatario.Nome == string.Empty)
            {
                int idDestinatario;
                int.TryParse(dr["id_cliente_destinatario"]?.ToString(), out idDestinatario);

                IdClienteDestinatario = idDestinatario;
            }

        }


        public static void Inserir(ISolicitacao solicitacao, bool inserirLog = false)
        {
            if (solicitacao.Destinatario != null && solicitacao.Produtos?.Count > 0)
            {
                if (!ExisteDestinatario(solicitacao.Destinatario.CpfCnpj))
                {
                    solicitacao.IdClienteDestinatario = solicitacao.Destinatario.IdClienteDestinatario = solicitacao.Destinatario.InsertCliente();
                }
                else
                    solicitacao.Destinatario = Destinatario.ObterPorCPF(solicitacao.Destinatario.CpfCnpj);

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_pre_solicitacao_produto ( arquivo_origem, data_solicitacao, id_cliente_destinatario) " +
                    "VALUES (@arquivo_origem, @data_solicitacao, @id_cliente_destinatario) RETURNING id_pre_solicitacao;");
                //cmd.Parameters.AddWithValue(@"nome_destinatario", solicitacao.Destinatario.Nome);
                cmd.Parameters.AddWithValue(@"arquivo_origem", solicitacao.ArquivoOrigem);
                cmd.Parameters.AddWithValue(@"data_solicitacao", DateTime.Now);
                cmd.Parameters.AddWithValue(@"id_cliente_destinatario", solicitacao.Destinatario.IdClienteDestinatario);

                int id_solicitacao = Convert.ToInt32(PGAccess.ExecuteScalar(cmd).ToString() ??
                    throw new Exception("Erro ao cadastrar solicitação!"));

                if (id_solicitacao > 0)
                {
                    foreach (var prod in solicitacao.Produtos)
                    {
                        cmd = new NpgsqlCommand($"INSERT INTO sysgestao.tb_item_pre_solicitacao" +
                            $" (id_pre_solicitacao, codigo_sku, variacao, descricao, quantidade) VALUES (@id_pre_solicitacao, @codigo_sku, @variacao, @descricao, @quantidade);");
                        cmd.Parameters.AddWithValue(@"id_pre_solicitacao", id_solicitacao);
                        cmd.Parameters.AddWithValue(@"codigo_sku", prod.CodigoSKU);
                        cmd.Parameters.AddWithValue(@"variacao", prod.Variacao);
                        cmd.Parameters.AddWithValue(@"quantidade", prod.Quantidade);
                        cmd.Parameters.AddWithValue(@"descricao", prod.Descricao);
                        PGAccess.ExecuteNonQuery(cmd);
                    }
                }
            }
        }

        public static IEnumerable<PreSolicitacao> GetPreSolicitacao(int limit = 0, bool distinctDestinatario = false)
        {
            List<PreSolicitacao> result = new List<PreSolicitacao>();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_pre_solicitacao_produto" + (limit > 0 ? $" LIMIT {limit};" : ";"));
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new PreSolicitacao(row));
            }

            if (distinctDestinatario)
                return result.Distinct(new EqualityComparemDestinatarioPreSolicitacao());
            else
                return result;

        }

        public static List<ProdutoResponse> GetItensPorDestinatario(string param)
        {
            List<ProdutoResponse> result = new List<ProdutoResponse>();

            NpgsqlCommand cmd;

            cmd = new NpgsqlCommand($"select c.nome_destinatario, i.codigo_sku, i.variacao, i.quantidade from sysgestao.tb_pre_solicitacao_produto as c INNER JOIN sysgestao.tb_item_pre_solicitacao" +
                $" AS i ON c.id_pre_solicitacao = i.id_pre_solicitacao where UPPER(c.nome_destinatario) LIKE $${param.ToUpper()}$$");


            foreach (DataRow dr in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(ConvertDataRowToProdutoResponse(dr));
            }

            return result;

        }



        public static List<ProdutoResponse> GetItensPreSolicitacao(int idSolicitacao)
        {
            List<ProdutoResponse> result = new List<ProdutoResponse>();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_item_pre_solicitacao WHERE id_pre_solicitacao = $$" + idSolicitacao + "$$;");

            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(ConvertDataRowToProdutoResponse(row));
            }
            return result;
        }

        public static ProdutoResponse ConvertDataRowToProdutoResponse(DataRow dr)
        {
            return new ProdutoResponse
            {
                CodigoSKU = dr["codigo_sku"].ToString(),
                Variacao = dr["variacao"].ToString(),
                Quantidade = dr["quantidade"] != DBNull.Value ? Convert.ToInt32(dr["quantidade"].ToString()) : 0,
                Descricao = dr["descricao"].ToString()
            };
        }

        public static void Remover(int id)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("delete from sysgestao.tb_item_pre_solicitacao where id_pre_solicitacao = $$" + id + "$$");
            PGAccess.ExecuteNonQuery(cmd);

            cmd = new NpgsqlCommand("DELETE FROM sysgestao.tb_pre_solicitacao_produto where id_pre_solicitacao = $$" + id + "$$;");
            PGAccess.ExecuteNonQuery(cmd);
        }


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
            if (Destinatario != null && Produtos?.Count > 0)
            {
                if (!ExisteDestinatario(Destinatario.CpfCnpj))
                {
                    Destinatario.IdClienteDestinatario = Destinatario.InsertCliente();
                }

                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_pre_solicitacao_produto (data_solicitacao, arquivo_origem, id_cliente_destinatario) " +
                  "VALUES (@data_solicitacao, @arquivo_origem, @id_cliente_destinatario) RETURNING id_pre_solicitacao;");
                //cmd.Parameters.AddWithValue(@"nome_destinatario", Destinatario.Nome);
                cmd.Parameters.AddWithValue(@"id_cliente_destinatario", Destinatario.IdClienteDestinatario);
                cmd.Parameters.AddWithValue(@"arquivo_origem", ArquivoOrigem);
                cmd.Parameters.AddWithValue(@"data_solicitacao", DateTime.Now);

                int id_solicitacao = Convert.ToInt32(PGAccess.ExecuteScalar(cmd).ToString() ??
                    throw new Exception("Erro ao cadastrar solicitação!"));

                if (id_solicitacao > 0)
                {
                    foreach (var prod in Produtos)
                    {
                        cmd = new NpgsqlCommand($"INSERT INTO sysgestao.tb_item_pre_solicitacao" +
                            $" (id_pre_solicitacao, codigo_sku, variacao, descricao, quantidade) VALUES (@id_pre_solicitacao, @codigo_sku, @variacao, @descricao, @quantidade);");
                        cmd.Parameters.AddWithValue(@"id_pre_solicitacao", id_solicitacao);
                        cmd.Parameters.AddWithValue(@"codigo_sku", prod.CodigoSKU);
                        cmd.Parameters.AddWithValue(@"variacao", prod.Variacao);
                        cmd.Parameters.AddWithValue(@"quantidade", prod.Quantidade);
                        cmd.Parameters.AddWithValue(@"descricao", prod.Descricao);
                        PGAccess.ExecuteNonQuery(cmd);
                    }
                    return true;
                }
            }
            return false;
        }

        public SolicitacaoProduto ToSolicitacaoProduto()
        {
            return new SolicitacaoProduto
            {
                Id = this.Id,
                Destinatario = this.Destinatario,
                ArquivoOrigem = this.ArquivoOrigem,
                DataSolicitacao = DateTime.Now,
                Produtos = this.Produtos
            };
        }

        public static bool ArquivoJaImportado(string origem)
        {
            NpgsqlCommand cmd = new NpgsqlCommand($"select id_pre_solicitacao from sysgestao.tb_pre_solicitacao_produto where arquivo_origem like $${origem}$$");

            return PGAccess.ExecuteReader(cmd).Tables[0]?.Rows?.Count > 0;
        }

        public bool VerificaEAtualizaTabelaDestinatario()
        {
            if (Destinatario.Exists(Destinatario.CpfCnpj))
            {
                Destinatario = Destinatario.ObterPorCPF(Destinatario.CpfCnpj);
            }

            throw new NotImplementedException();
        }
    }

    public class EqualityComparemDestinatarioPreSolicitacao : EqualityComparer<PreSolicitacao>
    {
        public EqualityComparemDestinatarioPreSolicitacao()
        {

        }


        public override bool Equals(PreSolicitacao x, PreSolicitacao y)
        {
            return x.Destinatario.Nome == y.Destinatario.Nome;
        }

        public override int GetHashCode(PreSolicitacao obj)
        {
            return obj.Destinatario.Nome.GetHashCode();
        }
    }
}

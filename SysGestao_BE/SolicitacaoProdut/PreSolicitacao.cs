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
        public Destinatario Destinatario { get; set; }

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


        public PreSolicitacao()
        {

        }
        public PreSolicitacao(DataRow dr)
        {
            Id = dr["id_pre_solicitacao"] != DBNull.Value ? Convert.ToInt32(dr["id_pre_solicitacao"].ToString()) : -1;

            Destinatario = new SysAux.ObjetosDestinatario.Destinatario();
            Destinatario.Nome = dr["nome_destinatario"].ToString();
        }


        public static void Inserir(ISolicitacao solicitacao, bool inserirLog = false)
        {
            if (solicitacao.Destinatario != null && solicitacao.Produtos?.Count > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_pre_solicitacao_produto (nome_destinatario, arquivo_origem) " +
                    "VALUES (@nome_destinatario, @arquivo_origem) RETURNING id_pre_solicitacao;");
                cmd.Parameters.AddWithValue(@"nome_destinatario", solicitacao.Destinatario.Nome);
                cmd.Parameters.AddWithValue(@"arquivo_origem", solicitacao.ArquivoOrigem);

                int id_solicitacao = Convert.ToInt32(PGAccess.ExecuteScalar(cmd).ToString() ??
                    throw new Exception("Erro ao cadastrar solicitação!"));

                if (id_solicitacao > 0)
                {
                    foreach (var prod in solicitacao.Produtos)
                    {
                        cmd = new NpgsqlCommand($"INSERT INTO sysgestao.tb_item_pre_solicitacao" +
                            $" (id_pre_solicitacao, codigo_sku, variacao, quantidade) VALUES (@id_pre_solicitacao, @codigo_sku, @variacao, @quantidade);");
                        cmd.Parameters.AddWithValue(@"id_pre_solicitacao", id_solicitacao);
                        cmd.Parameters.AddWithValue(@"codigo_sku", prod.CodigoSKU);
                        cmd.Parameters.AddWithValue(@"variacao", prod.Variacao);
                        cmd.Parameters.AddWithValue(@"quantidade", prod.Quantidade);
                        PGAccess.ExecuteNonQuery(cmd);
                    }
                }
            }
        }

        public static IEnumerable<PreSolicitacao> GetPreSolicitacao(int limit = 0)
        {
            List<PreSolicitacao> result = new List<PreSolicitacao>();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from sysgestao.tb_pre_solicitacao_produto" + (limit > 0 ? $" LIMIT {limit};" : ";"));
            foreach (DataRow row in PGAccess.ExecuteReader(cmd).Tables[0].Rows)
            {
                result.Add(new PreSolicitacao(row));
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
                Quantidade = dr["quantidade"] != DBNull.Value ? Convert.ToInt32(dr["quantidade"].ToString()) : 0
            };
        }

        public static void Remover(int id)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("delete from sysgestao.tb_item_pre_solicitacao where id_pre_solicitacao = $$" + id + "$$");
            PGAccess.ExecuteNonQuery(cmd);

            cmd = new NpgsqlCommand("DELETE FROM sysgestao.tb_pre_solicitacao_produto where id_pre_solicitacao = $$" + id + "$$;");
            PGAccess.ExecuteNonQuery(cmd);
        }

        public bool Inserir()
        {
            if (Destinatario != null && Produtos?.Count > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_pre_solicitacao_produto (nome_destinatario, arquivo_origem) " +
                    "VALUES (@nome_destinatario, @arquivo_origem) RETURNING id_pre_solicitacao;");
                cmd.Parameters.AddWithValue(@"nome_destinatario", Destinatario.Nome);
                cmd.Parameters.AddWithValue(@"arquivo_origem", ArquivoOrigem);

                int id_solicitacao = Convert.ToInt32(PGAccess.ExecuteScalar(cmd).ToString() ??
                    throw new Exception("Erro ao cadastrar solicitação!"));

                if (id_solicitacao > 0)
                {
                    foreach (var prod in Produtos)
                    {
                        cmd = new NpgsqlCommand($"INSERT INTO sysgestao.tb_item_pre_solicitacao" +
                            $" (id_pre_solicitacao, codigo_sku, variacao, quantidade) VALUES (@id_pre_solicitacao, @codigo_sku, @variacao, @quantidade);");
                        cmd.Parameters.AddWithValue(@"id_pre_solicitacao", id_solicitacao);
                        cmd.Parameters.AddWithValue(@"codigo_sku", prod.CodigoSKU);
                        cmd.Parameters.AddWithValue(@"variacao", prod.Variacao);
                        cmd.Parameters.AddWithValue(@"quantidade", prod.Quantidade);
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
    }
}

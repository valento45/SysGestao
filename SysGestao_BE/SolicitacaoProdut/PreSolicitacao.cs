using Access;
using Npgsql;
using SysAux.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.SolicitacaoProdut
{
    public class PreSolicitacao : Solicitacao
    {

        public static void InserirPreSolicitacao(Solicitacao solicitacao)
        {
            if (solicitacao.Destinatario != null && solicitacao.Produtos?.Count > 0)
            {
                NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_pre_solicitacao_produto (nome_destinatario, status, data_solicitacao) " +
                    "VALUES (@nome_destinatario, @status, @data_solicitacao) RETURNING id_solicitacao;");
                cmd.Parameters.AddWithValue(@"nome_destinatario", solicitacao.Destinatario.Nome);
                cmd.Parameters.AddWithValue(@"status", (int)StatusSolicitacao.Pendente);
                cmd.Parameters.AddWithValue(@"data_solicitacao", DateTime.Now);
                cmd.Parameters.AddWithValue(@"arquivo_origem", solicitacao.ArquivoOrigem);

                int id_solicitacao = Convert.ToInt32(PGAccess.ExecuteScalar(cmd).ToString() ??
                    throw new Exception("Erro ao cadastrar solicitação!"));

                if (id_solicitacao > 0)
                {
                    foreach (var prod in solicitacao.Produtos)
                    {
                        cmd = new NpgsqlCommand($"INSERT INTO sysgestao.tb_item_pre_solicitacao" +
                            $" (id_solicitacao, codigo_sku, variacao, quantidade) VALUES (@id_solicitacao, @codigo_sku, @variacao, @quantidade);");
                        cmd.Parameters.AddWithValue(@"id_pre_solicitacao", id_solicitacao);
                        cmd.Parameters.AddWithValue(@"codigo_sku", prod.CodigoSKU);
                        cmd.Parameters.AddWithValue(@"variacao", prod.Variacao);
                        cmd.Parameters.AddWithValue(@"quantidade", prod.Quantidade);
                        PGAccess.ExecuteNonQuery(cmd);
                    }
                }
            }
        }
    }
}

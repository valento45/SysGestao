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
    public class SolicitacaoProduto : Solicitacao
    {
        public static SolicitacaoProduto ConvertSolicitacaoProduto(Solicitacao solicitacao) =>
             new SolicitacaoProduto
             {
                 Destinatario = solicitacao.Destinatario,
                 Produtos = solicitacao.Produtos,
                 Status = solicitacao.Status
             };

        public bool Insert()
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
        }

        
    }
}

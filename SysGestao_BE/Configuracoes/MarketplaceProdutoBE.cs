using Access;
using Npgsql;
using SysAux.Configuracoes;
using SysAux.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SysGestao_BE.Configuracoes
{
    public class MarketplaceProdutoBE
    {

        public static bool Inserir(MarketplaceProdutoConfig marketplaceProdutoConfig)
        {

            try
            {
                if (marketplaceProdutoConfig.IdKey > 0)
                   return Update(marketplaceProdutoConfig);

                else
                {

                    NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO sysgestao.tb_marketplace_produto (id_marketplace, id_produto, codigo_sku) " +
                        "VALUES (@id_marketplace, @id_produto, @codigo_sku) RETURNING id_key;");

                    cmd.Parameters.AddWithValue(@"id_marketplace", marketplaceProdutoConfig.IdMarketPlace);
                    cmd.Parameters.AddWithValue(@"id_produto", marketplaceProdutoConfig.IdProduto);
                    cmd.Parameters.AddWithValue(@"codigo_sku", marketplaceProdutoConfig.CodigoSKU);

                    marketplaceProdutoConfig.IdKey = (int)PGAccess.ExecuteScalar(cmd);

                    return marketplaceProdutoConfig.IdKey > 0;
                }
            }
            catch (Exception ex)
            {
                throw new QueryException("Ocorreu um erro ao inserir a configuração no banco de dados!", ex.InnerException);
            }
        }

        public static bool Update(MarketplaceProdutoConfig marketplaceProdutoConfig)
        {
            NpgsqlCommand cmd = new NpgsqlCommand("UPDATE sysgestao.tb_marketplace_produto SET codigo_sku = @codigo_sku WHERE " +
                "id_key = @id_key" );
            cmd.Parameters.AddWithValue(@"id_key", marketplaceProdutoConfig.IdKey);
            cmd.Parameters.AddWithValue(@"codigo_sku", marketplaceProdutoConfig.CodigoSKU);

            return PGAccess.ExecuteNonQuery(cmd) > 0;
        }

        public static MarketplaceProdutoConfig ObterConfiguracaoMarketplaceProduto(int idProduto, int idMarketplace)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand($"select * from sysgestao.tb_marketplace_produto where id_produto = {idProduto}" +
                    $" AND id_marketplace = {idMarketplace}");

                var result = PGAccess.ExecuteReader(cmd).Tables[0];

                var obj = new MarketplaceProdutoConfig(result.Rows[0]);
                obj.InformarMarketplace(ConfiguracoesMarketplaceBE.GetMarketplacePorID(obj.IdMarketPlace));

                return obj;
            }
            catch
            {
                return null;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysAux.Configuracoes
{
    public class MarketplaceProdutoConfig
    {

        public int IdKey { get; set; }
        public int IdProduto { get; set; }
        public int IdMarketPlace { get; set; }
        public string CodigoSKU { get; set; }
        public Marketplace Marketplace { get; private set; }

        public MarketplaceProdutoConfig(DataRow dr)
        {
            IdKey = int.Parse(dr["id_key"].ToString());
            IdProduto = int.Parse(dr["id_produto"].ToString());
            IdMarketPlace = int.Parse(dr["id_marketplace"].ToString());
            CodigoSKU = dr["codigo_sku"].ToString();
        }

        public MarketplaceProdutoConfig(int marketplace, string codigoSKU, int idProduto)
        {
            IdMarketPlace = marketplace;
            CodigoSKU = codigoSKU;
            IdProduto = idProduto;

        }

        public void InformarMarketplace(Marketplace marketplace)
        {
            Marketplace = marketplace;
        }
    }
}

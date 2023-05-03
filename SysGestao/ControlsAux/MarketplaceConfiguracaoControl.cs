using SysAux.Configuracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.ControlsAux
{
    public partial class MarketplaceConfiguracaoControl : UserControl
    {
        private Marketplace _marketplace;
        private MarketplaceProdutoConfig _marketplaceProdutoConfigurado;
        private int _idProduto;

        public MarketplaceConfiguracaoControl()
        {
            InitializeComponent();
        }



        public MarketplaceConfiguracaoControl(Marketplace marketplace, int idProduto , string codigoSKU = "") : this()
        {
            _marketplace = marketplace;
            _idProduto = idProduto;

            lblMarketplace.Text = _marketplace.NomeMarketplace;          
            txtCodigoSKU.Text = codigoSKU;

        }

        public MarketplaceConfiguracaoControl(MarketplaceProdutoConfig marketPlaceProdutoConfig) : this()
        {
            _marketplaceProdutoConfigurado = marketPlaceProdutoConfig;

            lblMarketplace.Text = marketPlaceProdutoConfig.Marketplace.NomeMarketplace;
            txtCodigoSKU.Text = marketPlaceProdutoConfig.CodigoSKU;
        }

        public MarketplaceProdutoConfig GetMarketplaceProdutoConfig()
        {
            if (_marketplaceProdutoConfigurado != null)
            {
                _marketplaceProdutoConfigurado.CodigoSKU = txtCodigoSKU.Text;
                return _marketplaceProdutoConfigurado;
            }

            return new MarketplaceProdutoConfig(_marketplace.ID, txtCodigoSKU.Text.Trim(), _idProduto);
        }
    }
}

using SysAux.Configuracoes;
using SysGestao.ControlsAux;
using SysGestao_BE.Configuracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Configuracoes.Marketplaces
{
    public partial class frmConfiguraSKUMarketplace : frmDefault
    {
        protected List<Marketplace> _marketplaces;
        protected int _idProduto;
        public List<MarketplaceProdutoConfig> MarketplacesConfigurado { get; set; }
        public frmConfiguraSKUMarketplace()
        {
            InitializeComponent();
        }

        public frmConfiguraSKUMarketplace(List<Marketplace> marketplaces, int idProduto) : this()
        {
            _marketplaces = marketplaces;
            _idProduto = idProduto;
        }



        private void btSalvar_Click(object sender, EventArgs e)
        {
            try 
            {
                foreach(MarketplaceProdutoConfig mktConfig in ObterMarketplacesConfigurados())
                {
                    MarketplaceProdutoBE.Inserir(mktConfig);
                }

                MessageBox.Show("Configuração salva com sucesso !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            
            } catch { }
        }


        private void CarregarMarketplaces()
        {
            flowPnlMarketplaces.Controls.Clear();

            foreach (var marketplace in _marketplaces)
            {
                var config = MarketplaceProdutoBE.ObterConfiguracaoMarketplaceProduto(_idProduto, marketplace.ID);

                MarketplaceConfiguracaoControl configuracaoControl;
                if (config != null)
                {
                    configuracaoControl = new MarketplaceConfiguracaoControl(config);
                }
                else
                {
                    configuracaoControl = new MarketplaceConfiguracaoControl(marketplace, _idProduto);
                }
                flowPnlMarketplaces.Controls.Add(configuracaoControl);
            }
        }

        public List<MarketplaceProdutoConfig> ObterMarketplacesConfigurados()
        {
            var result = new List<MarketplaceProdutoConfig>();
            foreach(var item in flowPnlMarketplaces.Controls)
            {
                if(item is MarketplaceConfiguracaoControl mktControl)
                {
                    result.Add(mktControl.GetMarketplaceProdutoConfig());
                }
            }

            return result;
        }

        private void frmConfiguraSKUMarketplace_Load(object sender, EventArgs e)
        {
            CarregarMarketplaces();
        }
    }
}

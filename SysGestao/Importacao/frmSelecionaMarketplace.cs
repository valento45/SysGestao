using SysAux.Configuracoes;
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

namespace SysGestao.Importacao
{
    public partial class frmSelecionaMarketplace : frmDefault
    {
        public Marketplace MarketplaceSelecionado { get; set; }
        public frmSelecionaMarketplace()
        {
            InitializeComponent();
        }

        private void frmSelecionaMarketplace_Load(object sender, EventArgs e)
        {
            CarregarMarketplaces();
        }


        private void CarregarMarketplaces()
        {
            var marketplaces = ConfiguracoesMarketplaceBE.GetMarketplaces();

            RefreshMarketplaces(marketplaces);
        }

        private void RefreshMarketplaces(List<Marketplace> marketplaces)
        {
            cmbMarketplaces.DataSource = null;
            cmbMarketplaces.Items.Clear();
            if (marketplaces.Count > 0)
            {
                cmbMarketplaces.DataSource = marketplaces;
                cmbMarketplaces.DisplayMember = "NomeMarketplace";
                cmbMarketplaces.ValueMember = "ID";
            }
            else
            {
                cmbMarketplaces.DataSource = null;
                cmbMarketplaces.Items.Clear();
            }
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            MarketplaceSelecionado = cmbMarketplaces.SelectedItem as Marketplace;
            this.DialogResult = DialogResult.OK;
        }
    }
}

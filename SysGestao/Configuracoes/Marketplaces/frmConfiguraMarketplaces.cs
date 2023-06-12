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

namespace SysGestao.Configuracoes.Marketplaces
{
    public partial class frmConfiguraMarketplaces : frmDefault
    {
        protected List<Marketplace> _marketplaces;
        protected List<Marketplace> _marketplacesRemovidos;
        public frmConfiguraMarketplaces()
        {
            InitializeComponent();
            _marketplaces = new List<Marketplace>();
            _marketplacesRemovidos = new List<Marketplace>();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            foreach (var obj in cmbMarketplaces.Items)
            {
                if (obj is Marketplace item)
                {
                    var configMarketplace = new Marketplace()
                    {
                        ID = item.ID,
                        NomeMarketplace = item.NomeMarketplace
                    };
                    if (configMarketplace?.ID <= 0)
                        ConfiguracoesMarketplaceBE.Insert(configMarketplace);
                }
            }

            if (_marketplacesRemovidos?.Any() ?? false)
                RemoverItensExcluidos();


            RegDirty = false;
            MessageBox.Show("Configurações salva com sucesso !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoverItensExcluidos()
        {
            foreach (var item in _marketplacesRemovidos)
            {
                ConfiguracoesMarketplaceBE.Excluir(item.ID);
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMarketplace.Text.Trim()) && !cmbMarketplaces.Items.Contains(txtMarketplace.Text.Trim()))
            {
                _marketplaces.Add(new Marketplace { ID = 0, NomeMarketplace = txtMarketplace.Text.Trim() });
                RefreshMarketplaces(_marketplaces);
                txtMarketplace.Clear();
                RegDirty = true;
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {

            if (cmbMarketplaces.Items.Count > 0)
            {
                var objRemovido = cmbMarketplaces.SelectedItem as Marketplace;

                _marketplaces.Remove(objRemovido);

                if (objRemovido.ID > 0)
                    _marketplacesRemovidos.Add(objRemovido);

                RefreshMarketplaces(_marketplaces);
                RegDirty = true;
            }
        }

        private void frmConfiguraMarketplaces_Load(object sender, EventArgs e)
        {
            CarregarMarketplaces();
        }

        private void CarregarMarketplaces()
        {
            _marketplaces = ConfiguracoesMarketplaceBE.GetMarketplaces();

            RefreshMarketplaces(_marketplaces);
        }

        private void RefreshMarketplaces(List<Marketplace> marketplaces)
        {
            cmbMarketplaces.DataSource = null;

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

        private void frmConfiguraMarketplaces_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RegDirty)
            {
                if (MessageBox.Show("Existem alterações que não foram salvas !\r\n\r\nDeseja salvar essas alterações?", "Atenção", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    btSalvar.PerformClick();
                }

            }
        }
    }
}

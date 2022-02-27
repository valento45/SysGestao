using SysAux.Response;
using SysGestao_BE.SolicitacaoProdut;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Produtos
{
    public partial class frmConsultarSolicitacoesFinalizadas : frmDefault
    {
        public frmConsultarSolicitacoesFinalizadas()
        {
            InitializeComponent();
        }

        private void frmConsultarSolicitacoesFinalizadas_Load(object sender, EventArgs e)
        {
            AtualizarGridView();
        }

        private void AtualizarGridView()
        {
            List<SolicitacaoProduto> result = new List<SolicitacaoProduto>();

            int indexFiltro = cmbFiltros.SelectedIndex;
            switch (indexFiltro)
            {
                case 1:
                    if (!txtDataSolicitacao.MaskFull)
                    {
                        MessageBox.Show("Preencha a data corretamente!", "Validação de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DateTime data = Convert.ToDateTime(txtDataSolicitacao.Text);
                    result = SolicitacaoProduto.GetSolicitacaoByData(data).ToList();
                    break;

                case 0:
                default:
                    string nome = txtDestinatario.Text.Trim();
                    result = SolicitacaoProduto.GetSolicitacaoByDestinatario(nome).ToList();
                    break;

            };


            dgvSolicitacao.Rows.Clear();
            foreach (var obj in result)
            {
                dgvSolicitacao.Rows.Add(obj.Destinatario.Nome, obj.Status, obj.DataSolicitacao, obj);
            }
        }

        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexFiltro = cmbFiltros.SelectedIndex;

            switch (indexFiltro)
            {
                case 1:
                    pnlFiltrarPorData.Visible = true;
                    pnlFiltroDestinatario.Visible = false;
                    break;

                case 0:
                default:
                    pnlFiltrarPorData.Visible = false;
                    pnlFiltroDestinatario.Visible = true;
                    break;

            };
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            AtualizarGridView();
        }

        private void btVerItens_Click(object sender, EventArgs e)
        {
            if(dgvSolicitacao.SelectedRows?.Count > 0)
            {
                var produto = dgvSolicitacao.SelectedCells[colObj.Index].Value as SolicitacaoProduto;

                using(frmVerItensSolicitacao frm = new frmVerItensSolicitacao(produto.Produtos))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}

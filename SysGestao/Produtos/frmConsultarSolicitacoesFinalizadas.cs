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
            if (dgvSolicitacao.SelectedRows?.Count > 0)
            {
                var produto = dgvSolicitacao.SelectedCells[colObj.Index].Value as SolicitacaoProduto;

                using (frmVerItensSolicitacao frm = new frmVerItensSolicitacao(produto.Produtos))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSolicitacao.SelectedRows?.Count > 0)
                {
                    var produto = dgvSolicitacao.SelectedCells[colObj.Index].Value as SolicitacaoProduto;
                    if (MessageBox.Show($"Deseja realmente excluir a solicitação de '{produto.Destinatario.Nome.ToUpper()}' ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        if (SolicitacaoProduto.Excluir(produto.Id))
                        {
                            dgvSolicitacao.Rows.RemoveAt(dgvSolicitacao.CurrentRow.Index);
                        }
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um produto para excluir !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ! \r\n\r\n\r\n" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

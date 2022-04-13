using SysAux.Interfaces;
using SysAux.Response;
using SysGestao.Relatorios;
using SysGestao.Relatorios.DataSourcesModels;
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
    public partial class frmSolicitacoes : frmDefault
    {
        private readonly IEnumerable<ISolicitacao> _solicitacaos;
        private readonly bool _relatorios;

        public frmSolicitacoes(IEnumerable<ISolicitacao> solicitacaos, bool Relatorios = false)
        {
            InitializeComponent();
            _solicitacaos = solicitacaos;
            _relatorios = Relatorios;
        }


        public void AtualizaGridView()
        {
            dgvProdutos.Rows.Clear();

            foreach (var solicitacao in _solicitacaos)
            {
                dgvProdutos.Rows.Add(solicitacao.Destinatario.Nome, _relatorios ? "Gerar" : "Separar produtos", "Excluir", solicitacao);
            }
            RefreashCountGridView();
        }

        private void frmSolicitacoes_Load(object sender, EventArgs e)
        {
            if (_relatorios)
            {
                dgvProdutos.Columns[colBtnExcluir.Index].Visible = false;
                dgvProdutos.Columns[colBtnSepararProdutos.Index].HeaderText = "Gerar relatório";


            }

            AtualizaGridView();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e?.ColumnIndex == colBtnSepararProdutos.Index)
            {
                if ((sender as DataGridView).SelectedCells[colObj.Index].Value is PreSolicitacao preSolicitacao)
                {
                    if (_relatorios)
                    {

                        using (frmRelPorCliente frm = new frmRelPorCliente(PreSolicitacaoModel.GetPreSolicitacao(preSolicitacao)))
                        {
                            frm.ShowDialog();
                        }
                    }
                    else
                        using (frmSeparacaoDeProdutos frm = new frmSeparacaoDeProdutos(preSolicitacao.ToSolicitacaoProduto()))
                        {
                            var result = frm.ShowDialog();
                            if (result == DialogResult.OK)
                            {
                                dgvProdutos.Rows.Remove(dgvProdutos.CurrentRow);
                                RefreashCountGridView();
                            }
                        }
                }
            }

            else if (e?.ColumnIndex == colBtnExcluir.Index)
            {
                if ((sender as DataGridView).SelectedCells[colObj.Index].Value is PreSolicitacao preSolicitacao)
                {
                    if (MessageBox.Show("Deseja excluir a solicitação selecionada ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        PreSolicitacao.Remover(preSolicitacao.Id);
                        dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
                        RefreashCountGridView();
                    }
                }
            }
        }

        public void RefreashCountGridView()
        {
            lblQtd.Text = dgvProdutos.RowCount.ToString();
        }

    }
}

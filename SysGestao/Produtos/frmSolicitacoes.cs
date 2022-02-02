using SysAux.Interfaces;
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
    public partial class frmSolicitacoes : frmDefault
    {
        private readonly IEnumerable<ISolicitacao> _solicitacaos;

        public frmSolicitacoes(IEnumerable<ISolicitacao> solicitacaos)
        {
            InitializeComponent();
            _solicitacaos = solicitacaos;
        }
        public void AtualizaGridView()
        {
            dgvProdutos.Rows.Clear();

            foreach (var solicitacao in _solicitacaos)
            {
                dgvProdutos.Rows.Add(solicitacao.Destinatario.Nome, "Separar produtos", solicitacao);
            }  
        }

        private void frmSolicitacoes_Load(object sender, EventArgs e)
        {
            AtualizaGridView();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e?.ColumnIndex == colBtnSepararProdutos.Index)
            {                
                if ((sender as DataGridView).SelectedCells[colObj.Index].Value is PreSolicitacao preSolicitacao)
                {
                    using (frmSeparacaoDeProdutos frm = new frmSeparacaoDeProdutos(preSolicitacao.ToSolicitacaoProduto()))
                    {
                        var result = frm.ShowDialog();
                        if(result == DialogResult.OK)
                        {
                            dgvProdutos.Rows.Remove(dgvProdutos.CurrentRow);
                        }
                    }
                }
            }
        }
    }
}

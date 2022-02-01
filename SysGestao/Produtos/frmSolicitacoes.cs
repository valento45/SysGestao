using SysAux.Response;
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
        private readonly IEnumerable<Solicitacao> _solicitacaos;

        public frmSolicitacoes(IEnumerable<Solicitacao> solicitacaos)
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
                var solicitacao = (sender as DataGridView).SelectedCells[colObj.Index].Value as Solicitacao;
                using (frmSeparacaoDeProdutos frm = new frmSeparacaoDeProdutos(solicitacao))
                {
                    var result = frm.ShowDialog();
                }
            }
        }
    }
}

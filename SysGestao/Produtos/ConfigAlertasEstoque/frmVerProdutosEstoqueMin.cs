using SysGestao_BE.AlertasEstoque;
using SysGestao_BE.Produto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Produtos.ConfigAlertasEstoque
{
    public partial class frmVerProdutosEstoqueMin : frmDefault
    {
        private ConfiguracaoDeAlertas _configAlertas;
        public frmVerProdutosEstoqueMin( ConfiguracaoDeAlertas configAlertas)
        {
            InitializeComponent();
            _configAlertas = configAlertas;
        }

        private void frmVerProdutosEstoqueMin_Shown(object sender, EventArgs e)
        {
            AtualizarGridView();
        }

        private void AtualizarGridView()
        {
            dgvProdutos.Rows.Clear();
            foreach (var x in _configAlertas.Produtos)
                dgvProdutos.Rows.Add(x.Id, x.CodigoSKU, x.Variacao, x.Quantidade, x);
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                var produto = dgvProdutos.SelectedCells[colObj.Index]?.Value as Produto;
                if (produto != null)
                {
                    using (frmCadastrarProduto frm = new frmCadastrarProduto(produto, false, true))
                    {
                        frm.ShowDialog();

                        if (frm.GetProduto().Quantidade > _configAlertas.QuantidadeMinima)
                        {
                            dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentRow.Index);
                            _configAlertas.Produtos.Remove(frm.GetProduto());
                        }

                        else
                            dgvProdutos.SelectedCells[colQtd.Index].Value = frm.GetProduto().Quantidade;

                    }
                }
            }
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

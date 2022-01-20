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

namespace SysGestao.Produtos
{
    public partial class frmConsultarProdutos : frmDefault
    {
        public frmConsultarProdutos()
        {
            InitializeComponent();
        }

        private void ListarProdutos()
        {
            dgvProdutos.Rows.Clear();

            foreach (var x in Produto.ListarProdutos())
            {
                dgvProdutos.Rows.Add(x.Id, x.CodigoSKU, x.Cor, x.Tamanho, x.Quantidade, x.Variacao, x.Descricao, x);
            }
        }

        private void frmConsultarProdutos_Shown(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            switch (cmbFiltros.SelectedIndex)
            {
                case 0:
                    ListarPorCodigoSKU(txtFiltro.Text);
                    break;

                case 1:
                    ListarPorVariacao(txtFiltro.Text);
                    break;
            }
        }
        private void ListarPorCodigoSKU(string codigo)
        {
            dgvProdutos.Rows.Clear();

            foreach (var x in Produto.GetByCodigoSku(codigo))
            {
                dgvProdutos.Rows.Add(x.Id, x.CodigoSKU, x.Cor, x.Tamanho, x.Quantidade, x.Variacao, x.Descricao, x);
            }
        }

        private void ListarPorVariacao(string variacao)
        {
            dgvProdutos.Rows.Clear();

            foreach (var x in Produto.GetByVariacao(variacao))
            {
                dgvProdutos.Rows.Add(x.Id, x.CodigoSKU, x.Cor, x.Tamanho, x.Quantidade, x.Variacao, x.Descricao, x);
            }
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0 && dgvProdutos.SelectedCells.Count > 0)
            {
                var produto = dgvProdutos.SelectedCells[colObj.Index].Value as Produto;
                frmCadastrarProduto frm = new frmCadastrarProduto(produto);

                if(frm.ShowDialog() == DialogResult.OK)
                {
                    ListarProdutos();
                }
            }
            else
                MessageBox.Show("Nenhum produto selecionado!", "Não foi possível alterar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

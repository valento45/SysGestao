using SysAux.Response;
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
    public partial class frmVerItensSolicitacao : frmDefault
    {
        private  List<ProdutoResponse> _itens;

        public frmVerItensSolicitacao(List<ProdutoResponse> itens)
        {
            InitializeComponent();
            _itens = itens;
        }

        private void frmVerItensSolicitacao_Shown(object sender, EventArgs e)
        {
            AtualizaGridView();
        }
        private void AtualizaGridView()
        {
            dgvProdutos.Rows.Clear();

            foreach(var  item in _itens)
            {
                dgvProdutos.Rows.Add(item.Id, item.CodigoSKU, item.Variacao, item.Quantidade, item);
            }
        }

        private void btBuscarProduto_Click(object sender, EventArgs e)
        {
            if( dgvProdutos?.SelectedRows?.Count > 0)
            {
                var produto = dgvProdutos.SelectedCells[colObj.Index].Value as ProdutoResponse ?? throw new Exception("Não foi possível obter os dados do produto!");

                using(frmCadastrarProduto frm = new frmCadastrarProduto(produto as Produto, true))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}

using SysGestao_BE.Produto;
using System;
using System.Windows.Forms;
using System.IO;
using SysAux.BarCode;
using SysAux.Response;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace SysGestao.Produtos
{
    public partial class frmConsultarProdutos : frmDefault
    {

        private readonly bool IsBuscar;
        private StringReader leitor;
        private StreamReader streamToPrint;
        private int numerosSelecionados = 0;
        public Produto ProdutoSelecionado { get; private set; }

        public frmConsultarProdutos()
        {
            InitializeComponent();
        }

        public frmConsultarProdutos(bool isBuscar)
        {
            InitializeComponent();
            IsBuscar = isBuscar;
            if (isBuscar)
            {
                btAcao.Visible = true;
                btExcluir.Visible = false;
                btImprimirEtiqueta.Visible = false;

                btAcao.Text = "Selecionar";

            }
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

                default:
                    ListarPorCodigoSKU(txtFiltro.Text);
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

                CodigoBarras.ConvertBase64ToImage(x.CodigoBarrasBase64);
            }
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            if (!IsBuscar)
            {
                if (dgvProdutos.RowCount > 0 && dgvProdutos.SelectedCells.Count > 0)
                {
                    var produto = dgvProdutos.SelectedCells[colObj.Index].Value as Produto;
                    frmCadastrarProduto frm = new frmCadastrarProduto(produto);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ListarProdutos();
                    }
                }
                else
                    MessageBox.Show("Nenhum produto selecionado!", "Não foi possível alterar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (dgvProdutos.RowCount > 0 && dgvProdutos.SelectedCells.Count > 0)
                {
                    ProdutoSelecionado = dgvProdutos.SelectedCells[colObj.Index].Value as Produto;
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    MessageBox.Show("Nenhum produto selecionado!\r\n\r\nPor favor, verifique!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                try
                {
                    if (ExcluirProduto())
                        btProcurar.PerformClick();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ExcluirProduto()
        {
            var produto = dgvProdutos.SelectedCells[colObj.Index]?.Value as Produto ?? throw new Exception("Selecione algum produto para excluir!");
            if (MessageBox.Show($"Deseja excluir o produto {produto.CodigoSKU} ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                return Produto.Excluir(produto?.Id ?? -1);
            else
                return false;
        }

        public void ConverteImage(object o, PrintPageEventArgs e)
        {
            int pontoImageX = 0;
            int pontoImageY = 50;
            int pontoTextX = 10;
            int pontoTextY = 30;

            int quantidade = 0;
            foreach (var x in GetSelecionados())
            {
                quantidade++;
                string texto = $"{x.sku.ToLower()} {x.Variacao.ToLower()}"; 
                var bytes = Convert.FromBase64String(CodigoBarras.GerarBarCodeLib(x.CodigoBarrasText));
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    Image i = Image.FromStream(ms);
                    Point pImage = new Point(pontoImageX, pontoImageY);
                    Point pText = new Point(pontoTextX, pontoTextY);
                    e.Graphics.DrawImage(i, pImage);
                    e.Graphics.DrawString(texto, Font, Brushes.Black, pText);
                }

                //Posiciona o código de barras
                if (pontoImageX < 300)
                {
                    pontoImageX += 220;
                    pontoTextX += 220;
                }
                else
                {
                    pontoImageX = 0;
                    pontoTextX = 40;
                    pontoImageY += 150;
                    pontoTextY += 150;
                }
            }
        }
        private void btImprimirEtiqueta_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ConverteImage);
            pd.Print();
        }
        private void btnMarcaDesmarca_Click(object sender, EventArgs e)
        {
            MarcaDesmarca();
        }

        private void MarcaDesmarca()
        {
            if (dgvProdutos?.SelectedRows?.Count > 0)
            {
                if (dgvProdutos.CurrentRow.HeaderCell.Value != null && dgvProdutos.CurrentRow.HeaderCell.Value.ToString().CompareTo("►") == 0)
                {
                    dgvProdutos.CurrentRow.HeaderCell.Value = "";
                    numerosSelecionados--;
                }
                else
                {
                    dgvProdutos.CurrentRow.HeaderCell.Value = "►";
                    numerosSelecionados++;
                }
                dgvProdutos.CurrentCell = dgvProdutos[1, dgvProdutos.CurrentRow.Index < dgvProdutos.Rows.Count - 1 ? dgvProdutos.CurrentRow.Index + 1 : dgvProdutos.CurrentRow.Index];
            }
        }

        private List<PDF> GetSelecionados()
        {
            List<PDF> marcados = new List<PDF>();

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (row.HeaderCell.Value.ToString() == "►")
                {
                    var produto = row.Cells[colObj.Index].Value as ProdutoResponse;
                    marcados.Add(new PDF(produto.CodigoSKU, produto.CodigoBarras, produto.CodigoBarrasText, produto.Variacao));
                }
            }
            return marcados;
        }
    }
}

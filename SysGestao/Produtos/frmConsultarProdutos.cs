using SysGestao_BE.Produto;
using System;
using System.Windows.Forms;
using System.IO;
using SysAux.BarCode;
using SysAux.Response;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using SysGestao_BE.Auxx;
using SysGestao_BE.Impressao;

namespace SysGestao.Produtos
{
    public partial class frmConsultarProdutos : frmDefault
    {
        #region PROPRIEDADES PRIVADSA
        private readonly bool IsBuscar;
        #endregion


        #region PROPRIEDADES PUBLICAS
        public Produto ProdutoSelecionado { get; private set; }


        #endregion


        #region CONSTRUTORES
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
                btSelecionar.Visible = true;
                btAcao.Visible = true;
                btExcluir.Visible = false;
                btImprimirEtiqueta.Visible = false;
                btnMarcaDesmarca.Visible = false;

            }
        }

        #endregion

        private void frmConsultarProdutos_Shown(object sender, EventArgs e)
        {
            ListarProdutos();
        }


        #region FILTRO DE BUSCAS
        private void btProcurar_Click(object sender, EventArgs e)
        {
            bool mostrarKit = chkMostrarKits.Checked;

            int limit;
            int.TryParse(txtLimite.Value.ToString(), out limit);

            switch (cmbFiltros.SelectedIndex)
            {
                case 0:
                    ListarPorCodigoSKU(txtFiltro.Text, limit, mostrarKit);
                    break;

                case 1:
                    ListarPorVariacao(txtFiltro.Text, limit, mostrarKit);
                    break;

                default:
                    ListarPorCodigoSKU(txtFiltro.Text, limit, mostrarKit);
                    break;
            }
        }
        private void ListarProdutos()
        {
            PreencherGrid(Produto.ListarProdutos());
        }

        private void ListarPorCodigoSKU(string codigo, int limite = 0, bool mostrarKit = false)
        {
            PreencherGrid(Produto.GetByCodigoSku(codigo, limite, mostrarKit));
        }

        private void ListarPorVariacao(string variacao, int limite = 0, bool mostrarKit = false)
        {
            PreencherGrid(Produto.GetByVariacao(variacao, limite, mostrarKit));
        }

        private void PreencherGrid(IEnumerable<Produto> produtos)
        {
            dgvProdutos.Rows.Clear();

            foreach (var x in produtos)
            {
                dgvProdutos.Rows.Add(x.Id, x.Nome, x.CodigoSKU, x.Cor, x.Tamanho, x.Quantidade, x.Variacao, x.Descricao, x);
            }
        }
        #endregion



        private void btAcao_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0 && dgvProdutos.SelectedCells.Count > 0)
            {
                var produto = dgvProdutos.SelectedCells[colObj.Index].Value as Produto;

                if (!produto.IsKit)
                {
                    frmCadastrarProduto frm = new frmCadastrarProduto(produto, true);

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ListarProdutos();
                    }
                }
                else
                {
                    frmCadastroKitProdutos frm = new frmCadastroKitProdutos(produto);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        ListarProdutos();
                    }
                }
            }
            else
                MessageBox.Show("Nenhum produto selecionado!", "Não foi possível alterar", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                catch (Exception ex) { MessageBox.Show("Ocorreu um erro ao excluir, por favor verifique! \r\n\r\n\r\nDetalhes técnicos: " + ex.Message, "Erro ao excluir", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ExcluirProduto()
        {
            int qtdMarcados = GetQuantidadeMarcados();
            if (qtdMarcados > 0)
            {
                if (MessageBox.Show($"Deseja excluir os produtos selecionados ?\r\n\r\n\r\nQuantidade selecionados: " + qtdMarcados, "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvProdutos.Rows)
                    {
                        if (row.HeaderCell.Value != null)
                            if (row.HeaderCell.Value.ToString() == "►")
                            {
                                var produto = row.Cells[colObj.Index].Value as Produto;
                                Produto.Excluir(produto.Id);
                            }
                    }
                    return true;
                }
                return false;
            }
            else
            {
                var produto = dgvProdutos.SelectedCells[colObj.Index]?.Value as Produto ?? throw new Exception("Selecione algum produto para excluir!");

                if (MessageBox.Show($"Deseja excluir o produto '{produto.CodigoSKU}' ?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    return Produto.Excluir(produto?.Id ?? -1);
                else
                    return false;
            }
        }


        private void btImprimirEtiqueta_Click(object sender, EventArgs e)
        {
            using (frmConfiguraImpressao frm = new frmConfiguraImpressao(new PrintObjeto(GetSelecionados())))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    LimparSelecionados();
            }

        }


        private void btnMarcaDesmarca_Click(object sender, EventArgs e)
        {
            MarcaDesmarca();
        }



        private int GetQuantidadeMarcados()
        {
            int i = 0;
            try
            {
                foreach (DataGridViewRow row in dgvProdutos.Rows)
                {
                    if (row.HeaderCell.Value != null && row.HeaderCell.Value.ToString().CompareTo("►") == 0)
                    {
                        i++;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return i;
        }



        private void MarcaDesmarca()
        {
            if (dgvProdutos?.SelectedRows?.Count > 0)
            {
                if (dgvProdutos.CurrentRow.HeaderCell.Value != null && dgvProdutos.CurrentRow.HeaderCell.Value.ToString().CompareTo("►") == 0)
                {
                    dgvProdutos.CurrentRow.HeaderCell.Value = "";
                }
                else
                {
                    dgvProdutos.CurrentRow.HeaderCell.Value = "►";
                }
                dgvProdutos.CurrentCell = dgvProdutos[1, dgvProdutos.CurrentRow.Index < dgvProdutos.Rows.Count - 1 ? dgvProdutos.CurrentRow.Index + 1 : dgvProdutos.CurrentRow.Index];
            }

            btImprimirEtiqueta.Enabled = GetQuantidadeMarcados() > 0;
        }



        private List<EtiquetaPDF> GetSelecionados()
        {
            List<EtiquetaPDF> marcados = new List<EtiquetaPDF>();

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (row.HeaderCell.Value != null)
                    if (row.HeaderCell.Value.ToString() == "►")
                    {
                        var produto = row.Cells[colObj.Index].Value as ProdutoResponse;
                        marcados.Add(new EtiquetaPDF(produto.CodigoSKU, produto.CodigoBarras, produto.CodigoBarrasText, produto.Variacao));
                    }
            }
            return marcados;
        }

        private void LimparSelecionados()
        {
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                if (row.HeaderCell.Value != null)
                    if (row.HeaderCell.Value.ToString() == "►")
                    {
                        row.HeaderCell.Value = "";
                    }
            }
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIncluir_Click(object sender, EventArgs e)
        {
            using (frmCadastrarProduto frm = new frmCadastrarProduto())
            {
                frm.ShowDialog();
                ListarProdutos();
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaProduto();
        }

        private void SelecionaProduto()
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

        public void ConverteImage(object o, PrintPageEventArgs e)
        {
            int pontoImageX = 0;
            int pontoImageY = 67;
            int pontoTextX = 10;
            int pontoTextY = 30;

            int quantidade = 0;
            e.PageSettings.PaperSize = new PaperSize($"impressao {DateTime.Now}", 150, 100);

            Font fontPrint = new Font(new FontFamily("Microsoft Sans Serif"), 10.2f);

            foreach (var x in GetSelecionados())
            {
                quantidade++;
                string texto = $"{x.sku.ToUpper()} {x.Variacao.ToUpper()}".QuebraLinha(22);
                var bytes = Convert.FromBase64String(CodigoBarras.GerarBarCodeLib(x.CodigoBarrasText));
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    if (texto.Length > 40)
                        pontoImageY += texto.Length / 2;
                    Image i = Image.FromStream(ms);
                    Point pImage = new Point(pontoImageX, pontoImageY);
                    Point pText = new Point(pontoTextX, pontoTextY);
                    e.Graphics.DrawImage(i, pImage);
                    e.Graphics.DrawString(texto, fontPrint, Brushes.Black, pText);
                }

                //Posiciona o código de barras
                if (pontoImageX < 300)
                {
                    pontoImageX += 220;//400;//220;
                    pontoTextX += 220;//400;//220;
                }
                else
                {
                    pontoImageX = 0;
                    pontoTextX = 10;
                    pontoImageY += 150;//250;//150;
                    pontoTextY += 150;//250;//150;
                }
            }
        }

    }
}

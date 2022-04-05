using SysAux.BarCode;
using SysAux.Interfaces;
using SysAux.IOPdf;
using SysAux.Response;
using SysGestao_BE.Produto;
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
    public partial class frmSeparacaoDeProdutos : frmDefault
    {
        private readonly ISolicitacao solicitacao;
        private List<ProdutoResponse> listaSeparados;

        private Produto ObjSelecionado;

        public frmSeparacaoDeProdutos(ISolicitacao solicitacao)
        {
            InitializeComponent();
            this.solicitacao = solicitacao;

            IniciaDadosSolicitacao(solicitacao);
        }
        /// <summary>
        /// Carrega dados gerais da solicitação 
        /// </summary>
        /// <param name="solicitacao"></param>
        private void IniciaDadosSolicitacao(ISolicitacao solicitacao)
        {
            lbNome.Text = solicitacao.Destinatario.Nome;
            listaSeparados = new List<ProdutoResponse>();

            foreach (var obj in solicitacao.Produtos)
                listaSeparados.Add(obj.ConvertParaListaDeSeparacao());
        }

        private void frmSeparacaoDeProdutos_Load(object sender, EventArgs e)
        {
            AtualizarGridView();
        }
        /// <summary>
        /// Atualiza GridView e recarrega todos os itens
        /// </summary>
        private void AtualizarGridView()
        {
            dgvProdutos.Rows.Clear();

            for (int row = 0; row < solicitacao.Produtos.Count; row++)
            {
                dgvProdutos.Rows.Add(row + 1, solicitacao.Produtos[row].CodigoSKU,
                    solicitacao.Produtos[row].Variacao, solicitacao.Produtos[row].Quantidade,
                    listaSeparados?.FirstOrDefault(x => x.CodigoSKU == solicitacao.Produtos[row].CodigoSKU
                    && x.Variacao == solicitacao.Produtos[row].Variacao)?.Quantidade ?? 0,
                    "   ", solicitacao.Produtos[row]);

                if (solicitacao.Produtos[row].Separado)
                    dgvProdutos.Rows[row].Cells[colStatus.Index].Style.BackColor = Color.DarkGreen;
                else
                    dgvProdutos.Rows[row].Cells[colStatus.Index].Style.BackColor = Color.Red;

            }
        }
        /// <summary>
        /// Atualiza os campos do formulário com o produto especificado no argumento.
        /// </summary>
        /// <param name="produto"></param>
        private void PreencheCamposProduto(Produto produto)
        {
            if (produto != null)
            {
                txtCodigoSKU.Text = produto.CodigoSKU;
                txtVariacao.Text = produto.Variacao;
                if (produto.ImagemBase64 != string.Empty)
                {
                    pctImagemProduto.Image = CodigoBarras.ConvertBase64ToImage(produto.ImagemBase64);
                    lbImagem.Visible = false;
                }
                ObjSelecionado = produto;
                txtQuantidade.Focus();
            }
        }
        private void txtCodigoSKU_Leave(object sender, EventArgs e)
        {
            try
            {
                if (ObjSelecionado == null)
                {
                    if (sender is TextBox txt)
                    {
                        if (txt.Text != string.Empty)
                        {
                            string codigoSKU = txt.Text;
                            var produto = BuscarProduto(codigoSKU);
                            if (produto != null)
                            {
                                PreencheCamposProduto(produto);
                                btnAdicionar.PerformClick();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigoSKU"></param>
        /// <returns></returns>
        private Produto BuscarProduto(string codigoSKU)
        {
            return Produto.GetByBarCode(codigoSKU) ?? throw new Exception("Produto não encontrado!");
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            var length = txtQuantidade?.Value.ToString().Length ?? 1;
            txtQuantidade.Select(0, length);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ObjSelecionado != null)
            {
                if (solicitacao.Produtos.FirstOrDefault(x => x.CodigoSKU.ToLower() == ObjSelecionado.CodigoSKU.ToLower() && x.Variacao.ToLower() == ObjSelecionado.Variacao.ToLower()) == null)
                {
                    MessageBox.Show("Este produto não está na lista de pedidos!", "Produto incorreto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimparCamposProduto();
                }
                else
                {
                    AdicionarProdutoGridView();
                }
            }
            else
                MessageBox.Show("Não há produtos para adicionar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        /// <summary>
        /// 
        /// </summary>
        private void LimparCamposProduto()
        {
            ObjSelecionado = null;
            txtCodigoSKU.Clear();
            txtQuantidade.Value = 1;
            txtVariacao.Clear();
            txtCodigoSKU.Focus();
        }

        /// <summary>
        /// 
        /// </summary>
        private void AdicionarProdutoGridView()
        {
            int quantidade_pedido = (int)txtQuantidade?.Value;

            if (quantidade_pedido > ObjSelecionado.Quantidade)
            {
                MessageBox.Show("Quantidade insuficiente no estoque !", "Estoque insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < dgvProdutos?.Rows?.Count; i++)
            {
                if (dgvProdutos[colObj.Index, i]?.Value is ProdutoResponse prod)
                {
                    int quantidade = (int)dgvProdutos[colQuantidadeSeparada.Index, i]?.Value;
                    quantidade += quantidade_pedido;

                    if (quantidade >= prod.Quantidade)
                    {
                        prod.Separado = true;
                        dgvProdutos[colQuantidadeSeparada.Index, i].Value = prod.Quantidade;
                        if (quantidade > prod.Quantidade)
                        {
                            MessageBox.Show("Atenção!\r\n\r\n" + $"A quantidade do item '{prod.CodigoSKU} - {prod.Variacao}' já foi atingida, não será permitido ultrapassar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                        dgvProdutos[colQuantidadeSeparada.Index, i].Value = quantidade;

                    var ajustaProd = listaSeparados.FirstOrDefault(x => x.CodigoSKU == prod.CodigoSKU && x.Variacao == prod.Variacao);
                    ajustaProd.Separado = prod.Separado;
                    ajustaProd.Quantidade = prod.Quantidade;
                    ajustaProd.Id = ObjSelecionado.Id;
                    solicitacao.Produtos = listaSeparados;
                    LimparCamposProduto();

                }
            }
        }

        private void btBuscarProduto_Click(object sender, EventArgs e)
        {
            using (frmConsultarProdutos frm = new frmConsultarProdutos(true))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ObjSelecionado = frm.ProdutoSelecionado;

                    PreencheCamposProduto(ObjSelecionado);
                }
            }
        }

        private void btFinalizaSolicitacao_Click(object sender, EventArgs e)
        {
            if (listaSeparados.Count(x => !x.Separado) > 0)
            {
                MessageBox.Show("Por favor, separe todos os itens para prosseguir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (solicitacao.Inserir())
            {
                PreSolicitacao.Remover(solicitacao.Id);
                MessageBox.Show("Solicitação inserida com sucesso! Status da Solicitação atualizado para 'Finalizada'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txtCodigoSKU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAdicionar.PerformClick();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Access;
using SysAux.BarCode;
using SysGestao_BE.Produto;

namespace SysGestao.Produtos
{
    public partial class frmCadastrarProduto : frmDefault
    {
        private Produto _produto;
        private bool IsView;
        public override bool RegDirty
        {
            get { return base.RegDirty; }
            set
            {
                btAcao.Enabled = value;
                base.RegDirty = value;
            }
        }
        private bool _isInsert = false;
        public bool isInsert
        {
            get
            {
                return _isInsert;
            }
            set
            {
                btAcao.Text = value ? "&Incluir" : "Alterar";
                btVerCodigoDeBarras.Enabled = btNovo.Enabled = !value;
                _isInsert = value;
            }
        }
        public frmCadastrarProduto()
        {
            InitializeComponent();
            isInsert = true;
        }

        public frmCadastrarProduto(Produto produto, bool isView = false)
        {
            InitializeComponent();
            _produto = produto;
            isInsert = false;
            IsView = isView;
        }

        private bool ValidaCampos()
        {
            return
                txtCodigoSKU.Text != string.Empty && txtVariacao.Text != string.Empty;
        }

        private void Salvar()
        {
            Produto produto = _produto ?? new Produto();
            produto.CodigoSKU = txtCodigoSKU.Text.Trim();
            produto.Cor = txtCor.Text.Trim();
            produto.Tamanho = txtTamanho.Text.Trim();
            produto.Quantidade = (int)txtQuantidade?.Value;
            produto.Variacao = txtVariacao.Text.Trim();
            produto.Descricao = txtDescricao.Text.Trim();
            if (pctImagemProduto.Image != null) produto.ImagemBase64 = CodigoBarras.ConvertImageToBase64(pctImagemProduto.Image);

            if (isInsert)
            {
                var produto_exist = Produto.GetBySKUAndVariacao(produto.CodigoSKU, produto.Variacao);
                if (produto_exist != null)
                {
                    if (MessageBox.Show("Este produto já existe no estoque, deseja atualizar ?", "Atenção !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        isInsert = false;
                        produto.Id = produto_exist.Id;
                        produto.Quantidade += produto_exist.Quantidade;
                        produto.CodigoBarrasText = produto_exist.CodigoBarrasText;
                    }
                    else return;
                }
                else
                {
                    int codigo = Produto.GetNextCodigoBar();
                    produto.CodigoBarrasText = codigo > 0 ? codigo.ToString().PadLeft(10, '0') : throw new Exception("Ocorreu um erro ao gerar o código de barras!");
                }
            }

            produto.CodigoBarras = CodigoBarras.GerarBarCodeLib(produto.CodigoBarrasText);

            if (produto.InsertOrUpdate())
            {
                MessageBox.Show("Produto " + (isInsert ? "cadastrado " : "atualizado ") + "com sucesso!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                isInsert = false;
                _produto = produto;
            }
            else
            {
                MessageBox.Show("O produto não foi salvo corretamente! Por favor, tente novamente.", "Ocorre um problema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                Salvar();
            }
            else
            {
                MessageBox.Show("Verifique o preenchimento dos campos obrigatórios!", "Validação de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void LimparCampos()
        {
            txtCodigoSKU.Clear();
            txtCor.Clear();
            txtTamanho.Clear();
            txtQuantidade.Value = 1;
            txtVariacao.Clear();
            txtDescricao.Clear();
            pctBarCode.Image = null;
            pctImagemProduto.Image = null;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            NovoRegistro();
        }

        private void NovoRegistro()
        {
            LimparCampos();
            isInsert = true;
            _produto = null;
        }

        private void txtCodigoSKU_TextChanged(object sender, EventArgs e)
        {
            RegDirty = true;
        }

        private void btVerCodigoDeBarras_Click(object sender, EventArgs e)
        {
            if (pctBarCode.Image == null)
            {
                if (_produto?.CodigoBarrasText != string.Empty)
                {
                    pctBarCode.Image = CodigoBarras.ConvertBase64ToImage(CodigoBarras.GerarBarCodeLib(_produto.CodigoBarrasText));
                    //pctBarCode.Image = CodigoBarras.ConvertBase64ToImage(_produto.CodigoBarras);
                    //pctBarCode.Image.Save(@"C:\Users\iggor\Documents\Freelancer\Software para bipagem de produtos\testebarcode.png");
                    btVerCodigoDeBarras.Text = "Ocultar código de barras";
                }
            }
            else
            {
                btVerCodigoDeBarras.Text = "Ver código de barras";
                pctBarCode.Image = null;
            }
        }

        /// <summary>
        /// Carrega os valores do produto nos campos do formulário.
        /// </summary>
        /// <param name="produto"></param>
        private void CarregaCamposDoProduto(Produto produto)
        {
            txtCodigoSKU.Text = produto?.CodigoSKU;
            txtCor.Text = produto?.Cor;
            txtDescricao.Text = produto?.Descricao;
            txtQuantidade.Value = produto?.Quantidade ?? 1;
            txtTamanho.Text = produto?.Tamanho;
            txtVariacao.Text = produto?.Variacao;
            pctImagemProduto.Image = produto?.ImagemBase64 != string.Empty ? CodigoBarras.ConvertBase64ToImage(produto?.ImagemBase64) : null;
        }

        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            if (IsView)
            {
                pnlBotoes.Visible = false;
            }
        }

        private void frmCadastrarProduto_Shown(object sender, EventArgs e)
        {
            if (!isInsert)
                try
                {
                    CarregaCamposDoProduto(_produto ?? throw new ArgumentException("Erro ao carregar informações do produto!\r\nPor favor, tente novamente."));
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btBuscarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Title = "Buscar imagem";
                fileDialog.Filter = "image jpg (*.jpg)|*.jpg|image jpeg (*.jpeg)|*.jpeg|image png (*.png)|*.png";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    pctImagemProduto.Load(fileDialog.FileName);
                }
            }
        }
        private void btRemoverImagem_Click(object sender, EventArgs e)
        {
            pctImagemProduto.Image = null;
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            var length = txtQuantidade?.Value.ToString().Length ?? 1;
            txtQuantidade.Select(0, length);
        }
    }
}

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

        public frmCadastrarProduto(Produto produto)
        {
            InitializeComponent();
            _produto = produto;
            isInsert = produto.Id > 0;
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
            produto.CodigoBarras = produto.CodigoSKU + produto.Variacao;

            if (produto.InsertOrUpdate())
            {
                MessageBox.Show("Produto " + (isInsert ? "cadastrado " : "atualizado ") + "com sucesso!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                isInsert = false;
                _produto = produto;
            }
            else
            {
                MessageBox.Show("O produto não foi salvo corretamente! Por favor, verifique.", "Ocorre um problema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (_produto != null)
            {


                pctBarCode.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(CodigoBarras.GerarCodigo(_produto.CodigoBarras))));

            }
        }
    }
}

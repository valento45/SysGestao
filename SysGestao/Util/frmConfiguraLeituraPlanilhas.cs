using SysAux.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Util
{
    public partial class frmConfiguraLeituraPlanilhas : frmDefault
    {
        private XlsxDocumentConfigurationColumns DeclaracaoConteudo { get; set; }
        private XlsxDocumentConfigurationColumns Danfe { get; set; }


        public frmConfiguraLeituraPlanilhas()
        {
            InitializeComponent();
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            SalvarDanfe();
            SalvarDeclaracaoConteudo();
            MessageBox.Show("Dados atualizados com sucesso !", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SalvarDanfe()
        {
            if (Danfe == null)
            {
                Danfe = new XlsxDocumentConfigurationColumns() { TipoDocumento = SysAux.Util.Enums.TipoDocumento.DANFE };
            }

            Danfe.CodigoSKU = txtCodigoSKU.Text.Trim();
            Danfe.Variacao = txtVariacao.Text.Trim();
            Danfe.Quantidade = txtQuantidade.Text.Trim();
            Danfe.NomeDestinatario = txtNome.Text.Trim();
            Danfe.CpfCnpj = txtCpfCnpj.Text.Trim();
            Danfe.Endereco = txtEndereco.Text.Trim();
            Danfe.IsLeituraAutomatica = chkLeituraAutomatica.Checked;

            Danfe.Separadores = new List<char>();
            foreach (var item in cmbSeparadores.Items)
            {
                Danfe.Separadores.Add(item.ToString().ToCharArray()[0]);
            }

            Danfe.AtualizarConfiguracao();
        }


        private void SalvarDeclaracaoConteudo()
        {
            if (DeclaracaoConteudo == null)
            {
                DeclaracaoConteudo = new XlsxDocumentConfigurationColumns() { TipoDocumento = SysAux.Util.Enums.TipoDocumento.DECLARACAO_CONTEUDO };
            }

            DeclaracaoConteudo.CodigoSKU = txtCodigoSKUDc.Text.Trim();
            DeclaracaoConteudo.Variacao = txtVariacaoDc.Text.Trim();
            DeclaracaoConteudo.Quantidade = txtQuantidadeDc.Text.Trim();
            DeclaracaoConteudo.NomeDestinatario = txtNomeDc.Text.Trim();
            DeclaracaoConteudo.CpfCnpj = txtCpfCnpjDc.Text.Trim();
            DeclaracaoConteudo.Endereco = txtenderecoDc.Text.Trim();


            DeclaracaoConteudo.Separadores = new List<char>();
            foreach (var item in cmbSeparadoresDc.Items)
            {
                DeclaracaoConteudo.Separadores.Add(item.ToString().ToCharArray()[0]);
            }

            DeclaracaoConteudo.AtualizarConfiguracao();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            var valor = txtSeparador.Text;
            this.AdicionarItemComboBox(cmbSeparadores, valor);
            txtSeparador.Clear();
            txtSeparador.Focus();

        }

        private void btAdicionaSeparadorDc_Click(object sender, EventArgs e)
        {
            var valor = txtSeparadorDc.Text;
            this.AdicionarItemComboBox(cmbSeparadoresDc, valor);
            txtSeparadorDc.Clear();
            txtSeparadorDc.Focus();
        }


        private void AdicionarItemComboBox(object sender, string valor)
        {
            if (valor != string.Empty)
            {
                if (sender is ComboBox cmb)
                {
                    if (cmb.Items.Contains(valor))
                        return;
                    else
                        cmb.Items.Add(valor);
                }
            }
        }



        private void LoadCampos()
        {
            Danfe = ConfiguracaoLeituras.GetDanfe();
            DeclaracaoConteudo = ConfiguracaoLeituras.GetDeclaracaoConteudo();

            #region DANFE
            if (Danfe != null)
            {
                txtCodigoSKU.Text = Danfe.CodigoSKU;
                txtVariacao.Text = Danfe.Variacao;
                txtQuantidade.Text = Danfe.Quantidade;
                txtNome.Text = Danfe.NomeDestinatario;
                txtCpfCnpj.Text = Danfe.CpfCnpj;
                txtEndereco.Text = Danfe.Endereco;
                chkLeituraAutomatica.Checked = Danfe.IsLeituraAutomatica;
                pnlCampos.Enabled = !Danfe.IsLeituraAutomatica;

                cmbSeparadores.Items.Clear();
                foreach (char item in Danfe.Separadores)
                    cmbSeparadores.Items.Add(item);
            }
            #endregion


            #region DECLARACAO CONTEUDO
            if (DeclaracaoConteudo != null)
            {
                txtCodigoSKUDc.Text = DeclaracaoConteudo.CodigoSKU;
                txtVariacaoDc.Text = DeclaracaoConteudo.Variacao;
                txtQuantidadeDc.Text = DeclaracaoConteudo.Quantidade;
                txtNomeDc.Text = DeclaracaoConteudo.NomeDestinatario;
                txtCpfCnpjDc.Text = DeclaracaoConteudo.CpfCnpj;
                txtenderecoDc.Text = DeclaracaoConteudo.Endereco;

                cmbSeparadoresDc.Items.Clear();
                foreach (char item in DeclaracaoConteudo.Separadores)
                    cmbSeparadoresDc.Items.Add(item);
            }
            #endregion
        }

        private void frmConfiguraLeituraPlanilhas_Load(object sender, EventArgs e)
        {
            LoadCampos();
        }

        private void btLimparDc_Click(object sender, EventArgs e)
        {
            cmbSeparadoresDc.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbSeparadores.Items.Clear();
        }

        private void chkLeituraAutomatica_CheckedChanged(object sender, EventArgs e)
        {
            pnlCampos.Enabled = !chkLeituraAutomatica.Checked;
        }

        private void btRedefinir_Click(object sender, EventArgs e)
        {

        }
    }
}







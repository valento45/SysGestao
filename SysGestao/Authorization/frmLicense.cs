using SysGestao_BE.Autenticacao.Enums;
using SysGestao_BE.Autenticacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysGestao_BE.Auxx;
using System.Diagnostics;
using Newtonsoft.Json;
using SysAux.Util;

namespace SysGestao.Authorization
{
    public partial class frmLicense : Form
    {

        private bool ativado;
       
        public frmLicense()
        {
            InitializeComponent();
        }

        private void btAtivar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var codigo = txtCodigoLicensa.Text.Trim();
                TipoLicensa tipo_licensa = cmbTipoLicensa.Text.Trim().GetValueFromDescription<TipoLicensa>();

                var licensaDecrypt = Licensa.DecryptCodigoLicensa(codigo);
                var licensa = JsonConvert.DeserializeObject<Licensa>(licensaDecrypt);
                if (licensa.IsValido())
                {
                    if (tipo_licensa == licensa.TipoLicensa)
                    {
                        ativado = true;
                        Licensa.AtualizarLicensa(licensa);
                        Licensa.DadosLicensa = licensa;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Licença inválida !\r\n\r\n\r\n" +
                     $"A licença inserida não é válida para o sistema selecionado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Licença inválida !\r\n\r\n\r\n" +
                        $"Essa licença foi expirada em: {licensa.DataExpiracao.ToString("dd/MM/yyyy")}.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados da licença!", "Atenção campos nulos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ValidarCampos()
        {
            return txtCodigoLicensa.Text.Trim() != String.Empty && cmbTipoLicensa.SelectedIndex > -1;
        }

        private void frmLicense_Load(object sender, EventArgs e)
        {
            List<string> valores = typeof(TipoLicensa).GetValues();

            cmbTipoLicensa.Items.AddRange(valores.ToArray());
        }

        private void frmLicense_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ativado)
                Process.GetCurrentProcess().Kill();
        }

        private void btnComprarLicensa_Click(object sender, EventArgs e)
        {
            NavegarContatoIn();
        }

        private void NavegarContatoIn()
        {
            WebNavegador.AbrirPaginaWeb(Licensa.ContactLinkedinURL);
        }

        
    }
}

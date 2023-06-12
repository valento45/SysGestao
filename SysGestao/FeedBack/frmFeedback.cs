using SysGestao.ControlsAux;
using SysGestao.Email;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.FeedBack
{
    public partial class frmFeedback : frmDefault
    {

        public frmFeedback()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PNG files (*.png)|*.png|JPG files (*.jpg)|*.jpg|JPEG files (*.jpeg)|*.jpeg|XML files (*.xml)|*.xml";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtArquivo.Text = openFileDialog.FileName;
                }
            }
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            var anexo = txtArquivo.Text.Trim();
            if (anexo != string.Empty)
            {

                AdicionarAnexo(anexo);

                txtArquivo.Clear();
            }
            else
                MessageBox.Show("Nenhum anexo selecionado ! \r\n\r\n\r\nPor favor,Selecione um anexo clicando na lupa para adicioná-lo.", "Atenção",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void AdicionarAnexo(string caminhoAnexo)
        {
            var anexo = new AnexoControl(caminhoAnexo);
            fPnlAnexos.Controls.Add(anexo);
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (IsValido())
            {
                EmailModel email = new EmailModel();

                email.Assunto = txtAssunto.Text.Trim();
                email.Mensagem = txtMensagem.Text.Trim();
                email.Destinatario = "iggor1935@hotmail.com";
                

                if (HasAnexos())
                {
                    foreach (var ctrl in fPnlAnexos.Controls)
                    {
                        if (ctrl is AnexoControl anexoControl)
                        {
                            email.Anexos.Add(anexoControl.CaminhoAnexo);
                        }
                    }
                }



                EmailGateway emailGateway = new EmailGateway(null);
                emailGateway.EnviaEmailComAnexo(email);

            }
        }


        private bool HasAnexos() =>
             fPnlAnexos.Controls.Count > 0;



        private bool IsValido() =>
             txtAssunto.Text.Trim() != string.Empty && txtMensagem.Text.Trim() != string.Empty;

    }
}

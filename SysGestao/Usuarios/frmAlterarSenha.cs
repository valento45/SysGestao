using SysGestao_BE;
using System;
using System.Windows.Forms;

namespace SysGestao.Usuarios
{
    public partial class frmAlterarSenha : frmDefault
    {
        private Usuario _usuario;
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnFecharAlterar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidaCampos()
        {
            return
                txtRespostaSecreta.Text != string.Empty || txtUsuarioRec.Text != string.Empty;
        }

        private void btnEnviarResposta_Click(object sender, EventArgs e)
        {
            if (ValidaCampos() && _usuario.AlterarSenha(txtUsuarioRec.Text, txtRespostaSecreta.Text, txtNovaSenha.Text))
            {
                MessageBox.Show("Senha alterada!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Resposta incorreta!", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                _usuario = Usuario.BuscarUsuario(txtUsuarioRec.Text);
                if (_usuario == null)
                {
                    lblErro.Text = "Usuário não encontrado.";
                    return;
                }
                else
                {
                    lbPergunta.Text = _usuario.PerguntaSecreta;
                    txtUsuarioRec.ReadOnly = true;
                    lbPergunta.Visible = true;
                    txtRespostaSecreta.Visible = true;
                    lbNovaSenha.Visible = true;
                    txtNovaSenha.Visible = true;
                    btnEnviarResposta.Visible = true;


                }
            }
        }
    }
}

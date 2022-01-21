using SysGestao.EventosFolder;
using SysGestao.Usuarios;
using SysGestao_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao
{
    public partial class frmLogin : frmDefault
    {
        private Usuario _usuario;
        private bool _autenticado;
        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }
        private bool ValidaCampos()
        {
            return
                txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (ValidaCampos() && Usuario.Logar(txtUsuario.Text, txtSenha.Text))
            {
                _autenticado = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Dados Incorretos!", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEsqueci_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frm = new frmAlterarSenha();

            //this.Hide();
            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_autenticado)
                this.DialogResult = DialogResult.Abort;
        }
    }
}

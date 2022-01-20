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
        string userNome;
        string userSenha;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void usuarioBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void senhaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidaCampos()
        {
            return
                usuarioBox.Text != string.Empty && senhaBox.Text != string.Empty;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidaCampos())
            {
                MessageBox.Show("Boa!", "Texto Preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Verifique o preenchimento dos campos obrigatórios!", "Validação de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}

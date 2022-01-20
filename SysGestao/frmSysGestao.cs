using SysGestao.Produtos;
using SysGestao.Usuarios;
using SysGestao_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao
{
    public partial class frmSysGestao : Form
    {
        private int childFormNumber = 0;
        private bool autenticado;
        public frmSysGestao()
        {
            InitializeComponent();
            using (frmLogin frm = new frmLogin())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    autenticado = true;
                }
                else                
                    Process.GetCurrentProcess().Kill();
                
            }
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto frm = new frmCadastrarProduto();

            //frm.MdiParent = this;
            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frm = new frmAlterarSenha();

            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();

        }
        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public static void ShowMenuLogado(object sender, FormClosedEventArgs e)
        {
            frmSysGestao frm = new frmSysGestao();
            frm.Show();
        }
    }
}

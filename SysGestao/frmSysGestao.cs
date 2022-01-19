using SysGestao.Produtos;
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
    public partial class frmSysGestao : Form
    {
        private int childFormNumber = 0;

        public frmSysGestao()
        {
            InitializeComponent();
           
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto frm = new frmCadastrarProduto();
            frm.MdiParent = this;
            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarProdutos frm = new frmConsultarProdutos();
            frm.MdiParent = this;
            if (frm.Visible)
                frm.Focus();
            else
                frm.Show();
        }
    }
}

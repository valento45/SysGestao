using SysAux.IOPdf;
using SysGestao.Produtos;
using SysGestao.Util;
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

        private void importaçãoPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fil = new OpenFileDialog())
            {
                fil.Title = "Buscar declaração de conteúdo";
                fil.Filter = "Arquivo PDF (*.pdf)|*.pdf";
                if (fil.ShowDialog() == DialogResult.OK)
                {
                    string textoPdf = PdfLeitor.ConvertePDFParaTexto(fil.FileName);

                    string NomeDestinatario = PdfLeitor.GetDestinatarioNomeFromText(textoPdf);
                    var produtos = PdfLeitor.GetProdutosFromText(textoPdf);

                    #region Tela de screen Loading
                    //frmLoadingBar frm = new frmLoadingBar("Carregando declaração de conteúdo...");

                    //frm.Show();
                    //frm.IniciarLoading(13);

                    //for (int i = 0; i < 100; i++)
                    //{
                    //    frm.SetContagem(i);
                    //}
                    #endregion
                }

            }
        }
    }
}

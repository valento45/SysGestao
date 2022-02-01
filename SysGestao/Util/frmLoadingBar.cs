using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Util
{
    public partial class frmLoadingBar : Form
    {
        int contagem = 0;
        private static frmLoadingBar Loading;

        public frmLoadingBar(string title)
        {
            InitializeComponent();
            timer1.Enabled = true;
            lblTitle.Text = title != string.Empty ? title : lblTitle.Text ?? "Carregando arquivo...";
        }

        public void IniciarLoading(int cont)
        {
            contagem = cont;
            timer1.Enabled = true;
            // timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < contagem)
                progressBar1.Value = contagem;
            else
            {
                timer1.Enabled = false;
                this.Close();
            }
        }
        public void SetContagem(int cont)
        {
            this.contagem = cont;
        }

        public static void IniciarLoading(string title)
        {
            Loading = new frmLoadingBar(title);
            Loading.Show();
            // timer1.Start();
        }
        public static void CloseLoading()
        {
            if (Loading.Visible)
                Loading.Close();
            Loading.Dispose();
        }

    }
}

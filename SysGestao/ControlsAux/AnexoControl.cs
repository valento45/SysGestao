using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.ControlsAux
{
    public partial class AnexoControl : UserControl
    {
        public string CaminhoAnexo { get; set; }

        public AnexoControl(string caminho)
        {
            InitializeComponent();

            CaminhoAnexo = caminho;
            txtCaminho.Text = caminho;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

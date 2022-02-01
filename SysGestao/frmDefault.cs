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
    public partial class frmDefault : Form
    {
        public virtual bool RegDirty { get; set; }
        public frmDefault()
        {
            InitializeComponent();
        }

        private void frmDefault_Load(object sender, EventArgs e)
        {
            ApplyThemes();
        }
        protected void ApplyThemes()
        {
            foreach (var ctrl in this.Controls)
            {
                if(ctrl is Panel pnl)
                {
                    pnl.BackColor = Color.GhostWhite;
                }
                else if(ctrl is Button btn)
                {
                    btn.Font = new Font("Century Gothic", 7.8f);
                }
            }
        }
    }
}

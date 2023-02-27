using SysGestao_BE.AlertasEstoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Produtos.ConfigAlertasEstoque
{
    public partial class frmConfigurarAlertaEstoque : frmDefault
    {
        private readonly ConfiguracaoDeAlertas configuracaoDeAlertas;

        public frmConfigurarAlertaEstoque(ConfiguracaoDeAlertas obj)
        {
            InitializeComponent();
            if(obj != null)
            {
                rdbSim.Checked = obj.EmitirAlertas;
                txtQuantidade.Value = obj.QuantidadeMinima;
            }

            configuracaoDeAlertas = obj;
        }

        private void frmConfigurarAlertaEstoque_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            bool emiti = rdbSim.Checked;
            int qtd = (int)txtQuantidade.Value;
            configuracaoDeAlertas.EmitirAlertas = emiti;
            configuracaoDeAlertas.QuantidadeMinima = qtd;

            ConfiguracaoDeAlertas.SalvarConfiguracoes(configuracaoDeAlertas);
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            var x = txtQuantidade.Value;
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

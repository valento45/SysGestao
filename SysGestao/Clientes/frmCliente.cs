using SysAux.ObjetosDestinatario;
using SysGestao_BE.Auxx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Clientes
{
    public partial class frmCliente : frmDefault
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Search();
        }


        private void Search()
        {
            List<Destinatario> destinatarios = new List<Destinatario>();
            switch (cmbFiltros.SelectedIndex)
            {
                case -1:
                    destinatarios = ObterPorNome();
                    break;
                case 0:
                    destinatarios = ObterPorNome();
                    break;

                case 1:

                    destinatarios = ObterPorCPF();
                    break;
            }

            dgvClientes.Rows.Clear();
            foreach (var cliente in destinatarios)
            {
                dgvClientes.Rows.Add(cliente.IdClienteDestinatario, cliente.Nome, cliente.Endereco,
                    cliente.CpfCnpj.ToString().IsCnpj() ? cliente.CpfCnpj.ToString().FormataCNPJ() : cliente.CpfCnpj.ToString().FormataCPF(),
                    cliente.IdEstrangeiro);
            }
        }

        private List<Destinatario> ObterPorNome()
        {
            var result = new List<Destinatario>();
            var param = txtFiltro.Text.Trim();

            var obj = Destinatario.ObterPorNome(param);
            if (obj != null)
                result.Add(obj);
            return result;
        }

        private List<Destinatario> ObterPorCPF()
        {
            var result = new List<Destinatario>();
            var param = txtFiltro.Text.Trim();

            if (param.SomenteNumeros() != string.Empty)
            {
                var obj = Destinatario.ObterPorCPF(long.Parse(param));

                if (obj != null)
                    result.Add(obj);
            }
            return result;
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}

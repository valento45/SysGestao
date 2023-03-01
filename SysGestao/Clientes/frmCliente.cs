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
        private bool isAlterar = false;
        private Destinatario _destinatario;
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
                    cliente.IdEstrangeiro, cliente);
            }
        }

        private List<Destinatario> ObterPorNome()
        {
            List<Destinatario> result = null;
            var param = txtFiltro.Text.Trim();
            int limite = txtlimite?.Value > 0 ? int.Parse(txtlimite?.Value.ToString()) : 0;

            result = Destinatario.ObterPorNome(param, limite);
            return result;
        }

        private List<Destinatario> ObterPorCPF()
        {
            var result = new List<Destinatario>();
            var param = txtFiltro.Text.Trim().SomenteNumeros();

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

        private void toolStripBtnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount > 0 && dgvClientes.SelectedRows.Count > 0)
            {
                var obj = dgvClientes.SelectedRows[0].Cells[colObj.Index].Value as Destinatario;

                if (obj != null)
                {
                    _destinatario = obj;
                    PopulaCampos(_destinatario);
                    isAlterar = true;
                    tabControl1.SelectedTab = tabCadastro;
                }
            }
            else
            {
                MessageBox.Show("Selecione um item para atualizar !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PopulaCampos(Destinatario destinatario)
        {
            txtNome.Text = destinatario.Nome;
            txtCPF.Text = destinatario.CpfCnpj.ToString().IsCnpj() ? destinatario.CpfCnpj.ToString().FormataCNPJ()
                : destinatario.CpfCnpj.ToString().FormataCPF();

            txtEndereco.Text = destinatario.Endereco;
            txtIdEstrangeiro.Text = destinatario.IdEstrangeiro
                 > 0 ? destinatario.IdEstrangeiro.ToString() : "";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
                Salvar();
            else
                MessageBox.Show("Preencha todas os campos obrigatórios ! ", "Validação de campos", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

        }

        private bool ValidarCampos()
        {
            return txtNome.Text.Trim() != string.Empty && txtCPF.Text.Trim() != string.Empty;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Novo()
        {
            isAlterar = false;
            _destinatario = null;
            txtCPF.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtIdEstrangeiro.Clear();
        }

        private void Salvar()
        {
            if (_destinatario == null)
                _destinatario = new Destinatario();

            _destinatario.Nome = txtNome.Text.Trim();
            _destinatario.CpfCnpj = txtCPF.Text.Trim().SomenteNumeros().Length > 0 ? long.Parse(txtCPF.Text.SomenteNumeros().Trim()) : 0;
            _destinatario.Endereco = txtEndereco.Text.Trim();
            _destinatario.IdEstrangeiro = txtIdEstrangeiro.Text.Trim().Length > 0 ? long.Parse(txtIdEstrangeiro.Text) : 0;


            if (isAlterar)
            {
                if (_destinatario.AtualizarCliente())
                    MessageBox.Show("Dados do cliente atualizados com sucesso !", "OK", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                _destinatario.IdClienteDestinatario = _destinatario.InsertCliente();
                isAlterar = true;
                MessageBox.Show("Cliente inserido com sucesso !", "Dados Salvo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void toolStripBtnExcluir_Click(object sender, EventArgs e)
        {
            Deletar();
        }

        private void Deletar()
        {
            if (dgvClientes.RowCount > 0 && dgvClientes.SelectedRows.Count > 0)
            {
                var obj = dgvClientes.SelectedCells[colObj.Index].Value as Destinatario;

                if (obj != null)
                {
                    if (MessageBox.Show($"Ao excluir o cliente, será excluído também todas solicitações de vendas relacionadas a ele." +
                        $"\r\n\r\n\r\nDeseja prosseguir e excluir o cliente {obj.Nome.ToUpper()} - CPF/CNPJ: {obj.CpfCnpj.FormataCpfCnpj()} ? ", "Atenção",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Destinatario.Deletar(obj.IdClienteDestinatario))
                        {
                            dgvClientes.Rows.RemoveAt(dgvClientes.CurrentRow.Index);
                        }
                    }

                }
            }
        }

        private void tabConsulta_Enter(object sender, EventArgs e)
        {
            Search();
        }
    }
}

using SysGestao_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysGestao.Usuarios
{
    public partial class frmCadastrarUsuario : frmDefault
    {
        private Usuario _usuario { get; set; }
        private bool isInsert { get; set; }
        public frmCadastrarUsuario()
        {
            InitializeComponent();
            isInsert = true;
        }

        public frmCadastrarUsuario(Usuario user)
        {
            InitializeComponent();
            _usuario = user;
            isInsert = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfirmaSenha.Text)
                pctConfirmaSenha.Image = Properties.Resources.Confirmar;
            else
                pctConfirmaSenha.Image = Properties.Resources.excluir;
        }

        private void btAcao_Click(object sender, EventArgs e)
        {
            var user = PreencheUsuario();

            if (user.InsertOrUpdate())
            {
                MessageBox.Show($"Usuário '{user.LoginUsuario}' cadastrado com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            else
                MessageBox.Show("Ocorreu um erro ao cadastrar o usuário! Por favor, verifique.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private Usuario PreencheUsuario()
        {
            Usuario user = _usuario ?? new Usuario();

            user.Nome = txtNome.Text.Trim();
            user.PerguntaSecreta = txtPergunta.Text.Trim();
            user.RespostaSecreta = txtResposta.Text.Trim();
            user.LoginUsuario = txtUsuario.Text.Trim();
            user.Senha = txtSenha.Text;
            return user;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtPergunta.Clear();
            txtResposta.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
            pctConfirmaSenha.Image = null;
        }
    }
}

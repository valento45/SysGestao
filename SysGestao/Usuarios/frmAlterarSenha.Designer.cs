namespace SysGestao.Usuarios
{
    partial class frmAlterarSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNovaSenha = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtUsuarioRec = new System.Windows.Forms.TextBox();
            this.lbUsuarioRec = new System.Windows.Forms.Label();
            this.lbPergunta = new System.Windows.Forms.Label();
            this.btnFecharResposta = new System.Windows.Forms.Button();
            this.txtRespostaSecreta = new System.Windows.Forms.TextBox();
            this.btnEnviarResposta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblErro);
            this.panel1.Controls.Add(this.lbNovaSenha);
            this.panel1.Controls.Add(this.txtNovaSenha);
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.txtUsuarioRec);
            this.panel1.Controls.Add(this.lbUsuarioRec);
            this.panel1.Controls.Add(this.lbPergunta);
            this.panel1.Controls.Add(this.btnFecharResposta);
            this.panel1.Controls.Add(this.txtRespostaSecreta);
            this.panel1.Controls.Add(this.btnEnviarResposta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 501);
            this.panel1.TabIndex = 0;
            // 
            // lbNovaSenha
            // 
            this.lbNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbNovaSenha.AutoSize = true;
            this.lbNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNovaSenha.Location = new System.Drawing.Point(100, 290);
            this.lbNovaSenha.Name = "lbNovaSenha";
            this.lbNovaSenha.Size = new System.Drawing.Size(114, 24);
            this.lbNovaSenha.TabIndex = 23;
            this.lbNovaSenha.Text = "Nova Senha";
            this.lbNovaSenha.Visible = false;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNovaSenha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(104, 317);
            this.txtNovaSenha.Multiline = true;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(231, 25);
            this.txtNovaSenha.TabIndex = 22;
            this.txtNovaSenha.Visible = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(478, 113);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 40);
            this.btnBuscarUsuario.TabIndex = 21;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtUsuarioRec
            // 
            this.txtUsuarioRec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuarioRec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtUsuarioRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioRec.Location = new System.Drawing.Point(104, 122);
            this.txtUsuarioRec.Multiline = true;
            this.txtUsuarioRec.Name = "txtUsuarioRec";
            this.txtUsuarioRec.Size = new System.Drawing.Size(356, 25);
            this.txtUsuarioRec.TabIndex = 20;
            // 
            // lbUsuarioRec
            // 
            this.lbUsuarioRec.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbUsuarioRec.AutoSize = true;
            this.lbUsuarioRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarioRec.Location = new System.Drawing.Point(100, 95);
            this.lbUsuarioRec.Name = "lbUsuarioRec";
            this.lbUsuarioRec.Size = new System.Drawing.Size(74, 24);
            this.lbUsuarioRec.TabIndex = 19;
            this.lbUsuarioRec.Text = "Usuário";
            // 
            // lbPergunta
            // 
            this.lbPergunta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPergunta.AutoSize = true;
            this.lbPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPergunta.Location = new System.Drawing.Point(100, 189);
            this.lbPergunta.Name = "lbPergunta";
            this.lbPergunta.Size = new System.Drawing.Size(157, 24);
            this.lbPergunta.TabIndex = 18;
            this.lbPergunta.Text = "Resposta Secreta";
            this.lbPergunta.Visible = false;
            // 
            // btnFecharResposta
            // 
            this.btnFecharResposta.BackColor = System.Drawing.Color.Brown;
            this.btnFecharResposta.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharResposta.ForeColor = System.Drawing.Color.White;
            this.btnFecharResposta.Location = new System.Drawing.Point(588, 25);
            this.btnFecharResposta.Name = "btnFecharResposta";
            this.btnFecharResposta.Size = new System.Drawing.Size(54, 46);
            this.btnFecharResposta.TabIndex = 17;
            this.btnFecharResposta.Text = "X";
            this.btnFecharResposta.UseVisualStyleBackColor = false;
            this.btnFecharResposta.Click += new System.EventHandler(this.btnFecharAlterar_Click);
            // 
            // txtRespostaSecreta
            // 
            this.txtRespostaSecreta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRespostaSecreta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtRespostaSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespostaSecreta.Location = new System.Drawing.Point(104, 216);
            this.txtRespostaSecreta.Multiline = true;
            this.txtRespostaSecreta.Name = "txtRespostaSecreta";
            this.txtRespostaSecreta.Size = new System.Drawing.Size(524, 25);
            this.txtRespostaSecreta.TabIndex = 12;
            this.txtRespostaSecreta.Visible = false;
            // 
            // btnEnviarResposta
            // 
            this.btnEnviarResposta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviarResposta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEnviarResposta.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarResposta.Location = new System.Drawing.Point(101, 377);
            this.btnEnviarResposta.Name = "btnEnviarResposta";
            this.btnEnviarResposta.Size = new System.Drawing.Size(234, 46);
            this.btnEnviarResposta.TabIndex = 5;
            this.btnEnviarResposta.Text = "ENVIAR";
            this.btnEnviarResposta.UseVisualStyleBackColor = false;
            this.btnEnviarResposta.Visible = false;
            this.btnEnviarResposta.Click += new System.EventHandler(this.btnEnviarResposta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(231, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Senha";
            // 
            // lblErro
            // 
            this.lblErro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErro.Location = new System.Drawing.Point(114, 150);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(106, 15);
            this.lblErro.TabIndex = 24;
            this.lblErro.Text = "Resposta Secreta";
            this.lblErro.Visible = false;
            // 
            // frmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 525);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarSenha";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRespostaSecreta;
        private System.Windows.Forms.Button btnEnviarResposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecharResposta;
        private System.Windows.Forms.Label lbPergunta;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtUsuarioRec;
        private System.Windows.Forms.Label lbUsuarioRec;
        private System.Windows.Forms.Label lbNovaSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label lblErro;
    }
}
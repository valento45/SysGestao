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
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.lbNovaSenha = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtUsuarioRec = new System.Windows.Forms.TextBox();
            this.lbUsuarioRec = new System.Windows.Forms.Label();
            this.btnFecharResposta = new System.Windows.Forms.Button();
            this.txtRespostaSecreta = new System.Windows.Forms.TextBox();
            this.btnEnviarResposta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblResposta);
            this.panel1.Controls.Add(this.lblErro);
            this.panel1.Controls.Add(this.lbNovaSenha);
            this.panel1.Controls.Add(this.txtNovaSenha);
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.txtUsuarioRec);
            this.panel1.Controls.Add(this.lbUsuarioRec);
            this.panel1.Controls.Add(this.btnFecharResposta);
            this.panel1.Controls.Add(this.txtRespostaSecreta);
            this.panel1.Controls.Add(this.btnEnviarResposta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 438);
            this.panel1.TabIndex = 0;
            // 
            // lblResposta
            // 
            this.lblResposta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(135, 214);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(200, 29);
            this.lblResposta.TabIndex = 25;
            this.lblResposta.Text = "Resposta secreta";
            this.lblResposta.Visible = false;
            // 
            // lblErro
            // 
            this.lblErro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErro.Location = new System.Drawing.Point(136, 175);
            this.lblErro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(126, 17);
            this.lblErro.TabIndex = 24;
            this.lblErro.Text = "Resposta Secreta";
            this.lblErro.Visible = false;
            // 
            // lbNovaSenha
            // 
            this.lbNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNovaSenha.AutoSize = true;
            this.lbNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNovaSenha.Location = new System.Drawing.Point(134, 282);
            this.lbNovaSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNovaSenha.Name = "lbNovaSenha";
            this.lbNovaSenha.Size = new System.Drawing.Size(144, 29);
            this.lbNovaSenha.TabIndex = 23;
            this.lbNovaSenha.Text = "Nova Senha";
            this.lbNovaSenha.Visible = false;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNovaSenha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(140, 314);
            this.txtNovaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtNovaSenha.Multiline = true;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(307, 30);
            this.txtNovaSenha.TabIndex = 22;
            this.txtNovaSenha.Visible = false;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(637, 128);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(100, 49);
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
            this.txtUsuarioRec.Location = new System.Drawing.Point(139, 139);
            this.txtUsuarioRec.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioRec.Multiline = true;
            this.txtUsuarioRec.Name = "txtUsuarioRec";
            this.txtUsuarioRec.Size = new System.Drawing.Size(473, 30);
            this.txtUsuarioRec.TabIndex = 20;
            // 
            // lbUsuarioRec
            // 
            this.lbUsuarioRec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbUsuarioRec.AutoSize = true;
            this.lbUsuarioRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarioRec.Location = new System.Drawing.Point(133, 107);
            this.lbUsuarioRec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuarioRec.Name = "lbUsuarioRec";
            this.lbUsuarioRec.Size = new System.Drawing.Size(96, 29);
            this.lbUsuarioRec.TabIndex = 19;
            this.lbUsuarioRec.Text = "Usuário";
            // 
            // btnFecharResposta
            // 
            this.btnFecharResposta.BackColor = System.Drawing.Color.Brown;
            this.btnFecharResposta.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharResposta.ForeColor = System.Drawing.Color.White;
            this.btnFecharResposta.Location = new System.Drawing.Point(812, 4);
            this.btnFecharResposta.Margin = new System.Windows.Forms.Padding(4);
            this.btnFecharResposta.Name = "btnFecharResposta";
            this.btnFecharResposta.Size = new System.Drawing.Size(72, 57);
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
            this.txtRespostaSecreta.Location = new System.Drawing.Point(139, 247);
            this.txtRespostaSecreta.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespostaSecreta.Multiline = true;
            this.txtRespostaSecreta.Name = "txtRespostaSecreta";
            this.txtRespostaSecreta.Size = new System.Drawing.Size(697, 30);
            this.txtRespostaSecreta.TabIndex = 12;
            this.txtRespostaSecreta.Visible = false;
            // 
            // btnEnviarResposta
            // 
            this.btnEnviarResposta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEnviarResposta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEnviarResposta.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarResposta.Location = new System.Drawing.Point(140, 356);
            this.btnEnviarResposta.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnviarResposta.Name = "btnEnviarResposta";
            this.btnEnviarResposta.Size = new System.Drawing.Size(312, 57);
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
            this.label1.Location = new System.Drawing.Point(308, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterar Senha";
            // 
            // frmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 466);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtUsuarioRec;
        private System.Windows.Forms.Label lbUsuarioRec;
        private System.Windows.Forms.Label lbNovaSenha;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblResposta;
    }
}
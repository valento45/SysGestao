namespace SysGestao.Produtos
{
    partial class frmCadastrarProduto
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
            this.frmControls = new System.Windows.Forms.Panel();
            this.btNovo = new System.Windows.Forms.Button();
            this.btVerCodigoDeBarras = new System.Windows.Forms.Button();
            this.btImprimirPDF = new System.Windows.Forms.Button();
            this.btAcao = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoSKU = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVariacao = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btRemoverImagem = new System.Windows.Forms.Button();
            this.btBuscarImagem = new System.Windows.Forms.Button();
            this.pctImagemProduto = new System.Windows.Forms.PictureBox();
            this.frmControls.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // frmControls
            // 
            this.frmControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frmControls.BackColor = System.Drawing.Color.GhostWhite;
            this.frmControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frmControls.Controls.Add(this.btNovo);
            this.frmControls.Controls.Add(this.btVerCodigoDeBarras);
            this.frmControls.Controls.Add(this.btImprimirPDF);
            this.frmControls.Controls.Add(this.btAcao);
            this.frmControls.Controls.Add(this.pnlControls);
            this.frmControls.Controls.Add(this.label1);
            this.frmControls.Controls.Add(this.btRemoverImagem);
            this.frmControls.Controls.Add(this.btBuscarImagem);
            this.frmControls.Controls.Add(this.pctImagemProduto);
            this.frmControls.Location = new System.Drawing.Point(9, 10);
            this.frmControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frmControls.Name = "frmControls";
            this.frmControls.Size = new System.Drawing.Size(860, 388);
            this.frmControls.TabIndex = 0;
            // 
            // btNovo
            // 
            this.btNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btNovo.Enabled = false;
            this.btNovo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(289, 358);
            this.btNovo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(133, 24);
            this.btNovo.TabIndex = 7;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btVerCodigoDeBarras
            // 
            this.btVerCodigoDeBarras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btVerCodigoDeBarras.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerCodigoDeBarras.Location = new System.Drawing.Point(708, 358);
            this.btVerCodigoDeBarras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btVerCodigoDeBarras.Name = "btVerCodigoDeBarras";
            this.btVerCodigoDeBarras.Size = new System.Drawing.Size(133, 24);
            this.btVerCodigoDeBarras.TabIndex = 6;
            this.btVerCodigoDeBarras.Text = "Ver código de barras";
            this.btVerCodigoDeBarras.UseVisualStyleBackColor = true;
            // 
            // btImprimirPDF
            // 
            this.btImprimirPDF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btImprimirPDF.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimirPDF.Location = new System.Drawing.Point(571, 358);
            this.btImprimirPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btImprimirPDF.Name = "btImprimirPDF";
            this.btImprimirPDF.Size = new System.Drawing.Size(133, 24);
            this.btImprimirPDF.TabIndex = 5;
            this.btImprimirPDF.Text = "Im&primir PDF";
            this.btImprimirPDF.UseVisualStyleBackColor = true;
            // 
            // btAcao
            // 
            this.btAcao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAcao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcao.Location = new System.Drawing.Point(431, 358);
            this.btAcao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(133, 24);
            this.btAcao.TabIndex = 4;
            this.btAcao.Text = "&Incluir";
            this.btAcao.UseVisualStyleBackColor = true;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlControls.Controls.Add(this.txtNome);
            this.pnlControls.Controls.Add(this.label8);
            this.pnlControls.Controls.Add(this.txtCodigoSKU);
            this.pnlControls.Controls.Add(this.txtDescricao);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label7);
            this.pnlControls.Controls.Add(this.label3);
            this.pnlControls.Controls.Add(this.txtVariacao);
            this.pnlControls.Controls.Add(this.txtCor);
            this.pnlControls.Controls.Add(this.label6);
            this.pnlControls.Controls.Add(this.label4);
            this.pnlControls.Controls.Add(this.txtQuantidade);
            this.pnlControls.Controls.Add(this.txtTamanho);
            this.pnlControls.Controls.Add(this.label5);
            this.pnlControls.Location = new System.Drawing.Point(242, 100);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(614, 158);
            this.pnlControls.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(88, 38);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(272, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(41, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome:";
            // 
            // txtCodigoSKU
            // 
            this.txtCodigoSKU.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSKU.Location = new System.Drawing.Point(88, 15);
            this.txtCodigoSKU.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoSKU.Name = "txtCodigoSKU";
            this.txtCodigoSKU.Size = new System.Drawing.Size(272, 20);
            this.txtCodigoSKU.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(88, 85);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(512, 68);
            this.txtDescricao.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código (SKU):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(362, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cor:";
            // 
            // txtVariacao
            // 
            this.txtVariacao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariacao.Location = new System.Drawing.Point(367, 62);
            this.txtVariacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVariacao.Name = "txtVariacao";
            this.txtVariacao.Size = new System.Drawing.Size(234, 20);
            this.txtVariacao.TabIndex = 6;
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(396, 15);
            this.txtCor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(204, 20);
            this.txtCor.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(302, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Variação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tamanho:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(234, 63);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(60, 20);
            this.txtQuantidade.TabIndex = 5;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTamanho
            // 
            this.txtTamanho.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanho.Location = new System.Drawing.Point(88, 62);
            this.txtTamanho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(59, 20);
            this.txtTamanho.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(150, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(390, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informações do produto";
            // 
            // btRemoverImagem
            // 
            this.btRemoverImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRemoverImagem.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverImagem.Location = new System.Drawing.Point(2, 358);
            this.btRemoverImagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btRemoverImagem.Name = "btRemoverImagem";
            this.btRemoverImagem.Size = new System.Drawing.Size(236, 24);
            this.btRemoverImagem.TabIndex = 3;
            this.btRemoverImagem.Text = "Remover imagem";
            this.btRemoverImagem.UseVisualStyleBackColor = true;
            // 
            // btBuscarImagem
            // 
            this.btBuscarImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBuscarImagem.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarImagem.Location = new System.Drawing.Point(2, 328);
            this.btBuscarImagem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btBuscarImagem.Name = "btBuscarImagem";
            this.btBuscarImagem.Size = new System.Drawing.Size(236, 24);
            this.btBuscarImagem.TabIndex = 2;
            this.btBuscarImagem.Text = "Buscar imagem";
            this.btBuscarImagem.UseVisualStyleBackColor = true;
            // 
            // pctImagemProduto
            // 
            this.pctImagemProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pctImagemProduto.ErrorImage = null;
            this.pctImagemProduto.Location = new System.Drawing.Point(2, 2);
            this.pctImagemProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctImagemProduto.Name = "pctImagemProduto";
            this.pctImagemProduto.Size = new System.Drawing.Size(236, 321);
            this.pctImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImagemProduto.TabIndex = 0;
            this.pctImagemProduto.TabStop = false;
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 407);
            this.Controls.Add(this.frmControls);
            this.Name = "frmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar produto";
            this.frmControls.ResumeLayout(false);
            this.frmControls.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagemProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel frmControls;
        private System.Windows.Forms.Button btBuscarImagem;
        private System.Windows.Forms.PictureBox pctImagemProduto;
        private System.Windows.Forms.Button btRemoverImagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVariacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoSKU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btVerCodigoDeBarras;
        private System.Windows.Forms.Button btImprimirPDF;
        private System.Windows.Forms.Button btAcao;
        private System.Windows.Forms.Button btNovo;
    }
}
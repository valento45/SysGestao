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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarProduto));
            this.frmControls = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btDuplicar = new System.Windows.Forms.Button();
            this.btBuscarImagem = new System.Windows.Forms.Button();
            this.btRemoverImagem = new System.Windows.Forms.Button();
            this.btAcao = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.btVerCodigoDeBarras = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pctBarCode = new System.Windows.Forms.PictureBox();
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
            this.pctImagemProduto = new System.Windows.Forms.PictureBox();
            this.btConfiguracaoSKUMarketplace = new System.Windows.Forms.Button();
            this.frmControls.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarCode)).BeginInit();
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
            this.frmControls.Controls.Add(this.pnlBotoes);
            this.frmControls.Controls.Add(this.label9);
            this.frmControls.Controls.Add(this.pictureBox1);
            this.frmControls.Controls.Add(this.pnlControls);
            this.frmControls.Controls.Add(this.label1);
            this.frmControls.Controls.Add(this.pctImagemProduto);
            this.frmControls.Location = new System.Drawing.Point(12, 11);
            this.frmControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frmControls.Name = "frmControls";
            this.frmControls.Size = new System.Drawing.Size(1146, 545);
            this.frmControls.TabIndex = 0;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotoes.Controls.Add(this.btDuplicar);
            this.pnlBotoes.Controls.Add(this.btBuscarImagem);
            this.pnlBotoes.Controls.Add(this.btRemoverImagem);
            this.pnlBotoes.Controls.Add(this.btAcao);
            this.pnlBotoes.Controls.Add(this.btNovo);
            this.pnlBotoes.Controls.Add(this.btVerCodigoDeBarras);
            this.pnlBotoes.Location = new System.Drawing.Point(3, 470);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(1138, 70);
            this.pnlBotoes.TabIndex = 10;
            // 
            // btDuplicar
            // 
            this.btDuplicar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btDuplicar.BackColor = System.Drawing.Color.GhostWhite;
            this.btDuplicar.Enabled = false;
            this.btDuplicar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btDuplicar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDuplicar.Location = new System.Drawing.Point(372, 37);
            this.btDuplicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDuplicar.Name = "btDuplicar";
            this.btDuplicar.Size = new System.Drawing.Size(177, 30);
            this.btDuplicar.TabIndex = 8;
            this.btDuplicar.Text = "&Duplicar";
            this.btDuplicar.UseVisualStyleBackColor = false;
            this.btDuplicar.Click += new System.EventHandler(this.btDuplicar_Click);
            // 
            // btBuscarImagem
            // 
            this.btBuscarImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBuscarImagem.BackColor = System.Drawing.Color.GhostWhite;
            this.btBuscarImagem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btBuscarImagem.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarImagem.Location = new System.Drawing.Point(3, 4);
            this.btBuscarImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscarImagem.Name = "btBuscarImagem";
            this.btBuscarImagem.Size = new System.Drawing.Size(315, 30);
            this.btBuscarImagem.TabIndex = 2;
            this.btBuscarImagem.Text = "Buscar imagem";
            this.btBuscarImagem.UseVisualStyleBackColor = false;
            this.btBuscarImagem.Click += new System.EventHandler(this.btBuscarImagem_Click);
            // 
            // btRemoverImagem
            // 
            this.btRemoverImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRemoverImagem.BackColor = System.Drawing.Color.GhostWhite;
            this.btRemoverImagem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btRemoverImagem.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoverImagem.Location = new System.Drawing.Point(3, 37);
            this.btRemoverImagem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRemoverImagem.Name = "btRemoverImagem";
            this.btRemoverImagem.Size = new System.Drawing.Size(315, 30);
            this.btRemoverImagem.TabIndex = 3;
            this.btRemoverImagem.Text = "Remover imagem";
            this.btRemoverImagem.UseVisualStyleBackColor = false;
            this.btRemoverImagem.Click += new System.EventHandler(this.btRemoverImagem_Click);
            // 
            // btAcao
            // 
            this.btAcao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAcao.BackColor = System.Drawing.Color.GhostWhite;
            this.btAcao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAcao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcao.Location = new System.Drawing.Point(740, 37);
            this.btAcao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(177, 30);
            this.btAcao.TabIndex = 4;
            this.btAcao.Text = "&Incluir";
            this.btAcao.UseVisualStyleBackColor = false;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // btNovo
            // 
            this.btNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btNovo.BackColor = System.Drawing.Color.GhostWhite;
            this.btNovo.Enabled = false;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btNovo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(555, 37);
            this.btNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(177, 30);
            this.btNovo.TabIndex = 7;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btVerCodigoDeBarras
            // 
            this.btVerCodigoDeBarras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btVerCodigoDeBarras.BackColor = System.Drawing.Color.GhostWhite;
            this.btVerCodigoDeBarras.Enabled = false;
            this.btVerCodigoDeBarras.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btVerCodigoDeBarras.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerCodigoDeBarras.Location = new System.Drawing.Point(924, 37);
            this.btVerCodigoDeBarras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVerCodigoDeBarras.Name = "btVerCodigoDeBarras";
            this.btVerCodigoDeBarras.Size = new System.Drawing.Size(177, 30);
            this.btVerCodigoDeBarras.TabIndex = 6;
            this.btVerCodigoDeBarras.Text = "Ver código de barras";
            this.btVerCodigoDeBarras.UseVisualStyleBackColor = false;
            this.btVerCodigoDeBarras.Click += new System.EventHandler(this.btVerCodigoDeBarras_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(333, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Campos obrigatórios marcados com *";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = global::SysGestao.Properties.Resources.imgCadProduto;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(490, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 54);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.Controls.Add(this.btConfiguracaoSKUMarketplace);
            this.pnlControls.Controls.Add(this.txtLocalizacao);
            this.pnlControls.Controls.Add(this.label10);
            this.pnlControls.Controls.Add(this.pctBarCode);
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
            this.pnlControls.Location = new System.Drawing.Point(323, 95);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(819, 370);
            this.pnlControls.TabIndex = 1;
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocalizacao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizacao.Location = new System.Drawing.Point(589, 73);
            this.txtLocalizacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(211, 23);
            this.txtLocalizacao.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(492, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Localizacao:";
            // 
            // pctBarCode
            // 
            this.pctBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctBarCode.ErrorImage = null;
            this.pctBarCode.Location = new System.Drawing.Point(118, 267);
            this.pctBarCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctBarCode.Name = "pctBarCode";
            this.pctBarCode.Size = new System.Drawing.Size(683, 91);
            this.pctBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBarCode.TabIndex = 9;
            this.pctBarCode.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(117, 71);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 23);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.txtCodigoSKU_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(55, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome:";
            // 
            // txtCodigoSKU
            // 
            this.txtCodigoSKU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoSKU.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSKU.Location = new System.Drawing.Point(117, 42);
            this.txtCodigoSKU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoSKU.Name = "txtCodigoSKU";
            this.txtCodigoSKU.Size = new System.Drawing.Size(361, 23);
            this.txtCodigoSKU.TabIndex = 1;
            this.txtCodigoSKU.TextChanged += new System.EventHandler(this.txtCodigoSKU_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(118, 180);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(681, 83);
            this.txtDescricao.TabIndex = 8;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtCodigoSKU_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código (SKU):*";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(31, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(483, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cor:";
            // 
            // txtVariacao
            // 
            this.txtVariacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVariacao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariacao.Location = new System.Drawing.Point(489, 100);
            this.txtVariacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVariacao.Name = "txtVariacao";
            this.txtVariacao.Size = new System.Drawing.Size(311, 23);
            this.txtVariacao.TabIndex = 7;
            this.txtVariacao.TextChanged += new System.EventHandler(this.txtCodigoSKU_TextChanged);
            // 
            // txtCor
            // 
            this.txtCor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCor.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(528, 42);
            this.txtCor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(271, 23);
            this.txtCor.TabIndex = 2;
            this.txtCor.TextChanged += new System.EventHandler(this.txtCodigoSKU_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(403, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Variação:*";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tamanho:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantidade.Location = new System.Drawing.Point(312, 102);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(80, 22);
            this.txtQuantidade.TabIndex = 6;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Enter += new System.EventHandler(this.txtQuantidade_Enter);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTamanho.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanho.Location = new System.Drawing.Point(117, 100);
            this.txtTamanho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(77, 23);
            this.txtTamanho.TabIndex = 5;
            this.txtTamanho.TextChanged += new System.EventHandler(this.txtCodigoSKU_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(200, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade:*";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(578, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informações do produto";
            // 
            // pctImagemProduto
            // 
            this.pctImagemProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pctImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctImagemProduto.ErrorImage = null;
            this.pctImagemProduto.Location = new System.Drawing.Point(3, 2);
            this.pctImagemProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctImagemProduto.Name = "pctImagemProduto";
            this.pctImagemProduto.Size = new System.Drawing.Size(315, 463);
            this.pctImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImagemProduto.TabIndex = 0;
            this.pctImagemProduto.TabStop = false;
            // 
            // btConfiguracaoSKUMarketplace
            // 
            this.btConfiguracaoSKUMarketplace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConfiguracaoSKUMarketplace.BackColor = System.Drawing.Color.GhostWhite;
            this.btConfiguracaoSKUMarketplace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btConfiguracaoSKUMarketplace.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfiguracaoSKUMarketplace.Location = new System.Drawing.Point(118, 146);
            this.btConfiguracaoSKUMarketplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConfiguracaoSKUMarketplace.Name = "btConfiguracaoSKUMarketplace";
            this.btConfiguracaoSKUMarketplace.Size = new System.Drawing.Size(315, 30);
            this.btConfiguracaoSKUMarketplace.TabIndex = 19;
            this.btConfiguracaoSKUMarketplace.Text = "Configuração SKU por marketplace";
            this.btConfiguracaoSKUMarketplace.UseVisualStyleBackColor = false;
            this.btConfiguracaoSKUMarketplace.Click += new System.EventHandler(this.btConfiguracaoSKUMarketplace_Click);
            // 
            // frmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 568);
            this.Controls.Add(this.frmControls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastrarProduto";
            this.Text = "Cadastrar produto";
            this.Load += new System.EventHandler(this.frmCadastrarProduto_Load);
            this.Shown += new System.EventHandler(this.frmCadastrarProduto_Shown);
            this.frmControls.ResumeLayout(false);
            this.frmControls.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarCode)).EndInit();
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
        private System.Windows.Forms.Button btAcao;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctBarCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btDuplicar;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btConfiguracaoSKUMarketplace;
    }
}
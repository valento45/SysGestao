namespace SysGestao.Produtos
{
    partial class frmCadastroKitProdutos
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
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVariacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btBuscarItem = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btConfiguracaoSKUMarketplace = new System.Windows.Forms.Button();
            this.txtCodigoSKU = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVariacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.pnlFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlFundo.Controls.Add(this.button1);
            this.pnlFundo.Controls.Add(this.dgvProdutos);
            this.pnlFundo.Controls.Add(this.label1);
            this.pnlFundo.Controls.Add(this.btBuscarItem);
            this.pnlFundo.Controls.Add(this.pnlControls);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1267, 481);
            this.pnlFundo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1087, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Remover produto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeight = 29;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colCodigoSKU,
            this.colCor,
            this.colTamanho,
            this.colQuantidade,
            this.colVariacao,
            this.colDescricao,
            this.colObj});
            this.dgvProdutos.Location = new System.Drawing.Point(3, 274);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1078, 195);
            this.dgvProdutos.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 49;
            // 
            // colCodigoSKU
            // 
            this.colCodigoSKU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCodigoSKU.DataPropertyName = "SKU";
            this.colCodigoSKU.HeaderText = "Código(SKU)";
            this.colCodigoSKU.MinimumWidth = 6;
            this.colCodigoSKU.Name = "colCodigoSKU";
            this.colCodigoSKU.ReadOnly = true;
            // 
            // colCor
            // 
            this.colCor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCor.HeaderText = "Cor";
            this.colCor.MinimumWidth = 6;
            this.colCor.Name = "colCor";
            this.colCor.ReadOnly = true;
            this.colCor.Width = 57;
            // 
            // colTamanho
            // 
            this.colTamanho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTamanho.HeaderText = "Tamanho";
            this.colTamanho.MinimumWidth = 6;
            this.colTamanho.Name = "colTamanho";
            this.colTamanho.ReadOnly = true;
            this.colTamanho.Width = 94;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.MinimumWidth = 6;
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.Width = 106;
            // 
            // colVariacao
            // 
            this.colVariacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVariacao.DataPropertyName = "variacao";
            this.colVariacao.HeaderText = "Variação";
            this.colVariacao.MinimumWidth = 6;
            this.colVariacao.Name = "colVariacao";
            this.colVariacao.ReadOnly = true;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.MinimumWidth = 6;
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            this.colDescricao.Width = 98;
            // 
            // colObj
            // 
            this.colObj.HeaderText = "obj";
            this.colObj.MinimumWidth = 6;
            this.colObj.Name = "colObj";
            this.colObj.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(576, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lista de itens";
            // 
            // btBuscarItem
            // 
            this.btBuscarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscarItem.BackColor = System.Drawing.Color.GhostWhite;
            this.btBuscarItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btBuscarItem.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarItem.Location = new System.Drawing.Point(1087, 274);
            this.btBuscarItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscarItem.Name = "btBuscarItem";
            this.btBuscarItem.Size = new System.Drawing.Size(177, 30);
            this.btBuscarItem.TabIndex = 13;
            this.btBuscarItem.Text = "Buscar produto";
            this.btBuscarItem.UseVisualStyleBackColor = false;
            this.btBuscarItem.Click += new System.EventHandler(this.btBuscarItem_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.Controls.Add(this.label3);
            this.pnlControls.Controls.Add(this.btConfiguracaoSKUMarketplace);
            this.pnlControls.Controls.Add(this.txtCodigoSKU);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.txtLocalizacao);
            this.pnlControls.Controls.Add(this.label10);
            this.pnlControls.Controls.Add(this.txtNome);
            this.pnlControls.Controls.Add(this.label8);
            this.pnlControls.Controls.Add(this.txtDescricao);
            this.pnlControls.Controls.Add(this.label7);
            this.pnlControls.Controls.Add(this.txtVariacao);
            this.pnlControls.Controls.Add(this.label6);
            this.pnlControls.Controls.Add(this.txtQuantidade);
            this.pnlControls.Controls.Add(this.label5);
            this.pnlControls.Location = new System.Drawing.Point(3, 2);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1261, 210);
            this.pnlControls.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(510, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cadastro KIT de Produtos";
            // 
            // btConfiguracaoSKUMarketplace
            // 
            this.btConfiguracaoSKUMarketplace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConfiguracaoSKUMarketplace.BackColor = System.Drawing.Color.GhostWhite;
            this.btConfiguracaoSKUMarketplace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btConfiguracaoSKUMarketplace.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfiguracaoSKUMarketplace.Location = new System.Drawing.Point(137, 157);
            this.btConfiguracaoSKUMarketplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConfiguracaoSKUMarketplace.Name = "btConfiguracaoSKUMarketplace";
            this.btConfiguracaoSKUMarketplace.Size = new System.Drawing.Size(315, 30);
            this.btConfiguracaoSKUMarketplace.TabIndex = 12;
            this.btConfiguracaoSKUMarketplace.Text = "Configuração SKU por marketplace";
            this.btConfiguracaoSKUMarketplace.UseVisualStyleBackColor = false;
            this.btConfiguracaoSKUMarketplace.Click += new System.EventHandler(this.btConfiguracaoSKUMarketplace_Click);
            // 
            // txtCodigoSKU
            // 
            this.txtCodigoSKU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigoSKU.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoSKU.Location = new System.Drawing.Point(628, 96);
            this.txtCodigoSKU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoSKU.Name = "txtCodigoSKU";
            this.txtCodigoSKU.Size = new System.Drawing.Size(312, 23);
            this.txtCodigoSKU.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(512, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código (SKU):*";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLocalizacao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizacao.Location = new System.Drawing.Point(1055, 96);
            this.txtLocalizacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(151, 23);
            this.txtLocalizacao.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(958, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Localizacao:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(137, 96);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(75, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(749, 127);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(457, 60);
            this.txtDescricao.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(662, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição:";
            // 
            // txtVariacao
            // 
            this.txtVariacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVariacao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariacao.Location = new System.Drawing.Point(137, 127);
            this.txtVariacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVariacao.Name = "txtVariacao";
            this.txtVariacao.Size = new System.Drawing.Size(312, 23);
            this.txtVariacao.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(46, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Variação:*";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantidade.Location = new System.Drawing.Point(572, 127);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(80, 22);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.GhostWhite;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(460, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade:*";
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSalvar.BackColor = System.Drawing.Color.GhostWhite;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSalvar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(491, 499);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(177, 30);
            this.btSalvar.TabIndex = 15;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancelar.BackColor = System.Drawing.Color.GhostWhite;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCancelar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(674, 499);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(177, 30);
            this.btCancelar.TabIndex = 16;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmCadastroKitProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1291, 540);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.pnlFundo);
            this.Name = "frmCadastroKitProdutos";
            this.Text = "Cadastro KIT Produtos";
            this.Load += new System.EventHandler(this.frmCadastroKitProdutos_Load);
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Button btConfiguracaoSKUMarketplace;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoSKU;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVariacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btBuscarItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObj;
    }
}
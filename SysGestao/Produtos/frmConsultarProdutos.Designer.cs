namespace SysGestao.Produtos
{
    partial class frmConsultarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btProcurar = new System.Windows.Forms.Button();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigoSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVariacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAcao = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btImprimirEtiqueta = new System.Windows.Forms.Button();
            this.btnMarcaDesmarca = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvProdutos);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 366);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btProcurar);
            this.groupBox1.Controls.Add(this.cmbFiltros);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1182, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btProcurar
            // 
            this.btProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btProcurar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurar.Location = new System.Drawing.Point(999, 42);
            this.btProcurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(177, 26);
            this.btProcurar.TabIndex = 3;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Código(SKU)",
            "Variação"});
            this.cmbFiltros.Location = new System.Drawing.Point(87, 41);
            this.cmbFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(211, 24);
            this.cmbFiltros.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filtrar por";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(304, 42);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(689, 23);
            this.txtFiltro.TabIndex = 2;
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
            this.dgvProdutos.Location = new System.Drawing.Point(3, 150);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1182, 211);
            this.dgvProdutos.TabIndex = 4;
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
            this.colQuantidade.ReadOnly = true;
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
            this.colObj.ReadOnly = true;
            this.colObj.Visible = false;
            // 
            // btAcao
            // 
            this.btAcao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAcao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcao.Location = new System.Drawing.Point(433, 399);
            this.btAcao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(177, 30);
            this.btAcao.TabIndex = 1;
            this.btAcao.Text = "Alterar";
            this.btAcao.UseVisualStyleBackColor = true;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btExcluir.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(617, 399);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(177, 30);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btImprimirEtiqueta
            // 
            this.btImprimirEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btImprimirEtiqueta.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimirEtiqueta.Location = new System.Drawing.Point(799, 399);
            this.btImprimirEtiqueta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btImprimirEtiqueta.Name = "btImprimirEtiqueta";
            this.btImprimirEtiqueta.Size = new System.Drawing.Size(177, 30);
            this.btImprimirEtiqueta.TabIndex = 4;
            this.btImprimirEtiqueta.Text = "Imprimir Etiquetas";
            this.btImprimirEtiqueta.UseVisualStyleBackColor = true;
            this.btImprimirEtiqueta.Click += new System.EventHandler(this.btImprimirEtiqueta_Click);
            // 
            // btnMarcaDesmarca
            // 
            this.btnMarcaDesmarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMarcaDesmarca.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcaDesmarca.Location = new System.Drawing.Point(250, 400);
            this.btnMarcaDesmarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarcaDesmarca.Name = "btnMarcaDesmarca";
            this.btnMarcaDesmarca.Size = new System.Drawing.Size(177, 30);
            this.btnMarcaDesmarca.TabIndex = 5;
            this.btnMarcaDesmarca.Text = "Marca/Desmarca";
            this.btnMarcaDesmarca.UseVisualStyleBackColor = true;
            this.btnMarcaDesmarca.Click += new System.EventHandler(this.btnMarcaDesmarca_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btIncluir.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIncluir.Location = new System.Drawing.Point(12, 400);
            this.btIncluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(115, 30);
            this.btIncluir.TabIndex = 10;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btSelecionar
            // 
            this.btSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btSelecionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelecionar.Location = new System.Drawing.Point(133, 400);
            this.btSelecionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(111, 30);
            this.btSelecionar.TabIndex = 11;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Visible = false;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // frmConsultarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 441);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.btnMarcaDesmarca);
            this.Controls.Add(this.btImprimirEtiqueta);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAcao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultarProdutos";
            this.Text = "Consultar produtos";
            this.Shown += new System.EventHandler(this.frmConsultarProdutos_Shown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.Button btAcao;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btImprimirEtiqueta;
        private System.Windows.Forms.Button btnMarcaDesmarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObj;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btSelecionar;
    }
}
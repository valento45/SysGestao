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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btProcurar = new System.Windows.Forms.Button();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 383);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btProcurar
            // 
            this.btProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btProcurar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurar.Location = new System.Drawing.Point(837, 42);
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
            this.label3.Size = new System.Drawing.Size(72, 19);
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
            this.txtFiltro.Size = new System.Drawing.Size(527, 23);
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
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCodigoSKU,
            this.colCor,
            this.colTamanho,
            this.colQuantidade,
            this.colVariacao,
            this.colDescricao,
            this.colObj});
            this.dgvProdutos.Location = new System.Drawing.Point(3, 149);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1020, 229);
            this.dgvProdutos.TabIndex = 4;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colCodigoSKU
            // 
            this.colCodigoSKU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.colCor.Width = 59;
            // 
            // colTamanho
            // 
            this.colTamanho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTamanho.HeaderText = "Tamanho";
            this.colTamanho.MinimumWidth = 6;
            this.colTamanho.Name = "colTamanho";
            this.colTamanho.ReadOnly = true;
            this.colTamanho.Width = 97;
            // 
            // colQuantidade
            // 
            this.colQuantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.MinimumWidth = 6;
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            this.colQuantidade.Width = 111;
            // 
            // colVariacao
            // 
            this.colVariacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.btAcao.Location = new System.Drawing.Point(238, 400);
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
            this.btExcluir.Location = new System.Drawing.Point(421, 400);
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
            this.btImprimirEtiqueta.Location = new System.Drawing.Point(604, 400);
            this.btImprimirEtiqueta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btImprimirEtiqueta.Name = "btImprimirEtiqueta";
            this.btImprimirEtiqueta.Size = new System.Drawing.Size(177, 30);
            this.btImprimirEtiqueta.TabIndex = 4;
            this.btImprimirEtiqueta.Text = "Imprimir PDF Etiqueta";
            this.btImprimirEtiqueta.UseVisualStyleBackColor = true;
            // 
            // frmConsultarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 441);
            this.Controls.Add(this.btImprimirEtiqueta);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAcao);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsultarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigoSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObj;
    }
}
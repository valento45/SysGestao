
namespace SysGestao.Produtos
{
    partial class frmSeparacaoDeProdutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.grpDadosProduto = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVariacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoSKU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpProdutosLista = new System.Windows.Forms.GroupBox();
            this.lbImagem = new System.Windows.Forms.Label();
            this.btFinalizaSolicitacao = new System.Windows.Forms.Button();
            this.pctImagemProduto = new System.Windows.Forms.PictureBox();
            this.btBuscarProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVariacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidadeSeparada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDestinatario = new System.Windows.Forms.GroupBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlFundo.SuspendLayout();
            this.grpDadosProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.grpProdutosLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagemProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grpDestinatario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo.Controls.Add(this.grpDadosProduto);
            this.pnlFundo.Controls.Add(this.grpProdutosLista);
            this.pnlFundo.Controls.Add(this.grpDestinatario);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1399, 605);
            this.pnlFundo.TabIndex = 0;
            // 
            // grpDadosProduto
            // 
            this.grpDadosProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDadosProduto.Controls.Add(this.btnAdicionar);
            this.grpDadosProduto.Controls.Add(this.txtQuantidade);
            this.grpDadosProduto.Controls.Add(this.label2);
            this.grpDadosProduto.Controls.Add(this.txtVariacao);
            this.grpDadosProduto.Controls.Add(this.label1);
            this.grpDadosProduto.Controls.Add(this.txtCodigoSKU);
            this.grpDadosProduto.Controls.Add(this.label8);
            this.grpDadosProduto.Location = new System.Drawing.Point(3, 94);
            this.grpDadosProduto.Name = "grpDadosProduto";
            this.grpDadosProduto.Size = new System.Drawing.Size(1391, 92);
            this.grpDadosProduto.TabIndex = 2;
            this.grpDadosProduto.TabStop = false;
            this.grpDadosProduto.Text = "Dados produto";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdicionar.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(782, 51);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(177, 30);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtQuantidade.Location = new System.Drawing.Point(901, 23);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(56, 22);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Enter += new System.EventHandler(this.txtQuantidade_Enter);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(797, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantidade:";
            // 
            // txtVariacao
            // 
            this.txtVariacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtVariacao.Enabled = false;
            this.txtVariacao.Location = new System.Drawing.Point(495, 57);
            this.txtVariacao.Name = "txtVariacao";
            this.txtVariacao.Size = new System.Drawing.Size(281, 22);
            this.txtVariacao.TabIndex = 0;
            this.txtVariacao.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(412, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Variação:";
            // 
            // txtCodigoSKU
            // 
            this.txtCodigoSKU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCodigoSKU.Location = new System.Drawing.Point(495, 21);
            this.txtCodigoSKU.Name = "txtCodigoSKU";
            this.txtCodigoSKU.Size = new System.Drawing.Size(279, 22);
            this.txtCodigoSKU.TabIndex = 1;
            this.txtCodigoSKU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSKU_KeyPress);
            this.txtCodigoSKU.Leave += new System.EventHandler(this.txtCodigoSKU_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(422, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Produto:";
            // 
            // grpProdutosLista
            // 
            this.grpProdutosLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProdutosLista.Controls.Add(this.lbImagem);
            this.grpProdutosLista.Controls.Add(this.btFinalizaSolicitacao);
            this.grpProdutosLista.Controls.Add(this.pctImagemProduto);
            this.grpProdutosLista.Controls.Add(this.btBuscarProduto);
            this.grpProdutosLista.Controls.Add(this.dgvProdutos);
            this.grpProdutosLista.Location = new System.Drawing.Point(3, 192);
            this.grpProdutosLista.Name = "grpProdutosLista";
            this.grpProdutosLista.Size = new System.Drawing.Size(1391, 387);
            this.grpProdutosLista.TabIndex = 3;
            this.grpProdutosLista.TabStop = false;
            this.grpProdutosLista.Text = "Lista de separação";
            // 
            // lbImagem
            // 
            this.lbImagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbImagem.AutoSize = true;
            this.lbImagem.Location = new System.Drawing.Point(1035, 195);
            this.lbImagem.Name = "lbImagem";
            this.lbImagem.Size = new System.Drawing.Size(57, 17);
            this.lbImagem.TabIndex = 10;
            this.lbImagem.Text = "Imagem";
            this.lbImagem.Visible = false;
            // 
            // btFinalizaSolicitacao
            // 
            this.btFinalizaSolicitacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFinalizaSolicitacao.BackColor = System.Drawing.Color.GhostWhite;
            this.btFinalizaSolicitacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btFinalizaSolicitacao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizaSolicitacao.Location = new System.Drawing.Point(1212, 55);
            this.btFinalizaSolicitacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFinalizaSolicitacao.Name = "btFinalizaSolicitacao";
            this.btFinalizaSolicitacao.Size = new System.Drawing.Size(177, 30);
            this.btFinalizaSolicitacao.TabIndex = 9;
            this.btFinalizaSolicitacao.Text = "Finalizar solicitação(F12)";
            this.btFinalizaSolicitacao.UseVisualStyleBackColor = false;
            this.btFinalizaSolicitacao.Click += new System.EventHandler(this.btFinalizaSolicitacao_Click);
            // 
            // pctImagemProduto
            // 
            this.pctImagemProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctImagemProduto.ErrorImage = null;
            this.pctImagemProduto.Location = new System.Drawing.Point(919, 21);
            this.pctImagemProduto.Name = "pctImagemProduto";
            this.pctImagemProduto.Size = new System.Drawing.Size(291, 359);
            this.pctImagemProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImagemProduto.TabIndex = 1;
            this.pctImagemProduto.TabStop = false;
            // 
            // btBuscarProduto
            // 
            this.btBuscarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscarProduto.BackColor = System.Drawing.Color.GhostWhite;
            this.btBuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btBuscarProduto.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscarProduto.Location = new System.Drawing.Point(1212, 21);
            this.btBuscarProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBuscarProduto.Name = "btBuscarProduto";
            this.btBuscarProduto.Size = new System.Drawing.Size(177, 30);
            this.btBuscarProduto.TabIndex = 8;
            this.btBuscarProduto.Text = "&Buscar produto";
            this.btBuscarProduto.UseVisualStyleBackColor = false;
            this.btBuscarProduto.Click += new System.EventHandler(this.btBuscarProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colSKU,
            this.colVariacao,
            this.colQtd,
            this.colQuantidadeSeparada,
            this.colStatus,
            this.colObj});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.Location = new System.Drawing.Point(6, 21);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(907, 359);
            this.dgvProdutos.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "Id";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 48;
            // 
            // colSKU
            // 
            this.colSKU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSKU.HeaderText = "Código (SKU)";
            this.colSKU.MinimumWidth = 6;
            this.colSKU.Name = "colSKU";
            this.colSKU.ReadOnly = true;
            // 
            // colVariacao
            // 
            this.colVariacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colVariacao.HeaderText = "Variação";
            this.colVariacao.MinimumWidth = 6;
            this.colVariacao.Name = "colVariacao";
            this.colVariacao.ReadOnly = true;
            this.colVariacao.Width = 93;
            // 
            // colQtd
            // 
            this.colQtd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQtd.HeaderText = "Quantidade";
            this.colQtd.MinimumWidth = 6;
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            this.colQtd.Width = 111;
            // 
            // colQuantidadeSeparada
            // 
            this.colQuantidadeSeparada.HeaderText = "Qtd. separada";
            this.colQuantidadeSeparada.MinimumWidth = 6;
            this.colQuantidadeSeparada.Name = "colQuantidadeSeparada";
            this.colQuantidadeSeparada.Width = 125;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Visible = false;
            this.colStatus.Width = 125;
            // 
            // colObj
            // 
            this.colObj.HeaderText = "obj";
            this.colObj.MinimumWidth = 6;
            this.colObj.Name = "colObj";
            this.colObj.Visible = false;
            this.colObj.Width = 125;
            // 
            // grpDestinatario
            // 
            this.grpDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDestinatario.Controls.Add(this.lbNome);
            this.grpDestinatario.Controls.Add(this.label7);
            this.grpDestinatario.Location = new System.Drawing.Point(3, 12);
            this.grpDestinatario.Name = "grpDestinatario";
            this.grpDestinatario.Size = new System.Drawing.Size(1391, 76);
            this.grpDestinatario.TabIndex = 0;
            this.grpDestinatario.TabStop = false;
            this.grpDestinatario.Text = "Dados destinatário";
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Black;
            this.lbNome.Location = new System.Drawing.Point(289, 18);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(332, 34);
            this.lbNome.TabIndex = 16;
            this.lbNome.Text = "Exemple Souza Oliveira";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(178, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 34);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nome:";
            // 
            // frmSeparacaoDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 623);
            this.Controls.Add(this.pnlFundo);
            this.Name = "frmSeparacaoDeProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separação de produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSeparacaoDeProdutos_Load);
            this.pnlFundo.ResumeLayout(false);
            this.grpDadosProduto.ResumeLayout(false);
            this.grpDadosProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.grpProdutosLista.ResumeLayout(false);
            this.grpProdutosLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImagemProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grpDestinatario.ResumeLayout(false);
            this.grpDestinatario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.GroupBox grpProdutosLista;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.GroupBox grpDestinatario;
        private System.Windows.Forms.Button btBuscarProduto;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pctImagemProduto;
        private System.Windows.Forms.GroupBox grpDadosProduto;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVariacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoSKU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btFinalizaSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVariacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidadeSeparada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObj;
        private System.Windows.Forms.Label lbImagem;
    }
}
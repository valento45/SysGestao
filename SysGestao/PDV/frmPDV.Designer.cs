namespace SysGestao.PDV
{
    partial class frmPDV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDividirPgto = new System.Windows.Forms.Button();
            this.pnlDinheiro = new System.Windows.Forms.Panel();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFormaPgto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.chkVendaFiado = new System.Windows.Forms.CheckBox();
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.pnlFundo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDinheiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo.Controls.Add(this.panel1);
            this.pnlFundo.Location = new System.Drawing.Point(11, 11);
            this.pnlFundo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1513, 660);
            this.pnlFundo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDividirPgto);
            this.panel1.Controls.Add(this.pnlDinheiro);
            this.panel1.Controls.Add(this.cmbFormaPgto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvProdutos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProduto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtQtde);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Controls.Add(this.pnlBotoes);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 634);
            this.panel1.TabIndex = 0;
            // 
            // btnDividirPgto
            // 
            this.btnDividirPgto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDividirPgto.BackColor = System.Drawing.Color.Transparent;
            this.btnDividirPgto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDividirPgto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividirPgto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividirPgto.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnDividirPgto.ForeColor = System.Drawing.Color.White;
            this.btnDividirPgto.Location = new System.Drawing.Point(946, 577);
            this.btnDividirPgto.Margin = new System.Windows.Forms.Padding(2);
            this.btnDividirPgto.Name = "btnDividirPgto";
            this.btnDividirPgto.Size = new System.Drawing.Size(56, 41);
            this.btnDividirPgto.TabIndex = 41;
            this.btnDividirPgto.UseVisualStyleBackColor = false;
            // 
            // pnlDinheiro
            // 
            this.pnlDinheiro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDinheiro.Controls.Add(this.txtTroco);
            this.pnlDinheiro.Controls.Add(this.label6);
            this.pnlDinheiro.Controls.Add(this.txtValorPago);
            this.pnlDinheiro.Controls.Add(this.label5);
            this.pnlDinheiro.Location = new System.Drawing.Point(1197, 475);
            this.pnlDinheiro.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDinheiro.Name = "pnlDinheiro";
            this.pnlDinheiro.Size = new System.Drawing.Size(288, 145);
            this.pnlDinheiro.TabIndex = 40;
            this.pnlDinheiro.Visible = false;
            // 
            // txtTroco
            // 
            this.txtTroco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTroco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTroco.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.txtTroco.Location = new System.Drawing.Point(12, 102);
            this.txtTroco.Margin = new System.Windows.Forms.Padding(2);
            this.txtTroco.Multiline = true;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(210, 39);
            this.txtTroco.TabIndex = 36;
            this.txtTroco.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Troco (R$)";
            // 
            // txtValorPago
            // 
            this.txtValorPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtValorPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorPago.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.txtValorPago.Location = new System.Drawing.Point(12, 34);
            this.txtValorPago.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorPago.Multiline = true;
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(210, 39);
            this.txtValorPago.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Valor pago (R$)";
            // 
            // cmbFormaPgto
            // 
            this.cmbFormaPgto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbFormaPgto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPgto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormaPgto.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.cmbFormaPgto.FormattingEnabled = true;
            this.cmbFormaPgto.Items.AddRange(new object[] {
            "Dinheiro",
            "Pix",
            "Cartão Crédito/Débito",
            "Múltiplos pagamentos"});
            this.cmbFormaPgto.Location = new System.Drawing.Point(619, 582);
            this.cmbFormaPgto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFormaPgto.Name = "cmbFormaPgto";
            this.cmbFormaPgto.Size = new System.Drawing.Size(324, 33);
            this.cmbFormaPgto.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(614, 552);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Forma pgto.";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.txtTotal.Location = new System.Drawing.Point(129, 584);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(444, 39);
            this.txtTotal.TabIndex = 32;
            this.txtTotal.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(124, 552);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total (R$)";
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
            this.colId,
            this.colDescricao,
            this.colPrecoUnitario,
            this.colQtde,
            this.colTotal,
            this.colObj});
            this.dgvProdutos.Location = new System.Drawing.Point(129, 163);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1064, 377);
            this.dgvProdutos.TabIndex = 30;
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 43;
            // 
            // colDescricao
            // 
            this.colDescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.MinimumWidth = 6;
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.ReadOnly = true;
            // 
            // colPrecoUnitario
            // 
            this.colPrecoUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colPrecoUnitario.HeaderText = "Preço unitário";
            this.colPrecoUnitario.MinimumWidth = 6;
            this.colPrecoUnitario.Name = "colPrecoUnitario";
            this.colPrecoUnitario.ReadOnly = true;
            this.colPrecoUnitario.Width = 97;
            // 
            // colQtde
            // 
            this.colQtde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colQtde.HeaderText = "Qtde.";
            this.colQtde.MinimumWidth = 6;
            this.colQtde.Name = "colQtde";
            this.colQtde.ReadOnly = true;
            this.colQtde.Width = 58;
            // 
            // colTotal
            // 
            this.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTotal.HeaderText = "Total (R$)";
            this.colTotal.MinimumWidth = 6;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 79;
            // 
            // colObj
            // 
            this.colObj.HeaderText = "";
            this.colObj.MinimumWidth = 6;
            this.colObj.Name = "colObj";
            this.colObj.ReadOnly = true;
            this.colObj.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1256, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Qtde.";
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.txtProduto.Location = new System.Drawing.Point(129, 105);
            this.txtProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtProduto.Multiline = true;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(1123, 39);
            this.txtProduto.TabIndex = 2;
            this.txtProduto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Produto:";
            // 
            // txtQtde
            // 
            this.txtQtde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtde.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.txtQtde.Location = new System.Drawing.Point(1330, 110);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(2);
            this.txtQtde.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(121, 34);
            this.txtQtde.TabIndex = 3;
            this.txtQtde.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.txtCliente.Location = new System.Drawing.Point(129, 41);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(1323, 39);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TabStop = false;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnBuscarCliente);
            this.pnlBotoes.Controls.Add(this.chkVendaFiado);
            this.pnlBotoes.Controls.Add(this.btnBuscarProduto);
            this.pnlBotoes.Controls.Add(this.btnAdicionar);
            this.pnlBotoes.Controls.Add(this.btnFinalizar);
            this.pnlBotoes.Controls.Add(this.btnRemover);
            this.pnlBotoes.Location = new System.Drawing.Point(1194, 163);
            this.pnlBotoes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(288, 306);
            this.pnlBotoes.TabIndex = 41;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(4, 219);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(254, 51);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar (CTRL + S)";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCliente.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(4, 2);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(254, 51);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar cliente (F1)";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // chkVendaFiado
            // 
            this.chkVendaFiado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVendaFiado.AutoSize = true;
            this.chkVendaFiado.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVendaFiado.Location = new System.Drawing.Point(27, 328);
            this.chkVendaFiado.Margin = new System.Windows.Forms.Padding(2);
            this.chkVendaFiado.Name = "chkVendaFiado";
            this.chkVendaFiado.Size = new System.Drawing.Size(230, 34);
            this.chkVendaFiado.TabIndex = 9;
            this.chkVendaFiado.Text = "Venda por prazo";
            this.chkVendaFiado.UseVisualStyleBackColor = true;
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProduto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuscarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProduto.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnBuscarProduto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProduto.Location = new System.Drawing.Point(4, 56);
            this.btnBuscarProduto.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(254, 51);
            this.btnBuscarProduto.TabIndex = 5;
            this.btnBuscarProduto.Text = "Buscar produto (F2)";
            this.btnBuscarProduto.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(4, 110);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(254, 51);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar (F3)";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(4, 274);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(254, 51);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar (F5)";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(4, 165);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(254, 51);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover (F4)";
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // frmPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 682);
            this.Controls.Add(this.pnlFundo);
            this.Name = "frmPDV";
            this.Text = "Frente de caixa / PDV";
            this.pnlFundo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDinheiro.ResumeLayout(false);
            this.pnlDinheiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDividirPgto;
        private System.Windows.Forms.Panel pnlDinheiro;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFormaPgto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtQtde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.CheckBox chkVendaFiado;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnRemover;
    }
}
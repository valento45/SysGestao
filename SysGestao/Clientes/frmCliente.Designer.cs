namespace SysGestao.Clientes
{
    partial class frmCliente
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.txtlimite = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btProcurar = new System.Windows.Forms.Button();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAlterar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdEstrangeiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btNovo = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdEstrangeiro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtlimite)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 410);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabConsulta);
            this.tabControl1.Controls.Add(this.tabCadastro);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.txtlimite);
            this.tabConsulta.Controls.Add(this.label2);
            this.tabConsulta.Controls.Add(this.btProcurar);
            this.tabConsulta.Controls.Add(this.cmbFiltros);
            this.tabConsulta.Controls.Add(this.label3);
            this.tabConsulta.Controls.Add(this.txtFiltro);
            this.tabConsulta.Controls.Add(this.toolStrip1);
            this.tabConsulta.Controls.Add(this.dgvClientes);
            this.tabConsulta.Location = new System.Drawing.Point(4, 26);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(875, 372);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consultar";
            this.tabConsulta.UseVisualStyleBackColor = true;
            this.tabConsulta.Enter += new System.EventHandler(this.tabConsulta_Enter);
            // 
            // txtlimite
            // 
            this.txtlimite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlimite.Location = new System.Drawing.Point(603, 78);
            this.txtlimite.Name = "txtlimite";
            this.txtlimite.Size = new System.Drawing.Size(78, 23);
            this.txtlimite.TabIndex = 14;
            this.txtlimite.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(551, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Limite";
            // 
            // btProcurar
            // 
            this.btProcurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btProcurar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurar.Location = new System.Drawing.Point(687, 77);
            this.btProcurar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(177, 26);
            this.btProcurar.TabIndex = 11;
            this.btProcurar.Text = "Procurar";
            this.btProcurar.UseVisualStyleBackColor = true;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Nome",
            "CPF/CNPJ"});
            this.cmbFiltros.Location = new System.Drawing.Point(77, 49);
            this.cmbFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(211, 25);
            this.cmbFiltros.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filtrar por";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(294, 50);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(570, 23);
            this.txtFiltro.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAlterar,
            this.toolStripSeparator1,
            this.toolStripBtnExcluir});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(869, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAlterar
            // 
            this.toolStripBtnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAlterar.Image = global::SysGestao.Properties.Resources.btEditar;
            this.toolStripBtnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAlterar.Name = "toolStripBtnAlterar";
            this.toolStripBtnAlterar.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnAlterar.Text = "Alterar";
            this.toolStripBtnAlterar.Click += new System.EventHandler(this.toolStripBtnAlterar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripBtnExcluir
            // 
            this.toolStripBtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnExcluir.Image = global::SysGestao.Properties.Resources.delete;
            this.toolStripBtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExcluir.Name = "toolStripBtnExcluir";
            this.toolStripBtnExcluir.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnExcluir.Text = "Excluir";
            this.toolStripBtnExcluir.Click += new System.EventHandler(this.toolStripBtnExcluir_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeight = 29;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colNome,
            this.colEndereco,
            this.colCpfCnpj,
            this.colIdEstrangeiro,
            this.colObj});
            this.dgvClientes.Location = new System.Drawing.Point(6, 154);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(863, 213);
            this.dgvClientes.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // colNome
            // 
            this.colNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNome.DataPropertyName = "SKU";
            this.colNome.HeaderText = "Nome";
            this.colNome.MinimumWidth = 6;
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colEndereco
            // 
            this.colEndereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.MinimumWidth = 6;
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            this.colEndereco.Width = 98;
            // 
            // colCpfCnpj
            // 
            this.colCpfCnpj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCpfCnpj.HeaderText = "CPF/CNPJ";
            this.colCpfCnpj.MinimumWidth = 6;
            this.colCpfCnpj.Name = "colCpfCnpj";
            this.colCpfCnpj.ReadOnly = true;
            this.colCpfCnpj.Width = 103;
            // 
            // colIdEstrangeiro
            // 
            this.colIdEstrangeiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colIdEstrangeiro.HeaderText = "IDE (ID Estrang.)";
            this.colIdEstrangeiro.MinimumWidth = 6;
            this.colIdEstrangeiro.Name = "colIdEstrangeiro";
            this.colIdEstrangeiro.ReadOnly = true;
            this.colIdEstrangeiro.Width = 138;
            // 
            // colObj
            // 
            this.colObj.HeaderText = "obj";
            this.colObj.MinimumWidth = 6;
            this.colObj.Name = "colObj";
            this.colObj.ReadOnly = true;
            this.colObj.Visible = false;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.panel2);
            this.tabCadastro.Location = new System.Drawing.Point(4, 26);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(875, 372);
            this.tabCadastro.TabIndex = 1;
            this.tabCadastro.Text = "Cadastrar";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnlControls);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 360);
            this.panel2.TabIndex = 0;
            // 
            // pnlControls
            // 
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.Controls.Add(this.btNovo);
            this.pnlControls.Controls.Add(this.btSalvar);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.txtCPF);
            this.pnlControls.Controls.Add(this.label10);
            this.pnlControls.Controls.Add(this.txtNome);
            this.pnlControls.Controls.Add(this.label8);
            this.pnlControls.Controls.Add(this.txtEndereco);
            this.pnlControls.Controls.Add(this.label7);
            this.pnlControls.Controls.Add(this.txtIdEstrangeiro);
            this.pnlControls.Controls.Add(this.label6);
            this.pnlControls.Location = new System.Drawing.Point(3, 2);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(855, 354);
            this.pnlControls.TabIndex = 2;
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovo.BackgroundImage = global::SysGestao.Properties.Resources.Novo_21;
            this.btNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.ForeColor = System.Drawing.Color.Transparent;
            this.btNovo.Location = new System.Drawing.Point(27, 269);
            this.btNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(80, 63);
            this.btNovo.TabIndex = 21;
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.BackgroundImage = global::SysGestao.Properties.Resources.Salvar;
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.Transparent;
            this.btSalvar.Location = new System.Drawing.Point(395, 269);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(79, 63);
            this.btSalvar.TabIndex = 20;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(293, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dados Cliente / Destinatário";
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCPF.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(124, 124);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(211, 23);
            this.txtCPF.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(26, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "CPF/CNPJ*:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(124, 95);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(681, 23);
            this.txtNome.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(52, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome*:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(124, 153);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(681, 28);
            this.txtEndereco.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Endereço:";
            // 
            // txtIdEstrangeiro
            // 
            this.txtIdEstrangeiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdEstrangeiro.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEstrangeiro.Location = new System.Drawing.Point(494, 124);
            this.txtIdEstrangeiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdEstrangeiro.Name = "txtIdEstrangeiro";
            this.txtIdEstrangeiro.Size = new System.Drawing.Size(311, 23);
            this.txtIdEstrangeiro.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(388, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID Estrangeiro:";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 453);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCliente";
            this.Text = "Informações do cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtlimite)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAlterar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnExcluir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btProcurar;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdEstrangeiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpfCnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdEstrangeiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObj;
        private System.Windows.Forms.NumericUpDown txtlimite;
        private System.Windows.Forms.Label label2;
    }
}
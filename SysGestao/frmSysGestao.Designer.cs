namespace SysGestao
{
    partial class frmSysGestao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysGestao));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importaçãoPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declaraçãoDeConteúdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrdensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préSolicitaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitaçõesFinalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préSolicitaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioGeralToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioPorClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitaçãoFinalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioGeralToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leituraDePlanilhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoDeAlertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manuaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlAlertasEstoque = new System.Windows.Forms.Panel();
            this.chkNaoMostrarNovamente = new System.Windows.Forms.CheckBox();
            this.btVerProdutosAlertaEstoque = new System.Windows.Forms.Button();
            this.lblAlertaEstoque = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btFecharPnlAlerta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlAlertasEstoque.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.clientesToolStripMenuItem,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu,
            this.sairtToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1078, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem1});
            this.fileMenu.ForeColor = System.Drawing.Color.Black;
            this.fileMenu.Image = global::SysGestao.Properties.Resources.imgUsuario2;
            this.fileMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(93, 24);
            this.fileMenu.Text = "Usuário";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Image = global::SysGestao.Properties.Resources.Cadeado1;
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.consultarToolStripMenuItem1.Text = "Alterar senha";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem2});
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.clientesToolStripMenuItem.Image = global::SysGestao.Properties.Resources.imgUsuarios;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // consultarToolStripMenuItem2
            // 
            this.consultarToolStripMenuItem2.Image = global::SysGestao.Properties.Resources.Cadastro1;
            this.consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
            this.consultarToolStripMenuItem2.Size = new System.Drawing.Size(231, 26);
            this.consultarToolStripMenuItem2.Text = "Consultar / Cadastrar";
            this.consultarToolStripMenuItem2.Click += new System.EventHandler(this.consultarToolStripMenuItem2_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPDFToolStripMenuItem,
            this.consultarOrdensToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.viewMenu.ForeColor = System.Drawing.Color.Black;
            this.viewMenu.Image = global::SysGestao.Properties.Resources.imgSolicitacaoProduto;
            this.viewMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(195, 24);
            this.viewMenu.Text = "Solicitação de produto";
            // 
            // buscarPDFToolStripMenuItem
            // 
            this.buscarPDFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaçãoPDFToolStripMenuItem});
            this.buscarPDFToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Cadastro;
            this.buscarPDFToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarPDFToolStripMenuItem.Name = "buscarPDFToolStripMenuItem";
            this.buscarPDFToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.buscarPDFToolStripMenuItem.Text = "Incluir";
            // 
            // importaçãoPDFToolStripMenuItem
            // 
            this.importaçãoPDFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.declaraçãoDeConteúdoToolStripMenuItem,
            this.notaFiscalToolStripMenuItem,
            this.xMLToolStripMenuItem});
            this.importaçãoPDFToolStripMenuItem.Image = global::SysGestao.Properties.Resources.excel_ico1;
            this.importaçãoPDFToolStripMenuItem.Name = "importaçãoPDFToolStripMenuItem";
            this.importaçãoPDFToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.importaçãoPDFToolStripMenuItem.Text = "Importação Xlsx (Excel)";
            // 
            // declaraçãoDeConteúdoToolStripMenuItem
            // 
            this.declaraçãoDeConteúdoToolStripMenuItem.Name = "declaraçãoDeConteúdoToolStripMenuItem";
            this.declaraçãoDeConteúdoToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.declaraçãoDeConteúdoToolStripMenuItem.Text = "Declaração de conteúdo";
            this.declaraçãoDeConteúdoToolStripMenuItem.Click += new System.EventHandler(this.declaraçãoDeConteúdoToolStripMenuItem_Click);
            // 
            // notaFiscalToolStripMenuItem
            // 
            this.notaFiscalToolStripMenuItem.Name = "notaFiscalToolStripMenuItem";
            this.notaFiscalToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.notaFiscalToolStripMenuItem.Text = "DANFE Completa";
            this.notaFiscalToolStripMenuItem.Click += new System.EventHandler(this.notaFiscalToolStripMenuItem_Click);
            // 
            // consultarOrdensToolStripMenuItem
            // 
            this.consultarOrdensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.préSolicitaçõesToolStripMenuItem,
            this.solicitaçõesFinalizadasToolStripMenuItem});
            this.consultarOrdensToolStripMenuItem.Image = global::SysGestao.Properties.Resources.imgRelatorio;
            this.consultarOrdensToolStripMenuItem.Name = "consultarOrdensToolStripMenuItem";
            this.consultarOrdensToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.consultarOrdensToolStripMenuItem.Text = "Painel de solicitações";
            this.consultarOrdensToolStripMenuItem.Click += new System.EventHandler(this.consultarOrdensToolStripMenuItem_Click);
            // 
            // préSolicitaçõesToolStripMenuItem
            // 
            this.préSolicitaçõesToolStripMenuItem.Name = "préSolicitaçõesToolStripMenuItem";
            this.préSolicitaçõesToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.préSolicitaçõesToolStripMenuItem.Text = "Pré solicitações";
            this.préSolicitaçõesToolStripMenuItem.Click += new System.EventHandler(this.préSolicitaçõesToolStripMenuItem_Click);
            // 
            // solicitaçõesFinalizadasToolStripMenuItem
            // 
            this.solicitaçõesFinalizadasToolStripMenuItem.Name = "solicitaçõesFinalizadasToolStripMenuItem";
            this.solicitaçõesFinalizadasToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.solicitaçõesFinalizadasToolStripMenuItem.Text = "Solicitações finalizadas";
            this.solicitaçõesFinalizadasToolStripMenuItem.Click += new System.EventHandler(this.solicitaçõesFinalizadasToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.préSolicitaçãoToolStripMenuItem,
            this.solicitaçãoFinalizadasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Image = global::SysGestao.Properties.Resources.write;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // préSolicitaçãoToolStripMenuItem
            // 
            this.préSolicitaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioGeralToolStripMenuItem1,
            this.relatórioPorClienteToolStripMenuItem1});
            this.préSolicitaçãoToolStripMenuItem.Name = "préSolicitaçãoToolStripMenuItem";
            this.préSolicitaçãoToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.préSolicitaçãoToolStripMenuItem.Text = "Pré-Solicitação";
            // 
            // relatórioGeralToolStripMenuItem1
            // 
            this.relatórioGeralToolStripMenuItem1.Name = "relatórioGeralToolStripMenuItem1";
            this.relatórioGeralToolStripMenuItem1.Size = new System.Drawing.Size(230, 26);
            this.relatórioGeralToolStripMenuItem1.Text = "Relatório Geral";
            this.relatórioGeralToolStripMenuItem1.Click += new System.EventHandler(this.relatórioGeralToolStripMenuItem1_Click);
            // 
            // relatórioPorClienteToolStripMenuItem1
            // 
            this.relatórioPorClienteToolStripMenuItem1.Name = "relatórioPorClienteToolStripMenuItem1";
            this.relatórioPorClienteToolStripMenuItem1.Size = new System.Drawing.Size(230, 26);
            this.relatórioPorClienteToolStripMenuItem1.Text = "Relatório por Cliente";
            this.relatórioPorClienteToolStripMenuItem1.Click += new System.EventHandler(this.relatórioPorClienteToolStripMenuItem1_Click);
            // 
            // solicitaçãoFinalizadasToolStripMenuItem
            // 
            this.solicitaçãoFinalizadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioGeralToolStripMenuItem2,
            this.relatórioPorClienteToolStripMenuItem});
            this.solicitaçãoFinalizadasToolStripMenuItem.Name = "solicitaçãoFinalizadasToolStripMenuItem";
            this.solicitaçãoFinalizadasToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.solicitaçãoFinalizadasToolStripMenuItem.Text = "Solicitação finalizadas";
            // 
            // relatórioGeralToolStripMenuItem2
            // 
            this.relatórioGeralToolStripMenuItem2.Name = "relatórioGeralToolStripMenuItem2";
            this.relatórioGeralToolStripMenuItem2.Size = new System.Drawing.Size(230, 26);
            this.relatórioGeralToolStripMenuItem2.Text = "Relatório Geral";
            this.relatórioGeralToolStripMenuItem2.Click += new System.EventHandler(this.relatórioGeralToolStripMenuItem2_Click);
            // 
            // relatórioPorClienteToolStripMenuItem
            // 
            this.relatórioPorClienteToolStripMenuItem.Name = "relatórioPorClienteToolStripMenuItem";
            this.relatórioPorClienteToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.relatórioPorClienteToolStripMenuItem.Text = "Relatório por Cliente";
            this.relatórioPorClienteToolStripMenuItem.Click += new System.EventHandler(this.relatórioPorClienteToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leituraDePlanilhasToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Image = global::SysGestao.Properties.Resources.process;
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // leituraDePlanilhasToolStripMenuItem
            // 
            this.leituraDePlanilhasToolStripMenuItem.Name = "leituraDePlanilhasToolStripMenuItem";
            this.leituraDePlanilhasToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.leituraDePlanilhasToolStripMenuItem.Text = "Leitura de planilhas";
            this.leituraDePlanilhasToolStripMenuItem.Click += new System.EventHandler(this.leituraDePlanilhasToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.configuraçãoDeAlertasToolStripMenuItem});
            this.toolsMenu.ForeColor = System.Drawing.Color.Black;
            this.toolsMenu.Image = global::SysGestao.Properties.Resources.imgEstoque2;
            this.toolsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(96, 24);
            this.toolsMenu.Text = "Estoque";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incluirToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.produtosToolStripMenuItem.Image = global::SysGestao.Properties.Resources.imgConProduto1;
            this.produtosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.incluirToolStripMenuItem.Text = "Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // configuraçãoDeAlertasToolStripMenuItem
            // 
            this.configuraçãoDeAlertasToolStripMenuItem.Image = global::SysGestao.Properties.Resources.process;
            this.configuraçãoDeAlertasToolStripMenuItem.Name = "configuraçãoDeAlertasToolStripMenuItem";
            this.configuraçãoDeAlertasToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.configuraçãoDeAlertasToolStripMenuItem.Text = "Configuração de alertas";
            this.configuraçãoDeAlertasToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoDeAlertasToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.windowsMenu.ForeColor = System.Drawing.Color.Black;
            this.windowsMenu.Image = global::SysGestao.Properties.Resources.BancoDados;
            this.windowsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(150, 24);
            this.windowsMenu.Text = "Banco de dados";
            this.windowsMenu.Visible = false;
            this.windowsMenu.Click += new System.EventHandler(this.windowsMenu_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::SysGestao.Properties.Resources.ConfigurarBanco;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.toolStripMenuItem1.Text = "Backup/Restauração";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuaisToolStripMenuItem,
            this.contatoToolStripMenuItem});
            this.helpMenu.ForeColor = System.Drawing.Color.Black;
            this.helpMenu.Image = global::SysGestao.Properties.Resources.imgAjuda;
            this.helpMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(82, 24);
            this.helpMenu.Text = "Ajuda";
            // 
            // manuaisToolStripMenuItem
            // 
            this.manuaisToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Manual;
            this.manuaisToolStripMenuItem.Name = "manuaisToolStripMenuItem";
            this.manuaisToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.manuaisToolStripMenuItem.Text = "Manuais";
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Sobre;
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.contatoToolStripMenuItem.Text = "Sobre";
            this.contatoToolStripMenuItem.Click += new System.EventHandler(this.contatoToolStripMenuItem_Click);
            // 
            // sairtToolStripMenuItem
            // 
            this.sairtToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sairtToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Exit_Planning_300x300;
            this.sairtToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairtToolStripMenuItem.Name = "sairtToolStripMenuItem";
            this.sairtToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sairtToolStripMenuItem.Text = "Sair";
            this.sairtToolStripMenuItem.Click += new System.EventHandler(this.sairtToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Black;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.lbUsuarioLogado});
            this.statusStrip.Location = new System.Drawing.Point(0, 707);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1078, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 20);
            this.toolStripStatusLabel.Text = "Usuário logado: ";
            // 
            // lbUsuarioLogado
            // 
            this.lbUsuarioLogado.ForeColor = System.Drawing.Color.White;
            this.lbUsuarioLogado.Name = "lbUsuarioLogado";
            this.lbUsuarioLogado.Size = new System.Drawing.Size(36, 20);
            this.lbUsuarioLogado.Text = "user";
            // 
            // pnlAlertasEstoque
            // 
            this.pnlAlertasEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAlertasEstoque.BackColor = System.Drawing.Color.Khaki;
            this.pnlAlertasEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlertasEstoque.Controls.Add(this.chkNaoMostrarNovamente);
            this.pnlAlertasEstoque.Controls.Add(this.btVerProdutosAlertaEstoque);
            this.pnlAlertasEstoque.Controls.Add(this.lblAlertaEstoque);
            this.pnlAlertasEstoque.Controls.Add(this.label3);
            this.pnlAlertasEstoque.Controls.Add(this.btFecharPnlAlerta);
            this.pnlAlertasEstoque.Location = new System.Drawing.Point(671, 508);
            this.pnlAlertasEstoque.Name = "pnlAlertasEstoque";
            this.pnlAlertasEstoque.Size = new System.Drawing.Size(403, 196);
            this.pnlAlertasEstoque.TabIndex = 4;
            this.pnlAlertasEstoque.Visible = false;
            // 
            // chkNaoMostrarNovamente
            // 
            this.chkNaoMostrarNovamente.AutoSize = true;
            this.chkNaoMostrarNovamente.Location = new System.Drawing.Point(7, 159);
            this.chkNaoMostrarNovamente.Name = "chkNaoMostrarNovamente";
            this.chkNaoMostrarNovamente.Size = new System.Drawing.Size(173, 20);
            this.chkNaoMostrarNovamente.TabIndex = 12;
            this.chkNaoMostrarNovamente.Text = "Não mostrar novamente";
            this.chkNaoMostrarNovamente.UseVisualStyleBackColor = true;
            // 
            // btVerProdutosAlertaEstoque
            // 
            this.btVerProdutosAlertaEstoque.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btVerProdutosAlertaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVerProdutosAlertaEstoque.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerProdutosAlertaEstoque.Location = new System.Drawing.Point(217, 153);
            this.btVerProdutosAlertaEstoque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVerProdutosAlertaEstoque.Name = "btVerProdutosAlertaEstoque";
            this.btVerProdutosAlertaEstoque.Size = new System.Drawing.Size(177, 30);
            this.btVerProdutosAlertaEstoque.TabIndex = 11;
            this.btVerProdutosAlertaEstoque.Text = "Ver produtos";
            this.btVerProdutosAlertaEstoque.UseVisualStyleBackColor = true;
            this.btVerProdutosAlertaEstoque.Click += new System.EventHandler(this.btVerProdutosAlertaEstoque_Click);
            // 
            // lblAlertaEstoque
            // 
            this.lblAlertaEstoque.AutoSize = true;
            this.lblAlertaEstoque.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaEstoque.ForeColor = System.Drawing.Color.Black;
            this.lblAlertaEstoque.Location = new System.Drawing.Point(3, 57);
            this.lblAlertaEstoque.Name = "lblAlertaEstoque";
            this.lblAlertaEstoque.Size = new System.Drawing.Size(326, 34);
            this.lblAlertaEstoque.TabIndex = 10;
            this.lblAlertaEstoque.Text = "Alguns produtos chegaram ao estoque minímo ! \r\nPor favor, verifique seu estoque e" +
    " atualize-o.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Alerta de estoque!";
            // 
            // btFecharPnlAlerta
            // 
            this.btFecharPnlAlerta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFecharPnlAlerta.BackColor = System.Drawing.Color.DarkRed;
            this.btFecharPnlAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btFecharPnlAlerta.Location = new System.Drawing.Point(323, 3);
            this.btFecharPnlAlerta.Name = "btFecharPnlAlerta";
            this.btFecharPnlAlerta.Size = new System.Drawing.Size(75, 23);
            this.btFecharPnlAlerta.TabIndex = 0;
            this.btFecharPnlAlerta.Text = "X";
            this.btFecharPnlAlerta.UseVisualStyleBackColor = false;
            this.btFecharPnlAlerta.Click += new System.EventHandler(this.btFecharPnlAlerta_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Teal;
            this.btnSair.BackgroundImage = global::SysGestao.Properties.Resources.imgSair101;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Teal;
            this.btnSair.Location = new System.Drawing.Point(952, 32);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 78);
            this.btnSair.TabIndex = 10;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(571, 32);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(363, 78);
            this.txtDate.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::SysGestao.Properties.Resources.fundo1;
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnConfiguracoes);
            this.panel1.Controls.Add(this.btnProdutos);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 660);
            this.panel1.TabIndex = 13;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::SysGestao.Properties.Resources.imgCadCliente;
            this.btnClientes.Location = new System.Drawing.Point(4, 206);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(168, 112);
            this.btnClientes.TabIndex = 9;
            this.btnClientes.Text = "Clientes (F9)";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracoes.Image = global::SysGestao.Properties.Resources.process1;
            this.btnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfiguracoes.Location = new System.Drawing.Point(4, 326);
            this.btnConfiguracoes.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(168, 112);
            this.btnConfiguracoes.TabIndex = 8;
            this.btnConfiguracoes.Text = "Configurações (F10)";
            this.btnConfiguracoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfiguracoes.UseVisualStyleBackColor = false;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Image = global::SysGestao.Properties.Resources.imgConProduto1;
            this.btnProdutos.Location = new System.Drawing.Point(4, 91);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(168, 107);
            this.btnProdutos.TabIndex = 6;
            this.btnProdutos.Text = "Produtos(F6)";
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // frmSysGestao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::SysGestao.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pnlAlertasEstoque);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmSysGestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysGestao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSysGestao_FormClosing);
            this.Load += new System.EventHandler(this.frmSysGestao_Load);
            this.Shown += new System.EventHandler(this.frmSysGestao_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlAlertasEstoque.ResumeLayout(false);
            this.pnlAlertasEstoque.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem buscarPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarOrdensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manuaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairtToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lbUsuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem importaçãoPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem préSolicitaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitaçõesFinalizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoDeAlertasToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAlertasEstoque;
        private System.Windows.Forms.Button btFecharPnlAlerta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlertaEstoque;
        private System.Windows.Forms.Button btVerProdutosAlertaEstoque;
        private System.Windows.Forms.CheckBox chkNaoMostrarNovamente;
        private System.Windows.Forms.ToolStripMenuItem préSolicitaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioGeralToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatórioPorClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem solicitaçãoFinalizadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioGeralToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leituraDePlanilhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declaraçãoDeConteúdoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
    }
}




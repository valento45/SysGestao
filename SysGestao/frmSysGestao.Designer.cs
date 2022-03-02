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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importaçãoPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrdensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préSolicitaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitaçõesFinalizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btVerProdutosAlertaEstoque = new System.Windows.Forms.Button();
            this.lblAlertaEstoque = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btFecharPnlAlerta = new System.Windows.Forms.Button();
            this.chkNaoMostrarNovamente = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlAlertasEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
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
            this.fileMenu.Image = global::SysGestao.Properties.Resources.Login;
            this.fileMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(93, 24);
            this.fileMenu.Text = "Usuário";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(179, 26);
            this.consultarToolStripMenuItem1.Text = "Alterar senha";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPDFToolStripMenuItem,
            this.consultarOrdensToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.viewMenu.Image = global::SysGestao.Properties.Resources.imgEstoque;
            this.viewMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(195, 24);
            this.viewMenu.Text = "Solicitação de produto";
            // 
            // buscarPDFToolStripMenuItem
            // 
            this.buscarPDFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaçãoPDFToolStripMenuItem});
            this.buscarPDFToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Cadastro1;
            this.buscarPDFToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarPDFToolStripMenuItem.Name = "buscarPDFToolStripMenuItem";
            this.buscarPDFToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.buscarPDFToolStripMenuItem.Text = "Incluir";
            // 
            // importaçãoPDFToolStripMenuItem
            // 
            this.importaçãoPDFToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Manual;
            this.importaçãoPDFToolStripMenuItem.Name = "importaçãoPDFToolStripMenuItem";
            this.importaçãoPDFToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.importaçãoPDFToolStripMenuItem.Text = "Importação Xlsx (Excel)";
            this.importaçãoPDFToolStripMenuItem.Click += new System.EventHandler(this.importaçãoPDFToolStripMenuItem_Click);
            // 
            // consultarOrdensToolStripMenuItem
            // 
            this.consultarOrdensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.préSolicitaçõesToolStripMenuItem,
            this.solicitaçõesFinalizadasToolStripMenuItem});
            this.consultarOrdensToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Consulta;
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
            this.relatóriosToolStripMenuItem.Image = global::SysGestao.Properties.Resources.imgRelatorio;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.configuraçãoDeAlertasToolStripMenuItem});
            this.toolsMenu.Image = global::SysGestao.Properties.Resources.Estoque;
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
            this.produtosToolStripMenuItem.Image = global::SysGestao.Properties.Resources.imgCadProduto;
            this.produtosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Cadastro;
            this.incluirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.incluirToolStripMenuItem.Text = "Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Consulta;
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
            this.windowsMenu.Image = global::SysGestao.Properties.Resources.process;
            this.windowsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(138, 24);
            this.windowsMenu.Text = "Configurações";
            this.windowsMenu.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::SysGestao.Properties.Resources.ConfigurarBanco;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.toolStripMenuItem1.Text = "Backup/Restauração";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuaisToolStripMenuItem,
            this.contatoToolStripMenuItem});
            this.helpMenu.Image = global::SysGestao.Properties.Resources.help;
            this.helpMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(82, 24);
            this.helpMenu.Text = "Ajuda";
            // 
            // manuaisToolStripMenuItem
            // 
            this.manuaisToolStripMenuItem.Image = global::SysGestao.Properties.Resources.imgTelaVenda;
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
            // 
            // sairtToolStripMenuItem
            // 
            this.sairtToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Exit_Planning_300x300;
            this.sairtToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairtToolStripMenuItem.Name = "sairtToolStripMenuItem";
            this.sairtToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.sairtToolStripMenuItem.Text = "Sair";
            this.sairtToolStripMenuItem.Click += new System.EventHandler(this.sairtToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
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
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 20);
            this.toolStripStatusLabel.Text = "Usuário logado: ";
            // 
            // lbUsuarioLogado
            // 
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
            this.lblAlertaEstoque.Size = new System.Drawing.Size(344, 38);
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
            // chkNaoMostrarNovamente
            // 
            this.chkNaoMostrarNovamente.AutoSize = true;
            this.chkNaoMostrarNovamente.Location = new System.Drawing.Point(7, 159);
            this.chkNaoMostrarNovamente.Name = "chkNaoMostrarNovamente";
            this.chkNaoMostrarNovamente.Size = new System.Drawing.Size(182, 21);
            this.chkNaoMostrarNovamente.TabIndex = 12;
            this.chkNaoMostrarNovamente.Text = "Não mostrar novamente";
            this.chkNaoMostrarNovamente.UseVisualStyleBackColor = true;
            // 
            // frmSysGestao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::SysGestao.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 733);
            this.Controls.Add(this.pnlAlertasEstoque);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "frmSysGestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SysGestao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSysGestao_Load);
            this.Shown += new System.EventHandler(this.frmSysGestao_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlAlertasEstoque.ResumeLayout(false);
            this.pnlAlertasEstoque.PerformLayout();
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
    }
}




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
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiquetasCódigoDeBarraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.buscarPDFToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.buscarPDFToolStripMenuItem.Text = "Incluir";
            // 
            // importaçãoPDFToolStripMenuItem
            // 
            this.importaçãoPDFToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Exportar;
            this.importaçãoPDFToolStripMenuItem.Name = "importaçãoPDFToolStripMenuItem";
            this.importaçãoPDFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importaçãoPDFToolStripMenuItem.Text = "Importação PDF";
            this.importaçãoPDFToolStripMenuItem.Click += new System.EventHandler(this.importaçãoPDFToolStripMenuItem_Click);
            // 
            // consultarOrdensToolStripMenuItem
            // 
            this.consultarOrdensToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Consulta;
            this.consultarOrdensToolStripMenuItem.Name = "consultarOrdensToolStripMenuItem";
            this.consultarOrdensToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.consultarOrdensToolStripMenuItem.Text = "Consultar solicitações";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Image = global::SysGestao.Properties.Resources.imgRelatorio;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.imprimirToolStripMenuItem});
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
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetasCódigoDeBarraToolStripMenuItem});
            this.imprimirToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Exportar;
            this.imprimirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir PDF";
            // 
            // etiquetasCódigoDeBarraToolStripMenuItem
            // 
            this.etiquetasCódigoDeBarraToolStripMenuItem.Name = "etiquetasCódigoDeBarraToolStripMenuItem";
            this.etiquetasCódigoDeBarraToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.etiquetasCódigoDeBarraToolStripMenuItem.Text = "Etiquetas (Código de barra)";
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
            // frmSysGestao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::SysGestao.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 733);
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
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etiquetasCódigoDeBarraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manuaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairtToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lbUsuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem importaçãoPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
    }
}




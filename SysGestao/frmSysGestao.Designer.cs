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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1084, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.lbUsuarioLogado});
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel.Text = "Usuário logado: ";
            // 
            // lbUsuarioLogado
            // 
            this.lbUsuarioLogado.Name = "lbUsuarioLogado";
            this.lbUsuarioLogado.Size = new System.Drawing.Size(29, 17);
            this.lbUsuarioLogado.Text = "user";
            // 
            // fileMenu
            // 
            this.fileMenu.Image = global::SysGestao.Properties.Resources.Login;
            this.fileMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(79, 24);
            this.fileMenu.Text = "Usuário";
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
            this.viewMenu.Size = new System.Drawing.Size(158, 24);
            this.viewMenu.Text = "Solicitação de produto";
            // 
            // buscarPDFToolStripMenuItem
            // 
            this.buscarPDFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaçãoPDFToolStripMenuItem});
            this.buscarPDFToolStripMenuItem.Name = "buscarPDFToolStripMenuItem";
            this.buscarPDFToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.buscarPDFToolStripMenuItem.Text = "Incluir";
            // 
            // importaçãoPDFToolStripMenuItem
            // 
            this.importaçãoPDFToolStripMenuItem.Name = "importaçãoPDFToolStripMenuItem";
            this.importaçãoPDFToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.importaçãoPDFToolStripMenuItem.Text = "Importação PDF";
            // 
            // consultarOrdensToolStripMenuItem
            // 
            this.consultarOrdensToolStripMenuItem.Name = "consultarOrdensToolStripMenuItem";
            this.consultarOrdensToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultarOrdensToolStripMenuItem.Text = "Consultar solicitações";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
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
            this.toolsMenu.Size = new System.Drawing.Size(81, 24);
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
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Cadastro;
            this.incluirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.incluirToolStripMenuItem.Text = "Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Consulta;
            this.consultarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetasCódigoDeBarraToolStripMenuItem});
            this.imprimirToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Exportar;
            this.imprimirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir PDF";
            // 
            // etiquetasCódigoDeBarraToolStripMenuItem
            // 
            this.etiquetasCódigoDeBarraToolStripMenuItem.Name = "etiquetasCódigoDeBarraToolStripMenuItem";
            this.etiquetasCódigoDeBarraToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.etiquetasCódigoDeBarraToolStripMenuItem.Text = "Etiquetas (Código de barra)";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.windowsMenu.Image = global::SysGestao.Properties.Resources.process;
            this.windowsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(116, 24);
            this.windowsMenu.Text = "Configurações";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
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
            this.helpMenu.Size = new System.Drawing.Size(70, 24);
            this.helpMenu.Text = "Ajuda";
            // 
            // manuaisToolStripMenuItem
            // 
            this.manuaisToolStripMenuItem.Image = global::SysGestao.Properties.Resources.imgTelaVenda;
            this.manuaisToolStripMenuItem.Name = "manuaisToolStripMenuItem";
            this.manuaisToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.manuaisToolStripMenuItem.Text = "Manuais";
            // 
            // contatoToolStripMenuItem
            // 
            this.contatoToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Sobre;
            this.contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            this.contatoToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.contatoToolStripMenuItem.Text = "Sobre";
            // 
            // sairtToolStripMenuItem
            // 
            this.sairtToolStripMenuItem.Image = global::SysGestao.Properties.Resources.Exit_Planning_300x300;
            this.sairtToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairtToolStripMenuItem.Name = "sairtToolStripMenuItem";
            this.sairtToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.sairtToolStripMenuItem.Text = "Sair";
            // 
            // frmSysGestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1084, 457);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
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
    }
}




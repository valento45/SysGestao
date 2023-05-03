namespace SysGestao.Configuracoes.Marketplaces
{
    partial class frmConfiguraMarketplaces
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
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.txtMarketplace = new System.Windows.Forms.TextBox();
            this.cmbMarketplaces = new System.Windows.Forms.ComboBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFundo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.Color.White;
            this.pnlFundo.Controls.Add(this.groupBox1);
            this.pnlFundo.Controls.Add(this.btSalvar);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(584, 164);
            this.pnlFundo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Controls.Add(this.btAdicionar);
            this.groupBox1.Controls.Add(this.txtMarketplace);
            this.groupBox1.Controls.Add(this.cmbMarketplaces);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 110);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marketplaces";
            // 
            // btLimpar
            // 
            this.btLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimpar.BackColor = System.Drawing.Color.GhostWhite;
            this.btLimpar.BackgroundImage = global::SysGestao.Properties.Resources.BTLimpar;
            this.btLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimpar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btLimpar.Location = new System.Drawing.Point(410, 32);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(32, 23);
            this.btLimpar.TabIndex = 50;
            this.toolTip1.SetToolTip(this.btLimpar, "Remover item selecionado");
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdicionar.BackColor = System.Drawing.Color.GhostWhite;
            this.btAdicionar.BackgroundImage = global::SysGestao.Properties.Resources.Novo_2;
            this.btAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.GhostWhite;
            this.btAdicionar.Location = new System.Drawing.Point(373, 32);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(31, 23);
            this.btAdicionar.TabIndex = 49;
            this.toolTip1.SetToolTip(this.btAdicionar, "Adicionar Marketplace");
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // txtMarketplace
            // 
            this.txtMarketplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarketplace.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarketplace.Location = new System.Drawing.Point(131, 32);
            this.txtMarketplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarketplace.Name = "txtMarketplace";
            this.txtMarketplace.Size = new System.Drawing.Size(236, 23);
            this.txtMarketplace.TabIndex = 48;
            // 
            // cmbMarketplaces
            // 
            this.cmbMarketplaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMarketplaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarketplaces.FormattingEnabled = true;
            this.cmbMarketplaces.Items.AddRange(new object[] {
            "Nome",
            "CPF/CNPJ"});
            this.cmbMarketplaces.Location = new System.Drawing.Point(131, 59);
            this.cmbMarketplaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMarketplaces.Name = "cmbMarketplaces";
            this.cmbMarketplaces.Size = new System.Drawing.Size(311, 24);
            this.cmbMarketplaces.TabIndex = 10;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSalvar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(214, 132);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(177, 26);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // frmConfiguraMarketplaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 188);
            this.Controls.Add(this.pnlFundo);
            this.MaximizeBox = false;
            this.Name = "frmConfiguraMarketplaces";
            this.Text = "Configurar Marketplaces";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConfiguraMarketplaces_FormClosing);
            this.Load += new System.EventHandler(this.frmConfiguraMarketplaces_Load);
            this.pnlFundo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMarketplaces;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.TextBox txtMarketplace;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
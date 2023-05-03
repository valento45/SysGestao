namespace SysGestao.Importacao
{
    partial class frmSelecionaMarketplace
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMarketplaces = new System.Windows.Forms.ComboBox();
            this.btAcao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbMarketplaces);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 80);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Selecione o Marketplace:";
            // 
            // cmbMarketplaces
            // 
            this.cmbMarketplaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMarketplaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarketplaces.FormattingEnabled = true;
            this.cmbMarketplaces.Items.AddRange(new object[] {
            "Nome",
            "CPF/CNPJ"});
            this.cmbMarketplaces.Location = new System.Drawing.Point(219, 27);
            this.cmbMarketplaces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMarketplaces.Name = "cmbMarketplaces";
            this.cmbMarketplaces.Size = new System.Drawing.Size(311, 24);
            this.cmbMarketplaces.TabIndex = 11;
            // 
            // btAcao
            // 
            this.btAcao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAcao.BackColor = System.Drawing.Color.GhostWhite;
            this.btAcao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAcao.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcao.Location = new System.Drawing.Point(195, 97);
            this.btAcao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAcao.Name = "btAcao";
            this.btAcao.Size = new System.Drawing.Size(177, 30);
            this.btAcao.TabIndex = 5;
            this.btAcao.Text = "OK";
            this.btAcao.UseVisualStyleBackColor = false;
            this.btAcao.Click += new System.EventHandler(this.btAcao_Click);
            // 
            // frmSelecionaMarketplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 135);
            this.Controls.Add(this.btAcao);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmSelecionaMarketplace";
            this.Text = "Selecione o marketplace do qual está sendo importado";
            this.Load += new System.EventHandler(this.frmSelecionaMarketplace_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAcao;
        private System.Windows.Forms.ComboBox cmbMarketplaces;
        private System.Windows.Forms.Label label2;
    }
}
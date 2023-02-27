namespace SysGestao.Authorization
{
    partial class frmLicense
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
            this.btnComprarLicensa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btAtivar = new System.Windows.Forms.Button();
            this.cmbTipoLicensa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoLicensa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlFundo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo.Controls.Add(this.btnComprarLicensa);
            this.pnlFundo.Controls.Add(this.label3);
            this.pnlFundo.Controls.Add(this.btAtivar);
            this.pnlFundo.Controls.Add(this.cmbTipoLicensa);
            this.pnlFundo.Controls.Add(this.label2);
            this.pnlFundo.Controls.Add(this.txtCodigoLicensa);
            this.pnlFundo.Controls.Add(this.label1);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(997, 231);
            this.pnlFundo.TabIndex = 1;
            // 
            // btnComprarLicensa
            // 
            this.btnComprarLicensa.BackgroundImage = global::SysGestao.Properties.Resources.imgCadProduto;
            this.btnComprarLicensa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnComprarLicensa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprarLicensa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprarLicensa.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnComprarLicensa.ForeColor = System.Drawing.Color.Teal;
            this.btnComprarLicensa.Location = new System.Drawing.Point(681, 169);
            this.btnComprarLicensa.Name = "btnComprarLicensa";
            this.btnComprarLicensa.Size = new System.Drawing.Size(282, 39);
            this.btnComprarLicensa.TabIndex = 17;
            this.btnComprarLicensa.UseVisualStyleBackColor = true;
            this.btnComprarLicensa.Click += new System.EventHandler(this.btnComprarLicensa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(677, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "Não possui licença? \r\nClique e contate-nos para obter uma!\r\n";
            // 
            // btAtivar
            // 
            this.btAtivar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btAtivar.Location = new System.Drawing.Point(410, 169);
            this.btAtivar.Name = "btAtivar";
            this.btAtivar.Size = new System.Drawing.Size(174, 39);
            this.btAtivar.TabIndex = 15;
            this.btAtivar.Text = "Ativar";
            this.btAtivar.UseVisualStyleBackColor = true;
            this.btAtivar.Click += new System.EventHandler(this.btAtivar_Click);
            // 
            // cmbTipoLicensa
            // 
            this.cmbTipoLicensa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoLicensa.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cmbTipoLicensa.FormattingEnabled = true;
            this.cmbTipoLicensa.Location = new System.Drawing.Point(224, 91);
            this.cmbTipoLicensa.Name = "cmbTipoLicensa";
            this.cmbTipoLicensa.Size = new System.Drawing.Size(239, 28);
            this.cmbTipoLicensa.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo licença:";
            // 
            // txtCodigoLicensa
            // 
            this.txtCodigoLicensa.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtCodigoLicensa.Location = new System.Drawing.Point(224, 40);
            this.txtCodigoLicensa.Name = "txtCodigoLicensa";
            this.txtCodigoLicensa.Size = new System.Drawing.Size(673, 26);
            this.txtCodigoLicensa.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código de ativação:";
            // 
            // frmLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1021, 260);
            this.Controls.Add(this.pnlFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Licença";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLicense_FormClosing);
            this.Load += new System.EventHandler(this.frmLicense_Load);
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Button btnComprarLicensa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAtivar;
        private System.Windows.Forms.ComboBox cmbTipoLicensa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoLicensa;
        private System.Windows.Forms.Label label1;
    }
}
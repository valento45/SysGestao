namespace SysGestao.ControlsAux
{
    partial class MarketplaceConfiguracaoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMarketplace = new System.Windows.Forms.Label();
            this.txtCodigoSKU = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMarketplace
            // 
            this.lblMarketplace.AutoSize = true;
            this.lblMarketplace.Location = new System.Drawing.Point(7, 10);
            this.lblMarketplace.Name = "lblMarketplace";
            this.lblMarketplace.Size = new System.Drawing.Size(93, 16);
            this.lblMarketplace.TabIndex = 0;
            this.lblMarketplace.Text = "Mercado Livre";
            // 
            // txtCodigoSKU
            // 
            this.txtCodigoSKU.Location = new System.Drawing.Point(164, 7);
            this.txtCodigoSKU.Name = "txtCodigoSKU";
            this.txtCodigoSKU.Size = new System.Drawing.Size(204, 22);
            this.txtCodigoSKU.TabIndex = 1;
            // 
            // MarketplaceConfiguracaoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCodigoSKU);
            this.Controls.Add(this.lblMarketplace);
            this.Name = "MarketplaceConfiguracaoControl";
            this.Size = new System.Drawing.Size(492, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarketplace;
        private System.Windows.Forms.TextBox txtCodigoSKU;
    }
}

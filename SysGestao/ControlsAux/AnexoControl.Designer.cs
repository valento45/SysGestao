namespace SysGestao.ControlsAux
{
    partial class AnexoControl
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
            this.components = new System.ComponentModel.Container();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.lblMarketplace = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtCaminho
            // 
            this.txtCaminho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminho.Location = new System.Drawing.Point(73, 14);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.ReadOnly = true;
            this.txtCaminho.Size = new System.Drawing.Size(386, 22);
            this.txtCaminho.TabIndex = 3;
            // 
            // lblMarketplace
            // 
            this.lblMarketplace.AutoSize = true;
            this.lblMarketplace.Location = new System.Drawing.Point(4, 17);
            this.lblMarketplace.Name = "lblMarketplace";
            this.lblMarketplace.Size = new System.Drawing.Size(63, 16);
            this.lblMarketplace.TabIndex = 2;
            this.lblMarketplace.Text = "Caminho:";
            // 
            // btRemover
            // 
            this.btRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRemover.BackColor = System.Drawing.Color.GhostWhite;
            this.btRemover.BackgroundImage = global::SysGestao.Properties.Resources.excluir;
            this.btRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemover.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.ForeColor = System.Drawing.Color.GhostWhite;
            this.btRemover.Location = new System.Drawing.Point(465, 8);
            this.btRemover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(54, 30);
            this.btRemover.TabIndex = 51;
            this.toolTip1.SetToolTip(this.btRemover, "Remover anexo");
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // AnexoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.lblMarketplace);
            this.Name = "AnexoControl";
            this.Size = new System.Drawing.Size(545, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label lblMarketplace;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

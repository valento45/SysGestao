
namespace SysGestao.Relatorios
{
    partial class frmInformaPeriodo
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
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.btNovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtAte);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDe);
            this.panel1.Controls.Add(this.lblDe);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 115);
            this.panel1.TabIndex = 0;
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(291, 42);
            this.txtAte.Mask = "00/00/0000";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(100, 22);
            this.txtAte.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Até";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(150, 42);
            this.txtDe.Mask = "00/00/0000";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 22);
            this.txtDe.TabIndex = 1;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(114, 45);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(28, 16);
            this.lblDe.TabIndex = 0;
            this.lblDe.Text = "De:";
            // 
            // btNovo
            // 
            this.btNovo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btNovo.BackColor = System.Drawing.Color.GhostWhite;
            this.btNovo.Enabled = false;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btNovo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(189, 132);
            this.btNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(177, 30);
            this.btNovo.TabIndex = 8;
            this.btNovo.Text = "Gerar relatório";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // frmInformaPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 173);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInformaPeriodo";
            this.Text = "Informe o período";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDe;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.Button btNovo;
    }
}

namespace SysGestao.Relatorios
{
    partial class frmRelatorioGeralPreSoli
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
            this.grpPArametro = new System.Windows.Forms.GroupBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.pnlPeriodo = new System.Windows.Forms.Panel();
            this.txtAte = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.MaskedTextBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSair1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpPArametro.SuspendLayout();
            this.pnlPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grpPArametro);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 449);
            this.panel1.TabIndex = 2;
            // 
            // grpPArametro
            // 
            this.grpPArametro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPArametro.Controls.Add(this.btNovo);
            this.grpPArametro.Controls.Add(this.pnlPeriodo);
            this.grpPArametro.Location = new System.Drawing.Point(3, 3);
            this.grpPArametro.Name = "grpPArametro";
            this.grpPArametro.Size = new System.Drawing.Size(1157, 116);
            this.grpPArametro.TabIndex = 1;
            this.grpPArametro.TabStop = false;
            this.grpPArametro.Text = "Parâmetros";
            // 
            // btNovo
            // 
            this.btNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNovo.BackColor = System.Drawing.Color.GhostWhite;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btNovo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(974, 45);
            this.btNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(177, 30);
            this.btNovo.TabIndex = 9;
            this.btNovo.Text = "Gerar relatório";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // pnlPeriodo
            // 
            this.pnlPeriodo.BackColor = System.Drawing.Color.Snow;
            this.pnlPeriodo.Controls.Add(this.txtAte);
            this.pnlPeriodo.Controls.Add(this.label2);
            this.pnlPeriodo.Controls.Add(this.txtDe);
            this.pnlPeriodo.Controls.Add(this.lblDe);
            this.pnlPeriodo.Location = new System.Drawing.Point(6, 36);
            this.pnlPeriodo.Name = "pnlPeriodo";
            this.pnlPeriodo.Size = new System.Drawing.Size(308, 48);
            this.pnlPeriodo.TabIndex = 1;
            // 
            // txtAte
            // 
            this.txtAte.Location = new System.Drawing.Point(188, 13);
            this.txtAte.Mask = "00/00/0000";
            this.txtAte.Name = "txtAte";
            this.txtAte.Size = new System.Drawing.Size(100, 22);
            this.txtAte.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Até";
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(47, 13);
            this.txtDe.Mask = "00/00/0000";
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(100, 22);
            this.txtDe.TabIndex = 1;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(11, 16);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(28, 16);
            this.lblDe.TabIndex = 0;
            this.lblDe.Text = "De:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SysGestao.Relatorios.RelatorioGeralPorItem.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 125);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1161, 319);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnSair1
            // 
            this.btnSair1.BackgroundImage = global::SysGestao.Properties.Resources.excluir;
            this.btnSair1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair1.ForeColor = System.Drawing.Color.Teal;
            this.btnSair1.Location = new System.Drawing.Point(1123, 4);
            this.btnSair1.Name = "btnSair1";
            this.btnSair1.Size = new System.Drawing.Size(50, 24);
            this.btnSair1.TabIndex = 9;
            this.btnSair1.UseVisualStyleBackColor = true;
            this.btnSair1.Click += new System.EventHandler(this.btnSair1_Click);
            // 
            // frmRelatorioGeralPreSoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 495);
            this.Controls.Add(this.btnSair1);
            this.Controls.Add(this.panel1);
            this.Name = "frmRelatorioGeralPreSoli";
            this.Text = "Relatório Geral de Pré-Solicitação";
            this.panel1.ResumeLayout(false);
            this.grpPArametro.ResumeLayout(false);
            this.pnlPeriodo.ResumeLayout(false);
            this.pnlPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpPArametro;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Panel pnlPeriodo;
        private System.Windows.Forms.MaskedTextBox txtAte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDe;
        private System.Windows.Forms.Label lblDe;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnSair1;
    }
}
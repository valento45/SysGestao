
namespace SysGestao.Produtos
{
    partial class frmSolicitacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitacoes));
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.lblQtd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.colDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBtnSepararProdutos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colBtnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo.Controls.Add(this.lblQtd);
            this.pnlFundo.Controls.Add(this.label1);
            this.pnlFundo.Controls.Add(this.lbNome);
            this.pnlFundo.Controls.Add(this.dgvProdutos);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1038, 407);
            this.pnlFundo.TabIndex = 0;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQtd.Location = new System.Drawing.Point(189, 82);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(17, 19);
            this.lblQtd.TabIndex = 19;
            this.lblQtd.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Quantidade de registros:";
            // 
            // lbNome
            // 
            this.lbNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Black;
            this.lbNome.Location = new System.Drawing.Point(282, 13);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(507, 34);
            this.lbNome.TabIndex = 17;
            this.lbNome.Text = "Solicitações de produtos pendentes";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDestinatario,
            this.colBtnSepararProdutos,
            this.colBtnExcluir,
            this.colObj});
            this.dgvProdutos.Location = new System.Drawing.Point(3, 104);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1030, 298);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            // 
            // colDestinatario
            // 
            this.colDestinatario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDestinatario.HeaderText = "Destinatários";
            this.colDestinatario.MinimumWidth = 6;
            this.colDestinatario.Name = "colDestinatario";
            this.colDestinatario.ReadOnly = true;
            // 
            // colBtnSepararProdutos
            // 
            this.colBtnSepararProdutos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colBtnSepararProdutos.HeaderText = "Separar produtos";
            this.colBtnSepararProdutos.MinimumWidth = 6;
            this.colBtnSepararProdutos.Name = "colBtnSepararProdutos";
            this.colBtnSepararProdutos.ReadOnly = true;
            this.colBtnSepararProdutos.Width = 113;
            // 
            // colBtnExcluir
            // 
            this.colBtnExcluir.HeaderText = "Excluir";
            this.colBtnExcluir.MinimumWidth = 6;
            this.colBtnExcluir.Name = "colBtnExcluir";
            this.colBtnExcluir.ReadOnly = true;
            this.colBtnExcluir.Width = 125;
            // 
            // colObj
            // 
            this.colObj.HeaderText = "obj";
            this.colObj.MinimumWidth = 6;
            this.colObj.Name = "colObj";
            this.colObj.Visible = false;
            this.colObj.Width = 125;
            // 
            // frmSolicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 431);
            this.Controls.Add(this.pnlFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSolicitacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitações";
            this.Load += new System.EventHandler(this.frmSolicitacoes_Load);
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestinatario;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnSepararProdutos;
        private System.Windows.Forms.DataGridViewButtonColumn colBtnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObj;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label label1;
    }
}
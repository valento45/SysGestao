
namespace SysGestao.Produtos
{
    partial class frmConsultarSolicitacoesFinalizadas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarSolicitacoesFinalizadas));
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btVerItens = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlFiltrarPorData = new System.Windows.Forms.Panel();
            this.txtDataSolicitacao = new System.Windows.Forms.MaskedTextBox();
            this.pnlFiltroDestinatario = new System.Windows.Forms.Panel();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvSolicitacao = new System.Windows.Forms.DataGridView();
            this.colDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlFiltrarPorData.SuspendLayout();
            this.pnlFiltroDestinatario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundo.Controls.Add(this.pictureBox1);
            this.pnlFundo.Controls.Add(this.btExcluir);
            this.pnlFundo.Controls.Add(this.btVerItens);
            this.pnlFundo.Controls.Add(this.groupBox1);
            this.pnlFundo.Controls.Add(this.dgvSolicitacao);
            this.pnlFundo.Location = new System.Drawing.Point(12, 12);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(1281, 511);
            this.pnlFundo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::SysGestao.Properties.Resources.Lixeira;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1053, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 40);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(1048, 247);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(228, 51);
            this.btExcluir.TabIndex = 8;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btVerItens
            // 
            this.btVerItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btVerItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVerItens.Image = global::SysGestao.Properties.Resources.imgConProduto1;
            this.btVerItens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVerItens.Location = new System.Drawing.Point(1048, 190);
            this.btVerItens.Name = "btVerItens";
            this.btVerItens.Size = new System.Drawing.Size(228, 51);
            this.btVerItens.TabIndex = 7;
            this.btVerItens.Text = "Ver itens";
            this.btVerItens.UseVisualStyleBackColor = true;
            this.btVerItens.Click += new System.EventHandler(this.btVerItens_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pnlFiltrarPorData);
            this.groupBox1.Controls.Add(this.pnlFiltroDestinatario);
            this.groupBox1.Controls.Add(this.btBuscar);
            this.groupBox1.Controls.Add(this.cmbFiltros);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1273, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // pnlFiltrarPorData
            // 
            this.pnlFiltrarPorData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiltrarPorData.Controls.Add(this.txtDataSolicitacao);
            this.pnlFiltrarPorData.Location = new System.Drawing.Point(279, 22);
            this.pnlFiltrarPorData.Name = "pnlFiltrarPorData";
            this.pnlFiltrarPorData.Size = new System.Drawing.Size(613, 57);
            this.pnlFiltrarPorData.TabIndex = 1;
            this.pnlFiltrarPorData.Visible = false;
            // 
            // txtDataSolicitacao
            // 
            this.txtDataSolicitacao.Location = new System.Drawing.Point(17, 17);
            this.txtDataSolicitacao.Mask = "00/00/0000";
            this.txtDataSolicitacao.Name = "txtDataSolicitacao";
            this.txtDataSolicitacao.Size = new System.Drawing.Size(139, 23);
            this.txtDataSolicitacao.TabIndex = 0;
            // 
            // pnlFiltroDestinatario
            // 
            this.pnlFiltroDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiltroDestinatario.Controls.Add(this.txtDestinatario);
            this.pnlFiltroDestinatario.Location = new System.Drawing.Point(282, 22);
            this.pnlFiltroDestinatario.Name = "pnlFiltroDestinatario";
            this.pnlFiltroDestinatario.Size = new System.Drawing.Size(613, 57);
            this.pnlFiltroDestinatario.TabIndex = 1;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinatario.Location = new System.Drawing.Point(14, 17);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(580, 23);
            this.txtDestinatario.TabIndex = 0;
            // 
            // btBuscar
            // 
            this.btBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscar.Location = new System.Drawing.Point(901, 39);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(138, 27);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Destinatário",
            "Data solicitação"});
            this.cmbFiltros.Location = new System.Drawing.Point(115, 39);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(161, 25);
            this.cmbFiltros.TabIndex = 0;
            this.cmbFiltros.SelectedIndexChanged += new System.EventHandler(this.cmbFiltros_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Filtrar por:";
            // 
            // dgvSolicitacao
            // 
            this.dgvSolicitacao.AllowUserToAddRows = false;
            this.dgvSolicitacao.AllowUserToDeleteRows = false;
            this.dgvSolicitacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSolicitacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDestinatario,
            this.colStatus,
            this.colDataSolicitacao,
            this.colObj});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSolicitacao.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSolicitacao.Location = new System.Drawing.Point(3, 190);
            this.dgvSolicitacao.MultiSelect = false;
            this.dgvSolicitacao.Name = "dgvSolicitacao";
            this.dgvSolicitacao.RowHeadersWidth = 51;
            this.dgvSolicitacao.RowTemplate.Height = 24;
            this.dgvSolicitacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitacao.Size = new System.Drawing.Size(1039, 316);
            this.dgvSolicitacao.TabIndex = 5;
            this.dgvSolicitacao.TabStop = false;
            // 
            // colDestinatario
            // 
            this.colDestinatario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDestinatario.HeaderText = "Destinatário";
            this.colDestinatario.MinimumWidth = 6;
            this.colDestinatario.Name = "colDestinatario";
            this.colDestinatario.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colStatus.HeaderText = "Status";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 73;
            // 
            // colDataSolicitacao
            // 
            this.colDataSolicitacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDataSolicitacao.HeaderText = "Data da solicitação";
            this.colDataSolicitacao.MinimumWidth = 6;
            this.colDataSolicitacao.Name = "colDataSolicitacao";
            this.colDataSolicitacao.ReadOnly = true;
            this.colDataSolicitacao.Width = 139;
            // 
            // colObj
            // 
            this.colObj.HeaderText = "obj";
            this.colObj.MinimumWidth = 6;
            this.colObj.Name = "colObj";
            this.colObj.Visible = false;
            this.colObj.Width = 125;
            // 
            // frmConsultarSolicitacoesFinalizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 535);
            this.Controls.Add(this.pnlFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarSolicitacoesFinalizadas";
            this.Text = "Solicitações finalizadas";
            this.Load += new System.EventHandler(this.frmConsultarSolicitacoesFinalizadas_Load);
            this.pnlFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlFiltrarPorData.ResumeLayout(false);
            this.pnlFiltrarPorData.PerformLayout();
            this.pnlFiltroDestinatario.ResumeLayout(false);
            this.pnlFiltroDestinatario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSolicitacao;
        private System.Windows.Forms.Button btVerItens;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlFiltroDestinatario;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Panel pnlFiltrarPorData;
        private System.Windows.Forms.MaskedTextBox txtDataSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObj;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
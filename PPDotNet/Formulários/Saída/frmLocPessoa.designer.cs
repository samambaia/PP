namespace PPDotNet.Formulários.Saída
{
    partial class frmLocPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocPessoa));
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.toolCons = new System.Windows.Forms.ToolStrip();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.toolCons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAchar
            // 
            this.btnAchar.Click += new System.EventHandler(this.btnAchar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto_KeyPress);
            // 
            // gridResult
            // 
            this.gridResult.AllowUserToAddRows = false;
            this.gridResult.AllowUserToDeleteRows = false;
            this.gridResult.AllowUserToOrderColumns = true;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResult.Location = new System.Drawing.Point(0, 52);
            this.gridResult.Name = "gridResult";
            this.gridResult.ReadOnly = true;
            this.gridResult.Size = new System.Drawing.Size(622, 327);
            this.gridResult.TabIndex = 7;
            this.gridResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridResult_KeyDown);
            this.gridResult.DoubleClick += new System.EventHandler(this.gridResult_DoubleClick);
            // 
            // toolCons
            // 
            this.toolCons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolCons.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolCons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair,
            this.toolStripSeparator1,
            this.btnAlterar});
            this.toolCons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolCons.Location = new System.Drawing.Point(0, 356);
            this.toolCons.Name = "toolCons";
            this.toolCons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolCons.Size = new System.Drawing.Size(622, 23);
            this.toolCons.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(50, 20);
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(66, 20);
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlterar.ToolTipText = "Alterar Registro";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // frmLocPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(622, 379);
            this.Controls.Add(this.toolCons);
            this.Controls.Add(this.gridResult);
            this.Name = "frmLocPessoa";
            this.Text = "Localizar Cliente/Fornecedor";
            this.Load += new System.EventHandler(this.frmLocPessoa_Load);
            this.Controls.SetChildIndex(this.gridResult, 0);
            this.Controls.SetChildIndex(this.toolCons, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.toolCons.ResumeLayout(false);
            this.toolCons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridResult;
        public System.Windows.Forms.ToolStrip toolCons;
        public System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton btnAlterar;
    }
}

namespace PPDotNet.Formulários.Modelos
{
    partial class frmModeloConsulta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAchar = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.cmbCampos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAchar);
            this.groupBox1.Controls.Add(this.txtTexto);
            this.groupBox1.Controls.Add(this.cmbCampos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnAchar
            // 
            this.btnAchar.BackColor = System.Drawing.SystemColors.Info;
            this.btnAchar.ImageKey = "ACHAR.bmp";
            this.btnAchar.Location = new System.Drawing.Point(562, 19);
            this.btnAchar.Name = "btnAchar";
            this.btnAchar.Size = new System.Drawing.Size(50, 23);
            this.btnAchar.TabIndex = 3;
            this.btnAchar.Text = "Achar";
            this.btnAchar.UseVisualStyleBackColor = false;
            this.btnAchar.Click += new System.EventHandler(this.btnAchar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTexto.Location = new System.Drawing.Point(189, 19);
            this.txtTexto.MaxLength = 50;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(367, 21);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto_KeyPress);
            // 
            // cmbCampos
            // 
            this.cmbCampos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampos.FormattingEnabled = true;
            this.cmbCampos.Items.AddRange(new object[] {
            "Código",
            "Descrição"});
            this.cmbCampos.Location = new System.Drawing.Point(66, 19);
            this.cmbCampos.Name = "cmbCampos";
            this.cmbCampos.Size = new System.Drawing.Size(117, 21);
            this.cmbCampos.TabIndex = 1;
            this.cmbCampos.DropDownClosed += new System.EventHandler(this.cmbCampos_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campos";
            // 
            // frmModeloConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(622, 379);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmModeloConsulta";
            this.ShowInTaskbar = true;
            this.Shown += new System.EventHandler(this.frmModeloConsulta_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbCampos;
        public System.Windows.Forms.Button btnAchar;
        public System.Windows.Forms.TextBox txtTexto;
        public System.Windows.Forms.Label label1;
    }
}

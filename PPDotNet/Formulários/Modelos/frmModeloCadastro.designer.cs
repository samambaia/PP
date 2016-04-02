namespace PPDotNet.Formulários.Modelos
{
    partial class frmModeloCadastro
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
            this.tabDados = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.tabDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.tabPage2);
            this.tabDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDados.Location = new System.Drawing.Point(0, 0);
            this.tabDados.Name = "tabDados";
            this.tabDados.SelectedIndex = 0;
            this.tabDados.Size = new System.Drawing.Size(644, 484);
            this.tabDados.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados";
            // 
            // frmModeloCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(644, 515);
            this.Controls.Add(this.tabDados);
            this.Name = "frmModeloCadastro";
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.tabDados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabDados;
        public System.Windows.Forms.TabPage tabPage2;
    }
}

namespace PPDotNet.Formulários.Relatórios
{
    partial class frmPreview
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.viewimporcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSaida = new PPDotNet.DataSources.dsSaida();
            this.repViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_imp_orcaTableAdapter = new PPDotNet.DataSources.dsSaidaTableAdapters.view_imp_orcaTableAdapter();
            this.view_imp_orcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewimporcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_imp_orcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewimporcaBindingSource
            // 
            this.viewimporcaBindingSource.DataMember = "view_imp_orca";
            this.viewimporcaBindingSource.DataSource = this.dsSaida;
            // 
            // dsSaida
            // 
            this.dsSaida.DataSetName = "dsSaida";
            this.dsSaida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repViewer
            // 
            this.repViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsOrca";
            reportDataSource1.Value = this.view_imp_orcaBindingSource;
            this.repViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.repViewer.LocalReport.ReportEmbeddedResource = "PPDotNet.Formulários.Relatórios.repOrca.rdlc";
            this.repViewer.Location = new System.Drawing.Point(0, 0);
            this.repViewer.Name = "repViewer";
            this.repViewer.Size = new System.Drawing.Size(843, 494);
            this.repViewer.TabIndex = 0;
            // 
            // view_imp_orcaTableAdapter
            // 
            this.view_imp_orcaTableAdapter.ClearBeforeFill = true;
            // 
            // view_imp_orcaBindingSource
            // 
            this.view_imp_orcaBindingSource.DataMember = "view_imp_orca";
            this.view_imp_orcaBindingSource.DataSource = this.dsSaida;
            // 
            // frmPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 494);
            this.Controls.Add(this.repViewer);
            this.Name = "frmPreview";
            this.Text = "Preview de Relatório e Listagens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewimporcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_imp_orcaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repViewer;
        private System.Windows.Forms.BindingSource viewimporcaBindingSource;
        private DataSources.dsSaida dsSaida;
        private DataSources.dsSaidaTableAdapters.view_imp_orcaTableAdapter view_imp_orcaTableAdapter;
        private System.Windows.Forms.BindingSource view_imp_orcaBindingSource;


    }
}
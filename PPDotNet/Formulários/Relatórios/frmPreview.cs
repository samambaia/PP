using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Common;

namespace PPDotNet.Formulários.Relatórios
{
    public partial class frmPreview: PPDotNet.Formulários.Modelos.frmModelo
    {
        public int idOrca = 0;
        public string form = "";

        public frmPreview()
        {
            InitializeComponent();
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {
            //string path = @"D:\Projetos\PP\PPDotNet\Formulários\Relatórios\";    //@"\\PP01\C\PP\Relatórios\";
            string path = @"C:\PP\Relatórios\"; //@"\\PP01\C\PP\Relatórios\";

            // TODO: This line of code loads data into the 'dsSaida.view_imp_orca' table. You can move, or remove it, as needed.
            this.view_imp_orcaTableAdapter.Fill(this.dsSaida.view_imp_orca, idOrca);

            this.repViewer.LocalReport.ReportPath = path + form; 
            this.repViewer.RefreshReport();
        }
    }
}
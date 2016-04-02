using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PPDotNet.Formulários.Modelos;

namespace PPDotNet.Formulários.Modelos
{
    public partial class frmModeloConsulta : frmModelo
    {
        public frmModeloConsulta()
        {
            InitializeComponent();
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAchar_Click(btnAchar, e);
            }
        }

        private void btnAchar_Click(object sender, EventArgs e)
        {
        }

        private void cmbCampos_DropDownClosed(object sender, EventArgs e)
        {
            txtTexto.Text = string.Empty;
            txtTexto.Focus();
        }

        private void frmModeloConsulta_Shown ( object sender, EventArgs e )
        {
            cmbCampos.SelectedIndex = 1;
            cmbCampos_DropDownClosed(sender, e);
        }
    }
}


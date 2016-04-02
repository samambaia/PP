using System;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Modelos;

namespace PPDotNet.Formulários.Cadastros
{
    public partial class frmLocProduto:frmModeloConsulta
    {
        produto Produto = new produto();
        
        public frmLocProduto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carrega Grid
        /// </summary>
        /// <param name="intIndice"></param>
        private void CarregaGrid(int intIndice)
        {
            gridResult.DataSource = Produto.Achar(intIndice).Tables[0];
        }

        private void frmLocProduto_Load(object sender, EventArgs e)
        {
            CarregaGrid(9);
            gridResult.Columns[0].HeaderText = "Código";
            gridResult.Columns[0].Name = "id_produto";
            gridResult.Columns[0].Width = 80;

            gridResult.Columns[1].HeaderText = "Descrição";
            gridResult.Columns[1].Name = "descricao";
            gridResult.Columns[1].Width = 320;

            gridResult.Columns[2].Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAchar_Click(object sender, EventArgs e)
        {
            // No caso de não informar nada, carrega todos os dados no grid
            if (txtTexto.Text.Equals(string.Empty))
            {
                cmbCampos.SelectedIndex = -1;
            }

            // Caso algo seja informado com um campo selecionado
            switch (cmbCampos.SelectedIndex)
            {
                case 0:
                    Produto.id_produto = int.Parse(txtTexto.Text.TrimEnd());
                    break;
                case 1:
                    Produto.descricao = txtTexto.Text.Trim();
                    break;
                default:
                    break;
            }
            CarregaGrid(cmbCampos.SelectedIndex);
            if (gridResult.RowCount > 0)
                gridResult.Focus();
            else
                txtTexto.Focus();
        }

        private void txtTexto_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAchar_Click(sender, e);
        }
    }
}


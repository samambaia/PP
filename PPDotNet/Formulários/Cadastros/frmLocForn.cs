using System;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Cadastros;
using PPDotNet.Formulários.Modelos;

namespace PPDotNet.Formulários.Cadastros

{
    public partial class frmLocForn : frmModeloConsulta
    {
        pessoa Pessoa = new pessoa();

        private frmProdutosCad _produto;
        public frmProdutosCad produto
        {
            get { return _produto; }
            set { _produto = value; }
        }

        public frmLocForn ()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carrega Grid
        /// </summary>
        /// <param name="intIndice"></param>
        private void CarregaGrid ( int intIndice )
        {
            gridResult.DataSource = Pessoa.AcharFornFab(intIndice).Tables[0];
        }

        private void frmLocPessoa_Load ( object sender, EventArgs e )
        {
            CarregaGrid(9);
            gridResult.Columns[0].HeaderText = "Código";
            gridResult.Columns[0].Name = "id_pessoa";
            gridResult.Columns[0].Width = 80;

            gridResult.Columns[1].HeaderText = "Fantasia";
            gridResult.Columns[1].Name = "fantasia";
            gridResult.Columns[1].Width = 320;

            gridResult.Columns[2].HeaderText = "Orientação";
            gridResult.Columns[2].Name = "orientacao";
            gridResult.Columns[2].Width = 120;

            gridResult.Columns[3].Visible = false;
        }

        private void btnSair_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void gridResult_DoubleClick ( object sender, EventArgs e )
        {
            if (produto.TipoLoc == "Forn")
            {
                produto.txtCodForn.Text = gridResult.CurrentRow.Cells[0].Value.ToString();
                produto.txtDescForn.Text = gridResult.CurrentRow.Cells[1].Value.ToString();
                gridResult.DataMember = "";
                gridResult.DataSource = "";
                txtTexto.Text = string.Empty;
                Close();                
            }
            if (produto.TipoLoc == "Fab")
            {
                produto.txtCodFabrica.Text = gridResult.CurrentRow.Cells[0].Value.ToString();
                produto.txtDescFab.Text = gridResult.CurrentRow.Cells[1].Value.ToString();
                gridResult.DataMember = "";
                gridResult.DataSource = "";
                txtTexto.Text = string.Empty;
                Close();
            }            
        }

        private void btnAchar_Click ( object sender, EventArgs e )
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
                    Pessoa.id_pessoa = int.Parse(txtTexto.Text.TrimEnd());
                    break;
                case 1:
                    Pessoa.fantasia = txtTexto.Text.Trim();
                    break;
                default:
                    break;
            }
            CarregaGrid(cmbCampos.SelectedIndex);
        }

        private void txtTexto_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAchar_Click(btnAchar, e);
        }

        private void gridResult_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                gridResult_DoubleClick(sender, e);
        }
    }
}


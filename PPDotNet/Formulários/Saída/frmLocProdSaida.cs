using System;
using DllClasses.Net.Sistema.Negocio;
using DllClasses.Net.Sistema.Globais;
using PPDotNet.Formulários.Modelos;
using PPDotNet.Formulários.Cadastros;

namespace PPDotNet.Formulários.Saída
{
    public partial class frmLocProdSaida : frmModeloConsulta
    {
        produto Produto = new produto();

        public string FormChamou;

        private frmSaida _saida;
        public frmSaida saida
        {
            get { return _saida; }
            set { _saida = value; }
        }

        private frmProdutosCad _prod;
        public frmProdutosCad prod
        {
            get { return _prod; }
            set { _prod = value; }
        }

        public frmLocProdSaida()
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

        private void frmLocProdSaida_Load(object sender, EventArgs e)
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
                btnAchar_Click(btnAchar, e);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridResult_DoubleClick(object sender, EventArgs e)
        {
            if (FormChamou == "Saida")
                saida.Saida.id_produto = int.Parse(gridResult.CurrentRow.Cells[0].Value.ToString());
            if (FormChamou == "Produto")
                prod.Produto.id_produto = int.Parse(gridResult.CurrentRow.Cells[0].Value.ToString());
            gridResult.DataMember = "";
            gridResult.DataSource = "";
            txtTexto.Text = string.Empty;
            Close();
        }

        private void gridResult_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                gridResult_DoubleClick(sender, e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Alteração do Registro
            frmProdutosCad prodCad = new frmProdutosCad();
            prodCad.Operacao = clFuncoesGerais.Operacao.Alteracao;
            prodCad.Codigo = Convert.ToInt32(gridResult.CurrentRow.Cells[0].Value);
            prodCad.ShowDialog();
            prodCad.Dispose();
            CarregaGrid(9);
        }
    }
}
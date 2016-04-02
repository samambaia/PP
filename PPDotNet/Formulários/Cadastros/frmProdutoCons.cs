using System;
using System.Windows.Forms;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Modelos;
using PPDotNet.Formulários.Saída;

namespace PPDotNet.Formulários.Cadastros
{
    public partial class frmProdutoCons:frmModeloConsulta
    {
        produto Produto = new produto();

        public string FormChamou;

        private frmSaida formSaida;
        public frmSaida FormSaida
        {
            get { return formSaida; }
            set { formSaida = value; }
        }

        private frmOrcamento formOrca;
        public frmOrcamento FormOrca
        {
            get { return formOrca; }
            set { formOrca = value; }
        }

        frmProdutosCad prodCad = new frmProdutosCad();
        
        public frmProdutoCons()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Carrega Grid
        /// </summary>
        /// <param name="intIndice"></param>
        private void CarregaGrid(int intIndice)
        {
            gridResult.DataSource = Produto.Achar(intIndice).Tables[0];
        }

        private void frmProdutoCons_Load(object sender, EventArgs e)
        {
            CarregaGrid(9);
            gridResult.Columns[0].HeaderText = "Código";
            gridResult.Columns[0].Name = "id_produto";
            gridResult.Columns[0].Width = 80;

            gridResult.Columns[1].HeaderText = "Descrição";
            gridResult.Columns[1].Name = "descricao";
            gridResult.Columns[1].Width = 320;

            gridResult.Columns[2].HeaderText = "Preço";
            gridResult.Columns[2].Name = "valor_unitario";
            gridResult.Columns[2].Width = 100;
            gridResult.Columns[2].DefaultCellStyle.Format = "N2";
            gridResult.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAchar_Click(btnAchar, e);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridResult.RowCount > 0)
            {
                if ((MessageBox.Show("Deseja excluir o registro?", Text,
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
                {
                    return;
                }
                Produto.Excluir(Convert.ToInt32((gridResult.CurrentRow.Cells[0].Value)));
                MessageBox.Show("Registro excluído com sucesso", Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid(9);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            prodCad.Operacao = clFuncoesGerais.Operacao.Inclusao;
            prodCad.ShowDialog();
            CarregaGrid(9);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (gridResult.RowCount > 0)
            {
                prodCad.Operacao = clFuncoesGerais.Operacao.Alteracao;
                prodCad.Codigo = Convert.ToInt32(gridResult.CurrentRow.Cells[0].Value);
                prodCad.ShowDialog();
                CarregaGrid(9);
            }
        }

        private void gridResult_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   if (e.KeyChar == 13)
         //       btnAlterar_Click(sender, e);
        }

        private void gridResult_DoubleClick(object sender, EventArgs e)
        {
            if (FormChamou == "Saida")
            {
                formSaida.Saida.id_produto = int.Parse(gridResult.CurrentRow.Cells[0].Value.ToString());
                formSaida.Saida.valor_unitario = decimal.Parse(gridResult.CurrentRow.Cells[2].Value.ToString());
                Close();
            }

            if (FormChamou == "Orcamento")
            {
                formOrca.Orcamento.id_produto = int.Parse(gridResult.CurrentRow.Cells[0].Value.ToString());
                formOrca.Orcamento.valor_unitario = decimal.Parse(gridResult.CurrentRow.Cells[2].Value.ToString());
                Close();
            }
            //else
            //    if (gridResult.RowCount > 0)
            //        btnAlterar_Click(sender, e);
        }
    }
}


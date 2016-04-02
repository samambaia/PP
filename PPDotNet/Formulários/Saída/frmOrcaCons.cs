using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Modelos;

namespace PPDotNet.Formulários.Saída
{
    public partial class frmOrcaCons : frmModeloConsulta
    {
        orcamento Orcamento = new orcamento();
        
        public frmOrcaCons()
        {
            InitializeComponent();
        }

        private void CarregaGrid(int intIndice)
        {
            gridResult.DataSource = Orcamento.Achar(intIndice).Tables[0];
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Novo Registro
            frmOrcamento orcaCad = new frmOrcamento();
            orcaCad.Operacao = clFuncoesGerais.Operacao.Inclusao;
            orcaCad.ShowDialog();
            orcaCad.Dispose();
            CarregaGrid(9);
        }

        private void frmOrcamentoCons_Load(object sender, EventArgs e)
        {
            cmbCampos.Items.Clear();
            cmbCampos.Items.Add("Orçamento");
            cmbCampos.Items.Add("Cliente");
            cmbCampos.Items.Add("Placa");

            CarregaGrid(9);

            MontaGrid();

            this.Zebra_Grid(gridResult);
        }

        private void MontaGrid()
        {
            gridResult.Columns[0].HeaderText = "Nº Orçamento";
            gridResult.Columns[0].Name = "id_Orcamento";
            gridResult.Columns[0].Width = 100;

            gridResult.Columns[1].HeaderText = "Cliente";
            gridResult.Columns[1].Name = "nome_clie";
            gridResult.Columns[1].Width = 300;

            gridResult.Columns[2].HeaderText = "Placa";
            gridResult.Columns[2].Name = "nf";
            gridResult.Columns[2].Width = 80;

            gridResult.Columns[3].HeaderText = "Dt.Entrada";
            gridResult.Columns[3].Name = "dt_entrada";
            gridResult.Columns[3].Width = 90;
            gridResult.Columns[3].DefaultCellStyle.Format = "d";

            gridResult.Columns[4].HeaderText = "Vlr Total";
            gridResult.Columns[4].Name = "vlr_total";
            gridResult.Columns[4].Width = 90;
            gridResult.Columns[4].DefaultCellStyle.Format = "N2";
            gridResult.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            gridResult.Columns[5].HeaderText = "Observações";
            gridResult.Columns[5].Name = "obs";
            gridResult.Columns[5].Width = 500;
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
                    Orcamento.id_orcamento = int.Parse(txtTexto.Text.TrimEnd());
                    break;
                case 1:
                    Orcamento.desc_aux = txtTexto.Text.Trim();
                    break;
                case 2:
                    Orcamento.placa = txtTexto.Text.Trim();
                    break;
                default:
                    break;
            }
            CarregaGrid(cmbCampos.SelectedIndex);
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAchar_Click(btnAchar, e);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (gridResult.RowCount > 0)
            {
                this.Visible = false;
                // Alteração do Registro
                frmOrcamento orcaCad = new frmOrcamento();
                orcaCad.Operacao = clFuncoesGerais.Operacao.Alteracao;
                orcaCad.Codigo = Convert.ToInt32(gridResult.CurrentRow.Cells[0].Value);
                orcaCad.ShowDialog();
                orcaCad.Dispose();
                this.Visible = true;
                //CarregaGrid(9);
            }
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
                try
                {
                    Orcamento.Excluir(Convert.ToInt32((gridResult.CurrentRow.Cells[0].Value)));
                    MessageBox.Show("Registro excluído com sucesso", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Houve um problema durante a exclusão do registro.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CarregaGrid(9);
            }
        }
    }
}


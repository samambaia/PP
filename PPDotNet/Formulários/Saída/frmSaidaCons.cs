using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Modelos;

namespace PPDotNet.Formulários.Saída
{
    public partial class frmSaidaCons : frmModeloConsulta
    {
        saida Saida = new saida();

        public frmSaidaCons()
        {
            InitializeComponent();
        }

        private void CarregaGrid(int intIndice)
        {
            gridResult.DataSource = Saida.Achar(intIndice).Tables[0];
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Novo Registro
            frmSaida saiCad = new frmSaida();
            saiCad.Operacao = clFuncoesGerais.Operacao.Inclusao;
            saiCad.ShowDialog();
            saiCad.Dispose();
            CarregaGrid(9);
        }

        private void frmSaidaCons_Load(object sender, EventArgs e)
        {
            cmbCampos.Items.Add("Nota Fiscal");

            CarregaGrid(9);

            MontaGrid();

            this.Zebra_Grid(gridResult);
        }

        private void MontaGrid()
        {
            gridResult.Columns[0].HeaderText = "Código";
            gridResult.Columns[0].Name = "id_saida";
            gridResult.Columns[0].Width = 70;

            gridResult.Columns[1].HeaderText = "Cliente";
            gridResult.Columns[1].Name = "nome_clie";
            gridResult.Columns[1].Width = 250;

            gridResult.Columns[2].HeaderText = "Nota Fiscal";
            gridResult.Columns[2].Name = "nf";
            gridResult.Columns[2].Width = 100;

            gridResult.Columns[3].HeaderText = "Emissão";
            gridResult.Columns[3].Name = "data_emissao";
            gridResult.Columns[3].Width = 100;
            gridResult.Columns[3].DefaultCellStyle.Format = "d";
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
                    Saida.id_saida = int.Parse(txtTexto.Text.TrimEnd());
                    break;
                case 1:
                    Saida.desc_aux = txtTexto.Text.Trim();
                    break;
                case 2:
                    Saida.nf = txtTexto.Text.Trim();
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
                // Alteração do Registro
                frmSaida saiCad = new frmSaida();
                saiCad.Operacao = clFuncoesGerais.Operacao.Alteracao;
                saiCad.Codigo = Convert.ToInt32(gridResult.CurrentRow.Cells[0].Value);
                saiCad.ShowDialog();
                saiCad.Dispose();
                CarregaGrid(9);
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
                if (Saida.efetivado == 0)
                {
                    try
                    {
                        Saida.Excluir(Convert.ToInt32((gridResult.CurrentRow.Cells[0].Value)));
                        MessageBox.Show("Registro excluído com sucesso", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Pedido Vinculado ao um Romaneio! Exclua Primeiro no Romaneio.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                    MessageBox.Show("Saída Efetivada ou Em Trânsito. Impossível excluir!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaGrid(9);
            }
        }
    }
}


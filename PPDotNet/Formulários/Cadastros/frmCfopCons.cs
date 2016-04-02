using System;
using System.Windows.Forms;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formul�rios.Modelos;

namespace PPDotNet.Formul�rios.Cadastros
{
    partial class frmCfopCons : frmModeloConsulta
    {
        cfop Cfop = new cfop();
        frmCfopCad cfopCad = new frmCfopCad();

        public frmCfopCons()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carrega Grid
        /// </summary>
        /// <param name="intIndice"></param>
        private void CarregaGrid(int intIndice)
        {
            gridResult.DataSource = Cfop.Achar(intIndice).Tables[0];
        }

        /// <summary>
        /// Bot�o Novo
        /// </summary>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Novo Registro
            cfopCad.Operacao = clFuncoesGerais.Operacao.Inclusao;
            cfopCad.ShowDialog();
            CarregaGrid(9);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Evento LOAD que monta o grid
        /// </summary>
        private void frmCfopCons_Load(object sender, EventArgs e)
        {
            CarregaGrid(9);
            gridResult.Columns[0].HeaderText = "C�digo";
            gridResult.Columns[0].Name = "id_cfop";
            gridResult.Columns[0].Width = 80;

            gridResult.Columns[1].HeaderText = "Descri��o";
            gridResult.Columns[1].Name = "descricao";
            gridResult.Columns[1].Width = 300;

            gridResult.Columns[2].HeaderText = "Orienta��o";
            gridResult.Columns[2].Name = "orientacao";
            gridResult.Columns[2].Width = 200;

            cmbCampos.Items.Add("Orienta��o");
        }

        /// <summary>
        /// Bot�o Achar. Carrega o grid de acordo com o filtro selecionado
        /// </summary>
        private void btnAchar_Click(object sender, EventArgs e)
        {
            // No caso de n�o informar nada, carrega todos os dados no grid
            if (txtTexto.Text.Equals(string.Empty))
            {
                cmbCampos.SelectedIndex = -1;
            }

            // Caso algo seja informado com um campo selecionado
            switch (cmbCampos.SelectedIndex)
            {
                case 0:
                    Cfop.id_cfop = txtTexto.Text.TrimEnd();
                    break;
                case 1:
                    Cfop.descricao = txtTexto.Text.Trim();
                    break;
                case 2:
                    Cfop.orientacao = txtTexto.Text.Trim();
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

        /// <summary>
        /// Bot�o Alterar
        /// </summary>
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Altera��o do Registro
            cfopCad.Operacao = clFuncoesGerais.Operacao.Alteracao;
            cfopCad.CodigoCf = gridResult.CurrentRow.Cells[0].Value.ToString();
            cfopCad.ShowDialog();
            CarregaGrid(9);
        }

        /// <summary>
        /// Bot�o Excluir
        /// </summary>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja excluir o registro?", Text,
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                return;
            }
            Cfop.Excluir(Convert.ToInt32((gridResult.CurrentRow.Cells[0].Value)));
            MessageBox.Show("Registro exclu�do com sucesso", Text, 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregaGrid(9);
        }
    }
}
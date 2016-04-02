using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Modelos;
using PPDotNet.Formulários.Saída;

namespace PPDotNet.Formulários.Cadastros
{
    public partial class frmPessoaCons : frmModeloConsulta
    {
        pessoa Pessoa = new pessoa();

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

        public frmPessoaCons()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carrega Grid
        /// </summary>
        /// <param name="intIndice"></param>
        private void CarregaGrid(int intIndice)
        {
            gridResult.DataSource = this.Pessoa.Achar(intIndice).Tables[0];
        }

        /// <summary>
        /// Botao Novo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            // Novo Registro
            frmPessoaCad pessoaCad = new frmPessoaCad();
            pessoaCad.Operacao = DllClasses.Net.Sistema.Globais.clFuncoesGerais.Operacao.Inclusao;
            pessoaCad.ShowDialog();
            pessoaCad.Dispose();
            this.CarregaGrid(9);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento LOAD que monta o grid
        /// </summary>
        private void frmPessoaCons_Load(object sender, EventArgs e)
        {
            cmbCampos.Items.Clear();
            cmbCampos.Items.Add("Código");
            cmbCampos.Items.Add("Fantasia");
            cmbCampos.Items.Add("CNPJ");
            cmbCampos.Items.Add("CPF");

            this.CarregaGrid(9);
            gridResult.Columns[0].HeaderText = "Código";
            gridResult.Columns[0].Name = "id_pessoa";
            gridResult.Columns[0].Width = 80;

            gridResult.Columns[1].HeaderText = "Fantasia";
            gridResult.Columns[1].Name = "fantasia";
            gridResult.Columns[1].Width = 300;

            gridResult.Columns[2].HeaderText = "Orientação";
            gridResult.Columns[2].Name = "orientacao";
            gridResult.Columns[2].Width = 100;

            gridResult.Columns[3].HeaderText = "CNPJ";
            gridResult.Columns[3].Name = "cnpj";
            gridResult.Columns[3].Width = 130;

            gridResult.Columns[4].HeaderText = "CPF";
            gridResult.Columns[4].Name = "cpf";
            gridResult.Columns[4].Width = 110;

            gridResult.Columns[5].Visible = false;

        }

        /// <summary>
        /// Botão Achar. Carrega o grid de acordo com o filtro selecionado
        /// </summary>
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
                    this.Pessoa.id_pessoa = int.Parse(txtTexto.Text.TrimEnd());
                    break;
                case 1:
                    this.Pessoa.fantasia = txtTexto.Text.Trim();
                    break;
                case 2:
                    this.Pessoa.cnpj = txtTexto.Text.Trim();
                    break;
                case 3:
                    this.Pessoa.cpf = txtTexto.Text.Trim();
                    break;
                default:
                    break;
            }
            this.CarregaGrid(cmbCampos.SelectedIndex);
            if (gridResult.RowCount > 0)
                gridResult.Focus();
            else
                txtTexto.Focus();
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAchar_Click(btnAchar, e);
            }
        }

        /// <summary>
        /// Botão Alterar
        /// </summary>
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Alteração do Registro
            frmPessoaCad pessoaCad = new frmPessoaCad();
            pessoaCad.Operacao = DllClasses.Net.Sistema.Globais.clFuncoesGerais.Operacao.Alteracao;
            pessoaCad.Codigo = Convert.ToInt32(gridResult.CurrentRow.Cells[0].Value);
            pessoaCad.ShowDialog();
            pessoaCad.Dispose();
            CarregaGrid(9);
        }

        /// <summary>
        /// Botão Excluir
        /// </summary>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja excluir o registro?", this.Text,
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                return;
            }
            Pessoa.Excluir(Convert.ToInt32((gridResult.CurrentRow.Cells[0].Value)));
            MessageBox.Show("Registro excluído com sucesso", this.Text,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregaGrid(9);
        }

        private void gridResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                if (gridResult.RowCount > 0)
                    btnAlterar_Click(sender, e);
        }

        private void gridResult_DoubleClick(object sender, EventArgs e)
        {
            if (FormChamou == "Saida")
            {
                formSaida.Saida.id_cliente = int.Parse(gridResult.CurrentRow.Cells[0].Value.ToString());
                formSaida.Saida.fantasia = gridResult.CurrentRow.Cells[1].Value.ToString();
            }
            if (FormChamou == "Orcamento")
            {
                formOrca.Orcamento.id_cliente = int.Parse(gridResult.CurrentRow.Cells[0].Value.ToString());
                formOrca.Orcamento.fantasia = gridResult.CurrentRow.Cells[1].Value.ToString();
            }
            Close();
        }
    }
}


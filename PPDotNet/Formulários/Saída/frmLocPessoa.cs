using System;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Modelos;
using PPDotNet.Formulários.Cadastros;
using PPDotNet.Formulários.Saída;

namespace PPDotNet.Formulários.Saída
{
    public partial class frmLocPessoa : frmModeloConsulta
    {
        pessoa Pessoa = new pessoa();

        public string FormAberto;

        private frmSaida _saida;
        public frmSaida saida
        {
            get { return _saida; }
            set { _saida = value; }
        }
	
        public frmLocPessoa ()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carrega Grid
        /// </summary>
        /// <param name="intIndice"></param>
        private void CarregaGrid ( int intIndice )
        {
            if (FormAberto == "SAIDA")
                gridResult.DataSource = Pessoa.AcharCliente(intIndice).Tables[0];
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
            if (FormAberto == "SAIDA")
            {
                saida.Saida.id_cliente = int.Parse(gridResult.CurrentRow.Cells[0].Value.ToString());
                saida.Saida.fantasia = gridResult.CurrentRow.Cells[1].Value.ToString();
                saida.Saida.qtd_dias = int.Parse(gridResult.CurrentRow.Cells[3].Value.ToString());
            }

            gridResult.DataMember = "";
            gridResult.DataSource = "";
            txtTexto.Text = string.Empty;
            Close();
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

        private void gridResult_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                gridResult_DoubleClick(sender, e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            // Alteração do Registro
            frmPessoaCad pessoaCad = new frmPessoaCad();
            pessoaCad.Operacao = clFuncoesGerais.Operacao.Alteracao;
            pessoaCad.Codigo = Convert.ToInt32(gridResult.CurrentRow.Cells[0].Value);
            pessoaCad.ShowDialog();
            pessoaCad.Dispose();
            CarregaGrid(9);
        }
    }
}


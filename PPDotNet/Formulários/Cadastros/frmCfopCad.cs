using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formul�rios.Modelos;

namespace PPDotNet.Formul�rios.Cadastros
{
    public partial class frmCfopCad : frmModeloCadastro
    {
        cfop Cfop = new cfop();

        private string _CodigoCf;
        public string CodigoCf
        {
            get
            {
                return _CodigoCf;
            }
            set
            {
                _CodigoCf = value;
            }
        }

        public frmCfopCad()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(string.Empty))
            {
                errErro.SetError(txtDescricao, "Campo Obrigat�rio! Digite um C�digo CFOP.");
                return;
            }
            else
            {
                errErro.SetError(txtCodigo, "");
            }

            if (txtDescricao.Text.Equals(string.Empty))
            {
                errErro.SetError(txtDescricao, "Campo Obrigat�rio! Digite uma Descri��o.");
                return;
            }
            else
            {
                errErro.SetError(txtDescricao, "");
            }

            // Passa os par�metros e grava
            Cfop.id_cfop = txtCodigo.Text;
            Cfop.descricao = txtDescricao.Text;
            Cfop.orientacao = cmbOrientacao.Text;
            Cfop.tipo = Convert.ToInt16(cmbTipo.SelectedIndex);

            if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                Cfop.Gravar();
            }
            else if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                Cfop.id_cfop = CodigoCf.ToString();
                Cfop.Alterar();
            }
            MessageBox.Show("Registro gravado com sucesso", Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void frmCfopCad_Load(object sender, EventArgs e)
        {
            if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                SqlDataReader drDados;
                drDados = Cfop.Listar(CodigoCf.ToString());
                if (drDados.HasRows)
                {
                    drDados.Read();
                    txtCodigo.Text = drDados["id_cfop"].ToString();
                    txtCodigo.ReadOnly = true;
                    txtDescricao.Text = drDados["descricao"].ToString();
                    cmbOrientacao.SelectedItem = drDados["orientacao"].ToString();
                    cmbTipo.SelectedIndex = Convert.ToInt16(drDados["tipo"].ToString());
                }
            }
            else if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                // Limpa os Campos
                txtCodigo.ReadOnly = false;
                txtCodigo.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                cmbOrientacao.SelectedIndex = -1;
                cmbTipo.SelectedIndex = -1;
                txtCodigo.Focus();
            }
        }
    }
}


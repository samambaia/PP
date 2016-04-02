using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Modelos;
using PPDotNet.Formulários.Saída;

namespace PPDotNet.Formulários.Cadastros
{
    public partial class frmProdutosCad:frmModeloCadastro
    {
        pessoa Pessoa = new pessoa();
        SqlDataReader drPessoa;

        public string TipoLoc;

        public frmLocForn locForn = new frmLocForn();

        public frmLocProdSaida locProdSaida = new frmLocProdSaida();
        
        public produto Produto = new produto();

        saida Saida = new saida();

        public frmProdutosCad()
        {
            InitializeComponent();
        }

        private void frmProdutosCad_Load(object sender, EventArgs e)
        {
            Limpar_Campos();
            tabDados.TabIndex = 0;
            
            if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                txtCodigo.Enabled = false;
                SqlDataReader drDados;
                drDados = Produto.Listar(Codigo);
                if (drDados.HasRows)
                {
                    drDados.Read();
                    txtCodigo.Text = drDados["id_produto"].ToString();
                    txtDescricao.Text = drDados["descricao"].ToString();
                    //Fornecedor
                    txtCodForn.Text = drDados["id_fornecedor"].ToString();
                    if (!txtCodForn.Text.Equals(string.Empty))
                    {
                        drPessoa = Pessoa.ListarFornFab(int.Parse(txtCodForn.Text));
                        if (drPessoa.Read())
                        {
                            txtDescForn.Text = drPessoa["fantasia"].ToString();
                        }
                        else
                            MessageBox.Show("Não é um Fornecedor!", "Localizar Fornecedor");
                    }
                    else
                        txtDescForn.Text = "";
                    //Fábrica
                    txtCodFabrica.Text = drDados["id_fabrica"].ToString();
                    if (!txtCodFabrica.Text.Equals(string.Empty))
                    {
                        drPessoa = Pessoa.ListarFornFab(int.Parse(txtCodFabrica.Text));
                        if (drPessoa.Read())
                        {
                            txtDescFab.Text = drPessoa["fantasia"].ToString();
                        }
                        else
                            MessageBox.Show("Não é uma Fábrica!", "Localizar Fábrica");
                    }
                    else
                        txtDescFab.Text = "";
                    txtPrecoUnitario.Text = drDados["valor_unitario"].ToString();
                    chkStatus.Checked = drDados["status"].ToString() == "1" ? true : false;

                    //Fiscal
                    txtIcmsEst.Text = drDados["aliq_icms_est"].ToString();
                    txtIcmsInt.Text = drDados["aliq_icms_inter"].ToString();
                    txtIcmsEntra.Text = drDados["aliq_icms_entra"].ToString();
                    chkIcmsAnt.Checked = drDados["icms_ant"].ToString() == "1" ? true : false;
                    chkSubstTrib.Checked = drDados["sub_trib"].ToString() == "1" ? true : false;
                    txtSituTrib.Text = drDados["situacao_trib"].ToString();
                    rdbMaterial.Checked = drDados["tipo"].ToString() == "1" ? true : false;
                    rdbServico.Checked = drDados["tipo"].ToString() == "2" ? true : false;
                }
                txtDescricao.Focus();
            }
            else if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                txtCodigo.Enabled = true;
                Limpar_Campos();
                clDataBase clDB = new clDataBase();
                // Gera o AutoInc
                txtCodigo.Text = clDB.AutoInc("PRODUTOS").ToString();
                txtDescricao.Focus();
            }
        }

        private void Limpar_Campos()
        {
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtCodForn.Text = string.Empty;
            txtDescForn.Text = string.Empty;
            txtCodFabrica.Text = string.Empty;
            txtDescFab.Text = string.Empty;
            txtPrecoUnitario.Text = "0,00";
            chkStatus.Checked = true;
            txtIcmsEst.Text = "17,00";
            txtIcmsInt.Text = "12,00";
            txtIcmsEntra.Text = "0,00";
            txtSituTrib.Text = "00";
            chkIcmsAnt.Checked = false;
            chkSubstTrib.Checked = false;
            rdbMaterial.Checked = true;
            rdbServico.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Equals(string.Empty))
            {
                errErro.SetError(txtCodigo, "Campo Obrigatório! É obrigatório preencher um Código.");
                return;
            }
            else
                errErro.SetError(txtCodigo, "");
            
            if (txtDescricao.Text.Equals(string.Empty))
            {
                errErro.SetError(txtDescricao, "Campo Obrigatório! É obrigatório preencher uma descrição.");
                return;
            }
            else
                errErro.SetError(txtDescricao, "");

            if (txtIcmsEst.Text.Equals(string.Empty))
            {
                tabDados.SelectedIndex = 1;
                errErro.SetError(txtIcmsEst, "Campo Obrigatório! É obrigatório preencher o Campos ICMS Estadual.");
                return;
            }
            else
                errErro.SetError(txtIcmsInt, "");

            if (txtIcmsInt.Text.Equals(string.Empty))
            {
                tabDados.SelectedIndex = 1;
                errErro.SetError(txtIcmsInt, "Campo Obrigatório! É obrigatório preencher o Campos ICMS Interestadual.");
                return;
            }
            else
                errErro.SetError(txtIcmsInt, "");

            //Passa os parâmetros e grava
            Produto.id_produto = Convert.ToInt32(txtCodigo.Text);
            Produto.descricao = txtDescricao.Text.Trim();
            if (txtCodForn.Text != string.Empty)
                Produto.id_fornecedor = Convert.ToInt32(txtCodForn.Text);
            else
                Produto.id_fornecedor = 0;
            if (txtCodFabrica.Text != string.Empty)
                Produto.id_fabrica = Convert.ToInt32(txtCodFabrica.Text);
            else
                Produto.id_fabrica = 0;

            if (txtPrecoUnitario.Text != string.Empty)
                Produto.valor_unitario = Convert.ToDecimal(txtPrecoUnitario.Text);
            else
                Produto.valor_unitario = 0;
            Produto.status = (chkStatus.Checked) == true ? 1 : 0;
            Produto.usuario = "USUÁRIO";
            Produto.icms_est = Convert.ToDecimal(txtIcmsEst.Text);
            Produto.icms_int = Convert.ToDecimal(txtIcmsInt.Text);
            Produto.icms_entra = Convert.ToDecimal(txtIcmsEntra.Text);
            Produto.sit_trib = txtSituTrib.Text;
            Produto.icms_ant = (chkIcmsAnt.Checked) == true ? 1 : 0;
            Produto.sub_trib = (chkSubstTrib.Checked) == true ? 1 : 0;
            Produto.tipo = Convert.ToInt16((rdbMaterial.Checked) == true ? 1 : 2); //1 - Material, 2 - Serviço

            if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                Produto.Gravar();
            }
            else if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                Produto.id_produto = Codigo;
                Produto.Alterar();
            }
            MessageBox.Show("Registro gravado com sucesso", Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            //Limpa os campos e inicia um novo registro
            Limpar_Campos();
            if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                clDataBase clDB = new clDataBase();
                // Gera o AutoInc
                txtCodigo.Text = clDB.AutoInc("PRODUTOS").ToString();
                txtDescricao.Focus();
            }
            else
                Close();
        }

        private void btnLocForn_Click(object sender, EventArgs e)
        {
            TipoLoc = "Forn";
            locForn.produto = this;
            locForn.ShowDialog();
            txtCodForn.Focus();
        }

        private void btnLocFab_Click(object sender, EventArgs e)
        {
            TipoLoc = "Fab";
            locForn.produto = this;
            locForn.ShowDialog();
            txtPrecoUnitario.Focus();
        }

        private void txtCodForn_Leave(object sender, EventArgs e)
        {
            //Fornecedor
            if (!txtCodForn.Text.Equals(string.Empty))
            {
                drPessoa = Pessoa.ListarFornFab(int.Parse(txtCodForn.Text));
                if (drPessoa.Read())
                    txtDescForn.Text = drPessoa["fantasia"].ToString();
                else
                {
                    MessageBox.Show("Fornecedor não existe ou está Inativo!", "Localizar Fornecedor");
                    txtCodForn.Focus();
                }
            }
            else
                btnLocForn_Click(sender, e);
        }

        private void txtCodFabrica_Leave(object sender, EventArgs e)
        {
            //Fábrica
            if (!txtCodFabrica.Text.Equals(string.Empty))
            {
                drPessoa = Pessoa.ListarFornFab(int.Parse(txtCodFabrica.Text));
                if (drPessoa.Read())
                    txtDescFab.Text = drPessoa["fantasia"].ToString();
                else
                {
                    MessageBox.Show("Fábrica não existe ou está Inativo!", "Localizar Fábrica");
                    txtCodFabrica.Focus();
                }
            }
            else
                btnLocFab_Click(sender, e);
        }

        private void txtIcmsEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SelectNextControl(sender as Control, true, true, true, true);
            }
        }

        private void txtCodForn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 121)
                btnLocForn_Click(sender, e);
        }

        private void txtCodFabrica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 121)
                btnLocFab_Click(sender, e);
        }

        private void btnLocProd_Click(object sender, EventArgs e)
        {
            locProdSaida.FormChamou = "Produto";
            locProdSaida.prod = this;
            locProdSaida.ShowDialog();
            txtCodProdPai.Text = Produto.id_produto.ToString();
            if (txtCodProdPai.Text != string.Empty)
            {
                SqlDataReader drProd;
                drProd = Saida.LocProduto(Convert.ToInt32(txtCodProdPai.Text));
                if (drProd.HasRows)
                {
                    drProd.Read();
                    txtDescProdPai.Text = drProd["descricao"].ToString();
                }
                else
                {
                    MessageBox.Show("Produto não existe!", "Localizar Produto");
                    txtDescProdPai.Text = string.Empty;
                    txtCodProdPai.Focus();
                }
            }
            txtCodProdPai.Focus();
        }

        private void txtCodProdPai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 121)
                btnLocProd_Click(sender, e);
        }

        private void frmProdutosCad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SelectNextControl(sender as Control, true, true, true, true);
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            if (rdbMaterial.Checked)
                lblICMS_ISS.Text = "Alíquota ICMS Estadual";
            else
                lblICMS_ISS.Text = "Alíquota ISS";

            txtIcmsInt.Enabled = rdbMaterial.Checked;
            txtIcmsEntra.Enabled = rdbMaterial.Checked;
            txtSituTrib.Enabled = rdbMaterial.Checked;
        }
    }
}


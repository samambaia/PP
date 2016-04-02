using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Modelos;

namespace PPDotNet.Formulários.Cadastros
{
    public partial class frmPessoaCad : frmModeloCadastro
    {
        pessoa Pessoa = new pessoa();

        public enum Op_Contato
        {
            Inclusao,
            Alteracao
        }

        private Op_Contato _Op_Cont;
        public Op_Contato Op_cont
        {
            get { return _Op_Cont; }
            set { _Op_Cont = value; }
        }	

        public frmPessoaCad()
        {
            InitializeComponent();
        }

        private void tabContatos_Enter(object sender, EventArgs e)
        {
            if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                LimpaCont();
                toolStrip1.Visible = false;
                gridContatos.DataSource = Pessoa.ListarContatos(Convert.ToInt32(txtCodigo.Text)).Tables[0];

                gridContatos.Columns[0].HeaderText = "Código";
                gridContatos.Columns[0].Name = "id_contato";
                gridContatos.Columns[0].Width = 80;

                gridContatos.Columns[1].HeaderText = "Nome";
                gridContatos.Columns[1].Name = "nome";
                gridContatos.Columns[1].Width = 320;

                gridContatos.Columns[2].HeaderText = "Telefone";
                gridContatos.Columns[2].Name = "telefone";
                gridContatos.Columns[2].Width = 100;
            }
            else
            {
                if (!btnGravar.Enabled)
                {
                    LimpaCont();
                    toolStrip1.Visible = false;
                    gridContatos.DataSource = Pessoa.ListarContatos(Convert.ToInt32(txtCodigo.Text)).Tables[0];

                    gridContatos.Columns[0].HeaderText = "Código";
                    gridContatos.Columns[0].Name = "id_contato";
                    gridContatos.Columns[0].Width = 80;

                    gridContatos.Columns[1].HeaderText = "Nome";
                    gridContatos.Columns[1].Name = "nome";
                    gridContatos.Columns[1].Width = 320;

                    gridContatos.Columns[2].HeaderText = "Telefone";
                    gridContatos.Columns[2].Name = "telefone";
                    gridContatos.Columns[2].Width = 100;
                }
                else
                {
                    MessageBox.Show("É preciso primeiro Incluir um Cliente!");
                    tabDados.SelectedIndex = 0;
                }
            }
        }

        private void tabContatos_Leave(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }

        private void rdbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            txtCnpj.Enabled = (rdbJuridica.Checked);
            txtIE.Enabled = (rdbJuridica.Checked);
            txtCpf.Enabled = (!rdbJuridica.Checked);
            txtRg.Enabled = (!rdbJuridica.Checked);
            txtOrgaoRg.Enabled = (!rdbJuridica.Checked);
        }

        private void txtRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SelectNextControl(sender as Control, true, true, true, true);
            }
        }

        private void chkTransp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransp.Checked)
            {
                chkFornecedor.Checked = false;
                chkVendedor.Checked = false;
                chkServico.Checked = false;

                //cmbGrupoEco.Enabled = false;
                chkMLE.Checked = true;
            }
            gpbForn.Enabled = (chkTransp.Checked);
            gpbCli.Enabled = (!chkTransp.Checked);
        }

        private void chkFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFornecedor.Checked)
            {
                chkTransp.Checked = false;
                chkVendedor.Checked = false;
                chkServico.Checked = false;
                chkMLE.Checked = true;
            }
            gpbForn.Enabled = (chkFornecedor.Checked);
            gpbCli.Enabled = true;
        }

        private void chkVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVendedor.Checked)
            {
                chkFornecedor.Checked = false;
                chkTransp.Checked = false;
                chkServico.Checked = false;
                chkMLE.Checked = true;
            }
            gpbForn.Enabled = (!chkVendedor.Checked);
            gpbCli.Enabled = (!chkVendedor.Checked);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPessoaCad_Load(object sender, EventArgs e)
        {
            //Carrega os links de validação do CPF e CNPJ
            linkCNPJ.Links.Add(0,3,"www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/cnpjreva/Cnpjreva_Solicitacao.asp");
            linkCPF.Links.Add(0,3,"www.receita.fazenda.gov.br/Aplicacoes/ATCTA/cpf/ConsultaPublica.asp");

            // TODO: This line of code loads data into the 'dsContatos.PESSOA' table. You can move, or remove it, as needed.
           // this.pESSOATableAdapter.Fill(this.dsContatos.PESSOA);

            btnGravar.Enabled = true;

            tabDados.SelectedIndex = 0;
            if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                Limpa_Campos();
                SqlDataReader drDados;
                drDados = Pessoa.Listar(Codigo);
                if (drDados.HasRows)
                {
                    drDados.Read();
                    txtCodigo.Text = drDados["id_pessoa"].ToString();
                    txtLimCred.Text = drDados["limite_cred"].ToString();
                    if (txtLimCred.Text != string.Empty)
                        txtLimCred_Leave(sender, e);
                    else
                    {
                        txtLimCred.Text = "0";
                        txtLimCred_Leave(sender, e);
                    }
                    txtRazaoSocial.Text = drDados["razao_social"].ToString();
                    txtFantasia.Text = drDados["fantasia"].ToString();
                    txtEndereco.Text = drDados["endereco"].ToString();
                    txtReferencia.Text = drDados["referencia"].ToString();
                    txtBairro.Text = drDados["bairro"].ToString();
                    txtCep.Text = drDados["cep"].ToString();
                    cmbCidade.Text = drDados["cidade"].ToString();
                    cmbUf.Text = drDados["uf"].ToString();
                    if (drDados["tipo"].ToString() == "J")
                    {
                        rdbJuridica.Checked = true;
                        rdbFisica.Checked = false;
                        txtCnpj.Text = drDados["cnpj"].ToString();
                        txtIE.Text = drDados["ie"].ToString();
                    }
                    else
                    {
                        rdbJuridica.Checked = false;
                        rdbFisica.Checked = true;
                        txtCpf.Text = drDados["cpf"].ToString();
                        txtRg.Text = drDados["rg"].ToString();
                        txtOrgaoRg.Text = drDados["orgao_rg"].ToString();
                    }
                    switch (Convert.ToInt16(drDados["fornecedor"]))
                    {
                        case 1: 
                            chkFornecedor.Checked = true;
                            break;
                        case 0: 
                            chkFornecedor.Checked = false;
                            break;
                    }
                    switch (Convert.ToInt16(drDados["vendedor"]))
                    {
                        case 1:
                            chkVendedor.Checked = true;
                            break;
                        case 0:
                            chkVendedor.Checked = false;
                            break;
                    }
                    switch (Convert.ToInt16(drDados["transportadora"]))
                    {
                        case 1:
                            chkTransp.Checked = true;
                            break;
                        case 0:
                            chkTransp.Checked = false;
                            break;
                    }
                    switch (Convert.ToInt16(drDados["servico"]))
                    {
                        case 1:
                            chkServico.Checked = true;
                            break;
                        case 0:
                            chkServico.Checked = false;
                            break;
                    }
                    switch (Convert.ToInt16(drDados["cad_status"]))
                    {
                        case 1:
                            chkCadStatus.Checked = true;
                            break;
                        case 0:
                            chkCadStatus.Checked = false;
                            break;
                    }

                    if (drDados["mesmo_local_entrega"].ToString() == "1")
                    {
                        chkMLE.Checked = true;
                    }
                    else
                    {
                        chkMLE.Checked = false;
                    }
                    chkMLE_CheckedChanged(sender, e);

                    txtObs.Text = drDados["obs"].ToString();
                    if (drDados["ativo"].ToString() == "1")
                    {
                        rdbSim.Checked = true;
                    }
                    else
                    {
                        rdbNao.Checked = true;
                    }

                    // Outros Dados
                    if (drDados["frete_c"].ToString() == "C")
                    {
                        cmbFrete_C.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbFrete_C.SelectedIndex = 1;
                    }
                    if (drDados["frete_f"].ToString() == "C")
                    {
                        cmbFrete_F.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbFrete_F.SelectedIndex = 1;
                    }
                    txtQtdDias_C.Value = Convert.ToDecimal(drDados["qtd_dias_c"]);
                    txtQtdDias_F.Value = Convert.ToDecimal(drDados["qtd_dias_f"]);

                    // Local de Entrega
                    txtEndereco_LE.Text = drDados["endereco_le"].ToString();
                    txtReferencia_LE.Text = drDados["referencia_le"].ToString();
                    txtBairro_LE.Text = drDados["bairro_le"].ToString();
                    txtCep_LE.Text = drDados["cep_le"].ToString();
                    cmbCidade_LE.Text = drDados["cidade_le"].ToString();
                    cmbUf_LE.Text = drDados["uf_le"].ToString();
                }
            }
            else if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                Limpa_Campos();
                lblDataCadastro.Text = DateTime.Now.Date.ToShortDateString();
                clDataBase clDB = new clDataBase();
                // Gera o AutoInc
                txtCodigo.Text = clDB.AutoInc("PESSOA").ToString();

                txtRazaoSocial.Focus();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtFantasia.Text.Equals(string.Empty))
            {
                errErro.SetError(txtFantasia, "Campo Obrigatório! Digite um Nome Fantasia.");
                return;
            }
            else
            {
                errErro.SetError(txtFantasia, "");
            }

            // Passa os parâmetros e grava
            Pessoa.limite_cred = Convert.ToDecimal(txtLimCred.Text);
            Pessoa.razao_social = txtRazaoSocial.Text;
            Pessoa.fantasia = txtFantasia.Text;
            Pessoa.endereco = txtEndereco.Text;
            Pessoa.referencia = txtReferencia.Text;
            Pessoa.bairro = txtBairro.Text;
            Pessoa.cep = txtCep.Text;
            Pessoa.cidade = cmbCidade.Text;
            Pessoa.uf = cmbUf.Text;
            if (rdbFisica.Checked)
            {
                Pessoa.tipo = "F";
                Pessoa.cpf = txtCpf.Text;
                Pessoa.rg = txtRg.Text;
                Pessoa.orgao_rg = txtOrgaoRg.Text;
            }
            else
            {
                Pessoa.tipo = "J";
                Pessoa.cnpj = txtCnpj.Text;
                Pessoa.ie = txtIE.Text;
            }
            Pessoa.obs = txtObs.Text;
            if (chkMLE.Checked)
            {
                Pessoa.mesmo_local_entrega = 1;
                Pessoa.endereco_le = txtEndereco.Text;
                Pessoa.referencia_le = txtReferencia.Text;
                Pessoa.bairro_le = txtBairro.Text;
                Pessoa.cep_le = txtCep.Text;
                Pessoa.cidade_le = cmbCidade.Text;
                Pessoa.uf_le = cmbUf.Text;
            }
            else
            {
                Pessoa.mesmo_local_entrega = 0;
                Pessoa.endereco_le = txtEndereco_LE.Text;
                Pessoa.referencia_le = txtReferencia_LE.Text;
                Pessoa.bairro_le = txtBairro_LE.Text;
                Pessoa.cep_le = txtCep_LE.Text;
                Pessoa.cidade_le = cmbCidade_LE.Text;
                Pessoa.uf_le = cmbUf_LE.Text;
            }

            if ((!chkFornecedor.Checked) && (!chkTransp.Checked) && (!chkVendedor.Checked) && (!chkServico.Checked))
            {
                if (cmbFrete_C.Text.Equals(string.Empty))
                {
                    tabDados.SelectedIndex = 1;
                    errErro.SetError(cmbFrete_C, "Campo obrigatório! Informe o Frete para o Cliente!");
                    return;
                }
                else
                {
                    errErro.SetError(cmbFrete_C, "");
                }

                if (txtQtdDias_C.Value.Equals(string.Empty))
                {
                    tabDados.SelectedIndex = 1;
                    errErro.SetError(txtQtdDias_C, "Campo obrigatório! Informe uma forma de pagamento!");
                    return;
                }
                else
                {
                    errErro.SetError(txtQtdDias_C, "");
                }
                
                //Dados para Cliente
                if (cmbFrete_C.Text == "CIF")
                {
                    Pessoa.frete_c = "C";
                }
                else
                {
                    Pessoa.frete_c = "F";
                }
                Pessoa.qtd_dias_c = Convert.ToInt16(txtQtdDias_C.Value);
                Pessoa.fornecedor = 0;
                Pessoa.vendedor = 0;
                Pessoa.transportadora = 0;
                Pessoa.servico = 0;
            }
            else if (chkFornecedor.Checked)
            {
                if (cmbFrete_F.Text.Equals(string.Empty))
                {
                    tabDados.SelectedIndex = 1;
                    errErro.SetError(cmbFrete_F, "Campo obrigatório! Informe o tipo de Frete!");
                    return;
                }
                else
                {
                    errErro.SetError(cmbFrete_F, "");
                }

                if (txtQtdDias_F.Value.Equals(string.Empty))
                {
                    tabDados.SelectedIndex = 1;
                    errErro.SetError(txtQtdDias_F, "Campo obrigatório! Informe Quantidades de Dias!");
                    return;
                }
                else
                {
                    errErro.SetError(txtQtdDias_F, "");
                }

                //Dados para Cliente
                if (cmbFrete_C.Text == "CIF")
                {
                    Pessoa.frete_c = "C";
                }
                else
                {
                    Pessoa.frete_c = "F";
                }
                Pessoa.qtd_dias_c = Convert.ToInt16(txtQtdDias_C.Value);

                //Dados para o Fornecedor
                if (cmbFrete_F.Text == "CIF")
                {
                    Pessoa.frete_f = "C";
                }
                else
                {
                    Pessoa.frete_f = "F";
                }
                Pessoa.qtd_dias_f = Convert.ToInt16(txtQtdDias_F.Value);
                Pessoa.fornecedor = 1;
                Pessoa.vendedor = 0;
                Pessoa.transportadora = 0;
            }
            else if (chkTransp.Checked)
            {
                if (txtQtdDias_F.Value.Equals(string.Empty))
                {
                    tabDados.SelectedIndex = 1;
                    errErro.SetError(txtQtdDias_F, "Campo obrigatório! Informe Quantidades de Dias!");
                    return;
                }
                else
                {
                    errErro.SetError(txtQtdDias_F, "");
                }
                //Dados para a Transportadora
                if (cmbFrete_F.Text == "CIF")
                {
                    Pessoa.frete_f = "C";
                }
                else
                {
                    Pessoa.frete_f = "F";
                }
                Pessoa.qtd_dias_f = Convert.ToInt16(txtQtdDias_F.Value);

                Pessoa.transportadora = 1;
                Pessoa.fornecedor = 0;
                Pessoa.vendedor = 0;
            }
            else if (chkVendedor.Checked)
            {
                Pessoa.transportadora = 0;
                Pessoa.fornecedor = 0;
                Pessoa.servico = 0;
                Pessoa.vendedor = 1;
            }
            else if (chkServico.Checked)
            {
                Pessoa.transportadora = 0;
                Pessoa.fornecedor = 0;
                Pessoa.servico = 1;
                Pessoa.vendedor = 0;
            }

            Pessoa.ativo = rdbSim.Checked == true ? 1 : 0;
            Pessoa.cad_status = chkCadStatus.Checked == true ? 1 : 0;

            Pessoa.obs = txtObs.Text;

            if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                Pessoa.Gravar();
            }
            else if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                Pessoa.id_pessoa = Codigo;
                Pessoa.Alterar();
            }

            MessageBox.Show("Registro gravado com sucesso", this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnGravar.Enabled = false;
        }

        private void tabOutros_Enter(object sender, EventArgs e)
        {
            // Outros Dados
            //cmbGrupoEco.Enabled = ((!chkVendedor.Checked) && (!chkFornecedor.Checked) && (!chkTransp.Checked));
        }

        private void tabEndEntrega_Enter(object sender, EventArgs e)
        {
            // Endereço de Entrega
            txtEndereco_LE.Enabled   = ((!chkVendedor.Checked) && (!chkFornecedor.Checked) && (!chkTransp.Checked));
            txtReferencia_LE.Enabled = ((!chkVendedor.Checked) && (!chkFornecedor.Checked) && (!chkTransp.Checked));
            txtBairro_LE.Enabled     = ((!chkVendedor.Checked) && (!chkFornecedor.Checked) && (!chkTransp.Checked));
            txtCep_LE.Enabled        = ((!chkVendedor.Checked) && (!chkFornecedor.Checked) && (!chkTransp.Checked));
            cmbCidade_LE.Enabled     = ((!chkVendedor.Checked) && (!chkFornecedor.Checked) && (!chkTransp.Checked));
            cmbUf_LE.Enabled         = ((!chkVendedor.Checked) && (!chkFornecedor.Checked) && (!chkTransp.Checked));

            chkMLE_CheckedChanged(sender, e);
        }

        private void chkMLE_CheckedChanged(object sender, EventArgs e)
        {
            // Endereço de Entrega
            txtEndereco_LE.Enabled = (!chkMLE.Checked);
            txtReferencia_LE.Enabled = (!chkMLE.Checked);
            txtBairro_LE.Enabled = (!chkMLE.Checked);
            txtCep_LE.Enabled = (!chkMLE.Checked);
            cmbCidade_LE.Enabled = (!chkMLE.Checked);
            cmbUf_LE.Enabled = (!chkMLE.Checked);
        }

        private void LimpaCont()
        {
            txtCodContato.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCargo.Text = string.Empty;
        }

        private void btnNovoCont_Click(object sender, EventArgs e)
        {
            LimpaCont();
            clDataBase clDB = new clDataBase();
            // Gera o AutoInc
            txtCodContato.Text = clDB.AutoInc("CONTATOS").ToString();
            txtNome.Focus();
            btnNovoCont.Enabled = false;
            btnGravarCont.Enabled = true;
            this.Op_cont = Op_Contato.Inclusao;
        }

        private void btnGravarCont_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(string.Empty))
            {
                errErro.SetError(txtNome, "Campo Obrigatório! Digite um Nome para o Contato.");
                return;
            }
            else
            {
                errErro.SetError(txtNome, "");
            }

            // Passa os parâmetros e grava
            Pessoa.nome = txtNome.Text;
            Pessoa.telefone = txtTelefone.Text;
            Pessoa.fax = txtFax.Text;
            Pessoa.celular = txtCelular.Text;
            Pessoa.email = txtEmail.Text;
            Pessoa.cargo = txtCargo.Text;
            Pessoa.id_pessoa = Convert.ToInt32(txtCodigo.Text);
            if (Op_cont == Op_Contato.Inclusao)
            {
                Pessoa.IncContato();
            }
            else
            {
                Pessoa.id_contato = Convert.ToInt32(txtCodContato.Text);
                Pessoa.AltContato();
            }

            MessageBox.Show("Registro gravado com sucesso", this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            tabContatos_Enter(sender, e);
            btnNovoCont.Enabled = true;
            btnGravarCont.Enabled = false;
            btnExcluirCont.Enabled = false;
            LimpaCont();
        }

        private void gridContatos_DoubleClick(object sender, EventArgs e)
        {
            this.Op_cont = Op_Contato.Alteracao;
            SqlDataReader drDados;
            drDados = Pessoa.AcharContato(Convert.ToInt32(gridContatos.CurrentRow.Cells[0].Value));
            if (drDados.HasRows)
            {
                drDados.Read();
                txtCodContato.Text = drDados["id_contato"].ToString();
                txtNome.Text = drDados["nome"].ToString();
                txtTelefone.Text = drDados["telefone"].ToString();
                txtFax.Text = drDados["fax"].ToString();
                txtCelular.Text = drDados["celular"].ToString();
                txtEmail.Text = drDados["email"].ToString();
                txtCargo.Text = drDados["cargo"].ToString();
            }
            btnNovoCont.Enabled = false;
            btnGravarCont.Enabled = true;
            btnExcluirCont.Enabled = true;
            txtNome.Focus();
        }

        private void btnExcluirCont_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja excluir o registro?", this.Text,
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No))
            {
                return;
            }
            Pessoa.ExcContato(Convert.ToInt32(txtCodContato.Text));
            MessageBox.Show("Registro excluído com sucesso", this.Text,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabContatos_Enter(sender, e);
            LimpaCont();
            btnNovoCont.Enabled = true;
            btnGravarCont.Enabled = false;
            btnExcluirCont.Enabled = false;
        }

        private void Limpa_Campos()
        {
            // Limpa os Campos
            // Dados
            txtLimCred.Text = "0";
            txtRazaoSocial.Text = string.Empty;
            txtFantasia.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtReferencia.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCep.Text = string.Empty;
            cmbCidade.SelectedIndex = -1;
            cmbUf.Text = "PA";
            rdbFisica.Checked = false;
            rdbJuridica.Checked = false;
            txtCnpj.Text = string.Empty;
            txtIE.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtRg.Text = string.Empty;
            txtOrgaoRg.Text = string.Empty;
            chkFornecedor.Checked = false;
            chkVendedor.Checked = false;
            chkTransp.Checked = false;
            chkMLE.Checked = false;
            chkCadStatus.Checked = false;
            rdbSim.Checked = true; //Ativo
            rdbNao.Checked = false; //Inativo
            txtObs.Text = string.Empty;
            // Outros Dados
            cmbFrete_C.Text = "CIF";
            cmbFrete_F.Text = "CIF";
            txtQtdDias_C.Value = 0;
            txtQtdDias_F.Value = 0;
            // Local Entrega
            txtEndereco_LE.Text = string.Empty;
            txtReferencia_LE.Text = string.Empty;
            txtBairro_LE.Text = string.Empty;
            txtCep_LE.Text = string.Empty;
            cmbCidade_LE.SelectedIndex = -1;
            cmbUf_LE.Text = "PA";
        }

        private void txtLimCred_Leave(object sender, EventArgs e)
        {
            decimal vlr;
            vlr = Convert.ToDecimal(txtLimCred.Text);
            txtLimCred.Text = vlr.ToString("#,##0");
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            string SemPonto;
            SemPonto = txtCnpj.Text.Replace(".", "");
            SemPonto = SemPonto.Replace("/", "");
            SemPonto = SemPonto.Replace("-", "");

            if (!Pessoa.valida_cnpj_cpf(SemPonto))
            {
                MessageBox.Show("CNPJ Inválido! Faça a correção pra prosseguir.", "Validação de CNPJ");
                txtCnpj.Focus();
            }
            else
            {
                if (Operacao == clFuncoesGerais.Operacao.Inclusao)
                {
                    short Existe = Pessoa.LocCnpj_Cpf(txtCnpj.Text, 1);
                    if (Existe > 0)
                    {
                        MessageBox.Show("CNPJ já cadastrador! Verifique o cadastro.", this.Text);
                        txtCnpj.Focus();
                    }
                }
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            string SemPonto;
            SemPonto = txtCpf.Text.Replace(".", "");
            SemPonto = SemPonto.Replace("-", "");

            if (!Pessoa.valida_cnpj_cpf(SemPonto))
            {
                MessageBox.Show("CPF Inválido! Faça a correção pra prosseguir.", "Validação de CPF");
                txtCpf.Focus();
            }
            else
            {
                if (Operacao == clFuncoesGerais.Operacao.Inclusao)
                {
                    short Existe = Pessoa.LocCnpj_Cpf(txtCpf.Text, 2);
                    if (Existe > 0)
                    {
                        MessageBox.Show("CPF já cadastrado! Verifique o Cadastro.", "Validação de CPF");
                        txtCpf.Focus();
                    }
                }
            }
        }

        private void linkCNPJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void linkCPF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void chkServico_CheckedChanged(object sender, EventArgs e)
        {
            if (chkServico.Checked)
            {
                chkFornecedor.Checked = false;
                chkTransp.Checked = false;
                chkServico.Checked = true;
                chkMLE.Checked = true;
            }
            gpbForn.Enabled = (!chkVendedor.Checked);
            gpbCli.Enabled = (!chkVendedor.Checked);
        }
    }
}


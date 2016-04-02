using System;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Globais.NumeroExtenso;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Modelos;
using PPDotNet.Formulários.Cadastros;
using PPDotNet.DataSources;

namespace PPDotNet.Formulários.Saída
{
    public partial class frmSaida : frmModeloCadastro
    {
        private short Status;
        private short Status_item; 
        public short Tipo;
        public int ContCar;

        //Variáveis usadas para calcular a baixa do estoque
        private short _altestoque;
        public short altestoque
        {
            get { return _altestoque; }
            set { _altestoque = value; }
        }

        private string old_nf = "";

        public frmPessoaCons locPessoa = new frmPessoaCons();
        public frmProdutoCons locProdSaida = new frmProdutoCons();
        public saida Saida = new saida();

        private clFuncoesGerais fg = new clFuncoesGerais();

        public frmSaida()
        {
            InitializeComponent();
        }

        public void frmSaida_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSaida.EMPRESA' table. You can move, or remove it, as needed.
            this.eMPRESATableAdapter.Fill(this.dsSaida.EMPRESA);
            // TODO: This line of code loads data into the 'dsSaida.Vendedor' table. You can move, or remove it, as needed.
            this.vendedorTableAdapter1.Fill(this.dsSaida.Vendedor);
            // TODO: This line of code loads data into the 'dsSaida.CFOP' table. You can move, or remove it, as needed.
            this.cFOPTableAdapter.Fill(this.dsSaida.CFOP);
            Status = 1; //Setado para gravar cabeçalho no primeiro clique do botao gravar
            Status_item = 0; //Setado para nao gravar alteração de item

            if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                Limpa_Cab();
                Limpa_Itens();
                lblTotPed.Text = "0,00";

                txtDataEmissao.Text = DateTime.Now.Date.ToShortDateString();
                clDataBase clDB = new clDataBase();
                // Gera o AutoInc
                txtCodigo.Text = clDB.AutoInc("SAIDA").ToString();

                CarregaGrid_Itens();
            }
            else if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                Limpa_Cab();
                Limpa_Itens();
                SqlDataReader drDados = Saida.Listar(Codigo);
                if (drDados.HasRows)
                {
                    drDados.Read();
                    cmbCfop.SelectedValue = drDados["cfop"].ToString();
                    txtCodCliente.Text = drDados["id_cliente"].ToString();
                    txtCodCliente_Leave(sender, e);// Carrega fantasia e forma_pag
                    txtDataEmissao.Text = drDados["data_emissao"].ToString();
                    txtCodigo.Text = drDados["id_saida"].ToString();
                    txtNotaFiscal.Text = drDados["nf"].ToString().Trim();
                    //guarda o valor antigo da NF para o caso de querer validar na alteração
                    old_nf = drDados["nf"].ToString().Trim(); 
                    cmbVendedor.SelectedValue = drDados["id_vendedor"].ToString();
                    txtObs.Text = drDados["obs"].ToString();
                    txtObs2.Text = drDados["obs2"].ToString();
                    txtSelo.Text = drDados["selo"].ToString();
                    rdbEmitente.Checked = (drDados["frete_pc"].ToString() == "1" ? true : false);
                    rdbDest.Checked = !rdbEmitente.Checked;
                    txtNomeRazao.Text = drDados["nome_razao"].ToString();
                    txtCpfCnpj.Text = drDados["cpf_cnpj"].ToString();
                    txtIE.Text = drDados["insc_estadual"].ToString();
                    txtPlaca.Text = drDados["placa"].ToString();
                    txtUFPlaca.Text = drDados["uf_placa"].ToString();
                    txtEndereco.Text = drDados["endereco"].ToString();
                    txtMunicipio.Text = drDados["municipio"].ToString();
                    txtUF.Text = drDados["uf"].ToString();
                    txtQtdTransp.Text = drDados["qtd_transp"].ToString();
                    txtEspecie.Text = drDados["especie"].ToString();
                    cmbEmpresa.SelectedValue = Convert.ToInt32(drDados["empresa"].ToString());

                    CarregaGrid_Itens();

                    if (gridItens.RowCount > 0)
                    {
                        decimal vlr;
                        vlr = Convert.ToDecimal(Saida.Total_Pedido(int.Parse(txtCodigo.Text)).ToString());
                        lblTotPed.Text = vlr.ToString("#,##0.00");
                    }
                }     
            }       
        }

        private void Limpa_Cab()
        {
            // Limpa os Campos
            // Pedido
            cmbCfop.SelectedIndex = 0;
            lblOrientacao.Text = "...";
            txtCodCliente.Text = string.Empty;
            txtFantasia.Text = string.Empty;
            txtDataEmissao.Text = DateTime.Now.ToShortDateString();
            cmbVendedor.SelectedIndex = 0;
            txtObs.Text = string.Empty;
            txtObs2.Text = string.Empty;
            txtNotaFiscal.Text = string.Empty;
            txtSelo.Text = string.Empty;
            rdbEmitente.Checked = true;
            pnlFrete.Visible = rdbDest.Checked;
            txtNomeRazao.Text = string.Empty;
            txtCpfCnpj.Text = string.Empty;
            txtIE.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtUFPlaca.Text = "PA";
            txtEndereco.Text = string.Empty;
            txtMunicipio.Text = string.Empty;
            txtUF.Text = "PA";
            txtQtdTransp.Text = "0";
            txtEspecie.Text = string.Empty;
            cmbEmpresa.SelectedIndex = 0;
        }

        private void Limpa_Itens()
        {
            // Itens
            txtCodProd.Text = string.Empty;
            txtDescProd.Text = string.Empty;
            txtVlrUnitario.Text = "0,0000";
            txtQtd.Text = "1";
            txtPerDesconto.Text = "0,0000";
            txtVlrTotal.Text = "0,0000";
            txtICMS.Text = "17,00";
            cmbUnidade.Text = "PÇ";
        }

        public void btnSair_Click ( object sender, EventArgs e )
        {
            Close();
        }

        private void txtCodCliente_Leave ( object sender, EventArgs e )
        {
            if (txtCodCliente.Text != string.Empty)
            {
                SqlDataReader drCli;
                drCli = Saida.LocCliente(Convert.ToInt32(txtCodCliente.Text));
                if (drCli.HasRows)
                {
                    drCli.Read();
                    txtFantasia.Text = drCli["fantasia"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não existe ou está Inativo!", "Localizar Cliente");
                    txtCodCliente.Focus();
                }
            }
            else
            {
                btnLocCliente_Click(sender, e);
            }
        }

        private void btnLocCliente_Click ( object sender, EventArgs e )
        {
            locPessoa.FormChamou = "Saida";
            locPessoa.FormSaida = this;
            locPessoa.ShowDialog();
            txtCodCliente.Text = Saida.id_cliente.ToString();
            SqlDataReader drCli;
            drCli = Saida.LocCliente(Convert.ToInt32(txtCodCliente.Text));
            if (drCli.HasRows)
            {
                drCli.Read();
                txtFantasia.Text = drCli["fantasia"].ToString();
            }
        }

        private void txtCodProd_Leave ( object sender, EventArgs e )
        {
            int ContMat = 0;
            int ContServ = 0;

            if (txtCodProd.Text != string.Empty)
            {
                if (Status_item == 0)
                {
                    SqlDataReader drProd;
                    drProd = Saida.LocProduto(Convert.ToInt32(txtCodProd.Text));
                    if (drProd.HasRows)
                    {
                        drProd.Read();
                        txtDescProd.Text = drProd["descricao"].ToString();
                        txtICMS.Text = drProd["aliq_icms_est"].ToString();
                        txtVlrUnitario.Text = drProd["valor_unitario"].ToString();
                        decimal vlr;
                        vlr = Convert.ToDecimal(txtVlrUnitario.Text);
                        txtVlrUnitario.Text = vlr.ToString("#,##0.00");
                        Tipo = short.Parse(drProd["tipo"].ToString());
                        txtICMS.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Produto não existe!", "Localizar Produto");
                        txtDescProd.Text = string.Empty;
                        txtCodProd.Focus();
                        return;
                    }

                    //Esse código verifica se o limite de Materiais ja foi atingido.
                    foreach (DataGridViewRow item in gridItens.Rows)
                    {
                        if (item.Cells["tipo"].Value.ToString().Trim() == "1")
                        {
                            ContMat++;
                            if (ContMat >= 30 && Tipo == 1) //Antes ContMat >= 22 para permitir somente 22 itens cadastrados
                            {
                                MessageBox.Show("O Limite para MATERIAIS é de 30 Itens!", this.Text);
                                Limpa_Itens();
                                txtCodProd.Focus();
                                return;
                            }
                        }
                        if (item.Cells["tipo"].Value.ToString().Trim() == "2")
                        {
                            ContServ++;
                            if (ContServ >= 0 && Tipo == 2 ) //Antes ContServ >= 7 para permitir somente 7 itens cadastrados
                            {
                                MessageBox.Show("O Limite para SERVIÇOS é de 7 Itens!", this.Text);
                                Limpa_Itens();
                                txtCodProd.Focus();
                                return;
                            }
                        }
                    }

                    #region Código pra evitar duplicidade de produtos - Não usado na PP
                    /*
                    //Verifica se o produto ja existe para o item
                    string id_sai;
                    string id_prod;

                    //Esse código verifica se o produto ja foi cadastrado e barra o mesmo.
                    foreach (DataGridViewRow item in gridItens.Rows)
                    {
                        id_sai = item.Cells["id_saida"].Value.ToString();
                        id_prod = item.Cells["id_produto"].Value.ToString();
                        if ((id_sai == txtCodigo.Text) && (id_prod == txtCodProd.Text))
                        {
                            MessageBox.Show("O produto JÁ EXISTE neste Pedido!", this.Text);
                            Limpa_Itens();
                            txtCodProd.Focus();
                            return;
                        }
                    }
                    */
                    #endregion
                }
                else
                {
                    SqlDataReader drProd;
                    drProd = Saida.LocProduto(Convert.ToInt32(txtCodProd.Text));
                    if (drProd.HasRows)
                    {
                        drProd.Read();
                        txtDescProd.Text = drProd["descricao"].ToString();
                        txtICMS.Text = drProd["aliq_icms_est"].ToString();
                        txtVlrUnitario.Text = drProd["valor_unitario"].ToString();
                        decimal vlr;
                        vlr = Convert.ToDecimal(txtVlrUnitario.Text);
                        txtVlrUnitario.Text = vlr.ToString("#,##0.00");
                        Tipo = short.Parse(drProd["tipo"].ToString());
                        txtICMS.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Produto não existe!", "Localizar Produto");
                        txtDescProd.Text = string.Empty;
                        txtCodProd.Focus();
                        return;
                    }

                    //Esse código verifica se o limite de Materiais/Serviços ja foi atingido.
                    foreach (DataGridViewRow item in gridItens.Rows)
                    {
                        if (item.Cells["tipo"].Value.ToString().Trim() == "1")
                        {
                            ContMat++;
                            if (ContMat >= 22 && Tipo == 1 && Status_item == 0)
                            {
                                MessageBox.Show("O Limite para MATERIAIS é de 22 Itens!", this.Text);
                                Limpa_Itens();
                                txtCodProd.Focus();
                                return;
                            }
                        }
                        if (item.Cells["tipo"].Value.ToString().Trim() == "2")
                        {
                            ContServ++;
                            if (ContServ >= 7 && Tipo == 2 && Status_item == 0)
                            {
                                MessageBox.Show("O Limite para SERVIÇOS é de 7 Itens!", this.Text);
                                Limpa_Itens();
                                txtCodProd.Focus();
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                if ((MessageBox.Show("Deseja localizar o Produto?", "Localiza Produto",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    btnLocProd_Click(sender, e);
                    if (Status_item == 0)
                    {
                        if (txtCodProd.Text != string.Empty)
                        {
                            SqlDataReader drProd;
                            drProd = Saida.LocProduto(Convert.ToInt32(txtCodProd.Text));
                            if (drProd.HasRows)
                            {
                                drProd.Read();
                                txtDescProd.Text = drProd["descricao"].ToString();
                                txtVlrUnitario.Text = drProd["valor_unitario"].ToString();
                                txtICMS.Text = drProd["aliq_icms_est"].ToString();
                                Tipo = short.Parse(drProd["tipo"].ToString());
                                txtICMS.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Produto não existe!", "Localizar Produto");
                                txtDescProd.Text = string.Empty;
                                txtCodProd.Focus();
                                return;
                            }
                        }

                        //Esse código verifica se o limite de Materiais ja foi atingido.
                        foreach (DataGridViewRow item in gridItens.Rows)
                        {
                            if (item.Cells["tipo"].Value.ToString().Trim() == "1")
                            {
                                ContMat++;
                                if (ContMat >= 22 && Tipo == 1)
                                {
                                    MessageBox.Show("O Limite para MATERIAIS é de 22 Itens!", this.Text);
                                    Limpa_Itens();
                                    txtCodProd.Focus();
                                    return;
                                }
                            }
                            if (item.Cells["tipo"].Value.ToString().Trim() == "2")
                            {
                                ContServ++;
                                if (ContServ >= 7 && Tipo == 2)
                                {
                                    MessageBox.Show("O Limite para SERVIÇOS é de 7 Itens!", this.Text);
                                    Limpa_Itens();
                                    txtCodProd.Focus();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void txtVlrUnitario_Leave ( object sender, EventArgs e )
        {
            decimal vlr;
            vlr = Convert.ToDecimal(txtVlrUnitario.Text);
            txtVlrUnitario.Text = vlr.ToString("#,##0.00");
        }

        private void txtQtd_Leave ( object sender, EventArgs e )
        {
            txtQtd.Text = string.Format("{0:##,##0.0000}", decimal.Parse(txtQtd.Text));            
            txtPerDesconto_Leave(sender, e);
        }

        private void txtPerDesconto_Leave ( object sender, EventArgs e )
        {
            decimal vlr;
            vlr = Convert.ToDecimal(txtPerDesconto.Text);
            txtPerDesconto.Text = vlr.ToString("#,##0.00");

            //Calcula o Valor Total
            decimal vlrtotal;
            decimal desconto;
            vlrtotal = (Convert.ToDecimal(txtVlrUnitario.Text) *
                       Convert.ToDecimal(txtQtd.Text));
            desconto = Convert.ToDecimal(txtPerDesconto.Text);
            desconto = ((vlrtotal * desconto) / 100);
            vlrtotal = vlrtotal - desconto;
            txtVlrTotal.Text = vlrtotal.ToString("#,##0.00");
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (cmbCfop.Text.Equals(string.Empty))
            {
                errErro.SetError(cmbCfop, "Campo Obrigatório! É obrigatório escolher uma CFOP!");
                return;
            }
            else
                errErro.SetError(cmbCfop, "");

            if (txtCodCliente.Text.Equals(string.Empty))
            {
                errErro.SetError(txtCodCliente, "Campo Obrigatório! É obrigatório escolher um cliente.");
                return;
            }
            else
                errErro.SetError(txtCodCliente, "");

            if (txtICMS.Text.Equals(string.Empty))
            {
                errErro.SetError(txtICMS, "Campo Obrigatório!");
                return;
            }
            else
                errErro.SetError(txtICMS, "");

            #region Cabeçalho
            Saida.id_cliente = Convert.ToInt16(txtCodCliente.Text);
            Saida.cfop = cmbCfop.SelectedValue.ToString();
            Saida.data_emissao = Convert.ToDateTime(txtDataEmissao.Text);
            Saida.nf = txtNotaFiscal.Text;
            Saida.id_vendedor = Convert.ToInt16(cmbVendedor.SelectedValue);
            Saida.obs = txtObs.Text;
            Saida.obs2 = txtObs2.Text;
            Saida.selo = txtSelo.Text;
            Saida.frete_pc = Convert.ToInt16((rdbEmitente.Checked == true ? 1 : 2));
            Saida.nome_razao = txtNomeRazao.Text;
            Saida.cpf_cnpj = txtCpfCnpj.Text;
            Saida.insc_estadual = txtIE.Text;
            Saida.placa = txtPlaca.Text;
            Saida.uf_placa = txtUFPlaca.Text;
            Saida.endereco = txtEndereco.Text;
            Saida.municipio = txtMunicipio.Text;
            Saida.uf = txtUF.Text;
            Saida.qtd_transp = short.Parse(txtQtdTransp.Text);
            Saida.especie = txtEspecie.Text;
            Saida.empresa = Convert.ToInt32(cmbEmpresa.SelectedValue.ToString());

            #endregion

            #region Item do Pedido
            if (txtCodProd.Text != string.Empty)
            {
                Saida.id_saida = Convert.ToInt32(txtCodigo.Text);
                Saida.id_produto = Convert.ToInt32(txtCodProd.Text);
                Saida.quantidade = Convert.ToDecimal(txtQtd.Text);
                Saida.valor_unitario = Convert.ToDecimal(txtVlrUnitario.Text);
                Saida.per_desconto = Convert.ToDecimal(txtPerDesconto.Text);
                Saida.valor_total = Convert.ToDecimal(txtVlrTotal.Text);
                Saida.icms = Convert.ToDecimal(txtICMS.Text);
                Saida.unidade = cmbUnidade.Text.Trim();
            }
            #endregion

            if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                if (Status == 1)
                {
                    Saida.Gravar();
                    // Recupera o ID do pedido na primeira gravação
                    txtCodigo.Text = Saida.id_saida.ToString();
                    Status = 0; //Grava somente itens
                }
                else
                    Saida.Alterar(); //Apenas para alterar o cabeçalho antes de sair de um novo pedido

                if (Status_item == 0)
                {
                    if (txtCodProd.Text != string.Empty)
                        Saida.Gravar_Itens();
                }
                else
                {
                    if (txtCodProd.Text != string.Empty)
                    {
                        Saida.id_item = Convert.ToInt32(gridItens.CurrentRow.Cells[6].Value);
                        Saida.Alterar_Itens();
                        Status_item = 0;
                    }
                }
            }
            else if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                if (Status == 1) //Gravar cabeçalho primeira vez
                {
                    Saida.id_saida = Codigo;
                    Saida.Alterar();
                    Status = 0; //Grava somente itens
                    if (Status_item == 1)
                    {
                        Saida.id_item = Convert.ToInt32(gridItens.CurrentRow.Cells[6].Value);
                        if (txtCodProd.Text != string.Empty)
                            Saida.Alterar_Itens();
                        Status_item = 0;
                    }
                    else
                    {
                        if (txtCodProd.Text != string.Empty)
                            Saida.Gravar_Itens();
                    }
                }
                else
                {
                    if (Status_item == 1)
                    {
                        Saida.id_item = Convert.ToInt32(gridItens.CurrentRow.Cells[6].Value);
                        if (txtCodProd.Text != string.Empty)
                            Saida.Alterar_Itens();
                        Status_item = 0;
                    }
                    else
                    {
                        if (txtCodProd.Text != string.Empty)
                        {
                            Saida.Gravar_Itens();
                        }
                    }
                }
            }

            CarregaGrid_Itens();
            if (gridItens.RowCount > 0)
            {
                decimal vlr;
                vlr = Convert.ToDecimal(Saida.Total_Pedido(int.Parse(txtCodigo.Text)).ToString());
                lblTotPed.Text = vlr.ToString("#,##0.00");
            }

            Limpa_Itens();
            txtObs2.Focus();
        }

        private void CarregaGrid_Itens()
        {
            if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                Saida.id_saida = Convert.ToInt32(txtCodigo.Text);
            }
            gridItens.DataSource = Saida.Achar_Itens().Tables[0];

            //id_produto
            gridItens.Columns[0].HeaderText = "Cód.Prod";
            gridItens.Columns[0].Name = "id_produto";
            gridItens.Columns[0].Width = 70;

            gridItens.Columns[1].HeaderText = "Descrição Produto";
            gridItens.Columns[1].Name = "descricao";
            gridItens.Columns[1].Width = 335;

            gridItens.Columns[2].HeaderText = "Qtd";
            gridItens.Columns[2].Name = "quantidade";
            gridItens.Columns[2].Width = 70;
            gridItens.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridItens.Columns[2].DefaultCellStyle.Format = "N4";

            gridItens.Columns[3].HeaderText = "Vlr Unit.";
            gridItens.Columns[3].Name = "valor_unitario";
            gridItens.Columns[3].Width = 80;
            gridItens.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            gridItens.Columns[4].HeaderText = "% Desc.";
            gridItens.Columns[4].Name = "per_desconto";
            gridItens.Columns[4].Width = 80;
            gridItens.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridItens.Columns[4].DefaultCellStyle.Format = "N4";

            gridItens.Columns[5].HeaderText = "Vlr Total";
            gridItens.Columns[5].Name = "valor_total";
            gridItens.Columns[5].Width = 80;
            gridItens.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridItens.Columns[5].DefaultCellStyle.Format = "N2";
            
            //Essas colunas nao aparecem no grid
            //id_item
            gridItens.Columns[6].Visible = false;
            //id_saida
            gridItens.Columns[7].Visible = false;
            //icms
            gridItens.Columns[8].Visible = false;
            //tipo
            gridItens.Columns[9].Visible = false;

            this.Zebra_Grid(gridItens);
        }

        private void txtICMS_Leave(object sender, EventArgs e)
        {
            if (txtICMS.Text != string.Empty)
            {
                decimal vlr;
                vlr = Convert.ToDecimal(txtICMS.Text);
                txtICMS.Text = vlr.ToString("#,##0.00");
            }
            else
                txtICMS.Text = "0";
        }

        private void btnLocProd_Click(object sender, EventArgs e)
        {
            locProdSaida.FormChamou = "Saida";
            locProdSaida.FormSaida = this;
            locProdSaida.ShowDialog();
            txtCodProd.Text = Saida.id_produto.ToString();
            txtCodProd.Focus();
        }

        private void gridItens_DoubleClick(object sender, EventArgs e)
        {
            Limpa_Itens();
            SqlDataReader drItens;
            drItens = Saida.Listar_Itens(Convert.ToInt32(gridItens.CurrentRow.Cells[6].Value));
            if (drItens.HasRows)
            {
                Status_item = 1;
                drItens.Read();
                txtCodProd.Text = drItens["id_produto"].ToString();
                txtCodProd_Leave(sender, e);
                txtICMS.Text = drItens["icms"].ToString();
                txtICMS_Leave(sender,e);
                cmbUnidade.Text = drItens["unidade"].ToString();
                txtVlrUnitario.Text = drItens["valor_unitario"].ToString();
                txtVlrUnitario_Leave(sender, e);
                txtQtd.Text = drItens["quantidade"].ToString();
                txtPerDesconto.Text = drItens["per_desconto"].ToString();
                txtPerDesconto_Leave(sender, e);
                txtVlrTotal.Text = drItens["valor_total"].ToString();
                txtVlrTotal_Leave(sender, e);
                txtICMS.Focus();
            }
        }

        private void txtVlrTotal_Leave(object sender, EventArgs e)
        {
            decimal vlr;
            vlr = Convert.ToDecimal(txtVlrTotal.Text);
            txtVlrTotal.Text = vlr.ToString("#,##0.00");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (gridItens.Rows.Count > 0)
            {
                if ((MessageBox.Show("Deseja excluir o Item Selecionado?", "Item do Produto",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
                {
                    Saida.Excluir_Itens(Convert.ToInt32(gridItens.CurrentRow.Cells[6].Value));
                    MessageBox.Show("Item excluído com sucesso", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpa_Itens();
                    CarregaGrid_Itens();
                    if (gridItens.RowCount > 0)
                    {
                        decimal vlr;
                        vlr = Convert.ToDecimal(Saida.Total_Pedido(int.Parse(txtCodigo.Text)).ToString());
                        lblTotPed.Text = vlr.ToString("#,##0.00");
                    }
                }
            }
        }
        
        private void txtNotaFiscal_Leave(object sender, EventArgs e)
        {
            if (txtNotaFiscal.Text != string.Empty)
            {
                txtNotaFiscal.Text = string.Format("{0:##,##0}", decimal.Parse(txtNotaFiscal.Text));

                if (!txtNotaFiscal.Text.Equals(old_nf.Trim()))
                {
                    SqlDataReader drLocNF;
                    drLocNF = Saida.LocNF(txtNotaFiscal.Text);
                    if (drLocNF.HasRows)
                    {
                        MessageBox.Show("Nota Fiscal já utilizada!", "Nota Fiscal");
                        txtNotaFiscal.Focus();
                    }
                }
            }
        }

        private void txtVlrTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnGravar_Click(sender, e);
        }

        private void cmbCfop_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOrientacao.Text = string.Empty;
            foreach (DataRow cfopOrient in dsSaida.CFOP)
            {
                if (cfopOrient["id_cfop"].ToString() == Convert.ToString(cmbCfop.SelectedValue))
                {
                    lblOrientacao.Text = cfopOrient["descricao"].ToString();
                }
            }             
        }

        private void txtCodCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 121)
                btnLocCliente_Click(sender, e);
        }

        private void txtCodProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 121)
                btnLocProd_Click(sender, e);
        }

        private void Vlr_Unit_Normal()
        {
//            vlr_unit = drVlrEmb["valor"].ToString();
//            txtVlrUnitario.Text = string.Format("{0:##,##0.0000}", vlr_unit);
        }

        private void frmSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SelectNextControl(sender as Control, true, true, true, true);
        }

        private void txtDataEmissao_Leave(object sender, EventArgs e)
        {
            if (txtDataEmissao.Value.Month != DateTime.Now.Month)
                MessageBox.Show("O MÊS da Data é diferente do Mês Corrente!", "Validação de Data", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public void Cancelar_Pedido()
        {
            Saida.Muda_Sit_Ped(int.Parse(txtCodigo.Text), 2);
            // Atualiza as informações de tela
            btnGravar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNotaFiscal.Enabled = false;
        }

        public void btnPedido_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Confirma a impressão do Pedido?", "Impressão do Pedido",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
            {
                btnGravar_Click(sender, e);

                Decimal vlr;
                string dataConv;
                string semAcento;

                ImprimeTexto imp = new ImprimeTexto();

                SqlDataReader drImpPedido;
                drImpPedido = Saida.Imp_Pedido(Saida.id_saida);
                if (drImpPedido.HasRows)
                {
                    drImpPedido.Read();
                    if (imp.Inicio("\\\\marcello\\EpsonLX-300"))
                    {
                        //Cabeçalho
                        imp.Imp(imp.Normal);
                        imp.Pula(1);
                        imp.ImpColLF(02, "ADRIMAR ESCRITORIOS E INFORMATICA LTDA-EPP - 04.784.302/0001-59");
                        imp.ImpColLF(02, "Rua Riachuelo, 294 - Campina - Belem - PA");
                        imp.ImpColLF(02, "Fone: (91) 3212-7275 / 3222-6115");
                        imp.Imp(imp.NegritoOn);
                        imp.ImpColLF(02, "Pedido de Venda No.: " + drImpPedido["id_saida"].ToString());
                        imp.Imp(imp.NegritoOff);
                        imp.ImpColLF(02, "".PadLeft(78, '='));

                        //Dados Cliente/Pedido
                        semAcento = "Cliente: " + fg.remove_acentos(drImpPedido["cliente"].ToString().ToUpper());
                        imp.ImpColLF(02, semAcento);
                        semAcento = "Fantasia: " + fg.remove_acentos(drImpPedido["fantasia"].ToString().ToUpper());
                        imp.Imp(imp.NegritoOn);
                        imp.ImpCol(02, semAcento);
                        imp.Imp(imp.NegritoOff);
                        dataConv = "Dt.Pedido: " + Convert.ToDateTime(drImpPedido["data_emissao"].ToString()).ToShortDateString();
                        imp.ImpColLF(59, dataConv);
                        semAcento = fg.remove_acentos(drImpPedido["endereco_le"].ToString().ToUpper());
                        semAcento += " - " + fg.remove_acentos(drImpPedido["bairro_le"].ToString().ToUpper());
                        semAcento += " - " + fg.remove_acentos(drImpPedido["cidade_le"].ToString().ToUpper());
                        semAcento += " - " + drImpPedido["uf_le"].ToString();
                        imp.ImpColLF(02, semAcento);
                        semAcento = "CNPJ/CPF: " + drImpPedido["cnpj_cpf"].ToString();
                        semAcento += " - IE/RG: " + drImpPedido["ie_rg"].ToString();
                        semAcento += " - Telefone: " + drImpPedido["telefone"].ToString();
                        imp.ImpColLF(02, semAcento);
                        semAcento = "Referencia: " + fg.remove_acentos(drImpPedido["referencia_le"].ToString().ToUpper());
                        imp.ImpColLF(02, semAcento);
                        imp.ImpColLF(02, "".PadLeft(78, '='));
                        imp.Pula(1);

                        /*
                         * *********** ITENS ************
                         */
                        SqlDataReader drImpItensPedido;
                        drImpItensPedido = Saida.Imp_Pedido(Saida.id_saida);
                        int Ln = 0;
                        imp.Imp(imp.Comprimido);
                        while (drImpItensPedido.Read())
                        {
                            imp.ImpCol(05, drImpItensPedido["id_produto"].ToString());
                            semAcento = fg.remove_acentos(drImpItensPedido["descricao"].ToString());

                            if (semAcento.Length <= 60)
                                ContCar = 1;
                            if (semAcento.Length > 60 && semAcento.Length <= 120)
                                ContCar = 2;
                            if (semAcento.Length > 120 && semAcento.Length <= 180)
                                ContCar = 3;
                            if (semAcento.Length > 180 && semAcento.Length <= 240)
                                ContCar = 4;
                            if (semAcento.Length > 240 && semAcento.Length <= 300)
                                ContCar = 5;
                            if (semAcento.Length > 300 && semAcento.Length <= 360)
                                ContCar = 6;
                            if (semAcento.Length > 360 && semAcento.Length <= 420)
                                ContCar = 7;
                            if (semAcento.Length > 420 && semAcento.Length <= 480)
                                ContCar = 8;
                            if (semAcento.Length > 480)
                                ContCar = 9;

                            int Ini = 0;

                            if (ContCar == 1)
                            {
                                imp.ImpCol(15, semAcento);
                            }
                            else
                            {
                                for (int i = 0; i < ContCar; i++)
                                {
                                    if (i < (ContCar - 1))
                                    {
                                        imp.ImpCol(15, semAcento.Substring(Ini, 60));
                                        imp.Pula(1);
                                    }
                                    else
                                    {
                                        imp.ImpCol(15, semAcento.Substring(Ini, semAcento.Length - Ini));
                                    }

                                    Ini = Ini + 60;
                                }
                            }

                            vlr = Convert.ToDecimal(drImpItensPedido["quantidade"].ToString());
                            imp.ImpCol(65, vlr.ToString("#,##0.0000").PadLeft(12, ' '));
                            vlr = Convert.ToDecimal(drImpItensPedido["valor_unitario"].ToString());
                            imp.ImpCol(90, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                            imp.ImpCol(113, drImpItensPedido["per_desconto"].ToString());
                            vlr = Convert.ToDecimal(drImpItensPedido["total_item"].ToString());
                            imp.ImpColLF(118, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                            Ln++;
                        }
                        Ln = 20 - Ln;
                        // ************ RODAPÉ ************ //
                        SqlDataReader drImpNFTot;
                        drImpNFTot = Saida.Imp_NF_Totais(Saida.id_saida);
                        if (drImpNFTot.HasRows)
                        {
                            imp.Imp(imp.Normal);
                            imp.Imp(imp.NegritoOn);
                            drImpNFTot.Read();
                            imp.Pula(Ln + 1);
                            vlr = Convert.ToDecimal(drImpNFTot["total_nf"].ToString());
                            imp.ImpCol(53, "TOTAL PEDIDO: " + vlr.ToString("#,##0.00").TrimEnd());
                            imp.Pula(1);
                            imp.Imp(imp.NegritoOff);
                            imp.ImpColLF(02, "".PadLeft(78, '='));
                            semAcento = fg.remove_acentos(drImpPedido["obs_nf"].ToString());
                            imp.ImpColLF(02, "OBS.: " + semAcento);
                            imp.Pula(1);
                            imp.ImpCol(02, "Recebido e Conferido por_______________________________ em ___/___/_____");
                            imp.Pula(3);
                            imp.ImpColLF(02, "Assinatura: ______________________________");
                            imp.ImpCol(02, "".PadLeft(78, '='));
                        }

                        imp.Eject();
                        imp.Fim();
                        MessageBox.Show("Enviado para a Impressora!", "Impressão do Pedido");
                    }
                    else
                    {
                        MessageBox.Show("Erro na Impressora. Verifique a conexão!", "Impressão do Pedido");
                    }
                }
            }
        }

        public void btnNotaFiscal_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Confirma a impressão da Nota Fiscal?", "Nota Fiscal",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
            {
                btnGravar_Click(sender, e);

                Decimal vlr;
                string dataConv;
                string semAcento;
                //short Sub = 0;

                ImprimeTexto imp = new ImprimeTexto();

                SqlDataReader drImpNF;
                drImpNF = Saida.Imp_NF(Saida.id_saida);
                if (drImpNF.HasRows)
                {
                    drImpNF.Read();
                    if (imp.Inicio(@"\\PP02\LX300"))
                    {
                        {
                            #region *********** Cabeçalho Nota ***********
                            imp.Imp(imp.Comprimido);
                            //imp.Pula(2);
                            //imp.Imp(imp.NegritoOn);
                            //imp.ImpCol(52, "XX"); // Marca um X no campo SAÍDA
                            //imp.Imp(imp.NegritoOff);
                            imp.Pula(6);
                            semAcento = fg.remove_acentos(drImpNF["desc_cfop"].ToString());
                            imp.ImpCol(7, semAcento);
                            imp.ImpCol(35, drImpNF["id_cfop"].ToString());
                            imp.Pula(2);
                            semAcento = fg.remove_acentos(drImpNF["razao_social"].ToString().ToUpper());
                            imp.ImpCol(7, semAcento);
                            imp.ImpCol(94, drImpNF["cpf_cnpj"].ToString());
                            dataConv = Convert.ToDateTime(drImpNF["data_emissao"].ToString()).ToShortDateString();
                            imp.ImpCol(121, dataConv);
                            imp.Pula(1);
                            semAcento = fg.remove_acentos(drImpNF["endereco"].ToString().ToUpper());
                            imp.ImpCol(7, semAcento);
                            semAcento = fg.remove_acentos(drImpNF["bairro"].ToString().ToUpper());
                            imp.ImpCol(75, semAcento);
                            imp.ImpCol(101, drImpNF["cep"].ToString());
                            imp.Pula(2);
                            semAcento = fg.remove_acentos(drImpNF["cidade"].ToString().ToUpper());
                            imp.ImpCol(7, semAcento);
                            imp.ImpCol(63, drImpNF["telefone"].ToString());
                            imp.ImpCol(88, drImpNF["uf"].ToString());
                            imp.ImpCol(95, drImpNF["ie"].ToString());
                            imp.Pula(3);
                            #endregion

                            int Ln = 0;
                            //Impressão de Materiais
                            SqlDataReader drImpItensNF;
                            drImpItensNF = Saida.Imp_NF(Saida.id_saida, 1);
                            imp.Imp(imp.Comprimido);
                            if (drImpItensNF.HasRows)
                            {
                                while (drImpItensNF.Read())
                                {
                                    imp.ImpCol(7, drImpItensNF["id_produto"].ToString());
                                    semAcento = fg.remove_acentos(drImpItensNF["descricao"].ToString());
                                    imp.ImpCol(14, semAcento); //Se o campo for > 60 deve-se comentar essa linha e descomentar o codigo abaixo

                                    imp.ImpCol(77, "00");
                                    semAcento = fg.remove_acentos(drImpItensNF["unidade"].ToString().Trim());
                                    imp.ImpCol(83, semAcento);
                                    vlr = Convert.ToDecimal(drImpItensNF["quantidade"].ToString());
                                    imp.ImpCol(90, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                                    vlr = Convert.ToDecimal(drImpItensNF["valor_unitario"].ToString());
                                    imp.ImpCol(101, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                                    vlr = Convert.ToDecimal(drImpItensNF["total_item"].ToString());
                                    imp.ImpCol(116, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                                    imp.ImpColLF(129, "**".PadLeft(5, ' '));

                                    Ln++;
                                }
                            }

                            //Imprime o Total de Descontos. Se for ZERO imprime em branco so pra manter a linha
                            decimal Tot_Desc = 0;
                            SqlDataReader drImpTotDescNF;
                            drImpTotDescNF = Saida.Tot_Desc_NF(Saida.id_saida, 1);
                            drImpTotDescNF.Read();
                            Tot_Desc = decimal.Parse(drImpTotDescNF["total_desc"].ToString());
                            if (Tot_Desc > 0)
                            {
                                vlr = Convert.ToDecimal(drImpTotDescNF["total_desc"].ToString());
                                imp.ImpCol(90, "TOTAL DO DESCONTO: ");
                                imp.ImpCol(116, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                                Ln++;
                            }
                            else
                            {
                                vlr = Convert.ToDecimal(drImpTotDescNF["total_desc"].ToString());
                                imp.ImpCol(90, "");
                                Ln++;
                            }

                            Ln = 30 - Ln; //Ln = 23 - Ln;

                            # region Impressão de Serviços
                            SqlDataReader drImpItensNF_S;
                            drImpItensNF_S = Saida.Imp_NF(Saida.id_saida, 2);
                            decimal Tot_Serv = 0;
                            decimal Tot_ISS = 0;
                            if (drImpItensNF_S.HasRows)
                            {
                                imp.Pula(Ln + 4);
                                Ln = 7;
                                imp.Imp(imp.Comprimido);

                                while (drImpItensNF_S.Read())
                                {
                                    imp.ImpCol(7, drImpItensNF_S["id_produto"].ToString());
                                    semAcento = fg.remove_acentos(drImpItensNF_S["descricao"].ToString());
                                    imp.ImpCol(13, semAcento);
                                    imp.ImpCol(81, drImpItensNF_S["unidade"].ToString());
                                    vlr = Convert.ToDecimal(drImpItensNF_S["quantidade"].ToString());
                                    imp.ImpCol(88, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                                    vlr = Convert.ToDecimal(drImpItensNF_S["valor_unitario"].ToString());
                                    imp.ImpCol(99, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                                    vlr = Convert.ToDecimal(drImpItensNF_S["total_item"].ToString());
                                    imp.ImpCol(115, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                                    vlr = Convert.ToDecimal(drImpItensNF_S["ICMS"].ToString());
                                    imp.ImpColLF(130, vlr.ToString("#,##0.00").PadLeft(5, ' '));

                                    Tot_Serv = Tot_Serv + Convert.ToDecimal(drImpItensNF_S["total_item"].ToString());

                                    Tot_ISS = Tot_ISS + Convert.ToDecimal(drImpItensNF_S["TOTAL_ICMS"].ToString());

                                    Ln--;
                                }

                                //Imprime a base de calculo do ISS se houver
                                if (Tot_ISS > 0)
                                {
                                    imp.Imp(imp.Normal);
                                    imp.Imp(imp.NegritoOn);
                                    imp.Pula(Ln + 1);
                                    imp.ImpCol(25, Tot_Serv.ToString("#,##0.00").PadLeft(12, ' '));
                                    imp.ImpCol(45, Tot_ISS.ToString("#,##0.00").PadLeft(12, ' '));
                                    imp.ImpCol(65, Tot_Serv.ToString("#,##0.00").PadLeft(12, ' '));
                                }
                                else
                                {
                                    imp.Imp(imp.Normal);
                                    imp.Imp(imp.NegritoOn);
                                    imp.Pula(Ln + 1);
                                    imp.ImpCol(25, "");
                                }
                                Ln = 2;
                            }
                            else
                                Ln = Ln + 2; //Ln = Ln + 14;

                            #endregion

                            #region ************ RODAPÉ ************
                            SqlDataReader drImpNFTot;
                            drImpNFTot = Saida.Imp_NF_Totais(Saida.id_saida);
                            imp.Imp(imp.Normal);
                            imp.Imp(imp.NegritoOn);
                            drImpNFTot.Read();
                            imp.Pula(Ln);

                            //vlr = Convert.ToDecimal(drImpNFTot["base_icms"].ToString());
                            //imp.ImpCol(03, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                            //vlr = Convert.ToDecimal(drImpNFTot["total_icms"].ToString());
                            //imp.ImpCol(19, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                            //imp.ImpCol(35, "0,00".PadLeft(12, ' '));
                            //imp.ImpCol(48, "0,00".PadLeft(12, ' '));
                            vlr = Convert.ToDecimal(drImpNFTot["total_nf"].ToString());
                            vlr = vlr - Tot_Serv; //Deduz o desconto se houver, e os Serviços se houverem
                            imp.ImpCol(65, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                            imp.Pula(2);
                            //imp.ImpCol(03, "0,00".PadLeft(12, ' '));
                            //imp.ImpCol(19, "0,00".PadLeft(12, ' '));
                            //imp.ImpCol(35, "0,00".PadLeft(12, ' '));
                            //imp.ImpCol(48, "0,00".PadLeft(12, ' '));
                            vlr = Convert.ToDecimal(drImpNFTot["total_nf"].ToString());
                            //vlr = vlr - Tot_Desc;
                            imp.ImpCol(65, vlr.ToString("#,##0.00").PadLeft(12, ' '));
                            imp.Imp(imp.NegritoOff);

                            imp.Pula(2);

                            if (drImpNF["frete_pc"].ToString() == "1")
                            {
                                imp.ImpCol(5, "O MESMO");
                                imp.ImpCol(53, "1");
                                imp.Pula(4);
                                imp.Imp(imp.NegritoOn);
                            }
                            else
                            {
                                #region destinatario
                                imp.Imp(imp.Comprimido);
                                semAcento = fg.remove_acentos(drImpNF["nome_razao"].ToString());
                                imp.ImpCol(5, semAcento);
                                imp.ImpCol(70, "2");
                                imp.ImpCol(78, drImpNF["placa"].ToString());
                                imp.ImpCol(102, drImpNF["uf_placa"].ToString());
                                imp.ImpCol(113, drImpNF["cpf_cnpj_transp"].ToString());
                                imp.Pula(2);
                                semAcento = fg.remove_acentos(drImpNF["endereco_transp"].ToString());
                                imp.ImpCol(5, semAcento);
                                imp.ImpCol(60, drImpNF["municipio"].ToString());
                                imp.ImpCol(102, drImpNF["uf_transp"].ToString());
                                imp.ImpCol(113, drImpNF["insc_estadual"].ToString());
                                imp.Pula(1);
                                imp.ImpCol(5, drImpNF["qtd_transp"].ToString());
                                imp.ImpCol(20, drImpNF["especie"].ToString());
                                imp.Pula(2);
                                imp.Imp(imp.NegritoOn);
                                #endregion
                            }
                            // imp.ImpCol(1, "Pedido No.: " + drImpNF["seu_pedido"].ToString());
                            imp.Imp(imp.NegritoOff);
                            imp.Pula(2);
                            imp.Imp(imp.Comprimido);
                            imp.ImpColLF(10, "ESTA EMPRESA ESTA CADASTRADA NO SIMPLES NACIONAL,");
                            imp.ImpCol(10,   "CONFORME LEI COMPLEMENTAR No.123 DE 2006");
                            imp.Imp(imp.Normal);
                            imp.Imp(imp.NegritoOn);
                            dataConv = Convert.ToDateTime(drImpNF["data_emissao"].ToString()).ToShortDateString();
                            imp.ImpCol(60, dataConv);
//                            imp.ImpCol(55, DateTime.Now.ToShortDateString()); "agora imprimi a data de emissao ao inves da data do dia"     
                            imp.Pula(1);
                            imp.ImpCol(60, drImpNF["selo"].ToString());     
                            imp.Imp(imp.NegritoOff);
                            imp.Imp(imp.Comprimido);
                            //{
                            //    imp.ImpColLF(3, "Empresa optante pelo Simples Federal");
                            //    imp.ImpCol(3,   "Nota nao gera credito fiscal");
                            //    imp.Pula(1);
                            //}
                            //if (Sub == 1)
                            //{
                                //imp.ImpColLF(3, "** ITENS COM SUBSTITUICAO TRIBUTARIA");
                            //}
                            semAcento = fg.remove_acentos(drImpNF["obs"].ToString());
                            imp.ImpColLF(10, "OBS: " + semAcento);
                            semAcento = fg.remove_acentos(drImpNF["obs2"].ToString());
                            imp.ImpCol(10,   "     " + semAcento);
                            #endregion
                            imp.Imp(imp.Normal);
                        }

                        imp.Eject();
                        imp.Fim();
                        MessageBox.Show("Enviado para a Impressora!", "Impressão de NF");
                    }
                    else
                    {
                        MessageBox.Show("Erro na Impressora. Verifique a conexão!", "Impressão de NF");
                    }
                }
            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Confirma a impressão do Recibo?", "Impressão do Recibo",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
            {
                Decimal vlr;
                string semAcento;

                ImprimeTexto imp = new ImprimeTexto();

                SqlDataReader drImpRecibo;
                drImpRecibo = Saida.Imp_Recibo(Saida.id_saida);
                if (drImpRecibo.HasRows)
                {
                    drImpRecibo.Read();
                    if (imp.Inicio(@"\\PP02\LX300"))    //"\\\\GERAES3\\EPSONLX300"))  //"\\\\GERAES1\\EpsonFX-"))
                    {
                        //Cabeçalho
                        imp.Imp(imp.Normal);
                        imp.Pula(10);
                        semAcento = fg.remove_acentos(drImpRecibo["razao_empresa"].ToString());
                        imp.ImpColLF(02, semAcento+" - "+drImpRecibo["cpf_cnpj"].ToString());
                        semAcento = fg.remove_acentos(drImpRecibo["endereco"].ToString());
                        imp.ImpColLF(02, semAcento);
                        imp.ImpColLF(02, "Fone: "+ drImpRecibo["telefone"].ToString());
                        imp.Imp(imp.NegritoOn);
                        imp.ImpCol(02, "Pedido de Venda No.: " + drImpRecibo["id_saida"].ToString());
                        vlr = Convert.ToDecimal(drImpRecibo["total"].ToString());
                        imp.Imp(imp.NegritoOff);
                        imp.Pula(1);
                        imp.ImpColLF(02, "".PadLeft(78, '='));

                        imp.Pula(2);
                        imp.Imp(imp.Expandido); 
                        imp.ImpCol(14, "R E C I B O-R$:");
                        imp.ImpColLF(28, vlr.ToString("#,##0.00").PadLeft(12, ' '));

                        //Dados RECIBO
                        imp.Pula(2);
                        imp.ImpColLF(02, "Recebi(emos) do(a)  " + fg.remove_acentos(drImpRecibo["razao_social"].ToString().ToUpper()));
                        imp.Pula(2);
                        NumeroExtenso extenso = new NumeroExtenso();
                        imp.ImpColLF(02, "A quantia de:");
                        imp.ImpCol(02, fg.remove_acentos(extenso.ParaExtenso(decimal.Parse(drImpRecibo["total"].ToString())).ToUpper()));
                        imp.Pula(3);
                        imp.ImpColLF(02, "Referente a: PEDIDO No.: " + drImpRecibo["id_saida"].ToString());
                        if (!drImpRecibo["nf"].ToString().Equals(string.Empty))
                        {
                            imp.Pula(1);
                            imp.ImpColLF(02, "e Nota Fiscal No.: " + drImpRecibo["nf"].ToString());
                        }
                        imp.Pula(2);
                        imp.ImpColLF(40, "BELEM, ____/____/_______");
                        imp.Pula(4);
                        imp.ImpColLF(40, "_____________________________________");
                        imp.Pula(4);

                        imp.Imp(imp.Normal);
                        imp.ImpColLF(02, "".PadLeft(78, '='));
                        imp.Eject();
                        imp.Fim();
                        MessageBox.Show("Enviado para a Impressora!", "Impressão do Pedido");
                    }
                    else
                    {
                        MessageBox.Show("Erro na Impressora. Verifique a conexão!", "Impressão do Pedido");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlFrete.Visible = false;
        }

        private void rdbDest_CheckedChanged(object sender, EventArgs e)
        {
            pnlFrete.Visible = rdbDest.Checked;
        }

        private void txtObs2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtCodProd.Focus();
        }
    }
}
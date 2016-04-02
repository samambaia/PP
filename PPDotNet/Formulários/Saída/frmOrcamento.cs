using System;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DllClasses.Net.Sistema.Globais;
using DllClasses.Net.Sistema.Globais.NumeroExtenso;
using DllClasses.Net.Sistema.Negocio;
using PPDotNet.Formulários.Relatórios;
using PPDotNet.Formulários.Modelos;
using PPDotNet.Formulários.Cadastros;
using PPDotNet.DataSources;
using PPDotNet.DataSources.dsSaidaTableAdapters;

namespace PPDotNet.Formulários.Saída
{
    public partial class frmOrcamento : frmModeloCadastro
    {
        private short Status;
        private short Status_item; 
        public short Tipo;
        public int ContCar;

        public frmPessoaCons locPessoa = new frmPessoaCons();
        public frmProdutoCons locProdOrca = new frmProdutoCons();
        public orcamento Orcamento = new orcamento();

        private clFuncoesGerais fg = new clFuncoesGerais();

        public frmOrcamento()
        {
            InitializeComponent();
        }

        public void frmOrcamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSaida.EMPRESA' table. You can move, or remove it, as needed.
            this.eMPRESATableAdapter.Fill(this.dsSaida.EMPRESA);
            Status = 1; //Setado para gravar cabeçalho no primeiro clique do botao gravar
            Status_item = 0; //Setado para nao gravar alteração de item

            if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                Limpa_Cab();
                Limpa_Itens();
                lblTotPed.Text = "0,00";

                clDataBase clDB = new clDataBase();
                // Gera o AutoInc
                txtCodigo.Text = clDB.AutoInc("ORCAMENTO").ToString();

                CarregaGrid_Itens();
            }
            else if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                Limpa_Cab();
                Limpa_Itens();
                SqlDataReader drDados = Orcamento.Listar(Codigo);
                if (drDados.HasRows)
                {
                    drDados.Read();
                    txtCodigo.Text = Codigo.ToString();
                    cmbEmpresa.SelectedValue = Convert.ToInt32(drDados["empresa"].ToString());
                    txtCodCliente.Text = drDados["id_cliente"].ToString();
                    txtCodCliente_Leave(sender, e);// Carrega fantasia e forma_pag
                    txtVeiculo.Text = drDados["veiculo"].ToString();
                    txtPlaca.Text = drDados["placa"].ToString();
                    txtMecanico.Text = drDados["mecanico"].ToString();
                    txtKm.Text = drDados["kilometragem"].ToString();
                    txtDtEntrada.Text = drDados["dt_entrada"].ToString();
                    txtDtSaida.Text = drDados["dt_saida"].ToString();
                    cmbCombustivel.SelectedIndex = Convert.ToInt32(drDados["combustivel"].ToString())-1;
                    cmbGarantia.SelectedIndex = Convert.ToInt32(drDados["garantia"].ToString())-1;
                    txtOrdemServico.Text = drDados["ordem_servico"].ToString();
                    txtObs.Text = drDados["obs"].ToString();

                    CarregaGrid_Itens();

                    if (gridItens.RowCount > 0)
                    {
                        decimal vlr;
                        vlr = Convert.ToDecimal(Orcamento.Total_Pedido(int.Parse(txtCodigo.Text)).ToString());
                        lblTotPed.Text = vlr.ToString("#,##0.00");
                    }
                }     
            }       
        }

        private void Limpa_Cab()
        {
            // Limpa os Campos
            // Pedido
            txtCodigo.Text = string.Empty;
            txtCodCliente.Text = string.Empty;
            txtFantasia.Text = string.Empty;
            cmbEmpresa.SelectedIndex = 0;
            txtVeiculo.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            txtMecanico.Text = string.Empty;
            txtKm.Text = "0";
            txtDtEntrada.Text = DateTime.Now.ToShortDateString();
            txtDtSaida.Text = string.Empty;
            txtObs.Text = string.Empty;
            cmbCombustivel.SelectedIndex = -1;
            cmbGarantia.SelectedIndex = -1;
            txtOrdemServico.Text = string.Empty;
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
                drCli = Orcamento.LocCliente(Convert.ToInt32(txtCodCliente.Text));
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
            locPessoa.FormChamou = "Orcamento";
            locPessoa.FormOrca = this;
            locPessoa.ShowDialog();
            txtCodCliente.Text = Orcamento.id_cliente.ToString();
            SqlDataReader drCli;
            drCli = Orcamento.LocCliente(Convert.ToInt32(txtCodCliente.Text));
            if (drCli.HasRows)
            {
                drCli.Read();
                txtFantasia.Text = drCli["fantasia"].ToString();
            }
        }

        private void txtCodProd_Leave ( object sender, EventArgs e )
        {
            //int ContMat = 0;
            //int ContServ = 0;

            if (txtCodProd.Text != string.Empty)
            {
                if (Status_item == 0)
                {
                    SqlDataReader drProd;
                    drProd = Orcamento.LocProduto(Convert.ToInt32(txtCodProd.Text));
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

                    #region Esse código verifica se o limite de Materiais ja foi atingido.
                    //foreach (DataGridViewRow item in gridItens.Rows)
                    //{
                    //    if (item.Cells["tipo"].Value.ToString().Trim() == "1")
                    //    {
                    //        ContMat++;
                    //        if (ContMat >= 22 && Tipo == 1)
                    //        {
                    //            MessageBox.Show("O Limite para MATERIAIS é de 22 Itens!", this.Text);
                    //            Limpa_Itens();
                    //            txtCodProd.Focus();
                    //            return;
                    //        }
                    //    }
                    //    if (item.Cells["tipo"].Value.ToString().Trim() == "2")
                    //    {
                    //        ContServ++;
                    //        if (ContServ >= 7 && Tipo == 2 )
                    //        {
                    //            MessageBox.Show("O Limite para SERVIÇOS é de 7 Itens!", this.Text);
                    //            Limpa_Itens();
                    //            txtCodProd.Focus();
                    //            return;
                    //        }
                    //    }
                    //}
                    #endregion
                }
                else
                {
                    SqlDataReader drProd;
                    drProd = Orcamento.LocProduto(Convert.ToInt32(txtCodProd.Text));
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

                    #region Esse código verifica se o limite de Materiais/Serviços ja foi atingido.
                    //foreach (DataGridViewRow item in gridItens.Rows)
                    //{
                    //    if (item.Cells["tipo"].Value.ToString().Trim() == "1")
                    //    {
                    //        ContMat++;
                    //        if (ContMat >= 22 && Tipo == 1 && Status_item == 0)
                    //        {
                    //            MessageBox.Show("O Limite para MATERIAIS é de 22 Itens!", this.Text);
                    //            Limpa_Itens();
                    //            txtCodProd.Focus();
                    //            return;
                    //        }
                    //    }
                    //    if (item.Cells["tipo"].Value.ToString().Trim() == "2")
                    //    {
                    //        ContServ++;
                    //        if (ContServ >= 7 && Tipo == 2 && Status_item == 0)
                    //        {
                    //            MessageBox.Show("O Limite para SERVIÇOS é de 7 Itens!", this.Text);
                    //            Limpa_Itens();
                    //            txtCodProd.Focus();
                    //            return;
                    //        }
                    //    }
                    //}
                    #endregion
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
                            drProd = Orcamento.LocProduto(Convert.ToInt32(txtCodProd.Text));
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

                        #region Esse código verifica se o limite de Materiais ja foi atingido.
                        //foreach (DataGridViewRow item in gridItens.Rows)
                        //{
                        //    if (item.Cells["tipo"].Value.ToString().Trim() == "1")
                        //    {
                        //        ContMat++;
                        //        if (ContMat >= 22 && Tipo == 1)
                        //        {
                        //            MessageBox.Show("O Limite para MATERIAIS é de 22 Itens!", this.Text);
                        //            Limpa_Itens();
                        //            txtCodProd.Focus();
                        //            return;
                        //        }
                        //    }
                        //    if (item.Cells["tipo"].Value.ToString().Trim() == "2")
                        //    {
                        //        ContServ++;
                        //        if (ContServ >= 7 && Tipo == 2)
                        //        {
                        //            MessageBox.Show("O Limite para SERVIÇOS é de 7 Itens!", this.Text);
                        //            Limpa_Itens();
                        //            txtCodProd.Focus();
                        //            return;
                        //        }
                        //    }
                        //}
                        #endregion
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
            Orcamento.empresa = Convert.ToInt32(cmbEmpresa.SelectedValue.ToString());
            Orcamento.id_cliente = Convert.ToInt16(txtCodCliente.Text);
            Orcamento.veiculo = txtVeiculo.Text;
            Orcamento.placa = txtPlaca.Text;
            Orcamento.mecanico = txtMecanico.Text;
            Orcamento.kilometragem = int.Parse(txtKm.Text);
            Orcamento.dt_entrada = Convert.ToDateTime(txtDtEntrada.Text);
            if (!txtDtSaida.Text.Equals("  /  /"))
                Orcamento.dt_saida = Convert.ToDateTime(txtDtSaida.Text);
            Orcamento.combustivel = Convert.ToInt16(cmbCombustivel.SelectedIndex + 1);
            Orcamento.garantia = Convert.ToInt16(cmbGarantia.SelectedIndex + 1);
            Orcamento.ordem_servico = txtOrdemServico.Text;
            Orcamento.obs = txtObs.Text;
            #endregion

            #region Item do Pedido
            if (txtCodProd.Text != string.Empty)
            {
                Orcamento.id_orcamento = Convert.ToInt32(txtCodigo.Text);
                Orcamento.id_produto = Convert.ToInt32(txtCodProd.Text);
                Orcamento.quantidade = Convert.ToDecimal(txtQtd.Text);
                Orcamento.valor_unitario = Convert.ToDecimal(txtVlrUnitario.Text);
                Orcamento.per_desconto = Convert.ToDecimal(txtPerDesconto.Text);
                Orcamento.valor_total = Convert.ToDecimal(txtVlrTotal.Text);
                Orcamento.icms = Convert.ToDecimal(txtICMS.Text);
                Orcamento.unidade = cmbUnidade.Text.Trim();
            }
            #endregion

            if (Operacao == clFuncoesGerais.Operacao.Inclusao)
            {
                if (Status == 1)
                {
                    Orcamento.Gravar();
                    // Recupera o ID do pedido na primeira gravação
                    txtCodigo.Text = Orcamento.id_orcamento.ToString();
                    Status = 0; //Grava somente itens
                }
                else
                    Orcamento.Alterar(); //Apenas para alterar o cabeçalho antes de sair de um novo pedido

                if (Status_item == 0)
                {
                    if (txtCodProd.Text != string.Empty)
                        Orcamento.Gravar_Itens();
                }
                else
                {
                    if (txtCodProd.Text != string.Empty)
                    {
                        Orcamento.id_item_orca = Convert.ToInt32(gridItens.CurrentRow.Cells[6].Value);
                        Orcamento.Alterar_Itens();
                        Status_item = 0;
                    }
                }
            }
            else if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                if (Status == 1) //Gravar cabeçalho primeira vez
                {
                    Orcamento.id_orcamento = Codigo;
                    Orcamento.Alterar();
                    Status = 0; //Grava somente itens
                    if (Status_item == 1)
                    {
                        Orcamento.id_item_orca = Convert.ToInt32(gridItens.CurrentRow.Cells[6].Value);
                        if (txtCodProd.Text != string.Empty)
                            Orcamento.Alterar_Itens();
                        Status_item = 0;
                    }
                    else
                    {
                        if (txtCodProd.Text != string.Empty)
                            Orcamento.Gravar_Itens();
                    }
                }
                else
                {
                    if (Status_item == 1)
                    {
                        Orcamento.id_item_orca = Convert.ToInt32(gridItens.CurrentRow.Cells[6].Value);
                        if (txtCodProd.Text != string.Empty)
                            Orcamento.Alterar_Itens();
                        Status_item = 0;
                    }
                    else
                    {
                        if (txtCodProd.Text != string.Empty)
                        {
                            Orcamento.Gravar_Itens();
                        }
                    }
                }
            }

            CarregaGrid_Itens();
            if (gridItens.RowCount > 0)
            {
                decimal vlr;
                vlr = Convert.ToDecimal(Orcamento.Total_Pedido(int.Parse(txtCodigo.Text)).ToString());
                lblTotPed.Text = vlr.ToString("#,##0.00");
            }

            Limpa_Itens();
            txtObs.Focus();
        }

        private void CarregaGrid_Itens()
        {
            if (Operacao == clFuncoesGerais.Operacao.Alteracao)
            {
                Orcamento.id_orcamento = Convert.ToInt32(txtCodigo.Text);
            }
            gridItens.DataSource = Orcamento.Achar_Itens().Tables[0];

            //id_orcamento
            gridItens.Columns[0].HeaderText = "ORC";
            gridItens.Columns[0].Name = "id_orcamento";
            gridItens.Columns[0].Width = 60;
            gridItens.Columns[0].Visible = false;

            //id_produto
            gridItens.Columns[1].HeaderText = "Cód.Prod";
            gridItens.Columns[1].Name = "id_produto";
            gridItens.Columns[1].Width = 100;

            gridItens.Columns[2].HeaderText = "Descrição Produto";
            gridItens.Columns[2].Name = "descricao";
            gridItens.Columns[2].Width = 330;

            gridItens.Columns[3].HeaderText = "Qtd";
            gridItens.Columns[3].Name = "quantidade";
            gridItens.Columns[3].Width = 50;
            gridItens.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridItens.Columns[3].DefaultCellStyle.Format = "N2";

            gridItens.Columns[4].HeaderText = "Vlr Unit.";
            gridItens.Columns[4].Name = "valor_unitario";
            gridItens.Columns[4].Width = 80;
            gridItens.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridItens.Columns[4].DefaultCellStyle.Format = "N2";

            gridItens.Columns[5].HeaderText = "% Desc.";
            gridItens.Columns[5].Name = "per_desconto";
            gridItens.Columns[5].Width = 70;
            gridItens.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridItens.Columns[5].DefaultCellStyle.Format = "N2";

            gridItens.Columns[6].HeaderText = "Vlr Total";
            gridItens.Columns[6].Name = "valor_total";
            gridItens.Columns[6].Width = 80;
            gridItens.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridItens.Columns[6].DefaultCellStyle.Format = "N2";
            
            //Essas colunas nao aparecem no grid
            //id_item
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
            locProdOrca.FormChamou = "Orcamento";
            locProdOrca.FormOrca = this;
            locProdOrca.ShowDialog();
            txtCodProd.Text = Orcamento.id_produto.ToString();
            txtCodProd.Focus();
        }

        private void gridItens_DoubleClick(object sender, EventArgs e)
        {
            Limpa_Itens();
            SqlDataReader drItens;
            drItens = Orcamento.Listar_Itens(Convert.ToInt32(gridItens.CurrentRow.Cells[6].Value));
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
                    Orcamento.Excluir_Itens(Convert.ToInt32(gridItens.CurrentRow.Cells[7].Value));
                    MessageBox.Show("Item excluído com sucesso", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpa_Itens();
                    CarregaGrid_Itens();
                    if (gridItens.RowCount > 0)
                    {
                        decimal vlr;
                        vlr = Convert.ToDecimal(Orcamento.Total_Pedido(int.Parse(txtCodigo.Text)).ToString());
                        lblTotPed.Text = vlr.ToString("#,##0.00");
                    }
                }
            }
        }
        
        private void txtVlrTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnGravar_Click(sender, e);
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

        private void frmOrcamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SelectNextControl(sender as Control, true, true, true, true);
        }

        private void btnOrcamento_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Confirma a impressão do Orçamento?", "Impressão do Orçamento",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
            {
                btnGravar_Click(sender, e);

                frmPreview preview = new frmPreview();
                Cursor = Cursors.WaitCursor;

                if (cmbEmpresa.SelectedIndex == 0)
                    preview.form = "repOrca.rdlc";
                else
                    preview.form = "repOrcaPP.rdlc";

                preview.idOrca = int.Parse(txtCodigo.Text);
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog();

                Cursor = Cursors.Default;
            }
        }
    }
}
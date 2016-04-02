using PPDotNet.DataSources;

namespace PPDotNet.Formulários.Cadastros
{
    partial class frmPessoaCad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_pessoaLabel;
            System.Windows.Forms.Label razao_socialLabel;
            System.Windows.Forms.Label fantasiaLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label ufLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label ieLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label orgao_rgLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label mesmo_local_entregaLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label data_cadastroLabel;
            System.Windows.Forms.Label id_contatoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label freteLabel;
            System.Windows.Forms.Label label14;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPessoaCad));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.chkFornecedor = new System.Windows.Forms.CheckBox();
            this.chkTransp = new System.Windows.Forms.CheckBox();
            this.chkVendedor = new System.Windows.Forms.CheckBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.rdgTipo = new System.Windows.Forms.GroupBox();
            this.rdbJuridica = new System.Windows.Forms.RadioButton();
            this.rdbFisica = new System.Windows.Forms.RadioButton();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtIE = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtOrgaoRg = new System.Windows.Forms.TextBox();
            this.tabOutros = new System.Windows.Forms.TabPage();
            this.gpbForn = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQtdDias_F = new System.Windows.Forms.NumericUpDown();
            this.cmbFrete_F = new System.Windows.Forms.ComboBox();
            this.gpbCli = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtdDias_C = new System.Windows.Forms.NumericUpDown();
            this.cmbFrete_C = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.chkMLE = new System.Windows.Forms.CheckBox();
            this.tabEndEntrega = new System.Windows.Forms.TabPage();
            this.txtBairro_LE = new System.Windows.Forms.TextBox();
            this.txtCep_LE = new System.Windows.Forms.MaskedTextBox();
            this.cmbUf_LE = new System.Windows.Forms.ComboBox();
            this.cmbCidade_LE = new System.Windows.Forms.ComboBox();
            this.txtReferencia_LE = new System.Windows.Forms.TextBox();
            this.txtEndereco_LE = new System.Windows.Forms.TextBox();
            this.tabContatos = new System.Windows.Forms.TabPage();
            this.toolCons = new System.Windows.Forms.ToolStrip();
            this.btnNovoCont = new System.Windows.Forms.ToolStripButton();
            this.btnGravarCont = new System.Windows.Forms.ToolStripButton();
            this.btnExcluirCont = new System.Windows.Forms.ToolStripButton();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.gridContatos = new System.Windows.Forms.DataGridView();
            this.txtCodContato = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.rdbNao = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.chkCadStatus = new System.Windows.Forms.CheckBox();
            this.txtLimCred = new System.Windows.Forms.TextBox();
            this.linkCNPJ = new System.Windows.Forms.LinkLabel();
            this.linkCPF = new System.Windows.Forms.LinkLabel();
            this.chkServico = new System.Windows.Forms.CheckBox();
            this.pESSOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsContatos = new PPDotNet.DataSources.dsContatos();
            this.pESSOATableAdapter = new PPDotNet.DataSources.dsContatosTableAdapters.PESSOATableAdapter();
            id_pessoaLabel = new System.Windows.Forms.Label();
            razao_socialLabel = new System.Windows.Forms.Label();
            fantasiaLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            ufLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            ieLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            orgao_rgLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            mesmo_local_entregaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            data_cadastroLabel = new System.Windows.Forms.Label();
            id_contatoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            freteLabel = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            this.tabDados.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.rdgTipo.SuspendLayout();
            this.tabOutros.SuspendLayout();
            this.gpbForn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdDias_F)).BeginInit();
            this.gpbCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdDias_C)).BeginInit();
            this.tabEndEntrega.SuspendLayout();
            this.tabContatos.SuspendLayout();
            this.toolCons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.tabOutros);
            this.tabDados.Controls.Add(this.tabEndEntrega);
            this.tabDados.Controls.Add(this.tabContatos);
            this.tabDados.Size = new System.Drawing.Size(598, 400);
            this.tabDados.Controls.SetChildIndex(this.tabContatos, 0);
            this.tabDados.Controls.SetChildIndex(this.tabEndEntrega, 0);
            this.tabDados.Controls.SetChildIndex(this.tabOutros, 0);
            this.tabDados.Controls.SetChildIndex(this.tabPage2, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.chkServico);
            this.tabPage2.Controls.Add(this.linkCPF);
            this.tabPage2.Controls.Add(this.linkCNPJ);
            this.tabPage2.Controls.Add(this.txtLimCred);
            this.tabPage2.Controls.Add(label14);
            this.tabPage2.Controls.Add(label9);
            this.tabPage2.Controls.Add(this.chkCadStatus);
            this.tabPage2.Controls.Add(this.rdbNao);
            this.tabPage2.Controls.Add(this.rdbSim);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtBairro);
            this.tabPage2.Controls.Add(this.lblDataCadastro);
            this.tabPage2.Controls.Add(data_cadastroLabel);
            this.tabPage2.Controls.Add(mesmo_local_entregaLabel);
            this.tabPage2.Controls.Add(this.chkMLE);
            this.tabPage2.Controls.Add(obsLabel);
            this.tabPage2.Controls.Add(this.txtObs);
            this.tabPage2.Controls.Add(orgao_rgLabel);
            this.tabPage2.Controls.Add(this.txtOrgaoRg);
            this.tabPage2.Controls.Add(rgLabel);
            this.tabPage2.Controls.Add(this.txtRg);
            this.tabPage2.Controls.Add(cpfLabel);
            this.tabPage2.Controls.Add(this.txtCpf);
            this.tabPage2.Controls.Add(ieLabel);
            this.tabPage2.Controls.Add(this.txtIE);
            this.tabPage2.Controls.Add(cnpjLabel);
            this.tabPage2.Controls.Add(this.txtCnpj);
            this.tabPage2.Controls.Add(this.rdgTipo);
            this.tabPage2.Controls.Add(cepLabel);
            this.tabPage2.Controls.Add(this.txtCep);
            this.tabPage2.Controls.Add(ufLabel);
            this.tabPage2.Controls.Add(this.cmbUf);
            this.tabPage2.Controls.Add(cidadeLabel);
            this.tabPage2.Controls.Add(this.cmbCidade);
            this.tabPage2.Controls.Add(bairroLabel);
            this.tabPage2.Controls.Add(this.chkVendedor);
            this.tabPage2.Controls.Add(this.chkTransp);
            this.tabPage2.Controls.Add(this.chkFornecedor);
            this.tabPage2.Controls.Add(referenciaLabel);
            this.tabPage2.Controls.Add(this.txtReferencia);
            this.tabPage2.Controls.Add(enderecoLabel);
            this.tabPage2.Controls.Add(this.txtEndereco);
            this.tabPage2.Controls.Add(fantasiaLabel);
            this.tabPage2.Controls.Add(this.txtFantasia);
            this.tabPage2.Controls.Add(razao_socialLabel);
            this.tabPage2.Controls.Add(this.txtRazaoSocial);
            this.tabPage2.Controls.Add(id_pessoaLabel);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Size = new System.Drawing.Size(590, 374);
            // 
            // id_pessoaLabel
            // 
            id_pessoaLabel.AutoSize = true;
            id_pessoaLabel.Location = new System.Drawing.Point(36, 15);
            id_pessoaLabel.Name = "id_pessoaLabel";
            id_pessoaLabel.Size = new System.Drawing.Size(47, 13);
            id_pessoaLabel.TabIndex = 25;
            id_pessoaLabel.Text = "Código";
            // 
            // razao_socialLabel
            // 
            razao_socialLabel.AutoSize = true;
            razao_socialLabel.Location = new System.Drawing.Point(3, 41);
            razao_socialLabel.Name = "razao_socialLabel";
            razao_socialLabel.Size = new System.Drawing.Size(80, 13);
            razao_socialLabel.TabIndex = 26;
            razao_socialLabel.Text = "Razão Social";
            // 
            // fantasiaLabel
            // 
            fantasiaLabel.AutoSize = true;
            fantasiaLabel.Location = new System.Drawing.Point(29, 69);
            fantasiaLabel.Name = "fantasiaLabel";
            fantasiaLabel.Size = new System.Drawing.Size(54, 13);
            fantasiaLabel.TabIndex = 27;
            fantasiaLabel.Text = "Fantasia";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(23, 95);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(60, 13);
            enderecoLabel.TabIndex = 28;
            enderecoLabel.Text = "Endereço";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(15, 122);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(68, 13);
            referenciaLabel.TabIndex = 29;
            referenciaLabel.Text = "Referência";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(41, 146);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(42, 13);
            bairroLabel.TabIndex = 30;
            bairroLabel.Text = "Bairro";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(36, 173);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(47, 13);
            cidadeLabel.TabIndex = 31;
            cidadeLabel.Text = "Cidade";
            // 
            // ufLabel
            // 
            ufLabel.AutoSize = true;
            ufLabel.Location = new System.Drawing.Point(483, 176);
            ufLabel.Name = "ufLabel";
            ufLabel.Size = new System.Drawing.Size(45, 13);
            ufLabel.TabIndex = 33;
            ufLabel.Text = "Estado";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(463, 149);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(30, 13);
            cepLabel.TabIndex = 32;
            cepLabel.Text = "CEP";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(47, 245);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(36, 13);
            cnpjLabel.TabIndex = 38;
            cnpjLabel.Text = "CNPJ";
            // 
            // ieLabel
            // 
            ieLabel.AutoSize = true;
            ieLabel.Location = new System.Drawing.Point(264, 245);
            ieLabel.Name = "ieLabel";
            ieLabel.Size = new System.Drawing.Size(19, 13);
            ieLabel.TabIndex = 45;
            ieLabel.Text = "IE";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(54, 271);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(29, 13);
            cpfLabel.TabIndex = 39;
            cpfLabel.Text = "CPF";
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(259, 271);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(24, 13);
            rgLabel.TabIndex = 46;
            rgLabel.Text = "RG";
            // 
            // orgao_rgLabel
            // 
            orgao_rgLabel.AutoSize = true;
            orgao_rgLabel.Location = new System.Drawing.Point(381, 271);
            orgao_rgLabel.Name = "orgao_rgLabel";
            orgao_rgLabel.Size = new System.Drawing.Size(63, 13);
            orgao_rgLabel.TabIndex = 47;
            orgao_rgLabel.Text = "Órgão RG";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(54, 323);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(29, 13);
            obsLabel.TabIndex = 40;
            obsLabel.Text = "Obs";
            // 
            // mesmo_local_entregaLabel
            // 
            mesmo_local_entregaLabel.AutoSize = true;
            mesmo_local_entregaLabel.Location = new System.Drawing.Point(89, 348);
            mesmo_local_entregaLabel.Name = "mesmo_local_entregaLabel";
            mesmo_local_entregaLabel.Size = new System.Drawing.Size(128, 13);
            mesmo_local_entregaLabel.TabIndex = 41;
            mesmo_local_entregaLabel.Text = "Mesmo Local Entrega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(455, 72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 13);
            label1.TabIndex = 6;
            label1.Text = "CEP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(478, 99);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 13);
            label2.TabIndex = 10;
            label2.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(31, 99);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(47, 13);
            label3.TabIndex = 8;
            label3.Text = "Cidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(36, 72);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 13);
            label4.TabIndex = 4;
            label4.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(10, 45);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 13);
            label5.TabIndex = 2;
            label5.Text = "Referência";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(18, 18);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(60, 13);
            label6.TabIndex = 0;
            label6.Text = "Endereço";
            // 
            // data_cadastroLabel
            // 
            data_cadastroLabel.AutoSize = true;
            data_cadastroLabel.Location = new System.Drawing.Point(184, 17);
            data_cadastroLabel.Name = "data_cadastroLabel";
            data_cadastroLabel.Size = new System.Drawing.Size(90, 13);
            data_cadastroLabel.TabIndex = 37;
            data_cadastroLabel.Text = "Data Cadastro";
            // 
            // id_contatoLabel
            // 
            id_contatoLabel.AutoSize = true;
            id_contatoLabel.Location = new System.Drawing.Point(17, 40);
            id_contatoLabel.Name = "id_contatoLabel";
            id_contatoLabel.Size = new System.Drawing.Size(47, 13);
            id_contatoLabel.TabIndex = 0;
            id_contatoLabel.Text = "Código";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(24, 67);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(40, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(8, 94);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(56, 13);
            telefoneLabel.TabIndex = 4;
            telefoneLabel.Text = "Telefone";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(232, 94);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(27, 13);
            faxLabel.TabIndex = 6;
            faxLabel.Text = "Fax";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(403, 94);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(48, 13);
            celularLabel.TabIndex = 8;
            celularLabel.Text = "Celular";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(21, 121);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "E-mail";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(22, 148);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(42, 13);
            label8.TabIndex = 12;
            label8.Text = "Cargo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(259, 348);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(118, 13);
            label9.TabIndex = 42;
            label9.Text = "Cadastro Completo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(52, 23);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(36, 13);
            label10.TabIndex = 6;
            label10.Text = "Frete";
            // 
            // freteLabel
            // 
            freteLabel.AutoSize = true;
            freteLabel.Location = new System.Drawing.Point(52, 25);
            freteLabel.Name = "freteLabel";
            freteLabel.Size = new System.Drawing.Size(36, 13);
            freteLabel.TabIndex = 2;
            freteLabel.Text = "Frete";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(385, 17);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(87, 13);
            label14.TabIndex = 35;
            label14.Text = "Limite Crédito";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(94, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(77, 21);
            this.txtCodigo.TabIndex = 24;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(94, 39);
            this.txtRazaoSocial.MaxLength = 60;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(487, 21);
            this.txtRazaoSocial.TabIndex = 0;
            this.txtRazaoSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(94, 66);
            this.txtFantasia.MaxLength = 60;
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(487, 21);
            this.txtFantasia.TabIndex = 1;
            this.txtFantasia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(94, 92);
            this.txtEndereco.MaxLength = 60;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(487, 21);
            this.txtEndereco.TabIndex = 2;
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(94, 119);
            this.txtReferencia.MaxLength = 60;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(487, 21);
            this.txtReferencia.TabIndex = 3;
            this.txtReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // chkFornecedor
            // 
            this.chkFornecedor.AutoSize = true;
            this.chkFornecedor.Location = new System.Drawing.Point(94, 297);
            this.chkFornecedor.Name = "chkFornecedor";
            this.chkFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkFornecedor.Size = new System.Drawing.Size(90, 17);
            this.chkFornecedor.TabIndex = 14;
            this.chkFornecedor.Text = "Fornecedor";
            this.chkFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            this.chkFornecedor.CheckedChanged += new System.EventHandler(this.chkFornecedor_CheckedChanged);
            // 
            // chkTransp
            // 
            this.chkTransp.AutoSize = true;
            this.chkTransp.Location = new System.Drawing.Point(205, 297);
            this.chkTransp.Name = "chkTransp";
            this.chkTransp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkTransp.Size = new System.Drawing.Size(114, 17);
            this.chkTransp.TabIndex = 15;
            this.chkTransp.Text = "Transportadora";
            this.chkTransp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            this.chkTransp.CheckedChanged += new System.EventHandler(this.chkTransp_CheckedChanged);
            // 
            // chkVendedor
            // 
            this.chkVendedor.AutoSize = true;
            this.chkVendedor.Location = new System.Drawing.Point(340, 297);
            this.chkVendedor.Name = "chkVendedor";
            this.chkVendedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkVendedor.Size = new System.Drawing.Size(81, 17);
            this.chkVendedor.TabIndex = 16;
            this.chkVendedor.Text = "Vendedor";
            this.chkVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            this.chkVendedor.CheckedChanged += new System.EventHandler(this.chkVendedor_CheckedChanged);
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(94, 173);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(333, 21);
            this.cmbCidade.TabIndex = 6;
            this.cmbCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // cmbUf
            // 
            this.cmbUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RN",
            "RS",
            "RJ",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbUf.Location = new System.Drawing.Point(537, 173);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(44, 21);
            this.cmbUf.TabIndex = 7;
            this.cmbUf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(499, 146);
            this.txtCep.Mask = "00,000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.PromptChar = ' ';
            this.txtCep.Size = new System.Drawing.Size(82, 21);
            this.txtCep.TabIndex = 5;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // rdgTipo
            // 
            this.rdgTipo.Controls.Add(this.rdbJuridica);
            this.rdgTipo.Controls.Add(this.rdbFisica);
            this.rdgTipo.Location = new System.Drawing.Point(94, 200);
            this.rdgTipo.Name = "rdgTipo";
            this.rdgTipo.Size = new System.Drawing.Size(167, 34);
            this.rdgTipo.TabIndex = 8;
            this.rdgTipo.TabStop = false;
            this.rdgTipo.Text = "Tipo Pessoa";
            // 
            // rdbJuridica
            // 
            this.rdbJuridica.AutoSize = true;
            this.rdbJuridica.Location = new System.Drawing.Point(6, 11);
            this.rdbJuridica.Name = "rdbJuridica";
            this.rdbJuridica.Size = new System.Drawing.Size(68, 17);
            this.rdbJuridica.TabIndex = 0;
            this.rdbJuridica.TabStop = true;
            this.rdbJuridica.Text = "Jurídica";
            this.rdbJuridica.UseVisualStyleBackColor = true;
            this.rdbJuridica.CheckedChanged += new System.EventHandler(this.rdbJuridica_CheckedChanged);
            // 
            // rdbFisica
            // 
            this.rdbFisica.AutoSize = true;
            this.rdbFisica.Location = new System.Drawing.Point(94, 11);
            this.rdbFisica.Name = "rdbFisica";
            this.rdbFisica.Size = new System.Drawing.Size(56, 17);
            this.rdbFisica.TabIndex = 1;
            this.rdbFisica.TabStop = true;
            this.rdbFisica.Text = "Física";
            this.rdbFisica.UseVisualStyleBackColor = true;
            this.rdbFisica.CheckedChanged += new System.EventHandler(this.rdbJuridica_CheckedChanged);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(94, 241);
            this.txtCnpj.Mask = "00,000,000/0000-99";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.PromptChar = ' ';
            this.txtCnpj.Size = new System.Drawing.Size(132, 21);
            this.txtCnpj.TabIndex = 9;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(289, 241);
            this.txtIE.Name = "txtIE";
            this.txtIE.PromptChar = ' ';
            this.txtIE.Size = new System.Drawing.Size(110, 21);
            this.txtIE.TabIndex = 10;
            this.txtIE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(94, 267);
            this.txtCpf.Mask = "000,000,000-99";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PromptChar = ' ';
            this.txtCpf.Size = new System.Drawing.Size(100, 21);
            this.txtCpf.TabIndex = 11;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(289, 267);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(86, 21);
            this.txtRg.TabIndex = 12;
            this.txtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtOrgaoRg
            // 
            this.txtOrgaoRg.Location = new System.Drawing.Point(448, 267);
            this.txtOrgaoRg.Name = "txtOrgaoRg";
            this.txtOrgaoRg.Size = new System.Drawing.Size(133, 21);
            this.txtOrgaoRg.TabIndex = 13;
            this.txtOrgaoRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // tabOutros
            // 
            this.tabOutros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabOutros.Controls.Add(this.gpbForn);
            this.tabOutros.Controls.Add(this.gpbCli);
            this.tabOutros.Location = new System.Drawing.Point(4, 22);
            this.tabOutros.Name = "tabOutros";
            this.tabOutros.Padding = new System.Windows.Forms.Padding(3);
            this.tabOutros.Size = new System.Drawing.Size(590, 374);
            this.tabOutros.TabIndex = 2;
            this.tabOutros.Text = "Outros Dados";
            this.tabOutros.UseVisualStyleBackColor = true;
            this.tabOutros.Enter += new System.EventHandler(this.tabOutros_Enter);
            // 
            // gpbForn
            // 
            this.gpbForn.Controls.Add(freteLabel);
            this.gpbForn.Controls.Add(this.label12);
            this.gpbForn.Controls.Add(this.txtQtdDias_F);
            this.gpbForn.Controls.Add(this.cmbFrete_F);
            this.gpbForn.Enabled = false;
            this.gpbForn.Location = new System.Drawing.Point(7, 102);
            this.gpbForn.Name = "gpbForn";
            this.gpbForn.Size = new System.Drawing.Size(564, 51);
            this.gpbForn.TabIndex = 7;
            this.gpbForn.TabStop = false;
            this.gpbForn.Text = "Fornecedor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(157, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Qtd Dias";
            // 
            // txtQtdDias_F
            // 
            this.txtQtdDias_F.Location = new System.Drawing.Point(219, 20);
            this.txtQtdDias_F.Name = "txtQtdDias_F";
            this.txtQtdDias_F.Size = new System.Drawing.Size(51, 21);
            this.txtQtdDias_F.TabIndex = 5;
            // 
            // cmbFrete_F
            // 
            this.cmbFrete_F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrete_F.FormattingEnabled = true;
            this.cmbFrete_F.Items.AddRange(new object[] {
            "CIF",
            "FOB"});
            this.cmbFrete_F.Location = new System.Drawing.Point(95, 19);
            this.cmbFrete_F.Name = "cmbFrete_F";
            this.cmbFrete_F.Size = new System.Drawing.Size(51, 21);
            this.cmbFrete_F.TabIndex = 3;
            // 
            // gpbCli
            // 
            this.gpbCli.Controls.Add(this.comboBox3);
            this.gpbCli.Controls.Add(this.label11);
            this.gpbCli.Controls.Add(this.txtQtdDias_C);
            this.gpbCli.Controls.Add(label10);
            this.gpbCli.Controls.Add(this.cmbFrete_C);
            this.gpbCli.Location = new System.Drawing.Point(7, 46);
            this.gpbCli.Name = "gpbCli";
            this.gpbCli.Size = new System.Drawing.Size(564, 50);
            this.gpbCli.TabIndex = 6;
            this.gpbCli.TabStop = false;
            this.gpbCli.Text = "Cliente";
            // 
            // comboBox3
            // 
            this.comboBox3.DisplayMember = "descricao";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(109, 231);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(460, 21);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.ValueMember = "id_forma_pag";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Qtd Dias";
            // 
            // txtQtdDias_C
            // 
            this.txtQtdDias_C.Location = new System.Drawing.Point(219, 20);
            this.txtQtdDias_C.Name = "txtQtdDias_C";
            this.txtQtdDias_C.Size = new System.Drawing.Size(51, 21);
            this.txtQtdDias_C.TabIndex = 9;
            // 
            // cmbFrete_C
            // 
            this.cmbFrete_C.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrete_C.FormattingEnabled = true;
            this.cmbFrete_C.Items.AddRange(new object[] {
            "CIF",
            "FOB"});
            this.cmbFrete_C.Location = new System.Drawing.Point(95, 20);
            this.cmbFrete_C.Name = "cmbFrete_C";
            this.cmbFrete_C.Size = new System.Drawing.Size(51, 21);
            this.cmbFrete_C.TabIndex = 7;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(94, 320);
            this.txtObs.MaxLength = 60;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(487, 21);
            this.txtObs.TabIndex = 18;
            this.txtObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // chkMLE
            // 
            this.chkMLE.AutoSize = true;
            this.chkMLE.Location = new System.Drawing.Point(223, 348);
            this.chkMLE.Name = "chkMLE";
            this.chkMLE.Size = new System.Drawing.Size(15, 14);
            this.chkMLE.TabIndex = 19;
            this.chkMLE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            this.chkMLE.CheckedChanged += new System.EventHandler(this.chkMLE_CheckedChanged);
            // 
            // tabEndEntrega
            // 
            this.tabEndEntrega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabEndEntrega.Controls.Add(this.txtBairro_LE);
            this.tabEndEntrega.Controls.Add(label1);
            this.tabEndEntrega.Controls.Add(this.txtCep_LE);
            this.tabEndEntrega.Controls.Add(label2);
            this.tabEndEntrega.Controls.Add(this.cmbUf_LE);
            this.tabEndEntrega.Controls.Add(label3);
            this.tabEndEntrega.Controls.Add(this.cmbCidade_LE);
            this.tabEndEntrega.Controls.Add(label4);
            this.tabEndEntrega.Controls.Add(label5);
            this.tabEndEntrega.Controls.Add(this.txtReferencia_LE);
            this.tabEndEntrega.Controls.Add(label6);
            this.tabEndEntrega.Controls.Add(this.txtEndereco_LE);
            this.tabEndEntrega.Location = new System.Drawing.Point(4, 22);
            this.tabEndEntrega.Name = "tabEndEntrega";
            this.tabEndEntrega.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndEntrega.Size = new System.Drawing.Size(590, 374);
            this.tabEndEntrega.TabIndex = 3;
            this.tabEndEntrega.Text = "Endereço para Entrega";
            this.tabEndEntrega.UseVisualStyleBackColor = true;
            this.tabEndEntrega.Enter += new System.EventHandler(this.tabEndEntrega_Enter);
            // 
            // txtBairro_LE
            // 
            this.txtBairro_LE.Location = new System.Drawing.Point(86, 69);
            this.txtBairro_LE.MaxLength = 40;
            this.txtBairro_LE.Name = "txtBairro_LE";
            this.txtBairro_LE.Size = new System.Drawing.Size(333, 21);
            this.txtBairro_LE.TabIndex = 5;
            // 
            // txtCep_LE
            // 
            this.txtCep_LE.Location = new System.Drawing.Point(491, 69);
            this.txtCep_LE.Mask = "00,000-999";
            this.txtCep_LE.Name = "txtCep_LE";
            this.txtCep_LE.PromptChar = ' ';
            this.txtCep_LE.Size = new System.Drawing.Size(82, 21);
            this.txtCep_LE.TabIndex = 7;
            this.txtCep_LE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // cmbUf_LE
            // 
            this.cmbUf_LE.FormattingEnabled = true;
            this.cmbUf_LE.Location = new System.Drawing.Point(529, 96);
            this.cmbUf_LE.Name = "cmbUf_LE";
            this.cmbUf_LE.Size = new System.Drawing.Size(44, 21);
            this.cmbUf_LE.TabIndex = 11;
            this.cmbUf_LE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // cmbCidade_LE
            // 
            this.cmbCidade_LE.FormattingEnabled = true;
            this.cmbCidade_LE.Location = new System.Drawing.Point(86, 96);
            this.cmbCidade_LE.Name = "cmbCidade_LE";
            this.cmbCidade_LE.Size = new System.Drawing.Size(333, 21);
            this.cmbCidade_LE.TabIndex = 9;
            this.cmbCidade_LE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtReferencia_LE
            // 
            this.txtReferencia_LE.Location = new System.Drawing.Point(86, 42);
            this.txtReferencia_LE.MaxLength = 60;
            this.txtReferencia_LE.Name = "txtReferencia_LE";
            this.txtReferencia_LE.Size = new System.Drawing.Size(487, 21);
            this.txtReferencia_LE.TabIndex = 3;
            this.txtReferencia_LE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtEndereco_LE
            // 
            this.txtEndereco_LE.Location = new System.Drawing.Point(86, 15);
            this.txtEndereco_LE.MaxLength = 60;
            this.txtEndereco_LE.Name = "txtEndereco_LE";
            this.txtEndereco_LE.Size = new System.Drawing.Size(487, 21);
            this.txtEndereco_LE.TabIndex = 1;
            this.txtEndereco_LE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // tabContatos
            // 
            this.tabContatos.AutoScroll = true;
            this.tabContatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabContatos.Controls.Add(this.toolCons);
            this.tabContatos.Controls.Add(label8);
            this.tabContatos.Controls.Add(this.txtCargo);
            this.tabContatos.Controls.Add(this.gridContatos);
            this.tabContatos.Controls.Add(id_contatoLabel);
            this.tabContatos.Controls.Add(this.txtCodContato);
            this.tabContatos.Controls.Add(nomeLabel);
            this.tabContatos.Controls.Add(this.txtNome);
            this.tabContatos.Controls.Add(telefoneLabel);
            this.tabContatos.Controls.Add(this.txtTelefone);
            this.tabContatos.Controls.Add(faxLabel);
            this.tabContatos.Controls.Add(this.txtFax);
            this.tabContatos.Controls.Add(celularLabel);
            this.tabContatos.Controls.Add(this.txtCelular);
            this.tabContatos.Controls.Add(emailLabel);
            this.tabContatos.Controls.Add(this.txtEmail);
            this.tabContatos.Location = new System.Drawing.Point(4, 22);
            this.tabContatos.Name = "tabContatos";
            this.tabContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabContatos.Size = new System.Drawing.Size(590, 374);
            this.tabContatos.TabIndex = 4;
            this.tabContatos.Text = "Contatos";
            this.tabContatos.UseVisualStyleBackColor = true;
            this.tabContatos.Enter += new System.EventHandler(this.tabContatos_Enter);
            this.tabContatos.Leave += new System.EventHandler(this.tabContatos_Leave);
            // 
            // toolCons
            // 
            this.toolCons.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errErro.SetIconAlignment(this.toolCons, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.toolCons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovoCont,
            this.btnGravarCont,
            this.btnExcluirCont});
            this.toolCons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolCons.Location = new System.Drawing.Point(3, 3);
            this.toolCons.Name = "toolCons";
            this.toolCons.Size = new System.Drawing.Size(580, 23);
            this.toolCons.TabIndex = 16;
            // 
            // btnNovoCont
            // 
            this.btnNovoCont.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoCont.Image")));
            this.btnNovoCont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovoCont.Name = "btnNovoCont";
            this.btnNovoCont.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNovoCont.Size = new System.Drawing.Size(56, 20);
            this.btnNovoCont.Text = "&Novo";
            this.btnNovoCont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCont.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnNovoCont.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNovoCont.ToolTipText = "Adiciona um Novo Registro";
            this.btnNovoCont.Click += new System.EventHandler(this.btnNovoCont_Click);
            // 
            // btnGravarCont
            // 
            this.btnGravarCont.Enabled = false;
            this.btnGravarCont.Image = ((System.Drawing.Image)(resources.GetObject("btnGravarCont.Image")));
            this.btnGravarCont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravarCont.Name = "btnGravarCont";
            this.btnGravarCont.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGravarCont.Size = new System.Drawing.Size(67, 20);
            this.btnGravarCont.Text = "&Gravar";
            this.btnGravarCont.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGravarCont.ToolTipText = "Grava o Registro Editado";
            this.btnGravarCont.Click += new System.EventHandler(this.btnGravarCont_Click);
            // 
            // btnExcluirCont
            // 
            this.btnExcluirCont.Enabled = false;
            this.btnExcluirCont.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCont.Image")));
            this.btnExcluirCont.Name = "btnExcluirCont";
            this.btnExcluirCont.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExcluirCont.RightToLeftAutoMirrorImage = true;
            this.btnExcluirCont.Size = new System.Drawing.Size(64, 20);
            this.btnExcluirCont.Text = "Delete";
            this.btnExcluirCont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirCont.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluirCont.Click += new System.EventHandler(this.btnExcluirCont_Click);
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.Black;
            this.txtCargo.Location = new System.Drawing.Point(70, 145);
            this.txtCargo.MaxLength = 40;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(295, 21);
            this.txtCargo.TabIndex = 13;
            // 
            // gridContatos
            // 
            this.gridContatos.AllowUserToAddRows = false;
            this.gridContatos.AllowUserToDeleteRows = false;
            this.gridContatos.AllowUserToOrderColumns = true;
            this.gridContatos.Location = new System.Drawing.Point(22, 174);
            this.gridContatos.Name = "gridContatos";
            this.gridContatos.ReadOnly = true;
            this.gridContatos.Size = new System.Drawing.Size(557, 187);
            this.gridContatos.TabIndex = 14;
            this.gridContatos.DoubleClick += new System.EventHandler(this.gridContatos_DoubleClick);
            // 
            // txtCodContato
            // 
            this.txtCodContato.Location = new System.Drawing.Point(70, 37);
            this.txtCodContato.Name = "txtCodContato";
            this.txtCodContato.ReadOnly = true;
            this.txtCodContato.Size = new System.Drawing.Size(77, 21);
            this.txtCodContato.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(70, 64);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(487, 21);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(70, 91);
            this.txtTelefone.MaxLength = 12;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 21);
            this.txtTelefone.TabIndex = 5;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(265, 91);
            this.txtFax.MaxLength = 12;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 21);
            this.txtFax.TabIndex = 7;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(457, 91);
            this.txtCelular.MaxLength = 12;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 21);
            this.txtCelular.TabIndex = 9;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Blue;
            this.txtEmail.Location = new System.Drawing.Point(70, 118);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(487, 21);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.Location = new System.Drawing.Point(284, 15);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(91, 15);
            this.lblDataCadastro.TabIndex = 36;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(94, 146);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(333, 21);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // rdbNao
            // 
            this.rdbNao.AutoSize = true;
            this.rdbNao.Location = new System.Drawing.Point(534, 348);
            this.rdbNao.Name = "rdbNao";
            this.rdbNao.Size = new System.Drawing.Size(47, 17);
            this.rdbNao.TabIndex = 23;
            this.rdbNao.Text = "Não";
            this.rdbNao.UseVisualStyleBackColor = true;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Checked = true;
            this.rdbSim.Location = new System.Drawing.Point(481, 348);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(47, 17);
            this.rdbSim.TabIndex = 22;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Sim";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ativo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair,
            this.toolStripSeparator,
            this.btnGravar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 401);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(598, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSair.Size = new System.Drawing.Size(50, 22);
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSair.ToolTipText = "Sair do Formulário";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGravar.Size = new System.Drawing.Size(67, 22);
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGravar.ToolTipText = "Grava o Registro Editado";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // chkCadStatus
            // 
            this.chkCadStatus.AutoSize = true;
            this.chkCadStatus.Location = new System.Drawing.Point(384, 348);
            this.chkCadStatus.Name = "chkCadStatus";
            this.chkCadStatus.Size = new System.Drawing.Size(15, 14);
            this.chkCadStatus.TabIndex = 20;
            this.chkCadStatus.UseVisualStyleBackColor = true;
            this.chkCadStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // txtLimCred
            // 
            this.txtLimCred.Location = new System.Drawing.Point(473, 12);
            this.txtLimCred.Name = "txtLimCred";
            this.txtLimCred.Size = new System.Drawing.Size(108, 21);
            this.txtLimCred.TabIndex = 34;
            this.txtLimCred.Leave += new System.EventHandler(this.txtLimCred_Leave);
            this.txtLimCred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazaoSocial_KeyPress);
            // 
            // linkCNPJ
            // 
            this.linkCNPJ.AutoSize = true;
            this.linkCNPJ.Location = new System.Drawing.Point(232, 245);
            this.linkCNPJ.Name = "linkCNPJ";
            this.linkCNPJ.Size = new System.Drawing.Size(19, 13);
            this.linkCNPJ.TabIndex = 44;
            this.linkCNPJ.TabStop = true;
            this.linkCNPJ.Text = "...";
            this.linkCNPJ.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCNPJ_LinkClicked);
            // 
            // linkCPF
            // 
            this.linkCPF.AutoSize = true;
            this.linkCPF.Location = new System.Drawing.Point(200, 271);
            this.linkCPF.Name = "linkCPF";
            this.linkCPF.Size = new System.Drawing.Size(19, 13);
            this.linkCPF.TabIndex = 43;
            this.linkCPF.TabStop = true;
            this.linkCPF.Text = "...";
            this.linkCPF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCPF_LinkClicked);
            // 
            // chkServico
            // 
            this.chkServico.AutoSize = true;
            this.chkServico.BackColor = System.Drawing.Color.Yellow;
            this.chkServico.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkServico.Location = new System.Drawing.Point(495, 296);
            this.chkServico.Name = "chkServico";
            this.chkServico.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkServico.Size = new System.Drawing.Size(85, 17);
            this.chkServico.TabIndex = 17;
            this.chkServico.Text = "EMPRESA";
            this.chkServico.UseVisualStyleBackColor = false;
            this.chkServico.CheckedChanged += new System.EventHandler(this.chkServico_CheckedChanged);
            // 
            // pESSOABindingSource
            // 
            this.pESSOABindingSource.DataMember = "PESSOA";
            this.pESSOABindingSource.DataSource = this.dsContatos;
            // 
            // dsContatos
            // 
            this.dsContatos.DataSetName = "dsContatos";
            this.dsContatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pESSOATableAdapter
            // 
            this.pESSOATableAdapter.ClearBeforeFill = true;
            // 
            // frmPessoaCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(598, 426);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPessoaCad";
            this.Text = "Manutenção do Cadastro de Cliente/Fornecedor/Vendedor";
            this.Load += new System.EventHandler(this.frmPessoaCad_Load);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.tabDados, 0);
            this.tabDados.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.rdgTipo.ResumeLayout(false);
            this.rdgTipo.PerformLayout();
            this.tabOutros.ResumeLayout(false);
            this.gpbForn.ResumeLayout(false);
            this.gpbForn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdDias_F)).EndInit();
            this.gpbCli.ResumeLayout(false);
            this.gpbCli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdDias_C)).EndInit();
            this.tabEndEntrega.ResumeLayout(false);
            this.tabEndEntrega.PerformLayout();
            this.tabContatos.ResumeLayout(false);
            this.tabContatos.PerformLayout();
            this.toolCons.ResumeLayout(false);
            this.toolCons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pESSOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsContatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.CheckBox chkVendedor;
        private System.Windows.Forms.CheckBox chkTransp;
        private System.Windows.Forms.CheckBox chkFornecedor;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.GroupBox rdgTipo;
        private System.Windows.Forms.RadioButton rdbJuridica;
        private System.Windows.Forms.RadioButton rdbFisica;
        private System.Windows.Forms.TextBox txtOrgaoRg;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtIE;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TabPage tabOutros;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TabPage tabEndEntrega;
        private System.Windows.Forms.MaskedTextBox txtCep_LE;
        private System.Windows.Forms.ComboBox cmbUf_LE;
        private System.Windows.Forms.ComboBox cmbCidade_LE;
        private System.Windows.Forms.TextBox txtReferencia_LE;
        private System.Windows.Forms.TextBox txtEndereco_LE;
        private System.Windows.Forms.CheckBox chkMLE;
        private System.Windows.Forms.Label lblDataCadastro;
        private dsContatos dsContatos;
        private System.Windows.Forms.DataGridView gridContatos;
        private System.Windows.Forms.TextBox txtCodContato;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TabPage tabContatos;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtBairro_LE;
        private System.Windows.Forms.RadioButton rdbNao;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCargo;
        public System.Windows.Forms.ToolStrip toolCons;
        public System.Windows.Forms.ToolStripButton btnNovoCont;
        public System.Windows.Forms.ToolStripButton btnGravarCont;
        public System.Windows.Forms.ToolStripButton btnExcluirCont;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        public System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.CheckBox chkCadStatus;
        private System.Windows.Forms.GroupBox gpbCli;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtQtdDias_C;
        private System.Windows.Forms.ComboBox cmbFrete_C;
        private System.Windows.Forms.GroupBox gpbForn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown txtQtdDias_F;
        private System.Windows.Forms.ComboBox cmbFrete_F;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource pESSOABindingSource;
        private PPDotNet.DataSources.dsContatosTableAdapters.PESSOATableAdapter pESSOATableAdapter;
        private System.Windows.Forms.TextBox txtLimCred;
        private System.Windows.Forms.LinkLabel linkCPF;
        private System.Windows.Forms.LinkLabel linkCNPJ;
        private System.Windows.Forms.CheckBox chkServico;
    }
}

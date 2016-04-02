using PPDotNet.DataSources;

namespace PPDotNet.Formulários.Saída
{
    partial class frmSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaida));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNotaFiscal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRecibo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBoleto = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.btnLocCliente = new System.Windows.Forms.Button();
            this.txtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNotaFiscal = new System.Windows.Forms.TextBox();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSaida = new PPDotNet.DataSources.dsSaida();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.calculatorButton1 = new PopCalc.Library.CalculatorButton();
            this.txtVlrUnitario = new System.Windows.Forms.TextBox();
            this.txtICMS = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtVlrTotal = new System.Windows.Forms.TextBox();
            this.txtPerDesconto = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.btnLocProd = new System.Windows.Forms.Button();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gridItens = new System.Windows.Forms.DataGridView();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblOrientacao = new System.Windows.Forms.Label();
            this.cmbCfop = new System.Windows.Forms.ComboBox();
            this.cFOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotPed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cFOPTableAdapter = new PPDotNet.DataSources.dsSaidaTableAdapters.CFOPTableAdapter();
            this.vendedorTableAdapter1 = new PPDotNet.DataSources.dsSaidaTableAdapters.VendedorTableAdapter();
            this.txtSelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFrete = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtQtdTransp = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.txtUFPlaca = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtNomeRazao = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.rdbEmitente = new System.Windows.Forms.RadioButton();
            this.rdbDest = new System.Windows.Forms.RadioButton();
            this.txtObs2 = new System.Windows.Forms.TextBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.eMPRESATableAdapter = new PPDotNet.DataSources.dsSaidaTableAdapters.EMPRESATableAdapter();
            this.tabDados.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFOPBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlFrete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDados
            // 
            this.tabDados.Size = new System.Drawing.Size(792, 511);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.cmbEmpresa);
            this.tabPage2.Controls.Add(this.txtObs2);
            this.tabPage2.Controls.Add(this.rdbDest);
            this.tabPage2.Controls.Add(this.rdbEmitente);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.pnlFrete);
            this.tabPage2.Controls.Add(this.txtSelo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.cmbCfop);
            this.tabPage2.Controls.Add(this.lblOrientacao);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.txtObs);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.gridItens);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.cmbVendedor);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtNotaFiscal);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtFantasia);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtDataEmissao);
            this.tabPage2.Controls.Add(this.btnLocCliente);
            this.tabPage2.Controls.Add(this.txtCodCliente);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Size = new System.Drawing.Size(784, 485);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair,
            this.toolStripSeparator,
            this.btnGravar,
            this.btnExcluir,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 507);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 5;
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
            this.btnGravar.CheckOnClick = true;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGravar.Size = new System.Drawing.Size(67, 22);
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGravar.ToolTipText = "Grava o Registro Editado";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeftAutoMirrorImage = true;
            this.btnExcluir.Size = new System.Drawing.Size(95, 22);
            this.btnExcluir.Text = "&Delete Item";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPedido,
            this.btnNotaFiscal,
            this.btnRecibo,
            this.btnBoleto});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(103, 22);
            this.toolStripDropDownButton1.Text = "Impressões";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btnPedido
            // 
            this.btnPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPedido.Image")));
            this.btnPedido.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(146, 22);
            this.btnPedido.Text = "Pedido";
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnNotaFiscal
            // 
            this.btnNotaFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnNotaFiscal.Image")));
            this.btnNotaFiscal.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNotaFiscal.Name = "btnNotaFiscal";
            this.btnNotaFiscal.Size = new System.Drawing.Size(146, 22);
            this.btnNotaFiscal.Text = "Nota Fiscal";
            this.btnNotaFiscal.Click += new System.EventHandler(this.btnNotaFiscal_Click);
            // 
            // btnRecibo
            // 
            this.btnRecibo.Image = ((System.Drawing.Image)(resources.GetObject("btnRecibo.Image")));
            this.btnRecibo.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(146, 22);
            this.btnRecibo.Text = "Recibo";
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // btnBoleto
            // 
            this.btnBoleto.Enabled = false;
            this.btnBoleto.Image = ((System.Drawing.Image)(resources.GetObject("btnBoleto.Image")));
            this.btnBoleto.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnBoleto.Name = "btnBoleto";
            this.btnBoleto.Size = new System.Drawing.Size(146, 22);
            this.btnBoleto.Text = "Boleto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(171, 69);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(97, 21);
            this.txtCodigo.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cliente";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(171, 27);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(77, 21);
            this.txtCodCliente.TabIndex = 2;
            this.totToolTip.SetToolTip(this.txtCodCliente, "Pressione F10 para Localizar um Cliente");
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            this.txtCodCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodCliente_KeyDown);
            // 
            // btnLocCliente
            // 
            this.btnLocCliente.Location = new System.Drawing.Point(644, 27);
            this.btnLocCliente.Name = "btnLocCliente";
            this.btnLocCliente.Size = new System.Drawing.Size(48, 21);
            this.btnLocCliente.TabIndex = 23;
            this.btnLocCliente.Text = "&Achar";
            this.btnLocCliente.UseVisualStyleBackColor = true;
            this.btnLocCliente.Click += new System.EventHandler(this.btnLocCliente_Click);
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEmissao.Location = new System.Drawing.Point(171, 48);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(97, 21);
            this.txtDataEmissao.TabIndex = 3;
            this.txtDataEmissao.Value = new System.DateTime(2006, 11, 23, 0, 0, 0, 0);
            this.txtDataEmissao.Leave += new System.EventHandler(this.txtDataEmissao_Leave);
            this.txtDataEmissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Data Emissão";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(254, 27);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.ReadOnly = true;
            this.txtFantasia.Size = new System.Drawing.Size(384, 21);
            this.txtFantasia.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nota Fiscal";
            // 
            // txtNotaFiscal
            // 
            this.txtNotaFiscal.Location = new System.Drawing.Point(369, 69);
            this.txtNotaFiscal.MaxLength = 12;
            this.txtNotaFiscal.Name = "txtNotaFiscal";
            this.txtNotaFiscal.Size = new System.Drawing.Size(97, 21);
            this.txtNotaFiscal.TabIndex = 6;
            this.txtNotaFiscal.Leave += new System.EventHandler(this.txtNotaFiscal_Leave);
            this.txtNotaFiscal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.DataSource = this.vendedorBindingSource;
            this.cmbVendedor.DisplayMember = "fantasia";
            this.cmbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(171, 90);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(333, 21);
            this.cmbVendedor.TabIndex = 7;
            this.cmbVendedor.ValueMember = "id_pessoa";
            this.cmbVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataMember = "Vendedor";
            this.vendedorBindingSource.DataSource = this.dsSaida;
            // 
            // dsSaida
            // 
            this.dsSaida.DataSetName = "dsSaida";
            this.dsSaida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Vendedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.cmbUnidade);
            this.groupBox1.Controls.Add(this.calculatorButton1);
            this.groupBox1.Controls.Add(this.txtICMS);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtVlrTotal);
            this.groupBox1.Controls.Add(this.txtPerDesconto);
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Controls.Add(this.txtVlrUnitario);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtDescProd);
            this.groupBox1.Controls.Add(this.btnLocProd);
            this.groupBox1.Controls.Add(this.txtCodProd);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(6, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 86);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(167, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 13);
            this.label27.TabIndex = 11;
            this.label27.Text = "Unidade";
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "PC",
            "MO",
            "UN"});
            this.cmbUnidade.Location = new System.Drawing.Point(222, 35);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(62, 21);
            this.cmbUnidade.TabIndex = 2;
            this.cmbUnidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // calculatorButton1
            // 
            this.calculatorButton1.BackColor = System.Drawing.SystemColors.Control;
            this.calculatorButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("calculatorButton1.ButtonImage")));
            this.calculatorButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.calculatorButton1.Location = new System.Drawing.Point(164, 61);
            this.calculatorButton1.Name = "calculatorButton1";
            this.calculatorButton1.ResultControl = this.txtVlrUnitario;
            this.calculatorButton1.Size = new System.Drawing.Size(20, 20);
            this.calculatorButton1.TabIndex = 10;
            this.calculatorButton1.Text = "calculatorButton1";
            // 
            // txtVlrUnitario
            // 
            this.txtVlrUnitario.Location = new System.Drawing.Point(83, 57);
            this.txtVlrUnitario.Name = "txtVlrUnitario";
            this.txtVlrUnitario.Size = new System.Drawing.Size(77, 21);
            this.txtVlrUnitario.TabIndex = 3;
            this.txtVlrUnitario.Leave += new System.EventHandler(this.txtVlrUnitario_Leave);
            this.txtVlrUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtICMS
            // 
            this.txtICMS.Location = new System.Drawing.Point(83, 35);
            this.txtICMS.Name = "txtICMS";
            this.txtICMS.Size = new System.Drawing.Size(77, 21);
            this.txtICMS.TabIndex = 1;
            this.txtICMS.Leave += new System.EventHandler(this.txtICMS_Leave);
            this.txtICMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "ICMS %";
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(514, 57);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.ReadOnly = true;
            this.txtVlrTotal.Size = new System.Drawing.Size(90, 21);
            this.txtVlrTotal.TabIndex = 6;
            this.txtVlrTotal.Leave += new System.EventHandler(this.txtVlrTotal_Leave);
            this.txtVlrTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrTotal_KeyPress);
            // 
            // txtPerDesconto
            // 
            this.txtPerDesconto.Location = new System.Drawing.Point(380, 57);
            this.txtPerDesconto.Name = "txtPerDesconto";
            this.txtPerDesconto.Size = new System.Drawing.Size(77, 21);
            this.txtPerDesconto.TabIndex = 5;
            this.txtPerDesconto.Leave += new System.EventHandler(this.txtPerDesconto_Leave);
            this.txtPerDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(222, 57);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(62, 21);
            this.txtQtd.TabIndex = 4;
            this.txtQtd.Leave += new System.EventHandler(this.txtQtd_Leave);
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(479, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Total";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(301, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "% Desconto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(193, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Qtd";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Vlr Unitário";
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(166, 13);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.ReadOnly = true;
            this.txtDescProd.Size = new System.Drawing.Size(384, 21);
            this.txtDescProd.TabIndex = 12;
            // 
            // btnLocProd
            // 
            this.btnLocProd.Location = new System.Drawing.Point(556, 13);
            this.btnLocProd.Name = "btnLocProd";
            this.btnLocProd.Size = new System.Drawing.Size(48, 21);
            this.btnLocProd.TabIndex = 16;
            this.btnLocProd.Text = "A&char";
            this.btnLocProd.UseVisualStyleBackColor = true;
            this.btnLocProd.Click += new System.EventHandler(this.btnLocProd_Click);
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(83, 13);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(77, 21);
            this.txtCodProd.TabIndex = 0;
            this.totToolTip.SetToolTip(this.txtCodProd, "Pressione F10 para Localizar um Produto");
            this.txtCodProd.Leave += new System.EventHandler(this.txtCodProd_Leave);
            this.txtCodProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            this.txtCodProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProd_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Produto";
            // 
            // gridItens
            // 
            this.gridItens.AllowUserToAddRows = false;
            this.gridItens.AllowUserToDeleteRows = false;
            this.gridItens.AllowUserToOrderColumns = true;
            this.gridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItens.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridItens.Location = new System.Drawing.Point(3, 235);
            this.gridItens.Name = "gridItens";
            this.gridItens.ReadOnly = true;
            this.gridItens.RowTemplate.Height = 23;
            this.gridItens.Size = new System.Drawing.Size(774, 243);
            this.gridItens.TabIndex = 33;
            this.gridItens.DoubleClick += new System.EventHandler(this.gridItens_DoubleClick);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(171, 111);
            this.txtObs.MaxLength = 60;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(521, 21);
            this.txtObs.TabIndex = 9;
            this.txtObs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(138, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "Obs";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(129, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "CFOP";
            // 
            // lblOrientacao
            // 
            this.lblOrientacao.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrientacao.ForeColor = System.Drawing.Color.Red;
            this.lblOrientacao.Location = new System.Drawing.Point(239, 10);
            this.lblOrientacao.Name = "lblOrientacao";
            this.lblOrientacao.Size = new System.Drawing.Size(174, 13);
            this.lblOrientacao.TabIndex = 17;
            this.lblOrientacao.Text = "...";
            // 
            // cmbCfop
            // 
            this.cmbCfop.DataSource = this.cFOPBindingSource;
            this.cmbCfop.DisplayMember = "id_cfop";
            this.cmbCfop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCfop.FormattingEnabled = true;
            this.cmbCfop.Location = new System.Drawing.Point(171, 6);
            this.cmbCfop.Name = "cmbCfop";
            this.cmbCfop.Size = new System.Drawing.Size(62, 21);
            this.cmbCfop.TabIndex = 0;
            this.cmbCfop.ValueMember = "id_cfop";
            this.cmbCfop.SelectedIndexChanged += new System.EventHandler(this.cmbCfop_SelectedIndexChanged);
            this.cmbCfop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // cFOPBindingSource
            // 
            this.cFOPBindingSource.DataMember = "CFOP";
            this.cFOPBindingSource.DataSource = this.dsSaida;
            // 
            // lblTotPed
            // 
            this.lblTotPed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotPed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotPed.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotPed.ForeColor = System.Drawing.Color.Blue;
            this.lblTotPed.Location = new System.Drawing.Point(6, 26);
            this.lblTotPed.Name = "lblTotPed";
            this.lblTotPed.Size = new System.Drawing.Size(133, 22);
            this.lblTotPed.TabIndex = 16;
            this.lblTotPed.Text = "0,00";
            this.lblTotPed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(28, -34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotPed);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(629, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 56);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total do Pedido";
            // 
            // cFOPTableAdapter
            // 
            this.cFOPTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorTableAdapter1
            // 
            this.vendedorTableAdapter1.ClearBeforeFill = true;
            // 
            // txtSelo
            // 
            this.txtSelo.Location = new System.Drawing.Point(548, 89);
            this.txtSelo.MaxLength = 20;
            this.txtSelo.Name = "txtSelo";
            this.txtSelo.Size = new System.Drawing.Size(144, 21);
            this.txtSelo.TabIndex = 8;
            this.txtSelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Selo";
            // 
            // pnlFrete
            // 
            this.pnlFrete.Controls.Add(this.button1);
            this.pnlFrete.Controls.Add(this.label25);
            this.pnlFrete.Controls.Add(this.label24);
            this.pnlFrete.Controls.Add(this.label22);
            this.pnlFrete.Controls.Add(this.label14);
            this.pnlFrete.Controls.Add(this.label12);
            this.pnlFrete.Controls.Add(this.label11);
            this.pnlFrete.Controls.Add(this.label9);
            this.pnlFrete.Controls.Add(this.label8);
            this.pnlFrete.Controls.Add(this.label7);
            this.pnlFrete.Controls.Add(this.label5);
            this.pnlFrete.Controls.Add(this.txtEspecie);
            this.pnlFrete.Controls.Add(this.txtQtdTransp);
            this.pnlFrete.Controls.Add(this.txtUF);
            this.pnlFrete.Controls.Add(this.txtMunicipio);
            this.pnlFrete.Controls.Add(this.txtIE);
            this.pnlFrete.Controls.Add(this.txtEndereco);
            this.pnlFrete.Controls.Add(this.txtCpfCnpj);
            this.pnlFrete.Controls.Add(this.txtUFPlaca);
            this.pnlFrete.Controls.Add(this.txtPlaca);
            this.pnlFrete.Controls.Add(this.txtNomeRazao);
            this.pnlFrete.Location = new System.Drawing.Point(132, 251);
            this.pnlFrete.Name = "pnlFrete";
            this.pnlFrete.Size = new System.Drawing.Size(522, 214);
            this.pnlFrete.TabIndex = 0;
            this.pnlFrete.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(265, 160);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 13);
            this.label25.TabIndex = 19;
            this.label25.Text = "Espécie";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(52, 160);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 13);
            this.label24.TabIndex = 18;
            this.label24.Text = "Quantidade";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(297, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 17;
            this.label22.Text = "UF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(65, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Município";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Endereço";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "UF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Placa Veículo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Insc.Estadual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CPF/CNPJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome/Razão Social";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(319, 152);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(100, 21);
            this.txtEspecie.TabIndex = 9;
            this.txtEspecie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtQtdTransp
            // 
            this.txtQtdTransp.Location = new System.Drawing.Point(126, 152);
            this.txtQtdTransp.Name = "txtQtdTransp";
            this.txtQtdTransp.Size = new System.Drawing.Size(100, 21);
            this.txtQtdTransp.TabIndex = 8;
            this.txtQtdTransp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(319, 125);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(21, 21);
            this.txtUF.TabIndex = 7;
            this.txtUF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(126, 124);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(138, 21);
            this.txtMunicipio.TabIndex = 6;
            this.txtMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(375, 42);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(134, 21);
            this.txtIE.TabIndex = 2;
            this.txtIE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(126, 96);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(383, 21);
            this.txtEndereco.TabIndex = 5;
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(126, 42);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(138, 21);
            this.txtCpfCnpj.TabIndex = 1;
            this.txtCpfCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtUFPlaca
            // 
            this.txtUFPlaca.Location = new System.Drawing.Point(277, 69);
            this.txtUFPlaca.Name = "txtUFPlaca";
            this.txtUFPlaca.Size = new System.Drawing.Size(21, 21);
            this.txtUFPlaca.TabIndex = 4;
            this.txtUFPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(126, 69);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 21);
            this.txtPlaca.TabIndex = 3;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // txtNomeRazao
            // 
            this.txtNomeRazao.Location = new System.Drawing.Point(126, 15);
            this.txtNomeRazao.Name = "txtNomeRazao";
            this.txtNomeRazao.Size = new System.Drawing.Size(383, 21);
            this.txtNomeRazao.TabIndex = 0;
            this.txtNomeRazao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(293, 56);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "Frete Por Conta";
            // 
            // rdbEmitente
            // 
            this.rdbEmitente.AutoSize = true;
            this.rdbEmitente.Checked = true;
            this.rdbEmitente.Location = new System.Drawing.Point(398, 50);
            this.rdbEmitente.Name = "rdbEmitente";
            this.rdbEmitente.Size = new System.Drawing.Size(75, 17);
            this.rdbEmitente.TabIndex = 4;
            this.rdbEmitente.TabStop = true;
            this.rdbEmitente.Text = "Emitente";
            this.rdbEmitente.UseVisualStyleBackColor = true;
            this.rdbEmitente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // rdbDest
            // 
            this.rdbDest.AutoSize = true;
            this.rdbDest.Location = new System.Drawing.Point(476, 51);
            this.rdbDest.Name = "rdbDest";
            this.rdbDest.Size = new System.Drawing.Size(94, 17);
            this.rdbDest.TabIndex = 5;
            this.rdbDest.Text = "Destinatário";
            this.rdbDest.UseVisualStyleBackColor = true;
            this.rdbDest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            this.rdbDest.CheckedChanged += new System.EventHandler(this.rdbDest_CheckedChanged);
            // 
            // txtObs2
            // 
            this.txtObs2.Location = new System.Drawing.Point(171, 132);
            this.txtObs2.MaxLength = 60;
            this.txtObs2.Name = "txtObs2";
            this.txtObs2.Size = new System.Drawing.Size(521, 21);
            this.txtObs2.TabIndex = 10;
            this.txtObs2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObs2_KeyPress);
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DataSource = this.eMPRESABindingSource;
            this.cmbEmpresa.DisplayMember = "fantasia";
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(476, 6);
            this.cmbEmpresa.MaxLength = 60;
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(216, 21);
            this.cmbEmpresa.TabIndex = 1;
            this.cmbEmpresa.ValueMember = "id_pessoa";
            this.cmbEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            // 
            // eMPRESABindingSource
            // 
            this.eMPRESABindingSource.DataMember = "EMPRESA";
            this.eMPRESABindingSource.DataSource = this.dsSaida;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(419, 10);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 13);
            this.label28.TabIndex = 22;
            this.label28.Text = "Empresa";
            // 
            // eMPRESATableAdapter
            // 
            this.eMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // frmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(792, 532);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSaida";
            this.Text = "Manutenção de Pedidos - Saída";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSaida_KeyPress);
            this.Load += new System.EventHandler(this.frmSaida_Load);
            this.Controls.SetChildIndex(this.tabDados, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.tabDados.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFOPBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlFrete.ResumeLayout(false);
            this.pnlFrete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        public System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLocCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDataEmissao;
        private System.Windows.Forms.TextBox txtNotaFiscal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridItens;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.Button btnLocProd;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVlrTotal;
        private System.Windows.Forms.TextBox txtPerDesconto;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtVlrUnitario;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtICMS;
        private System.Windows.Forms.Label label21;
        //private dsSaida dsSaida;
        //private dsContatos dsContatos;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.Label lblOrientacao;
        private System.Windows.Forms.ComboBox cmbCfop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotPed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnBoleto;
        private System.Windows.Forms.ToolStripMenuItem btnRecibo;
        private System.Windows.Forms.ToolStripMenuItem btnNotaFiscal;
        private System.Windows.Forms.ToolStripMenuItem btnPedido;
        private PopCalc.Library.CalculatorButton calculatorButton1;
        private dsSaida dsSaida;
        private System.Windows.Forms.BindingSource cFOPBindingSource;
        private PPDotNet.DataSources.dsSaidaTableAdapters.CFOPTableAdapter cFOPTableAdapter;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private PPDotNet.DataSources.dsSaidaTableAdapters.VendedorTableAdapter vendedorTableAdapter1;
        private System.Windows.Forms.TextBox txtSelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlFrete;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtUFPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtNomeRazao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtQtdTransp;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.RadioButton rdbDest;
        private System.Windows.Forms.RadioButton rdbEmitente;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtObs2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.BindingSource eMPRESABindingSource;
        private PPDotNet.DataSources.dsSaidaTableAdapters.EMPRESATableAdapter eMPRESATableAdapter;
    }
}

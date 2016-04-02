using PPDotNet.DataSources;

namespace PPDotNet.Formulários.Saída
{
    partial class frmOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamento));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.btnLocCliente = new System.Windows.Forms.Button();
            this.txtDtEntrada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMecanico = new System.Windows.Forms.TextBox();
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
            this.lblTotPed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSaida = new PPDotNet.DataSources.dsSaida();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.cmbCombustivel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbGarantia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrdemServico = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cFOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cFOPTableAdapter = new PPDotNet.DataSources.dsSaidaTableAdapters.CFOPTableAdapter();
            this.vendedorTableAdapter1 = new PPDotNet.DataSources.dsSaidaTableAdapters.VendedorTableAdapter();
            this.eMPRESATableAdapter = new PPDotNet.DataSources.dsSaidaTableAdapters.EMPRESATableAdapter();
            this.txtDtSaida = new System.Windows.Forms.MaskedTextBox();
            this.tabDados.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDados
            // 
            this.tabDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDados.Dock = System.Windows.Forms.DockStyle.None;
            this.tabDados.Size = new System.Drawing.Size(792, 517);
            this.tabDados.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabPage2.Controls.Add(this.txtDtSaida);
            this.tabPage2.Controls.Add(this.txtPlaca);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtOrdemServico);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbGarantia);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbCombustivel);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.txtKm);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.cmbEmpresa);
            this.tabPage2.Controls.Add(this.txtVeiculo);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtObs);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.gridItens);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtMecanico);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtFantasia);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtDtEntrada);
            this.tabPage2.Controls.Add(this.btnLocCliente);
            this.tabPage2.Controls.Add(this.txtCodCliente);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Size = new System.Drawing.Size(784, 491);
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 520);
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
            this.btnOrcamento});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(103, 22);
            this.toolStripDropDownButton1.Text = "Impressões";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // btnOrcamento
            // 
            this.btnOrcamento.Image = ((System.Drawing.Image)(resources.GetObject("btnOrcamento.Image")));
            this.btnOrcamento.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnOrcamento.Name = "btnOrcamento";
            this.btnOrcamento.Size = new System.Drawing.Size(137, 22);
            this.btnOrcamento.Text = "Orçamento";
            this.btnOrcamento.Click += new System.EventHandler(this.btnOrcamento_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(171, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(97, 21);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orçamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(171, 28);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(77, 21);
            this.txtCodCliente.TabIndex = 5;
            this.totToolTip.SetToolTip(this.txtCodCliente, "Pressione F10 para Localizar um Cliente");
            this.txtCodCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodCliente_KeyDown);
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // btnLocCliente
            // 
            this.btnLocCliente.Location = new System.Drawing.Point(644, 28);
            this.btnLocCliente.Name = "btnLocCliente";
            this.btnLocCliente.Size = new System.Drawing.Size(48, 21);
            this.btnLocCliente.TabIndex = 7;
            this.btnLocCliente.Text = "&Achar";
            this.btnLocCliente.UseVisualStyleBackColor = true;
            this.btnLocCliente.Click += new System.EventHandler(this.btnLocCliente_Click);
            // 
            // txtDtEntrada
            // 
            this.txtDtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDtEntrada.Location = new System.Drawing.Point(435, 72);
            this.txtDtEntrada.Name = "txtDtEntrada";
            this.txtDtEntrada.Size = new System.Drawing.Size(93, 21);
            this.txtDtEntrada.TabIndex = 17;
            this.txtDtEntrada.Value = new System.DateTime(2006, 11, 23, 0, 0, 0, 0);
            this.txtDtEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dt.Entrada";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(254, 28);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.ReadOnly = true;
            this.txtFantasia.Size = new System.Drawing.Size(384, 21);
            this.txtFantasia.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mecânico";
            // 
            // txtMecanico
            // 
            this.txtMecanico.Location = new System.Drawing.Point(171, 72);
            this.txtMecanico.MaxLength = 50;
            this.txtMecanico.Name = "txtMecanico";
            this.txtMecanico.Size = new System.Drawing.Size(189, 21);
            this.txtMecanico.TabIndex = 15;
            this.txtMecanico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Veículo";
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
            this.groupBox1.Location = new System.Drawing.Point(6, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 86);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Itens";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(167, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 13);
            this.label27.TabIndex = 6;
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
            this.cmbUnidade.TabIndex = 7;
            this.cmbUnidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
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
            this.txtVlrUnitario.TabIndex = 9;
            this.txtVlrUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            this.txtVlrUnitario.Leave += new System.EventHandler(this.txtVlrUnitario_Leave);
            // 
            // txtICMS
            // 
            this.txtICMS.Location = new System.Drawing.Point(83, 35);
            this.txtICMS.Name = "txtICMS";
            this.txtICMS.Size = new System.Drawing.Size(77, 21);
            this.txtICMS.TabIndex = 5;
            this.txtICMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            this.txtICMS.Leave += new System.EventHandler(this.txtICMS_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(23, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "ICMS %";
            // 
            // txtVlrTotal
            // 
            this.txtVlrTotal.Location = new System.Drawing.Point(514, 57);
            this.txtVlrTotal.Name = "txtVlrTotal";
            this.txtVlrTotal.ReadOnly = true;
            this.txtVlrTotal.Size = new System.Drawing.Size(90, 21);
            this.txtVlrTotal.TabIndex = 16;
            this.txtVlrTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVlrTotal_KeyPress);
            this.txtVlrTotal.Leave += new System.EventHandler(this.txtVlrTotal_Leave);
            // 
            // txtPerDesconto
            // 
            this.txtPerDesconto.Location = new System.Drawing.Point(380, 57);
            this.txtPerDesconto.Name = "txtPerDesconto";
            this.txtPerDesconto.Size = new System.Drawing.Size(77, 21);
            this.txtPerDesconto.TabIndex = 14;
            this.txtPerDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            this.txtPerDesconto.Leave += new System.EventHandler(this.txtPerDesconto_Leave);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(222, 57);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(62, 21);
            this.txtQtd.TabIndex = 11;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            this.txtQtd.Leave += new System.EventHandler(this.txtQtd_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(479, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Total";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(301, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "% Desconto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(193, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Qtd";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Vlr Unitário";
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(166, 13);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.ReadOnly = true;
            this.txtDescProd.Size = new System.Drawing.Size(384, 21);
            this.txtDescProd.TabIndex = 2;
            // 
            // btnLocProd
            // 
            this.btnLocProd.Location = new System.Drawing.Point(556, 13);
            this.btnLocProd.Name = "btnLocProd";
            this.btnLocProd.Size = new System.Drawing.Size(48, 21);
            this.btnLocProd.TabIndex = 3;
            this.btnLocProd.Text = "A&char";
            this.btnLocProd.UseVisualStyleBackColor = true;
            this.btnLocProd.Click += new System.EventHandler(this.btnLocProd_Click);
            // 
            // txtCodProd
            // 
            this.txtCodProd.Location = new System.Drawing.Point(83, 13);
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(77, 21);
            this.txtCodProd.TabIndex = 1;
            this.totToolTip.SetToolTip(this.txtCodProd, "Pressione F10 para Localizar um Produto");
            this.txtCodProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProd_KeyDown);
            this.txtCodProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            this.txtCodProd.Leave += new System.EventHandler(this.txtCodProd_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Produto";
            // 
            // gridItens
            // 
            this.gridItens.AllowUserToAddRows = false;
            this.gridItens.AllowUserToDeleteRows = false;
            this.gridItens.AllowUserToOrderColumns = true;
            this.gridItens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridItens.Location = new System.Drawing.Point(3, 255);
            this.gridItens.Name = "gridItens";
            this.gridItens.ReadOnly = true;
            this.gridItens.RowTemplate.Height = 23;
            this.gridItens.Size = new System.Drawing.Size(781, 233);
            this.gridItens.TabIndex = 30;
            this.gridItens.DoubleClick += new System.EventHandler(this.gridItens_DoubleClick);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(171, 116);
            this.txtObs.MaxLength = 200;
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(521, 44);
            this.txtObs.TabIndex = 27;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(135, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Obs";
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
            this.lblTotPed.TabIndex = 1;
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
            this.groupBox2.Location = new System.Drawing.Point(629, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 56);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total do Pedido";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(171, 50);
            this.txtVeiculo.MaxLength = 50;
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(189, 21);
            this.txtVeiculo.TabIndex = 9;
            this.txtVeiculo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Placa";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.DataSource = this.eMPRESABindingSource;
            this.cmbEmpresa.DisplayMember = "fantasia";
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(429, 6);
            this.cmbEmpresa.MaxLength = 60;
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(263, 21);
            this.cmbEmpresa.TabIndex = 3;
            this.cmbEmpresa.ValueMember = "id_pessoa";
            this.cmbEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            // 
            // eMPRESABindingSource
            // 
            this.eMPRESABindingSource.DataMember = "EMPRESA";
            this.eMPRESABindingSource.DataSource = this.dsSaida;
            // 
            // dsSaida
            // 
            this.dsSaida.DataSetName = "dsSaida";
            this.dsSaida.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(366, 10);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Empresa";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(537, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "Dt.Saída";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(506, 56);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 13);
            this.label26.TabIndex = 12;
            this.label26.Text = "Kilometragem";
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(592, 50);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 21);
            this.txtKm.TabIndex = 13;
            this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            // 
            // cmbCombustivel
            // 
            this.cmbCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombustivel.FormattingEnabled = true;
            this.cmbCombustivel.Items.AddRange(new object[] {
            " Vazio",
            " 1/4",
            " Meio Tanque",
            " 3/4",
            " Cheio"});
            this.cmbCombustivel.Location = new System.Drawing.Point(171, 94);
            this.cmbCombustivel.Name = "cmbCombustivel";
            this.cmbCombustivel.Size = new System.Drawing.Size(140, 21);
            this.cmbCombustivel.TabIndex = 21;
            this.cmbCombustivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Combustível";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Garantia";
            // 
            // cmbGarantia
            // 
            this.cmbGarantia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGarantia.FormattingEnabled = true;
            this.cmbGarantia.Items.AddRange(new object[] {
            "03 Meses",
            "06 Meses",
            "Garantia Fábrica",
            "Sem Garantia"});
            this.cmbGarantia.Location = new System.Drawing.Point(382, 94);
            this.cmbGarantia.Name = "cmbGarantia";
            this.cmbGarantia.Size = new System.Drawing.Size(140, 21);
            this.cmbGarantia.TabIndex = 23;
            this.cmbGarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "O.Serviço";
            // 
            // txtOrdemServico
            // 
            this.txtOrdemServico.Location = new System.Drawing.Point(592, 94);
            this.txtOrdemServico.MaxLength = 20;
            this.txtOrdemServico.Name = "txtOrdemServico";
            this.txtOrdemServico.Size = new System.Drawing.Size(100, 21);
            this.txtOrdemServico.TabIndex = 25;
            this.txtOrdemServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(435, 50);
            this.txtPlaca.Mask = "AAA0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.PromptChar = ' ';
            this.txtPlaca.Size = new System.Drawing.Size(72, 21);
            this.txtPlaca.TabIndex = 11;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataMember = "Vendedor";
            this.vendedorBindingSource.DataSource = this.dsSaida;
            // 
            // cFOPBindingSource
            // 
            this.cFOPBindingSource.DataMember = "CFOP";
            this.cFOPBindingSource.DataSource = this.dsSaida;
            // 
            // cFOPTableAdapter
            // 
            this.cFOPTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorTableAdapter1
            // 
            this.vendedorTableAdapter1.ClearBeforeFill = true;
            // 
            // eMPRESATableAdapter
            // 
            this.eMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // txtDtSaida
            // 
            this.txtDtSaida.Location = new System.Drawing.Point(592, 72);
            this.txtDtSaida.Mask = "00/00/0000";
            this.txtDtSaida.Name = "txtDtSaida";
            this.txtDtSaida.PromptChar = ' ';
            this.txtDtSaida.Size = new System.Drawing.Size(100, 21);
            this.txtDtSaida.TabIndex = 19;
            this.txtDtSaida.ValidatingType = typeof(System.DateTime);
            this.txtDtSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(792, 545);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "frmOrcamento";
            this.ShowInTaskbar = true;
            this.Text = "Manutenção Orçamento";
            this.Load += new System.EventHandler(this.frmOrcamento_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmOrcamento_KeyPress);
            this.Controls.SetChildIndex(this.tabDados, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.tabDados.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItens)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFOPBindingSource)).EndInit();
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
        private System.Windows.Forms.DateTimePicker txtDtEntrada;
        private System.Windows.Forms.TextBox txtMecanico;
        private System.Windows.Forms.Label label10;
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
        public System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotPed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnOrcamento;
        private PopCalc.Library.CalculatorButton calculatorButton1;
        private dsSaida dsSaida;
        private System.Windows.Forms.BindingSource cFOPBindingSource;
        private PPDotNet.DataSources.dsSaidaTableAdapters.CFOPTableAdapter cFOPTableAdapter;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private PPDotNet.DataSources.dsSaidaTableAdapters.VendedorTableAdapter vendedorTableAdapter1;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.BindingSource eMPRESABindingSource;
        private PPDotNet.DataSources.dsSaidaTableAdapters.EMPRESATableAdapter eMPRESATableAdapter;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbGarantia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCombustivel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrdemServico;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.MaskedTextBox txtDtSaida;
    }
}

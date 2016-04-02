using PPDotNet.DataSources;

namespace PPDotNet.Formulários.Cadastros
{
    partial class frmProdutosCad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProdutosCad));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCustoHistorico = new System.Windows.Forms.TextBox();
            this.txtDescForn = new System.Windows.Forms.TextBox();
            this.btnLocForn = new System.Windows.Forms.Button();
            this.txtCodForn = new System.Windows.Forms.TextBox();
            this.txtDescFab = new System.Windows.Forms.TextBox();
            this.btnLocFab = new System.Windows.Forms.Button();
            this.txtCodFabrica = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtIcmsEntra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSituTrib = new System.Windows.Forms.TextBox();
            this.txtIcmsInt = new System.Windows.Forms.TextBox();
            this.txtIcmsEst = new System.Windows.Forms.TextBox();
            this.chkSubstTrib = new System.Windows.Forms.CheckBox();
            this.chkIcmsAnt = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblICMS_ISS = new System.Windows.Forms.Label();
            this.calculatorButton2 = new PopCalc.Library.CalculatorButton();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdbServico = new System.Windows.Forms.RadioButton();
            this.rdbMaterial = new System.Windows.Forms.RadioButton();
            this.tabDados.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.tabPage1);
            this.tabDados.Size = new System.Drawing.Size(607, 256);
            this.tabDados.Controls.SetChildIndex(this.tabPage1, 0);
            this.tabDados.Controls.SetChildIndex(this.tabPage2, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpTipo);
            this.tabPage2.Controls.Add(this.calculatorButton2);
            this.tabPage2.Controls.Add(this.txtDescFab);
            this.tabPage2.Controls.Add(this.btnLocFab);
            this.tabPage2.Controls.Add(this.txtCodFabrica);
            this.tabPage2.Controls.Add(this.txtDescForn);
            this.tabPage2.Controls.Add(this.btnLocForn);
            this.tabPage2.Controls.Add(this.txtCodForn);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.chkStatus);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtDescricao);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtCodigo);
            this.tabPage2.Controls.Add(this.txtPrecoUnitario);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Size = new System.Drawing.Size(599, 230);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código";
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 256);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(607, 25);
            this.toolStrip1.TabIndex = 3;
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
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(103, 199);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(100, 21);
            this.txtPrecoUnitario.TabIndex = 7;
            this.txtPrecoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProdutosCad_KeyPress);
            this.txtPrecoUnitario.Leave += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(101, 7);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(77, 21);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProdutosCad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(102, 36);
            this.txtDescricao.MaxLength = 190;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(487, 57);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProdutosCad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fornecedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fábrica";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(203, 11);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(55, 17);
            this.chkStatus.TabIndex = 1;
            this.chkStatus.Text = "Ativo";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProdutosCad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Preço Unitário";
            // 
            // txtCustoHistorico
            // 
            this.txtCustoHistorico.Location = new System.Drawing.Point(0, 0);
            this.txtCustoHistorico.Name = "txtCustoHistorico";
            this.txtCustoHistorico.Size = new System.Drawing.Size(100, 20);
            this.txtCustoHistorico.TabIndex = 0;
            // 
            // txtDescForn
            // 
            this.txtDescForn.Location = new System.Drawing.Point(185, 99);
            this.txtDescForn.Name = "txtDescForn";
            this.txtDescForn.ReadOnly = true;
            this.txtDescForn.Size = new System.Drawing.Size(350, 21);
            this.txtDescForn.TabIndex = 14;
            // 
            // btnLocForn
            // 
            this.btnLocForn.Location = new System.Drawing.Point(541, 99);
            this.btnLocForn.Name = "btnLocForn";
            this.btnLocForn.Size = new System.Drawing.Size(48, 21);
            this.btnLocForn.TabIndex = 16;
            this.btnLocForn.Text = "Achar";
            this.btnLocForn.UseVisualStyleBackColor = true;
            this.btnLocForn.Click += new System.EventHandler(this.btnLocForn_Click);
            // 
            // txtCodForn
            // 
            this.txtCodForn.Location = new System.Drawing.Point(102, 99);
            this.txtCodForn.Name = "txtCodForn";
            this.txtCodForn.Size = new System.Drawing.Size(77, 21);
            this.txtCodForn.TabIndex = 4;
            this.txtCodForn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodForn_KeyDown);
            this.txtCodForn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProdutosCad_KeyPress);
            this.txtCodForn.Leave += new System.EventHandler(this.txtCodForn_Leave);
            // 
            // txtDescFab
            // 
            this.txtDescFab.Location = new System.Drawing.Point(185, 125);
            this.txtDescFab.Name = "txtDescFab";
            this.txtDescFab.ReadOnly = true;
            this.txtDescFab.Size = new System.Drawing.Size(350, 21);
            this.txtDescFab.TabIndex = 15;
            // 
            // btnLocFab
            // 
            this.btnLocFab.Location = new System.Drawing.Point(541, 125);
            this.btnLocFab.Name = "btnLocFab";
            this.btnLocFab.Size = new System.Drawing.Size(48, 21);
            this.btnLocFab.TabIndex = 17;
            this.btnLocFab.Text = "Achar";
            this.btnLocFab.UseVisualStyleBackColor = true;
            this.btnLocFab.Click += new System.EventHandler(this.btnLocFab_Click);
            // 
            // txtCodFabrica
            // 
            this.txtCodFabrica.Location = new System.Drawing.Point(102, 125);
            this.txtCodFabrica.Name = "txtCodFabrica";
            this.txtCodFabrica.Size = new System.Drawing.Size(77, 21);
            this.txtCodFabrica.TabIndex = 5;
            this.txtCodFabrica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodFabrica_KeyDown);
            this.txtCodFabrica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProdutosCad_KeyPress);
            this.txtCodFabrica.Leave += new System.EventHandler(this.txtCodFabrica_Leave);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Turquoise;
            this.tabPage1.Controls.Add(this.txtIcmsEntra);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtSituTrib);
            this.tabPage1.Controls.Add(this.txtIcmsInt);
            this.tabPage1.Controls.Add(this.txtIcmsEst);
            this.tabPage1.Controls.Add(this.chkSubstTrib);
            this.tabPage1.Controls.Add(this.chkIcmsAnt);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lblICMS_ISS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 192);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Fiscal";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // txtIcmsEntra
            // 
            this.txtIcmsEntra.Location = new System.Drawing.Point(183, 70);
            this.txtIcmsEntra.Name = "txtIcmsEntra";
            this.txtIcmsEntra.Size = new System.Drawing.Size(78, 21);
            this.txtIcmsEntra.TabIndex = 2;
            this.txtIcmsEntra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIcmsEst_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Alíquota ICMS Entrada";
            // 
            // txtSituTrib
            // 
            this.txtSituTrib.Location = new System.Drawing.Point(183, 97);
            this.txtSituTrib.MaxLength = 2;
            this.txtSituTrib.Name = "txtSituTrib";
            this.txtSituTrib.Size = new System.Drawing.Size(26, 21);
            this.txtSituTrib.TabIndex = 3;
            this.txtSituTrib.Text = "00";
            this.txtSituTrib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIcmsEst_KeyPress);
            // 
            // txtIcmsInt
            // 
            this.txtIcmsInt.Location = new System.Drawing.Point(183, 43);
            this.txtIcmsInt.Name = "txtIcmsInt";
            this.txtIcmsInt.Size = new System.Drawing.Size(78, 21);
            this.txtIcmsInt.TabIndex = 1;
            this.txtIcmsInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIcmsEst_KeyPress);
            // 
            // txtIcmsEst
            // 
            this.txtIcmsEst.Location = new System.Drawing.Point(183, 15);
            this.txtIcmsEst.Name = "txtIcmsEst";
            this.txtIcmsEst.Size = new System.Drawing.Size(78, 21);
            this.txtIcmsEst.TabIndex = 0;
            this.txtIcmsEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIcmsEst_KeyPress);
            // 
            // chkSubstTrib
            // 
            this.chkSubstTrib.AutoSize = true;
            this.chkSubstTrib.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSubstTrib.Location = new System.Drawing.Point(44, 147);
            this.chkSubstTrib.Name = "chkSubstTrib";
            this.chkSubstTrib.Size = new System.Drawing.Size(153, 17);
            this.chkSubstTrib.TabIndex = 5;
            this.chkSubstTrib.Text = "Substituição Tributária";
            this.chkSubstTrib.UseVisualStyleBackColor = true;
            this.chkSubstTrib.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIcmsEst_KeyPress);
            // 
            // chkIcmsAnt
            // 
            this.chkIcmsAnt.AutoSize = true;
            this.chkIcmsAnt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIcmsAnt.Location = new System.Drawing.Point(74, 124);
            this.chkIcmsAnt.Name = "chkIcmsAnt";
            this.chkIcmsAnt.Size = new System.Drawing.Size(124, 17);
            this.chkIcmsAnt.TabIndex = 4;
            this.chkIcmsAnt.Text = "ICMS Antecipado";
            this.chkIcmsAnt.UseVisualStyleBackColor = true;
            this.chkIcmsAnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIcmsEst_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Situação Tributária";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Alíquota ICMS Interestadual";
            // 
            // lblICMS_ISS
            // 
            this.lblICMS_ISS.AutoSize = true;
            this.lblICMS_ISS.Location = new System.Drawing.Point(37, 23);
            this.lblICMS_ISS.Name = "lblICMS_ISS";
            this.lblICMS_ISS.Size = new System.Drawing.Size(140, 13);
            this.lblICMS_ISS.TabIndex = 9;
            this.lblICMS_ISS.Text = "Alíquota ICMS Estadual";
            this.lblICMS_ISS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculatorButton2
            // 
            this.calculatorButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.calculatorButton2.ButtonImage = ((System.Drawing.Image)(resources.GetObject("calculatorButton2.ButtonImage")));
            this.calculatorButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.calculatorButton2.Location = new System.Drawing.Point(204, 200);
            this.calculatorButton2.Name = "calculatorButton2";
            this.calculatorButton2.ResultControl = this.txtPrecoUnitario;
            this.calculatorButton2.Size = new System.Drawing.Size(20, 20);
            this.calculatorButton2.TabIndex = 18;
            this.calculatorButton2.Text = "calculatorButton2";
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rdbServico);
            this.grpTipo.Controls.Add(this.rdbMaterial);
            this.grpTipo.Location = new System.Drawing.Point(102, 149);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(181, 43);
            this.grpTipo.TabIndex = 6;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo de Produto";
            // 
            // rdbServico
            // 
            this.rdbServico.AutoSize = true;
            this.rdbServico.Location = new System.Drawing.Point(102, 21);
            this.rdbServico.Name = "rdbServico";
            this.rdbServico.Size = new System.Drawing.Size(68, 17);
            this.rdbServico.TabIndex = 1;
            this.rdbServico.Text = "Serviço";
            this.rdbServico.UseVisualStyleBackColor = true;
            this.rdbServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProdutosCad_KeyPress);
            // 
            // rdbMaterial
            // 
            this.rdbMaterial.AutoSize = true;
            this.rdbMaterial.Checked = true;
            this.rdbMaterial.Location = new System.Drawing.Point(17, 21);
            this.rdbMaterial.Name = "rdbMaterial";
            this.rdbMaterial.Size = new System.Drawing.Size(70, 17);
            this.rdbMaterial.TabIndex = 0;
            this.rdbMaterial.TabStop = true;
            this.rdbMaterial.Text = "Material";
            this.rdbMaterial.UseVisualStyleBackColor = true;
            this.rdbMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProdutosCad_KeyPress);
            // 
            // frmProdutosCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(607, 281);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmProdutosCad";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.frmProdutosCad_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmProdutosCad_KeyPress);
            this.Controls.SetChildIndex(this.tabDados, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.tabDados.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        public System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.TextBox txtCustoHistorico;
        private System.Windows.Forms.Label label8;
        //private dsProd dsProd;
        public System.Windows.Forms.TextBox txtDescFab;
        private System.Windows.Forms.Button btnLocFab;
        public System.Windows.Forms.TextBox txtCodFabrica;
        public System.Windows.Forms.TextBox txtDescForn;
        private System.Windows.Forms.Button btnLocForn;
        public System.Windows.Forms.TextBox txtCodForn;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblICMS_ISS;
        private System.Windows.Forms.TextBox txtSituTrib;
        private System.Windows.Forms.TextBox txtIcmsInt;
        private System.Windows.Forms.TextBox txtIcmsEst;
        private System.Windows.Forms.CheckBox chkSubstTrib;
        private System.Windows.Forms.CheckBox chkIcmsAnt;
        private System.Windows.Forms.TextBox txtIcmsEntra;
        private System.Windows.Forms.Label label11;
        private PopCalc.Library.CalculatorButton calculatorButton2;
        public System.Windows.Forms.TextBox txtDescProdPai;
        public System.Windows.Forms.TextBox txtCodProdPai;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdbServico;
        private System.Windows.Forms.RadioButton rdbMaterial;
    }
}

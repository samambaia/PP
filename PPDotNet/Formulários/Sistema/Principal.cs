using System;
using System.Windows.Forms;
using PPDotNet.Formulários.Modelos;
using PPDotNet.Formulários.Cadastros;
using PPDotNet.Formulários.Saída;
using PPDotNet.Formulários.Relatórios;
using System.Drawing.Printing;
using DllClasses.Net.Sistema.Negocio;

namespace PPDotNet.Formulários.Sistema
{
    public partial class frmPrincipal : frmModelo
    {
        public frmPrincipal()
        {
            InitializeComponent();

            PrintDocument pd = new PrintDocument();
            
            foreach (string impressora in PrinterSettings.InstalledPrinters)
            {
                cmbPrinters.Items.Add(impressora);
            }

            if (cmbPrinters.Items.Count > 0)
                cmbPrinters.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmProdutoCons prodCons = new frmProdutoCons();
            prodCons.ShowDialog();
            prodCons.Dispose();
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSaidaCons saidaCons = new frmSaidaCons();
            saidaCons.ShowDialog();
            saidaCons.Dispose();
            this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmPessoaCons pessoaCons = new frmPessoaCons();
            pessoaCons.ShowDialog();
            pessoaCons.Dispose();
            this.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCfopCons cfopCons = new frmCfopCons();
            cfopCons.ShowDialog();
            cfopCons.Dispose();
            this.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmOrcaCons orcaCons = new frmOrcaCons();
            orcaCons.ShowDialog();
            orcaCons.Dispose();
            this.Refresh();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCMBOrca.ORCAMENTO' table. You can move, or remove it, as needed.
            this.oRCAMENTOTableAdapter.Fill(this.dsCMBOrca.ORCAMENTO);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtNumOrca.Text.Length > 0)
            {
                orcamento Orcamento = new orcamento();

                var orca = Orcamento.Listar(int.Parse(txtNumOrca.Text));

                if (orca.HasRows)
                {
                    if ((MessageBox.Show("Confirma a impressão do Orçamento?", "Impressão do Orçamento",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
                    {
                        //Imprime direto -- falta corrigir
                        //Helpers.Demo _print = new Helpers.Demo();

                        //if (cmbOrca.Text.Length > 0)
                        //    _print.Run(@"C:\PP\Relatórios\repOrca.rdlc", cmbOrca.Text.ToString(), cmbPrinters.SelectedItem.ToString());
                        //else
                        //    MessageBox.Show("Selecione ou digite um orçamento!", "Erro na impressão");

                        frmPreview preview = new frmPreview();
                        Cursor = Cursors.WaitCursor;
                        preview.form = "repOrca.rdlc";

                        preview.idOrca = int.Parse(txtNumOrca.Text.ToString());
                        preview.WindowState = FormWindowState.Maximized;
                        preview.ShowDialog();

                        Cursor = Cursors.Default;
                    }
                }
                else
                {
                    MessageBox.Show("Orçamento não existe. Tente novamente.", "Impressão de Orçamento");
                }
            }
            else
                MessageBox.Show("Digite um orçamento!", "Impressão de Orçamento");
        }
    }
}
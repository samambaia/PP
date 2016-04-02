using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PPDotNet.Formulários.Modelos
{
    public partial class frmModelo : Form
    {
        //Atribui a variável de caminho da impressora para uma variável global
//        public string PrintPath_LX300 = Settings.Default.Impressora_lx300;
//        public string PrintPath_FX1170 = Settings.Default.Impressora_fx1170;

        public frmModelo()
        {
            InitializeComponent();
        }

        public void Zebra_Grid(DataGridView GridZebrado)
        {
            long Contador;
            for (Contador = 1; (Contador <= (GridZebrado.RowCount - 1)); Contador++)
            {
                if (((Contador % 2) == 0))
                {
                    GridZebrado.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                }
                else
                {
                    GridZebrado.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
                }
            }
        }
    }

}
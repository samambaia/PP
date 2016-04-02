using System;
using System.Drawing;
using DllClasses.Net.Sistema.Globais;

namespace PPDotNet.Formulários.Modelos
{
    public partial class frmModeloCadastro : frmModelo
    {
        public frmModeloCadastro()
        {
            InitializeComponent();
        }

        clFuncoesGerais.Operacao _Operacao;
        public clFuncoesGerais.Operacao Operacao
        {
            get
            {
                return _Operacao;
            }
            set
            {
                _Operacao = value;
            }
        }

        int _Codigo;
        public int Codigo
        {
            get
            {
                return _Codigo;
            }
            set
            {
                _Codigo = value;
            }
        }

        private void btnSair_Click()
        {
            Close();
        }
    }
}


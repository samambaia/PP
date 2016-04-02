/***
 * 
 * Componente: CDSImprimeTexto
 *      Autor: Carlos dos Santos
 *	     Data: 21/07/2004
 *   Objetivo: Imprime texto diretamente na porta da impressora.
 * 
 ***/
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace DllClasses.Net.Sistema.Globais
{
    /// <summary>
    /// Classe para impressão de textos diretamente para a porta da impressora.
    /// © 2004 CDS Informática Ltda.
    /// </summary>
    /// 
    public class ImprimeTexto
    {
        private int GENERIC_WRITE = 0x40000000; // indica a operação de gravação
        private int OPEN_EXISTING = 3; // abre mesmo existindo o arquivo
        private int FILE_SHARE_WRITE = 0x2; // define como escrita em modo compartilhado
        private string sPorta; // armazena a porta que está sendo usada
        private int hPort; // handle para a porta
        private FileStream outFile; // objeto que indica a porta
        private StreamWriter fileWriter; // objeto usado para escrever na porta
        private IntPtr hPortP; // usado como identificador da porta no Windows
        private bool lOK = false; // indica se conseguiu abrir a porta da impressora

        /// <summary>
        /// Retorna o caracter ASC indicado.
        /// </summary>
        /// <param name="asc">número do caracter na tabela ASCII</param>
        /// <returns></returns>
        private string Chr(int asc)
        {
            string ret = "";
            ret += (char) asc;
            return ret;
        }

        [DllImport("kernel32.dll", EntryPoint="CreateFileA")]
        private static extern int CreateFileA(string lpFileName, int dwDesiredAccess, int dwShareMode,
                                              int lpSecurityAttributes,
                                              int dwCreationDisposition, int dwFlagsAndAttributes,
                                              int hTemplateFile);

        [DllImport("kernel32.dll", EntryPoint="CloseHandle")]
        private static extern int CloseHandle(int hObject);

        /// <summary>
        /// Configura a impressora para impressão normal.
        /// </summary>
        public string Normal
        {
            get { return Chr(18); }
        }

        /// <summary>
        /// Configura a impressora para impressão em modo condensado.
        /// </summary>
        public string Comprimido
        {
            get { return Chr(15); }
        }

        /// <summary>
        /// Configura a impressora para impressão em modo expandido.
        /// </summary>
        public string Expandido
        {
            get { return Chr(14); }
        }

        /// <summary>
        /// Configura a impressora para impressão em modo expandido normal.
        /// </summary>
        public string ExpandidoNormal
        {
            get { return Chr(20); }
        }


        /// <summary>
        /// Ativa o modo negrito da impressora.
        /// </summary>
        public string NegritoOn
        {
            get { return Chr(27) + Chr(69); }
        }


        /// <summary>
        /// Desativa o modo negrito da impressora.
        /// </summary>
        public string NegritoOff
        {
            get { return Chr(27) + Chr(70); }
        }
        
        /// <summary>
        /// Configura a impressora para imprimir acentuando
        /// </summary>
        public string Brascii
        {
            get
            {
                return string.Format("{0}{1}{2}25{3}", Chr(27), Chr(40), Chr(116), Chr(48));
            }
        }

        /// <summary>
        /// Inicia a impressão em modo texto.
        /// </summary>
        /// <param name="sPortaInicio">Especifica a porta da impressora (LPT1,LPT2,LPT3,LPT4,...)</param>
        /// <returns>Retorna true se inciar a impressora e false caso contrário</returns>
        public bool Inicio(string sPortaInicio)
        {
            sPortaInicio.ToUpper();
            /*if (sPortaInicio.Substring(0, 3) != "LPT")
            {
                lOK = false;
                throw new Exception("Porta LPT inválida.");
            }
             */
  
            lOK = true;
            sPorta = sPortaInicio;
            hPort = CreateFileA(sPorta, GENERIC_WRITE, FILE_SHARE_WRITE, 0, OPEN_EXISTING, 0, 0);
            if (hPort != -1)
            {
                hPortP = new IntPtr(hPort);
                outFile = new FileStream(hPortP, FileAccess.Write);
                //Manda para Impressora
                fileWriter = new StreamWriter(outFile);
                //Manda para arquivo
                //fileWriter = new StreamWriter("C:\\NF.txt");
                lOK = true;
            }
            else
            {
                lOK = false;
            }
            return lOK;
        }

        /// <summary>
        /// Finaliza a Impressao.
        /// </summary>
        public void Fim()
        {
            if (lOK)
            {
                fileWriter.Close();
                outFile.Close();
                CloseHandle(hPort);
                lOK = false;
            }
        }

        /// <summary>
        /// Imprime uma string.
        /// </summary>
        /// <param name="sLinha">String a ser impressa</param>
        public void Imp(string sLinha)
        {
            if (lOK)
            {
                fileWriter.Write(sLinha);
                fileWriter.Flush();
            }
        }

        /// <summary>
        /// Imprime uma string e pula uma linha.
        /// </summary>
        /// <param name="sLinha">String a ser impressa</param>
        public void ImpLF(string sLinha)
        {
            if (lOK)
            {
                fileWriter.WriteLine(sLinha);
                fileWriter.Flush();
            }
        }

        /// <summary>
        /// Imprime uma string em uma determinada coluna.
        /// </summary>
        /// <param name="nCol">Coluna a ser posicionada</param>
        /// <param name="sLinha">String a ser impressa</param>
        public void ImpCol(int nCol, string sLinha)
        {
            string Cols = "";
            Cols = Cols.PadLeft(nCol, ' ');
            Imp(Chr(13)+ Cols + sLinha);
        }

        /// <summary>
        /// Imprime uma string em uma determinada coluna e pula uma linha.
        /// </summary>
        /// <param name="nCol">Coluna a ser posicionada</param>
        /// <param name="sLinha">String a ser impressa</param>
        public void ImpColLF(int nCol, string sLinha)
        {
            ImpCol(nCol, sLinha);
            Pula(1);
        }

        /// <summary>
        /// Pula uma numero determinado de linhas.
        /// </summary>
        /// <param name="nLinha">Número de linhas a serem puladas</param>
        public void Pula(int nLinha)
        {
            for (int i = 0; i < nLinha; i++)
            {
                ImpLF("");
            }
        }

        /// <summary>
        /// Ejeta uma página.
        /// </summary>
        public void Eject()
        {
            Imp(Chr(12));
        }

        public ImprimeTexto()
        {
            sPorta = "LPT1";
        }
    }
}
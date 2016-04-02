// Description: Classe que expoe metodos para a conversao de valores numericos em strings corresponden-
//              tes a sua descricao por extenso.
//
// Developer:   Samuel Leandro Barbosa (sleandro@ajato.com.br)
// Create Date: 17/03/2004
// Last Update: 18/03/2004
//
// Com corre��es feitas por Andr� Casteliano <andre@alcsystems.com.br>

using System;

namespace DllClasses.Net.Sistema.Globais.NumeroExtenso
{
    /// <summary>
    /// Esta classe exp�e o m�todo ParaExtenso, o qual retorna a descri��o por extenso de 
    /// um valor num�rico passado como par�metro.
    /// </summary>
    public class NumeroExtenso
    {
        /// <summary>
        /// Enumerador criado para limitar os valores informados como par�metro ao m�todo "ExtensoMilhar"
        /// </summary>
        private enum eDigitos { Zero = 0, Um, Dois, Tres, Quatro, Cinco, Seis, Sete, Oito, Nove }

        /// <summary>
        /// Vari�vel de controle da propriedade Unidade
        /// </summary>
        private sUnidade _Unidade;

        /// <summary>
        /// Matriz que cont�m a descri��o textual das "ordens" de milhar.
        /// Nota: Gra�as � nossa L�ngua Portuguesa, � necess�rio definir tais descri��es
        /// somente no singular, uma vez que para obter o plural basta substituir na string
        /// a ocorr�ncia de "�o" para "�es"
        /// </summary>
        private string[] GrupoMilhar = { "", 
										   "mil",				// 1.000
										   "milh�o",			// 1.000.000
										   "bilh�o",			// 1.000.000.000
										   "trilh�o",			// 1.000.000.000.000
										   "quadrilh�o",		// 1.000.000.000.000.000
										   "quintilh�o",		// e por a� vai...
										   "sextilh�o",
										   "setilh�o",
										   "octilh�o",
										   "nonilh�o",
										   "decilh�o",
										   "undecilh�o",
										   "dodecilh�o",
										   "tredicilh�o",
										   "quatordecilh�o",
										   "quindecilh�o",
										   "sedecilh�o",
										   "septendecilh�o"};

        /// <summary>
        /// Retorna a descri��o por extenso dos inteiros (menores que 1000) pertencentes 
        /// ao conjunto que chamaremos de "N�meros Simples", que s�o aqueles n�meros cuja 
        /// descri��o textual por extenso � formada por apenas uma palavra.
        /// 
        /// Exemplos de n�meros que PERTENCEM a este conjunto:
        /// "5", pois sua descri��o ("cinco") � formada por apenas uma palavra.
        /// "19", pois sua descri��o ("dezenove") � formada por apenas uma palavra.
        /// "200", pois sua descri��o ("duzentos") � formada por apenas uma palavra.
        /// 
        /// Exemplos de n�meros que N�O PERTENCEM a este conjunto:
        /// "27", pois sua descri��o ("vinte e sete") � formada por mais que uma palavra.
        /// "150", pois sua descri��o ("cento e cinq�enta") � formada por mais que uma palavra.
        /// "999", pois sua descri��o ("novecentos e noventa e nove") � formada por mais que uma palavra.
        /// </summary>
        private string PalavraSimples(eDigitos n)
        {
            return PalavraSimples(Convert.ToInt32(n));
        }

        /// <summary>
        /// Retorna a descri��o por extenso dos inteiros (menores que 1000) pertencentes 
        /// ao conjunto que chamaremos de "N�meros Simples", que s�o aqueles n�meros cuja 
        /// descri��o textual por extenso � formada por apenas uma palavra.
        /// 
        /// Exemplos de n�meros que PERTENCEM a este conjunto:
        /// "5", pois sua descri��o ("cinco") � formada por apenas uma palavra.
        /// "19", pois sua descri��o ("dezenove") � formada por apenas uma palavra.
        /// "200", pois sua descri��o ("duzentos") � formada por apenas uma palavra.
        /// 
        /// Exemplos de n�meros que N�O PERTENCEM a este conjunto:
        /// "27", pois sua descri��o ("vinte e sete") � formada por mais que uma palavra.
        /// "150", pois sua descri��o ("cento e cinq�enta") � formada por mais que uma palavra.
        /// "999", pois sua descri��o ("novecentos e noventa e nove") � formada por mais que uma palavra.
        /// </summary>
        private string PalavraSimples(int n)
        {
            switch (n)
            {
                case 0:
                    return ("");
                case 1:
                    return ("um");
                case 2:
                    return ("dois");
                case 3:
                    return ("tr�s");
                case 4:
                    return ("quatro");
                case 5:
                    return ("cinco");
                case 6:
                    return ("seis");
                case 7:
                    return ("sete");
                case 8:
                    return ("oito");
                case 9:
                    return ("nove");
                case 10:
                    return ("dez");
                case 11:
                    return ("onze");
                case 12:
                    return ("doze");
                case 13:
                    return ("treze");
                case 14:
                    return ("quatorze");
                case 15:
                    return ("quinze");
                case 16:
                    return ("dezesseis");
                case 17:
                    return ("dezessete");
                case 18:
                    return ("dezoito");
                case 19:
                    return ("dezenove");
                case 20:
                    return ("vinte");
                case 30:
                    return ("trinta");
                case 40:
                    return ("quarenta");
                case 50:
                    return ("cinq�enta");
                case 60:
                    return ("sessenta");
                case 70:
                    return ("setenta");
                case 80:
                    return ("oitenta");
                case 90:
                    return ("noventa");
                case 100:
                    return ("cento");
                case 200:
                    return ("duzentos");
                case 300:
                    return ("trezentos");
                case 400:
                    return ("quatrocentos");
                case 500:
                    return ("quinhentos");
                case 600:
                    return ("seiscentos");
                case 700:
                    return ("setecentos");
                case 800:
                    return ("oitocentos");
                case 900:
                    return ("novecentos");
                default:
                    return null;
            }
        }

        /// <summary>
        /// Retorna um array do enumerador eDigitos com 3 elementos, sendo que:
        /// o elemento da posi��o [0] representa o algarismo da centena do inteiro informado;
        /// o elemento da posi��o [1] representa o algarismo da dezena do inteiro informado;
        /// o elemento da posi��o [3] representa o algarismo da unidade do inteiro informado;
        /// </summary>
        private eDigitos[] Inteiro999ParaMatrizDigitos(int x)
        {
            // Declara e inicializa a matriz de retorno
            eDigitos[] Retorno = { eDigitos.Zero, eDigitos.Zero, eDigitos.Zero };

            // Despreza os algarismos de x que eventualmente estiverem em posi��es
            // relativas superiores � terceira casa decimal.
            // Exemplo: Se x foi recebido 1543786, ser� considerado 786
            while (x > 999)
            {
                x = x - 1000;
            }

            // Calcula o algarismo da centena do inteiro x, colocando-o na posi��o [0]
            // da matriz de retorno.
            Retorno[0] = (eDigitos)(x / 100);

            // Calcula o algarismo da dezena do inteiro x, colocando-o na posi��o [1]
            // da matriz de retorno.
            Retorno[1] = (eDigitos)((x - (100 * (x / 100))) / 10);

            // Calcula o algarismo da unidade do inteiro x colocando-o na posi��o [2]
            // da matriz de retorno.
            Retorno[2] = (eDigitos)(x - 10 * (x / 10));

            return Retorno;
        }

        /// <summary>
        /// Retorna um inteiro calculado � partir de um array do enumerador eDigitos, sendo que:
        /// o Elemento da �ltima posi��o do array representa o algarismo da unidade do inteiro a retornar;
        /// o Elemento da pen�ltima posi��o do array representa o algarismo da dezena do inteiro a retornar;
        /// o Elemento da antipen�ltima posi��o do array representa o algarismo da centena do inteiro a retornar;
        /// os demais Elementos que eventualmente pertencerem ao array ser�o ignorados
        /// </summary>
        private int MatrizDigitosParaInteiro999(eDigitos[] x)
        {
            int Retorno = 0;
            byte Algarismo = 0;

            // C�culo da Centena
            try
            {
                // Obt�m o algarismo que est� na anti-pen�ltima posi��o do array
                Algarismo = Convert.ToByte(x[x.Length - 3]);
            }
            catch
            {
                // Se ocorreu exce��o, como por exemplo quando o array cont�m menos 
                // do que 3 elementos, ent�o considera o algarismo "Zero"
                Algarismo = 0;
            }
            finally
            {
                // Multiplica o algarismo por 100 para obter o valor da centena
                Retorno += (100 * Algarismo);
            }

            // C�culo da Dezena
            try
            {
                // Obt�m o algarismo que est� na pen�ltima posi��o do array
                Algarismo = Convert.ToByte(x[x.Length - 2]);
            }
            catch
            {
                // Se ocorreu exce��o, como por exemplo quando o array cont�m menos 
                // do que 2 elementos, ent�o considera o algarismo "Zero"
                Algarismo = 0;
            }
            finally
            {
                // Multiplica o algarismo por 10 para obter o valor da dezena
                Retorno += (10 * Algarismo);
            }

            // C�culo da Unidade
            try
            {
                // Obt�m o algarismo que est� na �ltima posi��o do array
                Algarismo = Convert.ToByte(x[x.Length - 1]);
            }
            catch
            {
                // Se ocorreu exce��o, como por exemplo quando o array n�o
                // cont�m elementos, ent�o considera o algarismo "Zero"
                Algarismo = 0;
            }
            finally
            {
                // Soma o valor acumulado ao algarismo da unidade
                Retorno += Algarismo;
            }

            // Retorno do m�todo MatrizDigitosParaInteiro999
            return Retorno;
        }

        /// <summary>
        /// Retorna string contendo as palavras que formam a descri��o por extenso da 
        /// milhar representada pelo array do enumerador eDigitos passado como par�metro
        /// </summary>
        private string MilharPorExtenso(eDigitos[] a)
        {
            return MilharPorExtenso(a, 0);
        }

        /// <summary>
        /// Retorna string contendo as palavras que formam a descri��o por extenso da 
        /// milhar representada pelo array do enumerador eDigitos passado como par�metro
        /// </summary>
        private string MilharPorExtenso(eDigitos[] a, byte classe)
        {
            string[] Palavra = { "", "", "" };
            string Retorno = "";

            // Obt�m as palavras que formam a descri��o por extenso da milhar informada
            // atrav�s do array do enumerador eDigitos;

            // Se a milhar representada pelo array informado � maior do que 20
            if (this.MatrizDigitosParaInteiro999(a) > 20)
            {
                try
                {
                    // Na casa da centena, � preciso multiplicar por 100
                    Palavra[0] = this.PalavraSimples(100 * Convert.ToInt32(a[a.Length - 3]));
                }
                catch
                {
                    // Se o array informado n�o possui 3 elementos, ent�o palavra � vazia
                    Palavra[0] = "";
                }

                try
                {
                    // Na casa da dezena, � preciso multiplicar por 10
                    int _dez = 0;

                    _dez += (((int)a[a.Length - 2]) * 10) + ((int)a[a.Length - 1]);

                    //System.Windows.Forms.MessageBox.Show ("a[1] = " + a[a.Length - 1] + "\na[2] = " + a[a.Length - 2] + "\n\nDEZ :: " + _dez);

                    if (_dez >= 20)
                        Palavra[1] = this.PalavraSimples(10 * Convert.ToInt32(a[a.Length - 2]));
                    else
                        Palavra[1] = this.PalavraSimples(_dez);
                    //Palavra[1] = this.PalavraSimples((10 * (int)a[a.Length - 2]) + (int)a[a.Length - 1]);
                }
                catch
                {
                    // Se o array informado n�o possui 3 elementos, ent�o palavra � vazia
                    Palavra[1] = "";
                }

                try
                {
                    // Na casa da Unidade, n�o � preciso multiplicar 
                    int _dez = 0;

                    _dez += (((int)a[a.Length - 2]) * 10) + ((int)a[a.Length - 1]);

                    if (_dez > 20)
                        Palavra[2] = this.PalavraSimples(a[a.Length - 1]);
                    else
                        Palavra[2] = "";
                }
                catch
                {
                    // Se o array informado n�o possui 3 elementos, ent�o palavra � vazia
                    Palavra[2] = "";
                }
            }

                // Se a milhar representada pelo array informado N�O � maior do que 20
            else
            {
                // Como a milhar � menor do que 20, logicamente a palavra da centena � vazia
                Palavra[0] = "";

                // Soma o valor absoluto da unidade ao valor relativo da dezena, para
                // obter a descri��o dos chamados "N�meros Simples" entre 0 e 20.
                try
                {
                    Palavra[1] = this.PalavraSimples(10 * (int)a[a.Length - 2] + (int)a[a.Length - 1]);
                }
                catch
                {
                    // Se o array informado n�o possui 3 elementos, ent�o palavra � vazia
                    Palavra[1] = "";
                }

                // Como o valor da unidade j� foi incorporado no passo anterior,
                // ent�o sua descri��o deve ser vazia.
                Palavra[2] = "";
            }

            // O n�mero 100 � um caso particular que deve ser tratado como exce��o �s 
            // regras anteriores, visto que o m�todo "PalavraSimples" sempre retorna 
            // sua descri��o como "cento"
            if (this.MatrizDigitosParaInteiro999(a) == 100)
            {
                Palavra[0] = "cem";
            }

            // Concatena as palavras obtidas nos passos anteriores, 
            // utilizando a conjun��o "E" como separador de palavras

            // Palavra que representa a centena
            Retorno = Palavra[0];

            // Se as palavras que representam centena e dezena n�o s�o vazias
            if (Retorno != "" && Palavra[1] != "")
            {
                // Concantena a palavra da centena com a conjun��o "E" e a
                // palavra da dezena
                Retorno += (" e " + Palavra[1]);
            }

                // Se a palavras que representam a centena ou a dezena s�o vazias
            else
            {
                // Concantena a palavra da centena com a palavra da dezena sem 
                // utilizar a conjun��o "E"
                Retorno += Palavra[1];
            }

            // Se a string obtida no passo anterior e a palavra que representa 
            // a unidade n�o s�o vazias
            if (Retorno != "" && Palavra[2] != "")
            {
                // Concatena string obtida no passo anterior com a conjun��o "E" e a
                // palavra da unidade
                Retorno += (" e " + Palavra[2]);
            }

                // Se a string obtida no passo anterior ou a palavra que representa
            // a unidade s�o vazias
            else
            {
                // Concantena a string obtida no passo anterior com a palavra da unidade sem 
                // utilizar a conjun��o "E"
                Retorno += Palavra[2];
            }

            // Concatena a descri��o do grupo de milhar, considerando o singular/plural,
            // obtendo assim o valor de retorno do m�todo               
            switch (this.MatrizDigitosParaInteiro999(a))
            {
                // Se a milhar � zero, ent�o retorno � vazio
                case 0:
                    return ("");

                // Se a milhar � um, ent�o retorna a string obtida nos passos anteriores
                // concatenada com a correspondente descri��o de "Grupo de Milhar" no 
                // singular.
                case 1:
                    return (Retorno) + " " + GrupoMilhar[classe];

                // Se a milhar � qualquer outro valor, ent�o retorna a string obtida nos 
                // passos anteriores concatenada com a correspondente descri��o de 
                // "Grupo de Milhar" no plural.
                default:
                    return (Retorno) + " " + GrupoMilhar[classe].Replace("�o", "�es");
            }
        }

        /// <summary>
        /// Estrutura que define as descri��es textuais da unidade monet�ria a ser utilizada
        /// </summary>
        public struct sUnidade
        {
            public string IntSingular;
            public string IntPlural;
            public string DecSingular;
            public string DecPlural;
        }

        /// <summary>
        /// Propriedade que recebe/retorna as descri��es textuais da unidade monet�ria 
        /// a ser utilizada
        /// </summary>
        public sUnidade Unidade
        {
            get
            {
                return _Unidade;
            }
            set
            {
                _Unidade = Unidade;
            }
        }

        /// <summary>
        /// Construtor default da classe - Neste, a descri��o da unidade monet�ria � 
        /// definida como "real" e "reais"
        /// </summary>
        public NumeroExtenso()
        {
            this._Unidade.IntSingular = "real";
            this._Unidade.IntPlural = "reais";
            this._Unidade.DecSingular = "centavo";
            this._Unidade.DecPlural = "centavos";
        }

        /// <summary>
        /// Construtor alternativo da classe - Neste, a descri��o da unidade monet�ria � 
        /// recebida como par�metro
        /// </summary>
        public NumeroExtenso(string DescricaoInteiroSingular,
            string DescricaoInteiroPlural,
            string DescricaoDecimalSingular,
            string DescricaoDecimalPlural)
        {
            this._Unidade.IntSingular = DescricaoInteiroSingular;
            this._Unidade.IntPlural = DescricaoInteiroPlural;
            this._Unidade.DecSingular = DescricaoDecimalSingular;
            this._Unidade.DecPlural = DescricaoDecimalPlural;
        }

        /// <summary>
        /// Retorna a descri��o por extenso do n�mero informado como par�metro
        /// </summary>
        public string ParaExtenso(ValueType x)
        {
            return this.ParaExtenso(Convert.ToDouble(x));
        }

        /// <summary>
        /// Retorna a descri��o por extenso do n�mero informado como par�metro
        /// </summary>
        public string ParaExtenso(float x)
        {
            return this.ParaExtenso(Convert.ToDouble(x));
        }

        /// <summary>
        /// Retorna a descri��o por extenso do n�mero informado como par�metro
        /// </summary>
        public string ParaExtenso(decimal x)
        {
            return this.ParaExtenso(Convert.ToDouble(x));
        }

        /// <summary>
        /// Retorna a descri��o por extenso do n�mero informado como par�metro
        /// </summary>
        public string ParaExtenso(double x)
        {
            // Obt�m o n�mero correspondente � parte inteira do valor informado
            long ParteInteira = Convert.ToInt64(Math.Floor(Math.Abs(x)) * Math.Sign(x));

            // Obt�m o n�mero (0 a 99) correspondente � parte fracion�ria do valor informado
            int ParteDecimal = Convert.ToInt32(100 * (Math.Abs(x) - Math.Abs(ParteInteira)));

            // Obt�m um array do enumerador eDigitos correspondente � parte fracion�ria
            // do valor informado
            eDigitos[] a = this.Inteiro999ParaMatrizDigitos(ParteDecimal);

            // Obt�m a descri��o por extenso da parte inteira do valor informado
            string RetornoInt = this.ParaExtenso(ParteInteira);

            // Declara e inicializa a string de retorno do extenso da parte fracion�ria
            string RetornoDec = "";

            // Obt�m a descri��o por extenso da parte fracion�ria do valor informado
            switch (ParteDecimal)
            {
                // Se a parte fracion�ria � zero, ent�o n�o h� descri��o de centavos
                case 0:
                    break;

                // Se a parte facion�ria � um, ent�o utiliza a descri��o no singular
                case 1:
                    RetornoDec = this.MilharPorExtenso(a) + this._Unidade.DecSingular;
                    break;

                // Para os demais valores, utiliza a descri��o no plural
                default:
                    RetornoDec = this.MilharPorExtenso(a) + this._Unidade.DecPlural;
                    break;
            }

            // Se apenas a parte inteira � vazia, ent�o retorna a parte fracion�ria
            if (RetornoInt == "" && RetornoDec != "")
            {
                return RetornoDec;
            }

            // Se apenas a parte fracion�ria � vazia, ent�o retorna a parte inteira
            if (RetornoInt != "" && RetornoDec == "")
            {
                return RetornoInt;
            }

            // Se as partes inteira e fracion�ria n�o s�o vazias, ent�o retorna ambas
            // as partes separadas pela conjun��o "E"
            if (RetornoInt != "" && RetornoDec != "")
            {
                return RetornoInt + " e " + RetornoDec;
            }

            // Se as partes inteira e fracion�ria s�o ambas vazias, ent�o retorna string vazia
            return "";

        }

        /// <summary>
        /// Retorna a descri��o por extenso do n�mero informado como par�metro
        /// </summary>
        public string ParaExtenso(int n)
        {
            return this.ParaExtenso(Convert.ToInt64(n));
        }

        /// <summary>
        /// Retorna a descri��o por extenso do n�mero informado como par�metro
        /// </summary>
        public string ParaExtenso(long n)
        {
            // Define e inicializa uma string para o retorno do m�todo
            string Retorno = "";

            // Define e inicializa um array do enumerador eDigitos
            eDigitos[] a = { eDigitos.Zero, eDigitos.Zero, eDigitos.Zero };

            // Define e inicializa um byte que controla a ordem da milhar
            byte Classe = 0;

            // Define um flag booleano para controlar a necessidade ou n�o de
            // concatenar a conjun��o "de" no final da string, como em 
            // "um milh�o DE reais"
            bool IncluirConjuncao = false;

            // Define e inicializa a vari�vel auxiliar long, a qual inicialmente recebe 
            // o pr�prio valor informado como par�metro, e a cada ciclo de processamento 
            // do loop abaixo vai sendo dividida por 1.000
            long x = Math.Abs(n);

            // Loop para a chamada ao m�todo "MilharPorExtenso", que ser� executado tantas
            // vezes quantas forem as divis�es inteiras da vari�vel auxiliar (x) por 1.000
            // resultando em n�mero maior que zero.
            //
            // Exemplo: Seja x (inicial) o n�mero 11.547.325
            //          Neste exemplo, o loop deve ser processado 3 vezes, ou seja, uma vez
            //          para cada grupo de milhar que comp�e o n�mero (11, 547 e 325 ):
            //          1� Passo: x passa a valer 11.547
            //          2� Passo: x passa a valer 11
            //          3� Passo: x passa a valer 0, encerrando a execu��o do loop (pois 11/1000=0)
            while (x > 0)
            {
                // Obt�m o valor da milhar mais � direita (unidade) da vari�vel auxiliar
                int Milhar = Convert.ToInt32(x - ((x / 1000) * 1000));

                // Calcula o flag booleano que controla a necessidade ou n�o de
                // concatenar a conjun��o "de" no final da string
                IncluirConjuncao = (IncluirConjuncao || (Classe == 1 && Milhar == 0));

                // Efetua a divis�o inteira da vari�vel auxiliar por 1.000
                x /= 1000;

                // Obt�m o array do enumerador eDigitos correspondente ao milhar
                a = this.Inteiro999ParaMatrizDigitos(Milhar);

                // Se o valor absoluto da milhar � diferente de zero
                if (Milhar != 0)
                {
                    // Se a string de retorno n�o � vazia
                    if (Retorno != "")
                    {
                        // Para os n�meros acima da ordem dos milh�es, utiliza o caractere ","
                        // como separador ao inv�s da conjun��o "E"
                        if (Classe > 2 && !(IncluirConjuncao))
                        {
                            Retorno = ", " + Retorno;
                        }
                        else
                        {
                            Retorno = " e " + Retorno;
                        }
                    }

                    // Concatena a descri��o por extenso da milhar � string de retorno,
                    // incrementando o byte que controla a ordem da milhar
                    Retorno = this.MilharPorExtenso(a, Classe++) + Retorno;
                }

                    // Se o valor absoluto da milhar N�O � diferente de zero
                else
                {
                    // Apenas incrementa o byte que controla a ordem da milhar
                    Classe++;
                }
            }

            // Se o valor informado � negativo, adiciona o prefixo "menos"
            if (n < 0)
            {
                Retorno = "menos " + Retorno;
            }

            // Concatena a conjun��o "de" no final da string, conforme o status
            // do flag booleano e o valor informado pertencer � Classe dos milh�es 
            // ou superior
            if (IncluirConjuncao && Classe >= 3)
            {
                Retorno += " de ";
            }

            // Concatena o identificador de unidade monet�ria, observando o singular/plural
            switch (n)
            {
                // Considera o valor zero como plural ("zero unidades")
                case 0:
                    return ("zero " + this._Unidade.IntPlural);

                // Considera o valor um como singular ("um unidade")
                case 1:
                    return (Retorno.TrimEnd() + " " + this._Unidade.IntSingular);

                // Para os demais valores, considera como plural ("n unidades")
                default:
                    return (Retorno.TrimEnd() + " " + this._Unidade.IntPlural);
            }
        }
    }
}
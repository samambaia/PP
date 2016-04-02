// Description: Classe que expoe metodos para a conversao de valores numericos em strings corresponden-
//              tes a sua descricao por extenso.
//
// Developer:   Samuel Leandro Barbosa (sleandro@ajato.com.br)
// Create Date: 17/03/2004
// Last Update: 18/03/2004
//
// Com correções feitas por André Casteliano <andre@alcsystems.com.br>

using System;

namespace DllClasses.Net.Sistema.Globais.NumeroExtenso
{
    /// <summary>
    /// Esta classe expõe o método ParaExtenso, o qual retorna a descrição por extenso de 
    /// um valor numérico passado como parâmetro.
    /// </summary>
    public class NumeroExtenso
    {
        /// <summary>
        /// Enumerador criado para limitar os valores informados como parâmetro ao método "ExtensoMilhar"
        /// </summary>
        private enum eDigitos { Zero = 0, Um, Dois, Tres, Quatro, Cinco, Seis, Sete, Oito, Nove }

        /// <summary>
        /// Variável de controle da propriedade Unidade
        /// </summary>
        private sUnidade _Unidade;

        /// <summary>
        /// Matriz que contém a descrição textual das "ordens" de milhar.
        /// Nota: Graças à nossa Língua Portuguesa, é necessário definir tais descrições
        /// somente no singular, uma vez que para obter o plural basta substituir na string
        /// a ocorrência de "ão" para "ões"
        /// </summary>
        private string[] GrupoMilhar = { "", 
										   "mil",				// 1.000
										   "milhão",			// 1.000.000
										   "bilhão",			// 1.000.000.000
										   "trilhão",			// 1.000.000.000.000
										   "quadrilhão",		// 1.000.000.000.000.000
										   "quintilhão",		// e por aí vai...
										   "sextilhão",
										   "setilhão",
										   "octilhão",
										   "nonilhão",
										   "decilhão",
										   "undecilhão",
										   "dodecilhão",
										   "tredicilhão",
										   "quatordecilhão",
										   "quindecilhão",
										   "sedecilhão",
										   "septendecilhão"};

        /// <summary>
        /// Retorna a descrição por extenso dos inteiros (menores que 1000) pertencentes 
        /// ao conjunto que chamaremos de "Números Simples", que são aqueles números cuja 
        /// descrição textual por extenso é formada por apenas uma palavra.
        /// 
        /// Exemplos de números que PERTENCEM a este conjunto:
        /// "5", pois sua descrição ("cinco") é formada por apenas uma palavra.
        /// "19", pois sua descrição ("dezenove") é formada por apenas uma palavra.
        /// "200", pois sua descrição ("duzentos") é formada por apenas uma palavra.
        /// 
        /// Exemplos de números que NÃO PERTENCEM a este conjunto:
        /// "27", pois sua descrição ("vinte e sete") é formada por mais que uma palavra.
        /// "150", pois sua descrição ("cento e cinqüenta") é formada por mais que uma palavra.
        /// "999", pois sua descrição ("novecentos e noventa e nove") é formada por mais que uma palavra.
        /// </summary>
        private string PalavraSimples(eDigitos n)
        {
            return PalavraSimples(Convert.ToInt32(n));
        }

        /// <summary>
        /// Retorna a descrição por extenso dos inteiros (menores que 1000) pertencentes 
        /// ao conjunto que chamaremos de "Números Simples", que são aqueles números cuja 
        /// descrição textual por extenso é formada por apenas uma palavra.
        /// 
        /// Exemplos de números que PERTENCEM a este conjunto:
        /// "5", pois sua descrição ("cinco") é formada por apenas uma palavra.
        /// "19", pois sua descrição ("dezenove") é formada por apenas uma palavra.
        /// "200", pois sua descrição ("duzentos") é formada por apenas uma palavra.
        /// 
        /// Exemplos de números que NÃO PERTENCEM a este conjunto:
        /// "27", pois sua descrição ("vinte e sete") é formada por mais que uma palavra.
        /// "150", pois sua descrição ("cento e cinqüenta") é formada por mais que uma palavra.
        /// "999", pois sua descrição ("novecentos e noventa e nove") é formada por mais que uma palavra.
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
                    return ("três");
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
                    return ("cinqüenta");
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
        /// o elemento da posição [0] representa o algarismo da centena do inteiro informado;
        /// o elemento da posição [1] representa o algarismo da dezena do inteiro informado;
        /// o elemento da posição [3] representa o algarismo da unidade do inteiro informado;
        /// </summary>
        private eDigitos[] Inteiro999ParaMatrizDigitos(int x)
        {
            // Declara e inicializa a matriz de retorno
            eDigitos[] Retorno = { eDigitos.Zero, eDigitos.Zero, eDigitos.Zero };

            // Despreza os algarismos de x que eventualmente estiverem em posições
            // relativas superiores à terceira casa decimal.
            // Exemplo: Se x foi recebido 1543786, será considerado 786
            while (x > 999)
            {
                x = x - 1000;
            }

            // Calcula o algarismo da centena do inteiro x, colocando-o na posição [0]
            // da matriz de retorno.
            Retorno[0] = (eDigitos)(x / 100);

            // Calcula o algarismo da dezena do inteiro x, colocando-o na posição [1]
            // da matriz de retorno.
            Retorno[1] = (eDigitos)((x - (100 * (x / 100))) / 10);

            // Calcula o algarismo da unidade do inteiro x colocando-o na posição [2]
            // da matriz de retorno.
            Retorno[2] = (eDigitos)(x - 10 * (x / 10));

            return Retorno;
        }

        /// <summary>
        /// Retorna um inteiro calculado à partir de um array do enumerador eDigitos, sendo que:
        /// o Elemento da última posição do array representa o algarismo da unidade do inteiro a retornar;
        /// o Elemento da penúltima posição do array representa o algarismo da dezena do inteiro a retornar;
        /// o Elemento da antipenúltima posição do array representa o algarismo da centena do inteiro a retornar;
        /// os demais Elementos que eventualmente pertencerem ao array serão ignorados
        /// </summary>
        private int MatrizDigitosParaInteiro999(eDigitos[] x)
        {
            int Retorno = 0;
            byte Algarismo = 0;

            // Cáculo da Centena
            try
            {
                // Obtém o algarismo que está na anti-penúltima posição do array
                Algarismo = Convert.ToByte(x[x.Length - 3]);
            }
            catch
            {
                // Se ocorreu exceção, como por exemplo quando o array contém menos 
                // do que 3 elementos, então considera o algarismo "Zero"
                Algarismo = 0;
            }
            finally
            {
                // Multiplica o algarismo por 100 para obter o valor da centena
                Retorno += (100 * Algarismo);
            }

            // Cáculo da Dezena
            try
            {
                // Obtém o algarismo que está na penúltima posição do array
                Algarismo = Convert.ToByte(x[x.Length - 2]);
            }
            catch
            {
                // Se ocorreu exceção, como por exemplo quando o array contém menos 
                // do que 2 elementos, então considera o algarismo "Zero"
                Algarismo = 0;
            }
            finally
            {
                // Multiplica o algarismo por 10 para obter o valor da dezena
                Retorno += (10 * Algarismo);
            }

            // Cáculo da Unidade
            try
            {
                // Obtém o algarismo que está na última posição do array
                Algarismo = Convert.ToByte(x[x.Length - 1]);
            }
            catch
            {
                // Se ocorreu exceção, como por exemplo quando o array não
                // contém elementos, então considera o algarismo "Zero"
                Algarismo = 0;
            }
            finally
            {
                // Soma o valor acumulado ao algarismo da unidade
                Retorno += Algarismo;
            }

            // Retorno do método MatrizDigitosParaInteiro999
            return Retorno;
        }

        /// <summary>
        /// Retorna string contendo as palavras que formam a descrição por extenso da 
        /// milhar representada pelo array do enumerador eDigitos passado como parâmetro
        /// </summary>
        private string MilharPorExtenso(eDigitos[] a)
        {
            return MilharPorExtenso(a, 0);
        }

        /// <summary>
        /// Retorna string contendo as palavras que formam a descrição por extenso da 
        /// milhar representada pelo array do enumerador eDigitos passado como parâmetro
        /// </summary>
        private string MilharPorExtenso(eDigitos[] a, byte classe)
        {
            string[] Palavra = { "", "", "" };
            string Retorno = "";

            // Obtém as palavras que formam a descrição por extenso da milhar informada
            // através do array do enumerador eDigitos;

            // Se a milhar representada pelo array informado é maior do que 20
            if (this.MatrizDigitosParaInteiro999(a) > 20)
            {
                try
                {
                    // Na casa da centena, é preciso multiplicar por 100
                    Palavra[0] = this.PalavraSimples(100 * Convert.ToInt32(a[a.Length - 3]));
                }
                catch
                {
                    // Se o array informado não possui 3 elementos, então palavra é vazia
                    Palavra[0] = "";
                }

                try
                {
                    // Na casa da dezena, é preciso multiplicar por 10
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
                    // Se o array informado não possui 3 elementos, então palavra é vazia
                    Palavra[1] = "";
                }

                try
                {
                    // Na casa da Unidade, não é preciso multiplicar 
                    int _dez = 0;

                    _dez += (((int)a[a.Length - 2]) * 10) + ((int)a[a.Length - 1]);

                    if (_dez > 20)
                        Palavra[2] = this.PalavraSimples(a[a.Length - 1]);
                    else
                        Palavra[2] = "";
                }
                catch
                {
                    // Se o array informado não possui 3 elementos, então palavra é vazia
                    Palavra[2] = "";
                }
            }

                // Se a milhar representada pelo array informado NÃO é maior do que 20
            else
            {
                // Como a milhar é menor do que 20, logicamente a palavra da centena é vazia
                Palavra[0] = "";

                // Soma o valor absoluto da unidade ao valor relativo da dezena, para
                // obter a descrição dos chamados "Números Simples" entre 0 e 20.
                try
                {
                    Palavra[1] = this.PalavraSimples(10 * (int)a[a.Length - 2] + (int)a[a.Length - 1]);
                }
                catch
                {
                    // Se o array informado não possui 3 elementos, então palavra é vazia
                    Palavra[1] = "";
                }

                // Como o valor da unidade já foi incorporado no passo anterior,
                // então sua descrição deve ser vazia.
                Palavra[2] = "";
            }

            // O número 100 é um caso particular que deve ser tratado como exceção às 
            // regras anteriores, visto que o método "PalavraSimples" sempre retorna 
            // sua descrição como "cento"
            if (this.MatrizDigitosParaInteiro999(a) == 100)
            {
                Palavra[0] = "cem";
            }

            // Concatena as palavras obtidas nos passos anteriores, 
            // utilizando a conjunção "E" como separador de palavras

            // Palavra que representa a centena
            Retorno = Palavra[0];

            // Se as palavras que representam centena e dezena não são vazias
            if (Retorno != "" && Palavra[1] != "")
            {
                // Concantena a palavra da centena com a conjunção "E" e a
                // palavra da dezena
                Retorno += (" e " + Palavra[1]);
            }

                // Se a palavras que representam a centena ou a dezena são vazias
            else
            {
                // Concantena a palavra da centena com a palavra da dezena sem 
                // utilizar a conjunção "E"
                Retorno += Palavra[1];
            }

            // Se a string obtida no passo anterior e a palavra que representa 
            // a unidade não são vazias
            if (Retorno != "" && Palavra[2] != "")
            {
                // Concatena string obtida no passo anterior com a conjunção "E" e a
                // palavra da unidade
                Retorno += (" e " + Palavra[2]);
            }

                // Se a string obtida no passo anterior ou a palavra que representa
            // a unidade são vazias
            else
            {
                // Concantena a string obtida no passo anterior com a palavra da unidade sem 
                // utilizar a conjunção "E"
                Retorno += Palavra[2];
            }

            // Concatena a descrição do grupo de milhar, considerando o singular/plural,
            // obtendo assim o valor de retorno do método               
            switch (this.MatrizDigitosParaInteiro999(a))
            {
                // Se a milhar é zero, então retorno é vazio
                case 0:
                    return ("");

                // Se a milhar é um, então retorna a string obtida nos passos anteriores
                // concatenada com a correspondente descrição de "Grupo de Milhar" no 
                // singular.
                case 1:
                    return (Retorno) + " " + GrupoMilhar[classe];

                // Se a milhar é qualquer outro valor, então retorna a string obtida nos 
                // passos anteriores concatenada com a correspondente descrição de 
                // "Grupo de Milhar" no plural.
                default:
                    return (Retorno) + " " + GrupoMilhar[classe].Replace("ão", "ões");
            }
        }

        /// <summary>
        /// Estrutura que define as descrições textuais da unidade monetária a ser utilizada
        /// </summary>
        public struct sUnidade
        {
            public string IntSingular;
            public string IntPlural;
            public string DecSingular;
            public string DecPlural;
        }

        /// <summary>
        /// Propriedade que recebe/retorna as descrições textuais da unidade monetária 
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
        /// Construtor default da classe - Neste, a descrição da unidade monetária é 
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
        /// Construtor alternativo da classe - Neste, a descrição da unidade monetária é 
        /// recebida como parâmetro
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
        /// Retorna a descrição por extenso do número informado como parâmetro
        /// </summary>
        public string ParaExtenso(ValueType x)
        {
            return this.ParaExtenso(Convert.ToDouble(x));
        }

        /// <summary>
        /// Retorna a descrição por extenso do número informado como parâmetro
        /// </summary>
        public string ParaExtenso(float x)
        {
            return this.ParaExtenso(Convert.ToDouble(x));
        }

        /// <summary>
        /// Retorna a descrição por extenso do número informado como parâmetro
        /// </summary>
        public string ParaExtenso(decimal x)
        {
            return this.ParaExtenso(Convert.ToDouble(x));
        }

        /// <summary>
        /// Retorna a descrição por extenso do número informado como parâmetro
        /// </summary>
        public string ParaExtenso(double x)
        {
            // Obtém o número correspondente à parte inteira do valor informado
            long ParteInteira = Convert.ToInt64(Math.Floor(Math.Abs(x)) * Math.Sign(x));

            // Obtém o número (0 a 99) correspondente à parte fracionária do valor informado
            int ParteDecimal = Convert.ToInt32(100 * (Math.Abs(x) - Math.Abs(ParteInteira)));

            // Obtém um array do enumerador eDigitos correspondente à parte fracionária
            // do valor informado
            eDigitos[] a = this.Inteiro999ParaMatrizDigitos(ParteDecimal);

            // Obtém a descrição por extenso da parte inteira do valor informado
            string RetornoInt = this.ParaExtenso(ParteInteira);

            // Declara e inicializa a string de retorno do extenso da parte fracionária
            string RetornoDec = "";

            // Obtém a descrição por extenso da parte fracionária do valor informado
            switch (ParteDecimal)
            {
                // Se a parte fracionária é zero, então não há descrição de centavos
                case 0:
                    break;

                // Se a parte facionária é um, então utiliza a descrição no singular
                case 1:
                    RetornoDec = this.MilharPorExtenso(a) + this._Unidade.DecSingular;
                    break;

                // Para os demais valores, utiliza a descrição no plural
                default:
                    RetornoDec = this.MilharPorExtenso(a) + this._Unidade.DecPlural;
                    break;
            }

            // Se apenas a parte inteira é vazia, então retorna a parte fracionária
            if (RetornoInt == "" && RetornoDec != "")
            {
                return RetornoDec;
            }

            // Se apenas a parte fracionária é vazia, então retorna a parte inteira
            if (RetornoInt != "" && RetornoDec == "")
            {
                return RetornoInt;
            }

            // Se as partes inteira e fracionária não são vazias, então retorna ambas
            // as partes separadas pela conjunção "E"
            if (RetornoInt != "" && RetornoDec != "")
            {
                return RetornoInt + " e " + RetornoDec;
            }

            // Se as partes inteira e fracionária são ambas vazias, então retorna string vazia
            return "";

        }

        /// <summary>
        /// Retorna a descrição por extenso do número informado como parâmetro
        /// </summary>
        public string ParaExtenso(int n)
        {
            return this.ParaExtenso(Convert.ToInt64(n));
        }

        /// <summary>
        /// Retorna a descrição por extenso do número informado como parâmetro
        /// </summary>
        public string ParaExtenso(long n)
        {
            // Define e inicializa uma string para o retorno do método
            string Retorno = "";

            // Define e inicializa um array do enumerador eDigitos
            eDigitos[] a = { eDigitos.Zero, eDigitos.Zero, eDigitos.Zero };

            // Define e inicializa um byte que controla a ordem da milhar
            byte Classe = 0;

            // Define um flag booleano para controlar a necessidade ou não de
            // concatenar a conjunção "de" no final da string, como em 
            // "um milhão DE reais"
            bool IncluirConjuncao = false;

            // Define e inicializa a variável auxiliar long, a qual inicialmente recebe 
            // o próprio valor informado como parâmetro, e a cada ciclo de processamento 
            // do loop abaixo vai sendo dividida por 1.000
            long x = Math.Abs(n);

            // Loop para a chamada ao método "MilharPorExtenso", que será executado tantas
            // vezes quantas forem as divisões inteiras da variável auxiliar (x) por 1.000
            // resultando em número maior que zero.
            //
            // Exemplo: Seja x (inicial) o número 11.547.325
            //          Neste exemplo, o loop deve ser processado 3 vezes, ou seja, uma vez
            //          para cada grupo de milhar que compõe o número (11, 547 e 325 ):
            //          1º Passo: x passa a valer 11.547
            //          2º Passo: x passa a valer 11
            //          3º Passo: x passa a valer 0, encerrando a execução do loop (pois 11/1000=0)
            while (x > 0)
            {
                // Obtém o valor da milhar mais à direita (unidade) da variável auxiliar
                int Milhar = Convert.ToInt32(x - ((x / 1000) * 1000));

                // Calcula o flag booleano que controla a necessidade ou não de
                // concatenar a conjunção "de" no final da string
                IncluirConjuncao = (IncluirConjuncao || (Classe == 1 && Milhar == 0));

                // Efetua a divisão inteira da variável auxiliar por 1.000
                x /= 1000;

                // Obtém o array do enumerador eDigitos correspondente ao milhar
                a = this.Inteiro999ParaMatrizDigitos(Milhar);

                // Se o valor absoluto da milhar é diferente de zero
                if (Milhar != 0)
                {
                    // Se a string de retorno não é vazia
                    if (Retorno != "")
                    {
                        // Para os números acima da ordem dos milhões, utiliza o caractere ","
                        // como separador ao invés da conjunção "E"
                        if (Classe > 2 && !(IncluirConjuncao))
                        {
                            Retorno = ", " + Retorno;
                        }
                        else
                        {
                            Retorno = " e " + Retorno;
                        }
                    }

                    // Concatena a descrição por extenso da milhar à string de retorno,
                    // incrementando o byte que controla a ordem da milhar
                    Retorno = this.MilharPorExtenso(a, Classe++) + Retorno;
                }

                    // Se o valor absoluto da milhar NÃO é diferente de zero
                else
                {
                    // Apenas incrementa o byte que controla a ordem da milhar
                    Classe++;
                }
            }

            // Se o valor informado é negativo, adiciona o prefixo "menos"
            if (n < 0)
            {
                Retorno = "menos " + Retorno;
            }

            // Concatena a conjunção "de" no final da string, conforme o status
            // do flag booleano e o valor informado pertencer à Classe dos milhões 
            // ou superior
            if (IncluirConjuncao && Classe >= 3)
            {
                Retorno += " de ";
            }

            // Concatena o identificador de unidade monetária, observando o singular/plural
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
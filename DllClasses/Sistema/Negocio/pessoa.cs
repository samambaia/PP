using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DllClasses.Net.Sistema.Globais;

namespace DllClasses.Net.Sistema.Negocio
{
    public class pessoa
    {
        private int _id_pessoa;
        public int id_pessoa
        {
            get { return _id_pessoa; }
            set { _id_pessoa = value; }
        }
	
        private string _razao_social;
        public string razao_social
        {
            get { return _razao_social; }
            set { _razao_social = value; }
        }

        private string _fantasia;
        public string fantasia
        {
            get { return _fantasia; }
            set { _fantasia = value; }
        }

        private string _endereco;
        public string endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private string _referencia;
        public string referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }

        private string _bairro;
        public string bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private string _cep;
        public string cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private string _cidade;
        public string cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }
        
        private string _uf;
        public string uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        private string _tipo;
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private string _cnpj;
        public string cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }
        
        private string _cpf;
        public string cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
        
        private string _ie;
        public string ie
        {
            get { return _ie; }
            set { _ie = value; }
        }

        private string _rg;
        public string rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        private string _orgao_rg;
        public string orgao_rg
        {
            get { return _orgao_rg; }
            set { _orgao_rg = value; }
        }

        private string _frete_f;
        public string frete_f
        {
            get { return _frete_f; }
            set { _frete_f = value; }
        }

        private string _frete_c;
        public string frete_c
        {
            get { return _frete_c; }
            set { _frete_c = value; }
        }

        private int _ativo;
        public int ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }
        
        private int _fornecedor;
        public int fornecedor
        {
            get { return _fornecedor; }
            set { _fornecedor = value; }
        }
        
        private int _vendedor;
        public int vendedor
        {
            get { return _vendedor; }
            set { _vendedor = value; }
        }

        private int _transportadora;
        public int transportadora
        {
            get { return _transportadora; }
            set { _transportadora = value; }
        }

        private short _servico;
        public short servico
        {
            get { return _servico; }
            set { _servico = value; }
        }

        private decimal _limite_cred;
        public decimal limite_cred
        {
            get { return _limite_cred; }
            set { _limite_cred = value; }
        }

        private DateTime _data_cadastro = DateTime.Now;
        public DateTime data_cadastro
        {
            get { return _data_cadastro; }
        }

        private string _obs;
        public string obs
        {
            get { return _obs; }
            set { _obs = value; }
        }

        private int _mesmo_local_entrega;
        public int mesmo_local_entrega
        {
            get { return _mesmo_local_entrega; }
            set { _mesmo_local_entrega = value; }
        }

        private string _endereco_le;
        public string endereco_le
        {
            get { return _endereco_le; }
            set { _endereco_le = value; }
        }

        private string _referencia_le;
        public string referencia_le
        {
            get { return _referencia_le; }
            set { _referencia_le = value; }
        }

        private string _bairro_le;
        public string bairro_le
        {
            get { return _bairro_le; }
            set { _bairro_le = value; }
        }

        private string _cep_le;
        public string cep_le
        {
            get { return _cep_le; }
            set { _cep_le = value; }
        }

        private string _cidade_le;
        public string cidade_le
        {
            get { return _cidade_le; }
            set { _cidade_le = value; }
        }

        private string _uf_le;
        public string uf_le
        {
            get { return _uf_le; }
            set { _uf_le = value; }
        }
        
        private int _qtd_dias_f;
        public int qtd_dias_f
        {
            get { return _qtd_dias_f; }
            set { _qtd_dias_f = value; }
        }

        private int _qtd_dias_c;
        public int qtd_dias_c
        {
            get { return _qtd_dias_c; }
            set { _qtd_dias_c = value; }
        }

        private string _usuario;
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private int _cad_status;
        public int cad_status
        {
            get { return _cad_status; }
            set { _cad_status = value; }
        }

        /// <summary>
        /// Métodos para PESSOA
        /// </summary>
        /// <param name="intIndice"></param>
        /// <returns></returns>
        public DataSet Achar(int intIndice)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_pessoa, fantasia, orientacao, cnpj, cpf, qtd_dias_c ");
            strQuery.Append(" FROM view_pes_orient ");
            if (intIndice == 0)
            {
                strQuery.Append(" WHERE id_pessoa = " + id_pessoa);
            }
            if (intIndice == 1)
            {
                strQuery.Append(" WHERE fantasia like '%" + fantasia + "%'");
            }
            if (intIndice == 2)
            {
                strQuery.Append(" WHERE cnpj = '" + cnpj+"' ");
            }
            if (intIndice == 3)
            {
                strQuery.Append(" WHERE cpf = '" + cpf + "' ");
            }
            strQuery.Append(" ORDER BY id_pessoa DESC");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataSet(strQuery.ToString());
        }

        public DataSet AcharCliente(int intIndice)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_pessoa, fantasia, orientacao, qtd_dias_c ");
            strQuery.Append(" FROM view_pes_orient ");
            strQuery.Append(" WHERE vendedor = 0 ");
            strQuery.Append("   AND transportadora = 0 ");

            if (intIndice == 0)
            {
                strQuery.Append(" AND id_pessoa = " + id_pessoa);
            }
            if (intIndice == 1)
            {
                strQuery.Append(" AND fantasia like '%" + fantasia + "%'");
            }
            strQuery.Append(" ORDER BY id_pessoa DESC");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataSet(strQuery.ToString());
        }

        public DataSet AcharFornFab(int intIndice)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_pessoa, fantasia, orientacao, qtd_dias_c ");
            strQuery.Append(" FROM view_pes_orient ");
            strQuery.Append(" WHERE (fornecedor = 1 ");
            strQuery.Append("    OR transportadora = 1 ");
            strQuery.Append("    OR servico = 1) ");

            if (intIndice == 0)
            {
                strQuery.Append(" AND id_pessoa = " + id_pessoa);
            }
            if (intIndice == 1)
            {
                strQuery.Append(" AND fantasia like '%" + fantasia + "%'");
            }
            strQuery.Append(" ORDER BY id_pessoa DESC");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataSet(strQuery.ToString());
        }

        public void Alterar()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" UPDATE pessoa ");
            strQuery.Append(" SET ");
            strQuery.Append(" razao_social = " + " '" + razao_social + "', ");
            strQuery.Append(" limite_cred = '" + limite_cred + "', ");
            strQuery.Append(" fantasia = " + " '" + fantasia + "', ");
            strQuery.Append(" endereco = " + " '" + endereco + "', ");
            strQuery.Append(" referencia = " + " '" + referencia + "', ");
            strQuery.Append(" bairro = " + " '" + bairro + "', ");
            strQuery.Append(" cep = " + " '" + cep + "', ");
            strQuery.Append(" cidade = " + " '" + cidade + "', ");
            strQuery.Append(" uf = " + " '" + uf + "', ");
            strQuery.Append(" tipo = " + " '" + tipo + "', ");
            if (tipo == "J")
            {
                strQuery.Append(" cnpj = " + " '" + cnpj + "', ");
                strQuery.Append(" ie = " + " '" + ie + "', ");
                // Limpa dados pessoa física
                strQuery.Append(" cpf = '', ");
                strQuery.Append(" rg = '', ");
                strQuery.Append(" orgao_rg = '', ");
            }
            else if (tipo == "F")
            {
                strQuery.Append(" cpf = " + " '" + cpf + "', ");
                strQuery.Append(" rg = " + " '" + rg + "', ");
                strQuery.Append(" orgao_rg = " + " '" + orgao_rg + "', ");
                // Limpa dados pessoa jurídica
                strQuery.Append(" cnpj = '', ");
                strQuery.Append(" ie = '', ");
            }
            strQuery.Append(" frete_f = " + " '" + frete_f + "', ");
            strQuery.Append(" frete_c = " + " '" + frete_c + "', ");
            strQuery.Append(" fornecedor = " + " '" + fornecedor + "', ");
            strQuery.Append(" vendedor = " + " '" + vendedor + "', ");
            strQuery.Append(" transportadora = " + " '" + transportadora + "', ");
            strQuery.Append(" servico = " + " '" + servico + "', ");
            strQuery.Append(" mesmo_local_entrega = " + " '" + mesmo_local_entrega + "', ");
            if (mesmo_local_entrega == 1)
            {
                strQuery.Append(" endereco_le = " + " '" + endereco + "', ");
                strQuery.Append(" referencia_le = " + " '" + referencia + "', ");
                strQuery.Append(" bairro_le = " + " '" + bairro + "', ");
                strQuery.Append(" cep_le = " + " '" + cep + "', ");
                strQuery.Append(" cidade_le = " + " '" + cidade + "', ");
                strQuery.Append(" uf_le = " + " '" + uf + "', ");
            }
            else if (mesmo_local_entrega == 0)
            {
                strQuery.Append(" endereco_le = " + " '" + endereco_le + "', ");
                strQuery.Append(" referencia_le = " + " '" + referencia_le + "', ");
                strQuery.Append(" bairro_le = " + " '" + bairro_le + "', ");
                strQuery.Append(" cep_le = " + " '" + cep_le + "', ");
                strQuery.Append(" cidade_le = " + " '" + cidade_le + "', ");
                strQuery.Append(" uf_le = " + " '" + uf_le + "', ");
            }
            strQuery.Append(" qtd_dias_f = " + " " + qtd_dias_f + ", ");
            strQuery.Append(" qtd_dias_c = " + " " + qtd_dias_c + ", ");
            strQuery.Append(" cad_status = " + " " + cad_status + ", ");
            strQuery.Append(" ativo = " + " " + ativo + ", ");
            strQuery.Append(" obs = " + " '" + obs + "', ");
            strQuery.Append(" usuario = " + " '" + usuario + "' ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id_pessoa = " + _id_pessoa + " ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public void Excluir(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" DELETE FROM pessoa ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id_pessoa = " + intCodigo + " ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public void Gravar()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" INSERT INTO pessoa ");
            strQuery.Append(" ( ");
            strQuery.Append(" limite_cred, ");
            strQuery.Append(" razao_social, ");
            strQuery.Append(" fantasia, ");
            strQuery.Append(" endereco, ");
            strQuery.Append(" referencia, ");
            strQuery.Append(" bairro, ");
            strQuery.Append(" cep, ");
            strQuery.Append(" cidade, ");
            strQuery.Append(" uf, ");
            strQuery.Append(" tipo, ");
            if (tipo == "J")
            {
                strQuery.Append(" cnpj, ");
                strQuery.Append(" ie, ");
            }
            else if (tipo == "F")
            {
                strQuery.Append(" cpf, ");
                strQuery.Append(" rg, ");
                strQuery.Append(" orgao_rg, ");
            }
            strQuery.Append(" frete_f, ");
            strQuery.Append(" frete_c, ");
            strQuery.Append(" fornecedor, ");
            strQuery.Append(" vendedor, ");
            strQuery.Append(" transportadora, ");
            strQuery.Append(" servico, ");
            strQuery.Append(" mesmo_local_entrega, ");
            strQuery.Append(" endereco_le, ");
            strQuery.Append(" referencia_le, ");
            strQuery.Append(" bairro_le, ");
            strQuery.Append(" cep_le, ");
            strQuery.Append(" cidade_le, ");
            strQuery.Append(" uf_le, ");
            strQuery.Append(" qtd_dias_f, ");
            strQuery.Append(" qtd_dias_c, ");
            strQuery.Append(" cad_status, "); 
            strQuery.Append(" ativo, ");
            strQuery.Append(" obs, ");
            strQuery.Append(" usuario ");
            strQuery.Append(" ) ");
            // VALUES
            strQuery.Append(" VALUES ( ");
            strQuery.Append(" " + limite_cred + ", ");
            strQuery.Append(" '" + razao_social + "', ");
            strQuery.Append(" '" + fantasia + "', ");
            strQuery.Append(" '" + endereco + "', ");
            strQuery.Append(" '" + referencia + "', ");
            strQuery.Append(" '" + bairro + "', ");
            strQuery.Append(" '" + cep + "', ");
            strQuery.Append(" '" + cidade + "', ");
            strQuery.Append(" '" + uf + "', ");
            strQuery.Append(" '" + tipo + "', ");
            if (tipo == "J")
            {
                strQuery.Append(" '" + cnpj + "', ");
                strQuery.Append(" '" + ie + "', ");
            }
            else if (tipo == "F")
            {
                strQuery.Append(" '" + cpf + "', ");
                strQuery.Append(" '" + rg + "', ");
                strQuery.Append(" '" + orgao_rg + "', ");
            }
            strQuery.Append(" '" + frete_f + "', ");
            strQuery.Append(" '" + frete_c + "', ");
            strQuery.Append(" " + fornecedor + ", ");
            strQuery.Append(" " + vendedor + ", ");
            strQuery.Append(" " + transportadora + ", ");
            strQuery.Append(" " + servico + ", ");
            strQuery.Append(" " + mesmo_local_entrega + ", ");
            if (mesmo_local_entrega == 1)
            {
                strQuery.Append(" '" + endereco + "', ");
                strQuery.Append(" '" + referencia + "', ");
                strQuery.Append(" '" + bairro + "', ");
                strQuery.Append(" '" + cep + "', ");
                strQuery.Append(" '" + cidade + "', ");
                strQuery.Append(" '" + uf + "', ");
            }
            else if (mesmo_local_entrega == 0)
            {
                strQuery.Append(" '" + endereco_le + "', ");
                strQuery.Append(" '" + referencia_le + "', ");
                strQuery.Append(" '" + bairro_le + "', ");
                strQuery.Append(" '" + cep_le + "', ");
                strQuery.Append(" '" + cidade_le + "', ");
                strQuery.Append(" '" + uf_le + "', ");
            }
            strQuery.Append(" " + qtd_dias_f + ", ");
            strQuery.Append(" " + qtd_dias_c + ", ");
            strQuery.Append(" " + cad_status + ", "); 
            strQuery.Append(" " + ativo + ", ");
            strQuery.Append(" '" + obs + "', ");
            strQuery.Append(" '" + usuario + "' ");
            strQuery.Append(" ) ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public SqlDataReader Listar(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM pessoa ");
            strQuery.Append(" WHERE id_pessoa = " + intCodigo + " ");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader ListarFornFab(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM pessoa ");
            strQuery.Append(" WHERE id_pessoa = " + intCodigo + " ");
            strQuery.Append(" AND fornecedor = 1");
            strQuery.Append(" ORDER BY id_pessoa DESC");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public short LocCnpj_Cpf(string Cnpj_Cpf, short Tipo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT count(*) FROM pessoa ");
            if (Tipo == 1) //CNPJ
                strQuery.Append(" WHERE cnpj = '" + Cnpj_Cpf + "' ");
            else
                strQuery.Append(" WHERE cpf = '" + Cnpj_Cpf + "' ");
            clDataBase clDB = new clDataBase();
            return (short)clDB.ExComandoRetInt(strQuery.ToString());
        }

        /// <summary>
        /// INICIO CONTATO
        /// </summary>
        private int _id_contato;
        public int id_contato
        {
            get { return _id_contato; }
            set { _id_contato = value; }
        }

        private string _nome;
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _telefone;
        public string telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }

        private string _fax;
        public string fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        private string _celular;
        public string celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _cargo;
        public string cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        /// <summary>
        /// Métodos para CONTATO
        /// </summary>
        public void AltContato()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" UPDATE contatos");
            strQuery.Append(" SET");
            strQuery.Append(" nome = " + " '" + nome + "', ");
            strQuery.Append(" telefone = " + " '" + telefone + "', ");
            strQuery.Append(" fax = " + " '" + fax + "', ");
            strQuery.Append(" celular = " + " '" + celular + "', ");
            strQuery.Append(" email = " + " '" + email + "', ");
            strQuery.Append(" cargo = " + " '" + cargo + "', ");
            strQuery.Append(" id_pessoa = " + id_pessoa + " ");
            strQuery.Append(" WHERE");
            strQuery.Append(" id_contato = " + _id_contato + " ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public void ExcContato(int intContato)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" DELETE FROM contatos ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id_contato = " + intContato + " ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public void IncContato()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" INSERT INTO contatos");
            strQuery.Append(" ( ");
            strQuery.Append(" nome, ");
            strQuery.Append(" telefone, ");
            strQuery.Append(" fax, ");
            strQuery.Append(" celular, ");
            strQuery.Append(" email, ");
            strQuery.Append(" cargo, ");
            strQuery.Append(" id_pessoa ");
            strQuery.Append(" ) ");
            // VALUES
            strQuery.Append(" VALUES ( ");
            strQuery.Append(" '" + nome + "', ");
            strQuery.Append(" '" + telefone + "', ");
            strQuery.Append(" '" + fax + "', ");
            strQuery.Append(" '" + celular + "', ");
            strQuery.Append(" '" + email + "', ");
            strQuery.Append(" '" + cargo + "', ");
            strQuery.Append(" " + id_pessoa + " ");
            strQuery.Append(" ) ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public DataSet ListarContatos(int intPessoa)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_contato, nome, telefone FROM contatos ");
            strQuery.Append(" WHERE id_pessoa = " + intPessoa + " ");

            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataSet(strQuery.ToString());
        }

        public SqlDataReader AcharContato(int intContato)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM contatos ");
            strQuery.Append(" WHERE id_contato = " + intContato + " ");

            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public bool valida_cnpj_cpf(string s_cpf_cnpj)
        {
            if (!calculaCNPJ(s_cpf_cnpj))
            {
                if (!calculaCPF(s_cpf_cnpj))
                {
                    return false;
                }
            }
            return true;
        }

        private bool calculaCNPJ(string s_CNPJ)
        {
            int[] Numero = new int[14];
            int soma, resultado1, resultado2, x, i;
            string s = "";
            char ch;


            for (x = 0; x < s_CNPJ.Length; x++)
            {
                ch = Convert.ToChar(s_CNPJ.Substring(x, 1));
                if (((int)ch >= 48) && ((int)ch <= 57))
                {
                    s = s + s_CNPJ.Substring(x, 1);
                }
            }

            s_CNPJ = s;

            if ((s_CNPJ.Length != 14) || (s_CNPJ == "00000000000000"))
            {
                return false;
            }
            else
            {
                for (i = 0; i < s_CNPJ.Length; i++)
                {
                    Numero[i] = Convert.ToInt32(s_CNPJ.Substring(i, 1));
                }
            }

            soma = Numero[0] * 5 + Numero[1] * 4 + Numero[2] * 3 + Numero[3] * 2 + Numero[4] * 9 + Numero[5] * 8 + Numero[6] * 7 + Numero[7] * 6 + Numero[8] * 5 + Numero[9] * 4 + Numero[10] * 3 + Numero[11] * 2;

            soma = soma - (11 * (Math.Abs((soma / 11))));

            if (soma == 0 || soma == 1)
            {
                resultado1 = 0;
            }
            else
            {
                resultado1 = 11 - soma;
            }
            if (resultado1 == Numero[12])
            {
                soma = Numero[0] * 6 + Numero[1] * 5 + Numero[2] * 4 + Numero[3] * 3 + Numero[4] * 2 + Numero[5] * 9 + Numero[6] * 8 + Numero[7] * 7 + Numero[8] * 6 + Numero[9] * 5 + Numero[10] * 4 + Numero[11] * 3 + Numero[12] * 2;
                soma = soma - (11 * (Math.Abs((soma / 11))));

                if (soma == 0 || soma == 1)
                {
                    resultado2 = 0;
                }
                else
                {
                    resultado2 = 11 - soma;
                }

                if (resultado2 == Numero[13])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool calculaCPF(string s_CPF)
        {
            int[] Numero = new int[11];
            int soma, resultado1, resultado2, x, i;
            string s = "";
            char ch;

            //Retirar todos os caracteres que nao sejam 0-9
            for (x = 0; x < s_CPF.Length; x++)
            {
                ch = Convert.ToChar(s_CPF.Substring(x, 1));
                if (Convert.ToInt32(ch) >= 48 && Convert.ToInt32(ch) <= 57)
                {
                    s = s + s_CPF.Substring(x, 1);
                }
            }

            s_CPF = s;

            if ((s_CPF.Length != 11) || (s_CPF == "00000000000"))
            {
                return false;
            }
            else
            {
                for (i = 0; i < s_CPF.Length; i++)
                {
                    Numero[i] = Convert.ToInt32(s_CPF.Substring(i, 1));
                }

                soma = 10 * Numero[0] + 9 * Numero[1] + 8 * Numero[2] + 7 * Numero[3] + 6 * Numero[4] + 5 * Numero[5] + 4 * Numero[6] + 3 * Numero[7] + 2 * Numero[8];

                soma = soma - (11 * (Math.Abs((soma / 11))));

                if (soma == 0 || soma == 1)
                {
                    resultado1 = 0;
                }
                else
                {
                    resultado1 = 11 - soma;
                }

                if (resultado1 == Numero[9])
                {
                    soma = Numero[0] * 11 + Numero[1] * 10 + Numero[2] * 9 + Numero[3] * 8 + Numero[4] * 7 + Numero[5] * 6 + Numero[6] * 5 + Numero[7] * 4 + Numero[8] * 3 + Numero[9] * 2;
                    soma = soma - (11 * (Math.Abs((soma / 11))));

                    if (soma == 0 || soma == 1)
                    {
                        resultado2 = 0;
                    }
                    else
                    {
                        resultado2 = 11 - soma;
                    }

                    if (resultado2 == Numero[10])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

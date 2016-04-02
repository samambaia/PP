using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DllClasses.Net.Sistema.Globais;

namespace DllClasses.Net.Sistema.Negocio
{
    public class produto
    {
        private int _id_produto;
        public int id_produto
        {
            get
            {
                return _id_produto;
            }
            set
            {
                _id_produto = value;
            }
        }

        private string _descricao;
        public string descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                _descricao = value;
            }
        }

        private int _id_fornecedor;
        public int id_fornecedor
        {
            get
            {
                return _id_fornecedor;
            }
            set
            {
                _id_fornecedor = value;
            }
        }

        private int _id_fabrica;
        public int id_fabrica
        {
            get
            {
                return _id_fabrica;
            }
            set
            {
                _id_fabrica = value;
            }
        }

        private int _status;
        public int status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        private decimal _valor_unitario;
        public decimal valor_unitario
        {
            get
            {
                return _valor_unitario;
            }
            set
            {
                _valor_unitario = value;
            }
        }

        private DateTime _datacadastro = DateTime.Now;
        public DateTime datacadastro
        {
            get
            {
                return _datacadastro;
            }
        }

        private string _usuario;
        public string usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                _usuario = value;
            }
        }

        private decimal _icms_est;
        public decimal icms_est
        {
            get
            {
                return _icms_est;
            }
            set
            {
                _icms_est = value;
            }
        }

        private decimal _icms_int;
        public decimal icms_int
        {
            get
            {
                return _icms_int;
            }
            set
            {
                _icms_int = value;
            }
        }

        private decimal _icms_entra;
        public decimal icms_entra
        {
            get { return _icms_entra; }
            set { _icms_entra = value; }
        }

        private int _icms_ant;
        public int icms_ant
        {
            get
            {
                return _icms_ant;
            }
            set
            {
                _icms_ant = value;
            }
        }

        private int _sub_trib;
        public int sub_trib
        {
            get
            {
                return _sub_trib;
            }
            set
            {
                _sub_trib = value;
            }
        }

        private string _sit_trib;
        public string sit_trib
        {
            get
            {
                return _sit_trib;
            }
            set
            {
                _sit_trib = value;
            }
        }

        private short _tipo;
        public short tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }


        /// <summary>
        /// Métodos para Produto
        /// </summary>
        public void Alterar()
        {
            clDataBase clDB = new clDataBase();
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = clDB.strConexao;
            SqlCommand commAltProd = new SqlCommand();
            commAltProd.Connection = Conn;
            commAltProd.CommandType = CommandType.StoredProcedure;
            commAltProd.CommandText = "spc_AltProd";

            commAltProd.Parameters.Add("@id_produto", SqlDbType.SmallInt).Value = id_produto;
            commAltProd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;
            commAltProd.Parameters.Add("@id_fornecedor", SqlDbType.Int).Value = id_fornecedor;
            commAltProd.Parameters.Add("@id_fabrica", SqlDbType.Int).Value = id_fabrica;
            commAltProd.Parameters.Add("@status", SqlDbType.SmallInt).Value = status;
            commAltProd.Parameters.Add("@valor_unitario", SqlDbType.Decimal).Value = valor_unitario;
            commAltProd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            commAltProd.Parameters.Add("@aliq_icms_est", SqlDbType.Decimal).Value = icms_est;
            commAltProd.Parameters.Add("@aliq_icms_inter", SqlDbType.Decimal).Value = icms_int;
            commAltProd.Parameters.Add("@aliq_icms_entra", SqlDbType.Decimal).Value = icms_entra;
            commAltProd.Parameters.Add("@icms_ant", SqlDbType.SmallInt).Value = icms_ant;
            commAltProd.Parameters.Add("@sub_trib", SqlDbType.SmallInt).Value = sub_trib;
            commAltProd.Parameters.Add("@situacao_trib", SqlDbType.VarChar).Value = sit_trib;
            commAltProd.Parameters.Add("@tipo", SqlDbType.SmallInt).Value = tipo;

            try
            {
                Conn.Open();
                commAltProd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Gravar()
        {
            clDataBase clDB = new clDataBase();
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = clDB.strConexao;
            SqlCommand commIncProd = new SqlCommand();
            commIncProd.Connection = Conn;
            commIncProd.CommandType = CommandType.StoredProcedure;
            commIncProd.CommandText = "spc_IncProd";

            commIncProd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao;
            commIncProd.Parameters.Add("@id_fornecedor", SqlDbType.Int).Value = id_fornecedor;
            commIncProd.Parameters.Add("@id_fabrica", SqlDbType.Int).Value = id_fabrica;
            commIncProd.Parameters.Add("@status", SqlDbType.SmallInt).Value = status;
            commIncProd.Parameters.Add("@valor_unitario", SqlDbType.Decimal).Value = valor_unitario;
            commIncProd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            commIncProd.Parameters.Add("@aliq_icms_est", SqlDbType.Decimal).Value = icms_est;
            commIncProd.Parameters.Add("@aliq_icms_inter", SqlDbType.Decimal).Value = icms_int;
            commIncProd.Parameters.Add("@aliq_icms_entra", SqlDbType.Decimal).Value = icms_entra;
            commIncProd.Parameters.Add("@icms_ant", SqlDbType.SmallInt).Value = icms_ant;
            commIncProd.Parameters.Add("@sub_trib", SqlDbType.SmallInt).Value = sub_trib;
            commIncProd.Parameters.Add("@situacao_trib", SqlDbType.VarChar).Value = sit_trib;
            commIncProd.Parameters.Add("@tipo", SqlDbType.SmallInt).Value = tipo;

            try
            {
                Conn.Open();
                commIncProd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Conn.Close();
            }
        }

        public void Excluir(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" DELETE FROM produtos ");
            strQuery.Append(" WHERE ");
            strQuery.AppendFormat(" id_produto = {0} ", intCodigo);

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public DataSet Achar(int intIndice)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_produto, descricao, valor_unitario ");
            strQuery.Append(" FROM produtos ");
            if (intIndice == 0)
            {
                strQuery.AppendFormat(" WHERE id_produto = {0}", id_produto);
            }
            if (intIndice == 1)
            {
                strQuery.AppendFormat(" WHERE descricao like '%{0}%'", descricao);
            }
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataSet(strQuery.ToString());
        }

        public SqlDataReader Listar(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM produtos ");
            strQuery.AppendFormat(" WHERE id_produto = {0} ", intCodigo);
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }
    }
}

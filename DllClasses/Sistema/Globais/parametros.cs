using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DllClasses.Net.Sistema.Globais
{
    public class parametros
    {
        private short _mes_caixa;

        public short mes_caixa
        {
            get { return _mes_caixa; }
            set { _mes_caixa = value; }
        }

        private short _ano_caixa;

        public short ano_caixa
        {
            get { return _ano_caixa; }
            set { _ano_caixa = value; }
        }

        public void Alterar()
        {
            clDataBase clDB = new clDataBase();
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = clDB.strConexao;
            SqlCommand commAltera = new SqlCommand();
            commAltera.Connection = Conn;
            commAltera.CommandType = CommandType.StoredProcedure;
            commAltera.CommandText = "spc_AltParams";

            commAltera.Parameters.Add("@mes_caixa", SqlDbType.SmallInt).Value = mes_caixa;
            commAltera.Parameters.Add("@ano_caixa", SqlDbType.SmallInt).Value = ano_caixa;

            try
            {
                Conn.Open();
                commAltera.ExecuteNonQuery();
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

        public SqlDataReader Listar()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM parametros");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }
    }
}

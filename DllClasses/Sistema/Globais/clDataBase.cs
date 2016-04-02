using System;
using System.Data;
using System.Data.SqlClient;
using DllClasses.Properties;

namespace DllClasses.Net.Sistema.Globais
{
    public class clDataBase
    {
        // Atribui a variável o arquivo de configuração onde foi criada a string de conexão.
        public string strConexao = Settings.Default.Conexao;

        // Abre a conexão com o banco.
        public SqlConnection AbreBanco()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = strConexao;
            Conn.Open();
            return Conn;
        }

        // Fecha a conexao com o banco.
        public void FechaBanco(SqlConnection Conn)
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        // Função que executa um command no banco.
        public void ExComando(string strQuery)
        {
            SqlConnection Conn = new SqlConnection();
            try
            {
                Conn = AbreBanco();
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                cmdComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FechaBanco(Conn);
            }
        }

        // Função que executa um command com retorno do tipo Integer.
        public int ExComandoRetInt(string strQuery)
        {
            SqlConnection Conn = new SqlConnection();
            SqlDataReader dr;
            try
            {
                Conn = AbreBanco();
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                cmdComando.ExecuteScalar();

                // Cria uma query que busca o AutoInc gerado pelo banco.
                //cmdComando.CommandText = "Select @@Identity;";

                dr = cmdComando.ExecuteReader();
                if (dr.Read())
                    return Convert.ToInt32(dr[0]);
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FechaBanco(Conn);
            }
        }

        // Função que o ID atual da tabela.
        public int ExComandoRetID()
        {
            SqlConnection Conn = new SqlConnection();
            try
            {
                // Cria uma query que busca o AutoInc gerado pelo banco.
                Conn = AbreBanco();
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = "Select @@Identity;";
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                SqlDataReader dr;
                dr = cmdComando.ExecuteReader();
                if (dr.Read())
                    return Convert.ToInt32(dr[0]);
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FechaBanco(Conn);
            }
        }

        // Função que retorna um DataSet.
        public DataSet RetornaDataSet(string strQuery)
        {
            SqlConnection Conn = new SqlConnection();
            try
            {
                Conn = AbreBanco();
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;

                SqlDataAdapter da = new SqlDataAdapter();

                DataSet ds = new DataSet();

                da.SelectCommand = cmdComando;
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FechaBanco(Conn);
            }
        }

        // Função que retorna um DataReader.
        public SqlDataReader RetornaDataReader(string strQuery)
        {
            SqlConnection Conn = new SqlConnection();
            try
            {
                Conn = AbreBanco();
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                return cmdComando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //FechaBanco(Conn);
            }
        }

        // Auto-incremento
        public int AutoInc(string Tabela)
        {
            SqlConnection Conn = new SqlConnection();
            try
            {
                Conn = AbreBanco();
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = "select IDENT_CURRENT ('" + Tabela + "')+1";
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                SqlDataReader dr;
                dr = cmdComando.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() == "")
                    return 1;
                else
                    return Convert.ToInt32(dr[0]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FechaBanco(Conn);
            }
        }

        //Função que retorna um valor Decimal
        public Decimal ExComandoRetDec(string strQuery)
        {
            Decimal TotalPed;
            SqlConnection Conn = new SqlConnection();
            try
            {
                Conn = AbreBanco();
                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                TotalPed = Convert.ToDecimal(cmdComando.ExecuteScalar());

                return TotalPed;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FechaBanco(Conn);
            }
        }
    }
}

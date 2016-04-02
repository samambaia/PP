using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DllClasses.Net.Sistema.Globais;

namespace DllClasses.Net.Sistema.Negocio
{
    public class orcamento
    {
        #region Propriedades Cabeçalho Pedido

        private int _id_orcamento;
        public int id_orcamento
        {
            get { return _id_orcamento; }
            set { _id_orcamento = value; }
        }

        private int _id_cliente;
        public int id_cliente
        {
            get { return _id_cliente; }
            set { _id_cliente = value; }
        }

        private string _fantasia;
        public string fantasia
        {
            get { return _fantasia; }
            set { _fantasia = value; }
        }

        private string _veiculo;
        public string veiculo
        {
            get { return _veiculo; }
            set { _veiculo = value; }
        }

        private string _placa;
        public string placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        private string _mecanico;
        public string mecanico
        {
            get { return _mecanico; }
            set { _mecanico = value; }
        }

        private int _kilometragem;
        public int kilometragem
        {
            get { return _kilometragem; }
            set { _kilometragem = value; }
        }

        private DateTime _dt_entrada;
        public DateTime dt_entrada
        {
            get { return _dt_entrada; }
            set { _dt_entrada = value; }
        }

        private DateTime _dt_saida;
        public DateTime dt_saida
        {
            get { return _dt_saida; }
            set { _dt_saida = value; }
        }

        private short _combustivel;
        public short combustivel
        {
            get { return _combustivel; }
            set { _combustivel = value; }
        }

        private short _garantia;
        public short garantia
        {
            get { return _garantia; }
            set { _garantia = value; }
        }

        private string _ordem_servico;
        public string ordem_servico
        {
            get { return _ordem_servico; }
            set { _ordem_servico = value; }
        }

        private string _obs;
        public string obs
        {
            get { return _obs; }
            set { _obs = value; }
        }

        private string _desc_aux;
        public string desc_aux
        {
            get { return _desc_aux; }
            set { _desc_aux = value; }
        }

        private int _empresa;
        public int empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        public decimal vlr_total { get; set; }

        #endregion

        #region Métodos Orçamento
        public DataSet Achar(int intIndice)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_orcamento, nome_cliente, placa, dt_entrada, vlr_total, obs ");
            strQuery.Append(" FROM view_achar_orca ");
            if (intIndice == 0)
            {
                strQuery.Append(" WHERE id_orcamento = " + id_orcamento);
            }
            else if (intIndice == 1)
            {
                strQuery.Append(" WHERE nome_cliente like '%" + desc_aux + "%'");
                strQuery.Append(" ORDER BY id_orcamento DESC ");
            }
            else if (intIndice == 2)
            {
                strQuery.Append(" WHERE placa = '" + placa +"' ");
            }
            else
            {
                strQuery.Append(" WHERE id_orcamento = -1");
            }

            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataSet(strQuery.ToString());
        }

        public void Alterar()
        {
            clDataBase clDB = new clDataBase();
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = clDB.strConexao;
            SqlCommand commAltera = new SqlCommand();
            commAltera.Connection = Conn;
            commAltera.CommandType = CommandType.StoredProcedure;
            commAltera.CommandText = "spc_AltOrcamento";

            commAltera.Parameters.Add("@id_orcamento", SqlDbType.Int).Value = id_orcamento;
            commAltera.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
            commAltera.Parameters.Add("@veiculo", SqlDbType.VarChar).Value = veiculo;
            commAltera.Parameters.Add("@placa", SqlDbType.VarChar).Value = placa;
            commAltera.Parameters.Add("@mecanico", SqlDbType.VarChar).Value = mecanico;
            commAltera.Parameters.Add("@kilometragem", SqlDbType.Int).Value = kilometragem;
            commAltera.Parameters.Add("@dt_entrada", SqlDbType.DateTime).Value = dt_entrada;
            if (dt_saida.ToShortDateString().Equals("01/01/0001"))
                commAltera.Parameters.Add("@dt_saida", SqlDbType.VarChar).Value = "";
            else
                commAltera.Parameters.Add("@dt_saida", SqlDbType.DateTime).Value = dt_saida;
            commAltera.Parameters.Add("@combustivel", SqlDbType.SmallInt).Value = combustivel;
            commAltera.Parameters.Add("@garantia", SqlDbType.SmallInt).Value = garantia;
            commAltera.Parameters.Add("@obs", SqlDbType.VarChar).Value = obs;
            commAltera.Parameters.Add("@empresa", SqlDbType.Int).Value = empresa;
            commAltera.Parameters.Add("@ordem_servico", SqlDbType.VarChar).Value = ordem_servico;

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

        public void Excluir(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" DELETE FROM orcamento ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id_orcamento = " + intCodigo + " ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public void Gravar()
        {
            clDataBase clDB = new clDataBase();
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = clDB.strConexao;
            SqlCommand commGrava = new SqlCommand();
            commGrava.Connection = Conn;
            commGrava.CommandType = CommandType.StoredProcedure;
            commGrava.CommandText = "spc_IncOrcamento";

            commGrava.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
            commGrava.Parameters.Add("@veiculo", SqlDbType.VarChar).Value = veiculo;
            commGrava.Parameters.Add("@placa", SqlDbType.VarChar).Value = placa;
            commGrava.Parameters.Add("@mecanico", SqlDbType.VarChar).Value = mecanico;
            commGrava.Parameters.Add("@kilometragem", SqlDbType.Int).Value = kilometragem;
            commGrava.Parameters.Add("@dt_entrada", SqlDbType.DateTime).Value = dt_entrada;
            commGrava.Parameters.Add("@combustivel", SqlDbType.SmallInt).Value = combustivel;
            commGrava.Parameters.Add("@garantia", SqlDbType.SmallInt).Value = garantia;
            commGrava.Parameters.Add("@obs", SqlDbType.VarChar).Value = obs;
            commGrava.Parameters.Add("@empresa", SqlDbType.Int).Value = empresa;
            commGrava.Parameters.Add("@ordem_servico", SqlDbType.VarChar).Value = ordem_servico;

            try
            {
                Conn.Open();
                commGrava.ExecuteNonQuery();

                SqlCommand cmdComando = new SqlCommand();
                cmdComando.CommandText = "Select @@Identity;";
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                SqlDataReader dr;
                dr = cmdComando.ExecuteReader();
                dr.Read();
                id_orcamento = int.Parse(dr[0].ToString());
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

        public SqlDataReader Listar(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM orcamento ");
            strQuery.Append(" WHERE id_orcamento = " + intCodigo + " ");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader LocCliente(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_pessoa, fantasia, orientacao, qtd_dias_c"); 
            strQuery.Append(" FROM view_pes_orient ");
            strQuery.Append(" WHERE id_pessoa = " + intCodigo + " ");

            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        #endregion

        #region Propriedades Itens Pedido

        private int _id_item_orca;
        public int id_item_orca
        {
            get { return _id_item_orca; }
            set { _id_item_orca = value; }
        }

        private int _id_produto;
        public int id_produto
        {
            get { return _id_produto;}
            set { _id_produto = value;}
        }

        private string _unidade;
        public string unidade
        {
            get { return _unidade;}
            set { _unidade = value;}
        }

        private decimal _icms;
        public decimal icms
        {
            get { return _icms;}
            set { _icms = value;}
        }

        private decimal _quantidade;
        public decimal quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        private Decimal _valor_unitario;
        public Decimal valor_unitario
        {
            get { return _valor_unitario; }
            set { _valor_unitario = value; }
        }

        private Decimal _valor_total;
        public Decimal valor_total
        {
            get { return _valor_total; }
            set { _valor_total = value; }
        }

        private Decimal _per_desconto;
        public Decimal per_desconto
        {
            get { return _per_desconto; }
            set { _per_desconto = value; }
        }
        #endregion

        #region Métodos Itens Orçamento
        public DataSet Achar_Itens()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_orcamento, id_produto, descricao, quantidade, valor_unitario, ");
            strQuery.Append(" per_desconto, valor_total, id_item_orca, icms, tipo ");
            strQuery.Append(" FROM view_grid_itens_orca ");
            strQuery.Append(" WHERE id_orcamento = " + id_orcamento);

            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataSet(strQuery.ToString());
        }

        public void Alterar_Itens()
        {
            clDataBase clDB = new clDataBase();
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = clDB.strConexao;
            SqlCommand commAltItens = new SqlCommand();
            commAltItens.Connection = Conn;
            commAltItens.CommandType = CommandType.StoredProcedure;
            commAltItens.CommandText = "spc_AltItens_Orca";

            commAltItens.Parameters.Add("@id_item_orca", SqlDbType.SmallInt).Value = id_item_orca;
            commAltItens.Parameters.Add("@id_orcamento", SqlDbType.SmallInt).Value = id_orcamento;
            commAltItens.Parameters.Add("@id_produto", SqlDbType.SmallInt).Value = id_produto;
            commAltItens.Parameters.Add("@quantidade", SqlDbType.Decimal).Value = quantidade;
            commAltItens.Parameters.Add("@valor_unitario", SqlDbType.Decimal).Value = valor_unitario;
            commAltItens.Parameters.Add("@valor_total", SqlDbType.Decimal).Value = valor_total;
            commAltItens.Parameters.Add("@per_desconto", SqlDbType.Decimal).Value = per_desconto;
            commAltItens.Parameters.Add("@icms", SqlDbType.Decimal).Value = icms;
            commAltItens.Parameters.Add("@unidade", SqlDbType.VarChar).Value = unidade;

            try
            {
                Conn.Open();
                commAltItens.ExecuteNonQuery();
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

        public void Excluir_Itens(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" DELETE FROM itens_orcamento ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id_item_orca = " + intCodigo + " ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public void Gravar_Itens()
        {
            clDataBase clDB = new clDataBase();
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = clDB.strConexao;
            SqlCommand commGravaItens = new SqlCommand();
            commGravaItens.Connection = Conn;
            commGravaItens.CommandType = CommandType.StoredProcedure;
            commGravaItens.CommandText = "spc_IncItens_Orca";

            commGravaItens.Parameters.Add("@id_orcamento", SqlDbType.SmallInt).Value = id_orcamento;
            commGravaItens.Parameters.Add("@id_produto", SqlDbType.SmallInt).Value = id_produto;
            commGravaItens.Parameters.Add("@quantidade", SqlDbType.Decimal).Value = quantidade;
            commGravaItens.Parameters.Add("@valor_unitario", SqlDbType.Decimal).Value = valor_unitario;
            commGravaItens.Parameters.Add("@valor_total", SqlDbType.Decimal).Value = valor_total;
            commGravaItens.Parameters.Add("@per_desconto", SqlDbType.Decimal).Value = per_desconto;
            commGravaItens.Parameters.Add("@icms", SqlDbType.Decimal).Value = icms;
            commGravaItens.Parameters.Add("@unidade", SqlDbType.VarChar).Value = unidade;

            try
            {
                Conn.Open();
                commGravaItens.ExecuteNonQuery();
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

        public SqlDataReader Listar_Itens(int idItem)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM view_grid_itens_orca ");
            strQuery.Append(" WHERE id_item_orca = " + idItem + " ");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader LocProduto(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_produto, descricao, aliq_icms_est, aliq_icms_entra, valor_unitario, tipo FROM produtos ");
            strQuery.Append(" WHERE id_produto = " + intCodigo + " ");
            strQuery.Append(" AND status = 1 ");

            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public Decimal Total_Pedido(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT sum(valor_total) total_pedido FROM itens_orcamento ");
            strQuery.Append(" WHERE id_orcamento = " + intCodigo + " ");

            clDataBase clDB = new clDataBase();
            return clDB.ExComandoRetDec(strQuery.ToString());
        }

        public SqlDataReader Dup_Itens(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM view_grid_itens_saida ");
            strQuery.Append(" WHERE id_saida = " + intCodigo + " ");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }
        #endregion
    }
}

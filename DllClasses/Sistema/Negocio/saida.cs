using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DllClasses.Net.Sistema.Globais;

namespace DllClasses.Net.Sistema.Negocio
{
    public class saida
    {
        #region Propriedades Cabeçalho Pedido
        private int _id_saida;
        public int id_saida
        {
            get { return _id_saida; }
            set { _id_saida = value; }
        }

        private int _id_armazenagem;
        public int id_armazenagem
        {
            get { return _id_armazenagem; }
            set { _id_armazenagem = value; }
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
        
        private int _id_forma_pag;
        public int id_forma_pag
        {
            get { return _id_forma_pag; }
            set { _id_forma_pag = value; }
        }

        private int _id_ccorrente;
        public int id_ccorrente
        {
            get { return _id_ccorrente; }
            set { _id_ccorrente = value; }
        }

        private string _cfop;
        public string cfop
        {
            get { return _cfop; }
            set { _cfop = value; }
        }
        
        private DateTime _data_emissao;
        public DateTime data_emissao
        {
            get { return _data_emissao; }
            set { _data_emissao = value; }
        }

        private DateTime _data_saida;
        public DateTime data_saida
        {
            get { return _data_saida; }
            set { _data_saida = value; }
        }

        private DateTime _data_vencimento;
        public DateTime data_vencimento
        {
            get { return _data_vencimento; }
            set { _data_vencimento = value; }
        }
         
        //private Nullable<DateTime> _data_pagamento;
        //public Nullable<DateTime> data_pagamento
        //{
        //    get { return _data_pagamento; }
        //}

        private string _nf;
        public string nf
        {
            get { return _nf; }
            set { _nf = value; }
        }

        private int _id_vendedor;
        public int id_vendedor
        {
            get { return _id_vendedor; }
            set { _id_vendedor = value; }
        }

        private string _obs;
        public string obs
        {
            get { return _obs; }
            set { _obs = value; }
        }

        private string _obs2;
        public string obs2
        {
            get { return _obs2; }
            set { _obs2 = value; }
        }

        private int _conciliado = 0;
        public int conciliado
        {
            get { return _conciliado; }
        }

        private int _efetivado = 0;
        public int efetivado
        {
            get { return _efetivado; }
        }

        private string _usuario;
        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _desc_aux;
        public string desc_aux
        {
            get { return _desc_aux; }
            set { _desc_aux = value; }
        }

        private string _selo;
        public string selo
        {
            get{return _selo;}
            set{_selo = value;}
        }

        private int _qtd_dias;
        public int qtd_dias
        {
            set { _qtd_dias = value;}
        }

        private short _frete_pc;
        public short frete_pc
        {
            get { return _frete_pc; }
            set { _frete_pc = value; }
        }

        private string _nome_razao;
        public string nome_razao
        {
            get { return _nome_razao; }
            set { _nome_razao = value; }
        }

        private string _placa;
        public string placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        private string _uf_placa;
        public string uf_placa
        {
            get { return _uf_placa; }
            set { _uf_placa = value; }
        }

        private string _cpf_cnpj;
        public string cpf_cnpj
        {
            get { return _cpf_cnpj; }
            set { _cpf_cnpj = value; }
        }

        private string _insc_estadual;
        public string insc_estadual
        {
            get { return _insc_estadual; }
            set { _insc_estadual = value; }
        }

        private string _endereco;
        public string endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        private string _municipio;
        public string municipio
        {
            get { return _municipio; }
            set { _municipio = value; }
        }

        private string _uf;
        public string uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        private short _qtd_transp;
        public short qtd_transp
        {
            get { return _qtd_transp; }
            set { _qtd_transp = value; }
        }

        private string _especie;
        public string especie
        {
            get { return _especie; }
            set { _especie = value; }
        }

        private int _empresa;
        public int empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        #endregion

        #region Métodos Pedido
        public DataSet Achar(int intIndice)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_saida, nome_clie, nf, data_emissao ");
            strQuery.Append(" FROM view_achar_saida ");
            if (intIndice == 0)
            {
                strQuery.Append(" WHERE id_saida = " + id_saida);
            }
            if (intIndice == 1)
            {
                strQuery.Append(" WHERE nome_clie like '%" + desc_aux + "%'");
            }
            if (intIndice == 3)
            {
                strQuery.Append(" WHERE nf = '" + nf +"' ");
            }
            strQuery.Append(" ORDER BY data_emissao DESC ");

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
            commAltera.CommandText = "spc_AltSaida";

            commAltera.Parameters.Add("@id_saida", SqlDbType.Int).Value = id_saida;
            commAltera.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
            commAltera.Parameters.Add("@data_emissao", SqlDbType.DateTime).Value = data_emissao;
            commAltera.Parameters.Add("@nf", SqlDbType.VarChar).Value = nf;
            commAltera.Parameters.Add("@id_vendedor", SqlDbType.Int).Value = id_vendedor;
            commAltera.Parameters.Add("@obs", SqlDbType.VarChar).Value = obs;
            commAltera.Parameters.Add("@obs2", SqlDbType.VarChar).Value = obs2;
            commAltera.Parameters.Add("@cfop", SqlDbType.VarChar).Value = cfop;
            commAltera.Parameters.Add("@selo", SqlDbType.VarChar).Value = selo;
            commAltera.Parameters.Add("@frete_pc", SqlDbType.SmallInt).Value = frete_pc;
            commAltera.Parameters.Add("@nome_razao", SqlDbType.VarChar).Value = nome_razao;
            commAltera.Parameters.Add("@placa", SqlDbType.VarChar).Value = placa;
            commAltera.Parameters.Add("@uf_placa", SqlDbType.VarChar).Value = uf_placa;
            commAltera.Parameters.Add("@cpf_cnpj", SqlDbType.VarChar).Value = cpf_cnpj;
            commAltera.Parameters.Add("@insc_estadual", SqlDbType.VarChar).Value = insc_estadual;
            commAltera.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;
            commAltera.Parameters.Add("@municipio", SqlDbType.VarChar).Value = municipio;
            commAltera.Parameters.Add("@uf", SqlDbType.VarChar).Value = uf;
            commAltera.Parameters.Add("@qtd_transp", SqlDbType.SmallInt).Value = qtd_transp;
            commAltera.Parameters.Add("@especie", SqlDbType.VarChar).Value = especie;
            commAltera.Parameters.Add("@empresa", SqlDbType.Int).Value = empresa;
            commAltera.Parameters.Add("@usuario", SqlDbType.VarChar).Value = "USUÁRIO";

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
            strQuery.Append(" DELETE FROM saida ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id_saida = " + intCodigo + " ");

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
            commGrava.CommandText = "spc_IncSaida";

            commGrava.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
            commGrava.Parameters.Add("@data_emissao", SqlDbType.DateTime).Value = data_emissao;
            commGrava.Parameters.Add("@nf", SqlDbType.VarChar).Value = nf;
            commGrava.Parameters.Add("@id_vendedor", SqlDbType.Int).Value = id_vendedor;
            commGrava.Parameters.Add("@obs", SqlDbType.VarChar).Value = obs;
            commGrava.Parameters.Add("@obs2", SqlDbType.VarChar).Value = obs2;
            commGrava.Parameters.Add("@cfop", SqlDbType.VarChar).Value = cfop;
            commGrava.Parameters.Add("@selo", SqlDbType.VarChar).Value = selo;
            commGrava.Parameters.Add("@frete_pc", SqlDbType.SmallInt).Value = frete_pc;
            commGrava.Parameters.Add("@nome_razao", SqlDbType.VarChar).Value = nome_razao;
            commGrava.Parameters.Add("@placa", SqlDbType.VarChar).Value = placa;
            commGrava.Parameters.Add("@uf_placa", SqlDbType.VarChar).Value = uf_placa;
            commGrava.Parameters.Add("@cpf_cnpj", SqlDbType.VarChar).Value = cpf_cnpj;
            commGrava.Parameters.Add("@insc_estadual", SqlDbType.VarChar).Value = insc_estadual;
            commGrava.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;
            commGrava.Parameters.Add("@municipio", SqlDbType.VarChar).Value = municipio;
            commGrava.Parameters.Add("@uf", SqlDbType.VarChar).Value = uf;
            commGrava.Parameters.Add("@qtd_transp", SqlDbType.SmallInt).Value = qtd_transp;
            commGrava.Parameters.Add("@especie", SqlDbType.VarChar).Value = especie;
            commGrava.Parameters.Add("@empresa", SqlDbType.Int).Value = empresa;
            commGrava.Parameters.Add("@usuario", SqlDbType.VarChar).Value = "USUÁRIO";

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
                id_saida = int.Parse(dr[0].ToString());
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

        public void Gravar_Dup()
        {
            clDataBase clDB = new clDataBase();
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = clDB.strConexao;
            SqlCommand commGrava = new SqlCommand();
            commGrava.Connection = Conn;
            commGrava.CommandType = CommandType.StoredProcedure;
            commGrava.CommandText = "spc_IncDupSaida";

            commGrava.Parameters.Add("@id_armazenagem", SqlDbType.Int).Value = id_armazenagem;
            commGrava.Parameters.Add("@id_cliente", SqlDbType.Int).Value = id_cliente;
            commGrava.Parameters.Add("@id_forma_pag", SqlDbType.Int).Value = id_forma_pag;
            commGrava.Parameters.Add("@id_ccorrente", SqlDbType.Int).Value = id_ccorrente;
            commGrava.Parameters.Add("@id_vendedor", SqlDbType.Int).Value = id_vendedor;
            commGrava.Parameters.Add("@data_emissao", SqlDbType.DateTime).Value = data_emissao;
            commGrava.Parameters.Add("@data_vencimento", SqlDbType.DateTime).Value = data_vencimento;
            commGrava.Parameters.Add("@cfop", SqlDbType.VarChar).Value = cfop;

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
                id_saida = int.Parse(dr[0].ToString());
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
            strQuery.Append(" SELECT * FROM saida ");
            strQuery.Append(" WHERE id_saida = " + intCodigo + " ");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader Imp_NF(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM view_saida_nf ");
            strQuery.Append(" WHERE id_saida = " + intCodigo + " ");
            strQuery.Append(" ORDER BY tipo, id_item ");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader Imp_NF(int intCodigo, short Tipo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM view_saida_nf ");
            strQuery.Append(" WHERE id_saida = " + intCodigo + " ");
            strQuery.Append(" AND tipo = " + Tipo + " ");
            strQuery.Append(" ORDER BY tipo, id_item ");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader Tot_Desc_NF(int intCodigo, short Tipo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT coalesce(SUM(total_desc),0) as total_desc FROM view_saida_nf ");
            strQuery.Append(" WHERE id_saida = " + intCodigo + " ");
            strQuery.Append(" AND tipo = " + Tipo);
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader Imp_NF_Totais(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT ");
            strQuery.Append(" coalesce((SELECT sum(total_item) FROM view_saida_nf ");
            strQuery.Append("   WHERE id_saida = " + intCodigo + " and icms > 0),0) as base_icms, ");
            strQuery.Append(" coalesce((SELECT sum(total_icms) FROM view_saida_nf ");
            strQuery.Append("   WHERE id_saida = " + intCodigo + "),0) as total_icms, ");
            strQuery.Append(" coalesce((SELECT sum(total_item) FROM view_saida_nf ");
            strQuery.Append("   WHERE id_saida = " + intCodigo + "),0) as total_nf ");
            strQuery.Append(" FROM view_saida_nf ");
            strQuery.Append(" WHERE id_saida = " + intCodigo);
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader Imp_Pedido(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM view_saida_pedido ");
            strQuery.Append(" WHERE id_saida = " + intCodigo + " ");
            strQuery.Append(" ORDER BY id_produto ");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader Imp_Recibo(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT DISTINCT razao_empresa, endereco, telefone, ");
            strQuery.Append(" razao_social, id_saida, nf, cpf_cnpj, ");
            strQuery.Append(" (SELECT SUM(total_item) FROM view_saida_recibo ");
            strQuery.Append(" WHERE id_saida = "+ intCodigo +") AS total ");
            strQuery.Append(" FROM view_saida_recibo ");
            strQuery.Append(" WHERE id_saida = " + intCodigo); 
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

        public SqlDataReader LocNF(string nf)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT nf from SAIDA");
            strQuery.Append(" WHERE nf = '" + nf + "' ");

            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public SqlDataReader LocMeuPedido(string meu_pedido)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT meu_pedido from SAIDA");
            strQuery.Append(" WHERE meu_pedido = '" + meu_pedido + "' ");

            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }
        #endregion

        #region Propriedades Itens Pedido
        private int _id_item;
        public int id_item
        {
            get { return _id_item; }
            set { _id_item = value; }
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

        #region Métodos Itens Pedido
        public DataSet Achar_Itens()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_produto, descricao, quantidade, valor_unitario, ");
            strQuery.Append(" per_desconto, valor_total, id_item, id_saida, icms, tipo ");
            strQuery.Append(" FROM view_grid_itens_saida ");
            strQuery.Append(" WHERE id_saida = " + id_saida);

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
            commAltItens.CommandText = "spc_AltItens_Saida";

            commAltItens.Parameters.Add("@id_item", SqlDbType.SmallInt).Value = id_item;
            commAltItens.Parameters.Add("@id_saida", SqlDbType.SmallInt).Value = id_saida;
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
            strQuery.Append(" DELETE FROM itens_saida ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id_item = " + intCodigo + " ");

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
            commGravaItens.CommandText = "spc_IncItens_Saida";

            commGravaItens.Parameters.Add("@id_saida", SqlDbType.SmallInt).Value = id_saida;
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
            strQuery.Append(" SELECT * FROM view_grid_itens_saida ");
            strQuery.Append(" WHERE id_item = " + idItem + " ");
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
            strQuery.Append(" SELECT sum(valor_total) total_pedido FROM itens_saida ");
            strQuery.Append(" WHERE id_saida = " + intCodigo + " ");

            clDataBase clDB = new clDataBase();
            return clDB.ExComandoRetDec(strQuery.ToString());
        }

        public SqlDataReader LocValorEmb(int intCodEmb, int intCodTab) 
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT valor FROM precos ");
            strQuery.Append(" WHERE id_tabelas   = " + intCodTab);
            strQuery.Append("   AND id_embalagem = " + intCodEmb);

            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }

        public Decimal Total_Ind_Dist(int intCodigo, short Ind)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT coalesce(sum(valor_total),0) total_pedido ");
            strQuery.Append(" FROM view_grid_itens_saida ");
            strQuery.Append(" WHERE id_saida = " + intCodigo + " ");
            strQuery.Append("   AND industria = " + Ind);

            clDataBase clDB = new clDataBase();
            return clDB.ExComandoRetDec(strQuery.ToString());
        }

        public void Muda_Sit_Ped(int intCodigo, short Tipo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" UPDATE saida ");
            strQuery.Append(" SET efetivado = " + Tipo);
            strQuery.Append(" WHERE ");
            strQuery.Append(" id_saida = " + intCodigo);

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
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

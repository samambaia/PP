using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DllClasses.Net.Sistema.Globais;

namespace DllClasses.Net.Sistema.Negocio
{
    public class cfop
    {
        private string _id_cfop;
        public string id_cfop        
        {
            get
            {
                return _id_cfop;
            }
            set
            {
                _id_cfop = value;
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

        private short _tipo;
        public short tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                _tipo = value;
            }
        }

        private string _orientacao;
        public string orientacao
        {
            get
            {
                return _orientacao;
            }
            set
            {
                _orientacao = value;
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

        public void Gravar()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" INSERT INTO cfop ");
            strQuery.Append(" ( ");
            strQuery.Append(" id_cfop, ");
            strQuery.Append(" descricao, ");
            strQuery.Append(" orientacao, ");
            strQuery.Append(" tipo, ");
            strQuery.Append(" usuario ");
            strQuery.Append(" ) ");
            strQuery.Append(" VALUES ( ");
            strQuery.Append(" '" + id_cfop + "', ");
            strQuery.Append(" '" + descricao + "', ");
            strQuery.Append(" '" + orientacao + "', ");
            strQuery.Append(" " + tipo + ", ");
            strQuery.Append(" '" + usuario + "' ");
            strQuery.Append(" ) ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public void Alterar()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" UPDATE cfop ");
            strQuery.Append(" SET ");
            strQuery.Append(" descricao = " + " '" + descricao + "', ");
            strQuery.Append(" orientacao = "+" '" + orientacao + "', ");
            strQuery.Append(" tipo = " + tipo + ", ");
            strQuery.Append(" usuario = "+" '" + usuario + "' ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id_cfop = '"+ _id_cfop +"' ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public void Excluir(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" DELETE FROM cfop ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" id_cfop = '" + intCodigo + "' ");

            clDataBase clDB = new clDataBase();
            clDB.ExComando(strQuery.ToString());
        }

        public DataSet Achar(int intIndice)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT id_cfop, descricao, orientacao FROM cfop ");
            if (intIndice == 0)
            {
                strQuery.Append(" WHERE id_cfop = '"+id_cfop+"' ");
            }
            if (intIndice == 1)
            {
                strQuery.Append(" WHERE descricao like '%" + descricao + "%'"); 
            }
            if (intIndice == 2)
            {
                strQuery.Append(" WHERE orientacao like '%" + orientacao + "%'");
            }
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataSet(strQuery.ToString());
        }

        public SqlDataReader Listar(string intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT * FROM cfop");
            strQuery.Append(" WHERE id_cfop = '" + intCodigo + "' ");
            clDataBase clDB = new clDataBase();
            return clDB.RetornaDataReader(strQuery.ToString());
        }
    }
}

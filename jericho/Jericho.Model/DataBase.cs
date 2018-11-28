using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SQLite;


namespace Jericho.Model
{
   public class DataBase
    {
        
        private SQLiteConnection conn { get; set; }
        private string stringConnection { get; set; }
        private List<SQLiteParameter> listaParameter = new List<SQLiteParameter>();
        string pathBanco = @"C:\Users\17000001504\Documents\Jericho.db"; //Aqui é definido o caminho do banco
        public DataBase()
        {
            try
            {
                if (File.Exists(pathBanco)) //Verifica se o banco existe
                {
                    this.stringConnection = "Data Source=" + pathBanco + ";Version=3"; // atribui string de conexão
                    conn = new SQLiteConnection(stringConnection);
                }
                else
                {
                    throw new Exception("Banco de Dados não encontrado. Reinstá-le a aplicação!"); //caso o banco não exista retornara esta mensagem
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
          }                
        
      public void AddParameter(string nome, object valor, DbType tipo, int size)
        {
            SQLiteParameter parametro = new SQLiteParameter(nome, valor);
            parametro.DbType = tipo;
            parametro.Size = size;
            listaParameter.Add(parametro);
        }
        public void AddParameter(string nome, object valor, DbType tipo)
        {
            SQLiteParameter parametro = new SQLiteParameter(nome, valor);
            parametro.DbType = tipo;
            listaParameter.Add(parametro);
        }
        /// <summary>
        ///  Verifica se a conexão esta fechada caso esteja abra conexão
        /// </summary>
        public void OpenConnection() //Verifica conexão
        {
            if (this.conn.State == ConnectionState.Closed)
            {
                this.conn.Open();
            }
        }
       /// <summary>
       /// Responsavel por fechar conexão
       /// </summary>
        public void CloseConection()
        {
            this.conn.Close();
        }

        /// <summary>
        /// Retorna um SQLiteDataReader com um objeto (É usado no select e no select all)
        /// </summary>
        /// <param name="_sql"></param>
        /// <returns></returns>
        public SQLiteDataReader ExecuteReader(string _sql)
        {

            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = _sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;

            if (listaParameter != null)
            {
                foreach (SQLiteParameter parameter in listaParameter)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            SQLiteDataReader dr;
            dr = cmd.ExecuteReader();
            return dr;
        }

        /// <summary>
        /// Retorna uma int que contem as linhas afetadas (usado no insert, update, delete)
        /// </summary>
        /// <param name="_sql"></param>
        /// <returns></returns>
        public int ExecuteNoQuery(string _sql)
        {
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.CommandText = _sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                if (listaParameter != null)
                {
                    foreach (SQLiteParameter parameter in listaParameter)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                int resultado = cmd.ExecuteNonQuery();
                return resultado;
         }
          
        

        public object ExecuteEscalar(string _sql)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.CommandText = _sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            if (listaParameter != null)
            {
                foreach (SQLiteParameter parameter in listaParameter)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            object resultado = cmd.ExecuteScalar();
            return resultado;

        }
    }
}



        


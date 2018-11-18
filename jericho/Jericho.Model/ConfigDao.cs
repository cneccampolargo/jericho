using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Jericho.Model
{
    public class ConfigDao
    {
        public Config selectCFG(string chave)
        {
            DataBase db = new DataBase();
            try
            {
                SQLiteDataReader dr;
             
                db.OpenConnection();
                db.AddParameter("@chave", chave, DbType.String);
                string sql = "SELECT * FROM Config WHERE Chave = @chave ";

                dr = db.ExecuteReader(sql);

                Config config = new Config();
                if (dr.Read())
                {
                    config.Chave = Convert.ToString(dr["Chave"]);
                    config.Valor = Convert.ToString(dr["Valor"]);

                }
                return config;
            }


            catch (Exception ex)
            {

                ex.ToString();
                return null;
            }
            finally
            {

                db.CloseConection();
            }


        }
        public void updateCFG(string chave, string valor)
        {
            DataBase db = new DataBase();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();
                
                db.OpenConnection();
                db.AddParameter("@chave", chave, DbType.String);
                db.AddParameter("@valor", valor, DbType.String);
                string sql = "UPDATE Config SET valor = @valor WHERE chave = @chave;";

                int result = db.ExecuteNoQuery(sql);
            }
            catch(Exception ex)
            {

                ex.ToString();
               
               
            }
            finally
            {
                db.CloseConection();
            }
            
        }

        public Config selectNome(string chave)
        {
            DataBase db = new DataBase();
            try
            {
                SQLiteDataReader dr;

                db.OpenConnection();
                db.AddParameter("@chave", chave, DbType.String);
                string sql = "SELECT * FROM Config WHERE Chave = @chave ";

                dr = db.ExecuteReader(sql);

                Config config = new Config();
                if (dr.Read())
                {
                    config.Chave = Convert.ToString(dr["Chave"]);
                    config.Valor = Convert.ToString(dr["Valor"]);

                }
                return config;
            }


            catch (Exception ex)
            {

                ex.ToString();
                return null;
            }
            finally
            {

                db.CloseConection();
            }
        }


        public void updateNome(string chave, string valor)
        {
            DataBase db = new DataBase();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();

                db.OpenConnection();
                db.AddParameter("@chave", chave, DbType.String);
                db.AddParameter("@valor", valor, DbType.String);
                string sql = "UPDATE Config SET valor = @valor WHERE chave = @chave;";

                int result = db.ExecuteNoQuery(sql);
            }
            catch (Exception ex)
            {

                ex.ToString();


            }
            finally
            {
                db.CloseConection();
            }

        }


        public Config selectVoz(string chave)
        {
            DataBase db = new DataBase();
            try
            {
                SQLiteDataReader dr;

                db.OpenConnection();
                db.AddParameter("@chave", chave, DbType.String);
                string sql = "SELECT * FROM Config WHERE Chave = @chave ";

                dr = db.ExecuteReader(sql);

                Config config = new Config();
                if (dr.Read())
                {
                    config.Chave = Convert.ToString(dr["Chave"]);
                    config.Valor = Convert.ToString(dr["Valor"]);

                }
                return config;
            }


            catch (Exception ex)
            {

                ex.ToString();
                return null;
            }
            finally
            {

                db.CloseConection();
            }
        }


        public void updateVoz(string chave, string valor)
        {
            DataBase db = new DataBase();
            try
            {
                SQLiteCommand cmd = new SQLiteCommand();

                db.OpenConnection();
                db.AddParameter("@chave", chave, DbType.String);
                db.AddParameter("@valor", valor, DbType.String);
                string sql = "UPDATE Config SET valor = @valor WHERE chave = @chave;";

                int result = db.ExecuteNoQuery(sql);
            }
            catch (Exception ex)
            {

                ex.ToString();


            }
            finally
            {
                db.CloseConection();
            }

        }
    }
}

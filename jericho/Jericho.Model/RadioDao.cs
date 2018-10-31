using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Jericho.Model
{
   public class RadioDao
    {
        public List<Radio> GetRadioByName(string _name)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@name", "%" + _name + "%", DbType.String);
                dr = db.ExecuteReader("select * from RadioOnline WHERE nome like @name");
                Radio radio = new Radio();
                List<Radio> radios = new List<Radio>();
                while (dr.Read())
                {
                    radio.Id_Radio = Convert.ToInt32(dr["Id_Radio"]);
                    radio.Nome_Radio = Convert.ToString(dr["Nome"]);
                    radio.urlRadio = Convert.ToString(dr["Link"]);
                    radio.estacao = Convert.ToString(dr["Estacao"]);
                    radios.Add(radio);
                }
                return radios;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }

        }
        public Radio GetRadioById(int _id)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@id", _id, DbType.Int32);
                dr = db.ExecuteReader("select * from Ebook RadioOnline Id_Radio = @id");
                Radio radio = new Radio();
                if (dr.Read())
                {
                    radio.Id_Radio = Convert.ToInt32(dr["Id_Radio"]);
                    radio.Nome_Radio = Convert.ToString(dr["Nome"]);
                    radio.urlRadio = Convert.ToString(dr["Link"]);
                    radio.estacao = Convert.ToString(dr["Estacao"]);
                    
                }
                return radio;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }

        }
        public int InsertRadio(Radio radio)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                db.AddParameter("@nome", radio.Nome_Radio, DbType.String);
                db.AddParameter("@link", radio.urlRadio, DbType.String);
                db.AddParameter("@estacao", radio.estacao, DbType.String);
                return db.ExecuteNoQuery("INSERT INTO RadioOnline(Nome," +
                                                                 "Link," +
                                                                 "Estacao)" +
                                                         "VALUES (@nome," +
                                                                 "@link," +
                                                                 "@estacao)");
                                                              
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }
        }
        public int DeleteRadio(int _id)
        {
            DataBase db = new DataBase();

            try
            {
                db.OpenConnection();
                db.AddParameter("@id", _id, DbType.Int32);
                return db.ExecuteNoQuery("Delete from RadioOnline where Id_Radio = @id");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }

        }
        public int UpdateRadio(Radio radio)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                db.AddParameter("@nome", radio.Nome_Radio, DbType.String);
                db.AddParameter("@link", radio.urlRadio, DbType.String);
                db.AddParameter("@estacao", radio.estacao, DbType.String);
                db.AddParameter("@id", radio.Id_Radio, DbType.Int32);
                return db.ExecuteNoQuery("UPDATE RadioOnline SET (Nome     = @nome," +
                                                           "Link     = @link," +
                                                           "Estacao  = @estacao" +                                                        
                                                     "WHERE Id_Radio = @id");
               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }

        }
        public List<Radio> GetAll()
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                dr = db.ExecuteReader("select * from RadioOnline");
                List<Radio> radios = new List<Radio>();
                Radio radio = new Radio();
                while (dr.Read())
                {
                    radio.Id_Radio = Convert.ToInt32(dr["Id_Radio"]);
                    radio.Nome_Radio = Convert.ToString(dr["Nome"]);
                    radio.urlRadio = Convert.ToString(dr["Link"]);
                    radio.estacao = Convert.ToString(dr["Estacao"]);
                    radios.Add(radio);

                }
                return radios;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }
        }
             public List<Radio> BuscarTudoRadio(string parameter)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;

                db.AddParameter("@parameter", parameter, DbType.String);
                dr = db.ExecuteReader("select* from RadioOnline where Id_Radio like @parameter or Nome like @parameter or Link like @parameter or Estacao like @parameter");
                Radio radio = new Radio();
                List<Radio> radios = new List<Radio>();
                while (dr.Read())
                {
                    radio.Id_Radio = Convert.ToInt32(dr["Id_Radio"]);
                    radio.Nome_Radio = Convert.ToString(dr["Nome"]);
                    radio.urlRadio = Convert.ToString(dr["Link"]);
                    radio.estacao = Convert.ToString(dr["Estacao"]);
                    radios.Add(radio);
                }
                return radios;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }
        }
    }
}

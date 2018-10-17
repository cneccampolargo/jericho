using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace Jericho.Model
{
   public class RadioDao
    {
        public Radio GetRadio(string _id)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@id", _id, DbType.String);
                dr = db.ExecuteReader("select * from RadioOnline WHERE Id_Radio = @id");
                Radio radio = new Radio(); if (dr.Read())
                {
                    radio.Id_Radio = Convert.ToString(dr["Id_Radio"]);
                    radio.Nome = Convert.ToString(dr["Nome"]);
                    radio.Link = Convert.ToString(dr["Link"]);
                    radio.Estacao = Convert.ToString(dr["Estacao"]);
                }
                return radio;
            }
            catch (Exception ex)
            {
                return null;
                ex.ToString();
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
                db.AddParameter("@Id_Radio", radio.Id_Radio, DbType.String);
                db.AddParameter("@Nome", radio.Nome, DbType.String);
                db.AddParameter("@Link", radio.Link, DbType.String);
                db.AddParameter("@Estacao", radio.Estacao, DbType.String);

                return db.ExecuteNoQuery("Insert into Radio(Id_Radio, Nome, Link, Estacao) Values (@Id_Radio, @Nome, @Link, @Estacao)");

            }
            catch (Exception ex)
            {
                return 0;
                ex.ToString();
            }
            finally
            {
                db.CloseConection();
            }
        }
        public int DeleteRadio(string _id)
        {
            DataBase db = new DataBase();
            try
            {


                db.AddParameter("@Id_Radio", _id, DbType.String);
                return db.ExecuteNoQuery("Delete from Radio where Id_Radio = @Id_Radio");

            }
            catch (Exception ex)
            {

                return 0;
                ex.ToString();
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
                Radio Radio = new Radio();
                db.AddParameter("@Id_Radio", radio.Id_Radio, DbType.String);
                db.AddParameter("@Nome", radio.Nome, DbType.String);
                db.AddParameter("@Link", radio.Link, DbType.String);
                db.AddParameter("@Estacao", radio.Estacao, DbType.String);
                return db.ExecuteNoQuery("Insert Radio SET (Id_Radio,Nome,Link,Estacao) Where Id_Radio = @Id_Radio");

            }
            catch (Exception ex)
            {
                return 0;
                ex.ToString();
            }
            finally
            {
                db.CloseConection();
            }
        }
        public List<Radio> GetAll()
        {
            DataBase db = new DataBase();
            SQLiteDataReader dr;
            dr = db.ExecuteReader("select * from RadioOnline");
            List<Radio> radio = new List<Radio>();
            Radio Radio = new Radio();
            while (dr.Read())
            {
                Radio.Id_Radio = Convert.ToString(dr["Id_Radio"]);
                Radio.Nome = Convert.ToString(dr["Nome"]);
                Radio.Link = Convert.ToString(dr["Link"]);
                Radio.Estacao = Convert.ToString(dr["Estacao"]);
            }
            return radio;
           }

        }

    }


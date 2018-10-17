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
    public class Mp3Dao
    {

        public  Mp3 GetMp3(string _id)
        {
           
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@id", _id, DbType.String);
                dr = db.ExecuteReader("select * from MP3 WHERE Id_MP3 = @id");
                Mp3 mp3 = new Mp3();
                if (dr.Read())
                {
                    mp3.nomeMusica = Convert.ToString(dr["NomeMusica"]);
                    mp3.id_Mp3 = Convert.ToString(dr["Id_MP3"]);
                    mp3.generoMusical = Convert.ToString(dr["GeneroMusical"]);
                    mp3.artista = Convert.ToString(dr["Artista"]);
                    mp3.dataAdicionado = Convert.ToDateTime(dr["DataAdicionado"]);
                    mp3.caminhoMp3 = Convert.ToString(dr["CaminhoMp3"]);
                }
                return mp3;
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


        public int InsertMp3(Mp3 _Mp3)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                db.AddParameter("id", _Mp3.id_Mp3, DbType.String);
                db.AddParameter("NomeMusica", _Mp3.nomeMusica, DbType.String);
                db.AddParameter("Generomusical", _Mp3.generoMusical, DbType.String);
                db.AddParameter("Artista", _Mp3.artista, DbType.String);
                db.AddParameter("DataAdd", _Mp3.dataAdicionado, DbType.DateTime);
                db.AddParameter("CaminhoMp3", _Mp3.caminhoMp3, DbType.String);

                return db.ExecuteNoQuery("INSERT INTO MP3 (Id_MP3, NomeMusica, GeneroMusical, Artista, DataAdicionado, CaminhoMp3) VALUES(@id, @NomeMusica, @GeneroMusical, @Artista, @DataAdicionado, @CaminhoMp3)");
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

        public int DeleteMP3(int _IdMp3)
        {
            try
            {

            DataBase db = new DataBase();
            db.OpenConnection();
            db.AddParameter("id", _IdMp3, DbType.String);
            
            return db.ExecuteNoQuery("DELETE FROM TabelaMp3 WHERE IdMp3 = @idMP3 ");

            }
            catch (Exception ex)
            {
                return 0;
                ex.ToString();
           
            }

        }
        public int UpdateMp3(Mp3 _Mp3)
        {

            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();

                db.AddParameter("id", _Mp3.id_Mp3, DbType.String);
                db.AddParameter("NomeMusica", _Mp3.nomeMusica, DbType.String);
                db.AddParameter("Generomusical", _Mp3.generoMusical, DbType.String);
                db.AddParameter("Artista", _Mp3.artista, DbType.String);
                db.AddParameter("DataAdd", _Mp3.dataAdicionado, DbType.DateTime);
                db.AddParameter("CaminhoMp3", _Mp3.caminhoMp3, DbType.String);

                return db.ExecuteNoQuery("UPDATE MP3 SET (Id_MP3, NomeMusica, GeneroMusical, Artista, DataAdicionado, CaminhoMp3) WHERE (Id_MP3=id)");
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
        public List<Mp3> GetAllMp3()
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                dr = db.ExecuteReader("select * from MP3 ");
                List<Mp3> listaMp3 = new List<Mp3>();
                Mp3 Mp3 = new Mp3();
                while (dr.Read())
                {
                    Mp3.nomeMusica = Convert.ToString(dr["NomeMusica"]);
                    Mp3.id_Mp3 = Convert.ToString(dr["Id_MP3"]);
                    Mp3.generoMusical = Convert.ToString(dr["GeneroMusical"]);
                    Mp3.artista = Convert.ToString(dr["Artista"]);
                    Mp3.dataAdicionado = Convert.ToDateTime(dr["DataAdicionado"]);
                    Mp3.caminhoMp3 = Convert.ToString(dr["CaminhoMp3"]);
                    listaMp3.Add(Mp3);
                }
                return listaMp3;
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
    }
}


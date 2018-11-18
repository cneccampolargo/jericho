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
        public List<Mp3> GetMp3ByName(string _nome)
        {           
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@nome", "%" + _nome + "%", DbType.String);
                dr = db.ExecuteReader("select * from MP3 WHERE NomeMusica LIKE @nome");
                Mp3 mp3 = new Mp3();
                List<Mp3> mp3s = new List<Mp3>();
                if (dr.Read())
                {
                    mp3.nomeMusica = Convert.ToString(dr["NomeMusica"]);
                    mp3.id_Mp3 = Convert.ToString(dr["Id_MP3"]);
                    mp3.generoMusical = Convert.ToString(dr["GeneroMusical"]);
                    mp3.artista = Convert.ToString(dr["Artista"]);
                    mp3.dataAdicionado = Convert.ToDateTime(dr["DataAdicionado"]);
                    mp3.caminhoMp3 = Convert.ToString(dr["CaminhoMp3"]);
                    mp3s.Add(mp3);
                }
                return mp3s;
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

        public List<Mp3> GetMp3ByGenero(string _genero)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@genero", _genero, DbType.String);
                dr = db.ExecuteReader("select * from MP3 WHERE GeneroMusical = @genero");
                Mp3 mp3 = new Mp3();
                List<Mp3> mp3s = new List<Mp3>();
                while (dr.Read())
                {
                    mp3.nomeMusica = Convert.ToString(dr["NomeMusica"]);
                    mp3.id_Mp3 = Convert.ToString(dr["Id_MP3"]);
                    mp3.generoMusical = Convert.ToString(dr["GeneroMusical"]);
                    mp3.artista = Convert.ToString(dr["Artista"]);
                    mp3.dataAdicionado = Convert.ToDateTime(dr["DataAdicionado"]);
                    mp3.caminhoMp3 = Convert.ToString(dr["CaminhoMp3"]);
                    mp3s.Add(mp3);
                }
                return mp3s;
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

        public List<Mp3> GetMp3ByArtista(string _Artista)
        
{
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@artista", "%" + _Artista + "%", DbType.String);
                dr = db.ExecuteReader("select * from MP3 WHERE Artista LIKE @artista");
                Mp3 mp3 = new Mp3();
                List<Mp3> mp3s = new List<Mp3>();
                while (dr.Read())
                {
                    mp3.nomeMusica = Convert.ToString(dr["NomeMusica"]);
                    mp3.id_Mp3 = Convert.ToString(dr["Id_MP3"]);
                    mp3.generoMusical = Convert.ToString(dr["GeneroMusical"]);
                    mp3.artista = Convert.ToString(dr["Artista"]);
                    mp3.dataAdicionado = Convert.ToDateTime(dr["DataAdicionado"]);
                    mp3.caminhoMp3 = Convert.ToString(dr["CaminhoMp3"]);
                    mp3s.Add(mp3);
                }
                return mp3s;
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
        public Mp3 GetMp3ById(string _Id)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@id", _Id, DbType.String);
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
            catch (Exception)
            {
                throw;
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
                db.AddParameter("@id", _Mp3.id_Mp3, DbType.String);
                db.AddParameter("@NomeMusica", _Mp3.nomeMusica, DbType.String);
                db.AddParameter("@Generomusical", _Mp3.generoMusical, DbType.String);
                db.AddParameter("@Artista", _Mp3.artista, DbType.String);
                db.AddParameter("@DataAdicionado", _Mp3.dataAdicionado, DbType.DateTime);
                db.AddParameter("@CaminhoMp3", _Mp3.caminhoMp3, DbType.String);

                return db.ExecuteNoQuery("INSERT INTO MP3 (Id_MP3, " +
                                                           "NomeMusica, " +
                                                           "GeneroMusical,  " +
                                                           "Artista," +
                                                           "DataAdicionado," +
                                                           "CaminhoMp3)" +
                                                    "VALUES (@id," +
                                                            " @NomeMusica, " +
                                                            "@Generomusical, " +
                                                            "@Artista," +
                                                            " @DataAdicionado," +
                                                            " @CaminhoMp3)");
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

        public int DeleteMP3(int _IdMp3)
        {
            try
            {
            DataBase db = new DataBase();
            db.OpenConnection();
            db.AddParameter("@idMP3", _IdMp3, DbType.String);
            
            return db.ExecuteNoQuery("DELETE FROM TabelaMp3 WHERE IdMp3 = @idMP3");

            }
            catch (Exception)
            {
              throw;           
            }
        }
        public int UpdateMp3(Mp3 _Mp3)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                db.AddParameter("@id", _Mp3.id_Mp3, DbType.String);
                db.AddParameter("@NomeMusica", _Mp3.nomeMusica, DbType.String);
                db.AddParameter("@Generomusical", _Mp3.generoMusical, DbType.String);
                db.AddParameter("@Artista", _Mp3.artista, DbType.String);
                db.AddParameter("@DataAdd", _Mp3.dataAdicionado, DbType.DateTime);
                db.AddParameter("@CaminhoMp3", _Mp3.caminhoMp3, DbType.String);

                return db.ExecuteNoQuery("UPDATE MP3 SET (Id_MP3         = @id, " +
                                                         "NomeMusica     = @NomeMusica," +
                                                         "GeneroMusical  = @Generomusical," +
                                                         "Artista        = @Artista," +
                                                         "DataAdicionado = @DataAdd," +
                                                         "CaminhoMp3     = @CaminhoMp3)" +
                                                  "WHERE (Id_MP3         = @id)");
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
       public List<Mp3> GetAll()
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                dr = db.ExecuteReader("select * from MP3");
                Mp3 mp3 = new Mp3();
                List<Mp3> mp3s = new List<Mp3>();
                while (dr.Read())
                {
                    mp3.nomeMusica = Convert.ToString(dr["NomeMusica"]);
                    mp3.id_Mp3 = Convert.ToString(dr["Id_MP3"]);
                    mp3.generoMusical = Convert.ToString(dr["GeneroMusical"]);
                    mp3.artista = Convert.ToString(dr["Artista"]);
                    mp3.dataAdicionado = Convert.ToDateTime(dr["DataAdicionado"]);
                    mp3.caminhoMp3 = Convert.ToString(dr["CaminhoMp3"]);
                    mp3s.Add(mp3);
                }
                return mp3s;
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

        public List<Mp3> BuscarTudoMp3(string parameter)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                
                db.AddParameter("@parameter","%" + parameter + "%", DbType.String);
                dr = db.ExecuteReader("select * from MP3 where Id_MP3 Like @parameter or NomeMusica like @parameter or GeneroMusical like @parameter or Artista like @parameter or DataAdicionado like @parameter or CaminhoMp3 like @parameter");
                Mp3 mp3 = new Mp3();
                List<Mp3> mp3s = new List<Mp3>();
                while (dr.Read())
                {
                    mp3.nomeMusica = Convert.ToString(dr["NomeMusica"]);
                    mp3.id_Mp3 = Convert.ToString(dr["Id_MP3"]);
                    mp3.generoMusical = Convert.ToString(dr["GeneroMusical"]);
                    mp3.artista = Convert.ToString(dr["Artista"]);
                    mp3.dataAdicionado = Convert.ToDateTime(dr["DataAdicionado"]);
                    mp3.caminhoMp3 = Convert.ToString(dr["CaminhoMp3"]);
                    mp3s.Add(mp3);
                }
                return mp3s;
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


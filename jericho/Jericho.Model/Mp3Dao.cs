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
    class Mp3Dao
    {

        public Mp3 GetMp3(string _id)
        {
            DataBase db = new DataBase();
            SQLiteDataReader dr;

            db.AddParameter("@id", _id, DbType.String);
            dr = db.ExecuteReader("select * from MP3 WHERE Id_MP3 = @id");
            Mp3 mp3 = new Mp3();
            if (dr.Read())
            {
                mp3.NomeMusica1 = Convert.ToString(dr["NomeMusica"]);
                mp3.Id_mp31 = Convert.ToString(dr["Id_MP3"]);
                mp3.GeneroMusical1 = Convert.ToString(dr["GeneroMusical"]);
                mp3.Artista1 = Convert.ToString(dr["Artista"]);
                mp3.DataAdicionado1 = Convert.ToDateTime(dr["DataAdicionado"]);
                mp3.CaminhoMp31 = Convert.ToString(dr["CaminhoMp3"]);
            }
            return mp3;
        }


        public int InsertMp3(Mp3 _Mp3)
        {
            DataBase db = new DataBase();

            db.AddParameter("id", _Mp3.Id_mp31, DbType.String);
            db.AddParameter("NomeMusica", _Mp3.NomeMusica1, DbType.String);
            db.AddParameter("Generomusical", _Mp3.GeneroMusical1, DbType.String);
            db.AddParameter("Artista", _Mp3.Artista1, DbType.String);
            db.AddParameter("DataAdd", _Mp3.DataAdicionado1,DbType.DateTime);
            db.AddParameter("CaminhoMp3", _Mp3.CaminhoMp31, DbType.String);

            return db.ExecuteNoQuery("INSERT INTO MP3 (Id_MP3, NomeMusica, GeneroMusical, Artista, DataAdicionado, CaminhoMp3) VALUES(@id, @NomeMusica, @GeneroMusical, @Artista, @DataAdicionado, @CaminhoMp3)");

        }

        public int DeleteMP3(int _IdMp3)
        {

            DataBase db = new DataBase();
            db.AddParameter("id", _IdMp3, DbType.String);
            return db.ExecuteNoQuery("DELETE FROM TabelaMp3 WHERE IdMp3 = @idMP3 ");

        }
        public int UpdateMp3(Mp3 _Mp3)
        {

            DataBase db = new DataBase();

            db.AddParameter("id", _Mp3.Id_mp31, DbType.String);
            db.AddParameter("NomeMusica", _Mp3.NomeMusica1, DbType.String);
            db.AddParameter("Generomusical", _Mp3.GeneroMusical1, DbType.String);
            db.AddParameter("Artista", _Mp3.Artista1, DbType.String);
            db.AddParameter("DataAdd", _Mp3.DataAdicionado1, DbType.DateTime);
            db.AddParameter("CaminhoMp3", _Mp3.CaminhoMp31, DbType.String);

            return db.ExecuteNoQuery("UPDATE MP3 SET (Id_MP3, NomeMusica, GeneroMusical, Artista, DataAdicionado, CaminhoMp3) WHERE (Id_MP3=id)");



        }
    }
}


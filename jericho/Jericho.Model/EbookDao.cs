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
    class EbookDao
    {
       public Ebook GetEbook(string _id)
            {
                DataBase db = new DataBase();
                SQLiteDataReader dr;
                db.AddParameter("@id", _id, DbType.String);
                dr = db.ExecuteReader("select * from Ebook WHERE Id_Ebook = @id");
                Ebook ebook = new Ebook();                if (dr.Read())
                {
                    ebook.Autor = Convert.ToString(dr["Autor"]);
                    ebook.CaminhoEbook1 = Convert.ToString(dr["CaminhoEbook"]);
                    ebook.DataAdd = Convert.ToDateTime(dr["DataAdicionado"]);
                    ebook.Editora1 = Convert.ToString(dr["Editora"]);
                    ebook.Sinopse1 = Convert.ToString(dr["sinopse"]);
                    ebook.IdEbook = Convert.ToString(dr["Id_Ebook"]);
                    ebook.NomeLivro1 = Convert.ToString(dr["NomeLivro"]);
                }
                return ebook;
            }
        public int InsertEbook(Ebook ebook)
        {
            DataBase db = new DataBase();
            db.AddParameter("@id", ebook.IdEbook, DbType.String);
            db.AddParameter("@Autor", ebook.Autor, DbType.String);
            db.AddParameter("@CaminhoEbook", ebook.CaminhoEbook1, DbType.String);
            db.AddParameter("@Editora", ebook.Editora1, DbType.String);
            db.AddParameter("@sinopse", ebook.Sinopse1, DbType.String);
            db.AddParameter("@NomeLivro", ebook.NomeLivro1, DbType.String);
            db.AddParameter("@DataAdicionado", ebook.DataAdd, DbType.DateTime);

            return db.ExecuteNoQuery("Insert into Ebook(Id_Ebook,Autor,CaminhoEbook,Editora,sinopse,NomeLivro,DataAdicionado) Values(@id,@Autor,@CaminhoEbook,@Editora,@sinopse,@NomeLivro,@DataAdicionado)");

        }
        public int DeleteMp3(string _id)
        {
            
            DataBase db = new DataBase();
            db.AddParameter("@id", _id, DbType.String);
            return db.ExecuteNoQuery("Delete from Ebook where Id_Ebook = @id");
        }
        public int UpdateEbook(Ebook ebook)
        {
            DataBase db = new DataBase();
            db.AddParameter("@id", ebook.IdEbook, DbType.String);
            db.AddParameter("@Autor", ebook.Autor, DbType.String);
            db.AddParameter("@CaminhoEbook", ebook.CaminhoEbook1, DbType.String);
            db.AddParameter("@Editora", ebook.Editora1, DbType.String);
            db.AddParameter("@sinopse", ebook.Sinopse1, DbType.String);
            db.AddParameter("@NomeLivro", ebook.NomeLivro1, DbType.String);
            db.AddParameter("@DataAdicionado", ebook.DataAdd, DbType.DateTime);
            return db.ExecuteNoQuery("Insert Ebook SET (Id_Ebook,Autor,CaminhoEbook,Editora,sinopse,NomeLivro,DataAdicionado) Where Id_Ebook = @id" );
        }

    }
}

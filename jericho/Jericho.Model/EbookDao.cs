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
   public class EbookDao
    {
        public List<Ebook> GetAllEbooks(string _parameter)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@parameter", "%" + _parameter + "%", DbType.String);
                dr = db.ExecuteReader("select * from Ebook WHERE Id_Ebook like @parameter or Autor like @parameter or Editora like @parameter or NomeLivro like @parameter");
                Ebook ebook = new Ebook();
                List<Ebook> ebooks = new List<Ebook>();
                while (dr.Read())
                {
                    ebook.autor = Convert.ToString(dr["Autor"]);
                    ebook.CaminhoEbook = Convert.ToString(dr["CaminhoEbook"]);
                    ebook.dataAdd = Convert.ToDateTime(dr["DataAdicionado"]);
                    ebook.Editora = Convert.ToString(dr["Editora"]);
                    ebook.Sinopse = Convert.ToString(dr["sinopse"]);
                    ebook.idEbook = Convert.ToString(dr["Id_Ebook"]);
                    ebook.NomeLivro = Convert.ToString(dr["NomeLivro"]);
                    ebooks.Add(ebook);
                }
                return ebooks;
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

        
    


        public List<Ebook> GetEbookByName(string _name)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@name","%" + _name + "%", DbType.String);
                dr = db.ExecuteReader("select * from Ebook WHERE nomeLivro like @name");
                Ebook ebook = new Ebook();
                List<Ebook> ebooks = new List<Ebook>();
                while (dr.Read())
                {
                    ebook.autor = Convert.ToString(dr["Autor"]);
                    ebook.CaminhoEbook = Convert.ToString(dr["CaminhoEbook"]);
                    ebook.dataAdd = Convert.ToDateTime(dr["DataAdicionado"]);
                    ebook.Editora = Convert.ToString(dr["Editora"]);
                    ebook.Sinopse = Convert.ToString(dr["sinopse"]);
                    ebook.idEbook = Convert.ToString(dr["Id_Ebook"]);
                    ebook.NomeLivro = Convert.ToString(dr["NomeLivro"]);
                    ebooks.Add(ebook);
                }
                return ebooks;
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
        public List<Ebook> GetEbookByAutor(string _Autor)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@autor", "%" + _Autor + "%", DbType.String);
                dr = db.ExecuteReader("select * from Ebook WHERE Autor like @autor");
                Ebook ebook = new Ebook();
                List<Ebook> ebooks = new List<Ebook>();
                while (dr.Read())
                {
                    ebook.autor = Convert.ToString(dr["Autor"]);
                    ebook.CaminhoEbook = Convert.ToString(dr["CaminhoEbook"]);
                    ebook.dataAdd = Convert.ToDateTime(dr["DataAdicionado"]);
                    ebook.Editora = Convert.ToString(dr["Editora"]);
                    ebook.Sinopse = Convert.ToString(dr["sinopse"]);
                    ebook.idEbook = Convert.ToString(dr["Id_Ebook"]);
                    ebook.NomeLivro = Convert.ToString(dr["NomeLivro"]);
                    ebooks.Add(ebook);
                }
                return ebooks;
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
        public Ebook GetEbookById(string _id)
        {
            DataBase db = new DataBase();
            try
            {
                db.OpenConnection();
                SQLiteDataReader dr;
                db.AddParameter("@id", _id, DbType.String);
                dr = db.ExecuteReader("select * from Ebook WHERE Id_Ebook = @id");
                Ebook ebook = new Ebook();
                if (dr.Read())
                {
                    ebook.autor = Convert.ToString(dr["Autor"]);
                    ebook.CaminhoEbook = Convert.ToString(dr["CaminhoEbook"]);
                    ebook.dataAdd = Convert.ToDateTime(dr["DataAdicionado"]);
                    ebook.Editora = Convert.ToString(dr["Editora"]);
                    ebook.Sinopse = Convert.ToString(dr["sinopse"]);
                    ebook.idEbook = Convert.ToString(dr["Id_Ebook"]);
                    ebook.NomeLivro = Convert.ToString(dr["NomeLivro"]);
                   
                }
                return ebook;
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

        public int InsertEbook(Ebook ebook)
        {
            DataBase db = new DataBase();
            try {
                db.OpenConnection();
                db.AddParameter("@id", ebook.idEbook, DbType.String);
                db.AddParameter("@Autor", ebook.autor, DbType.String);
                db.AddParameter("@CaminhoEbook", ebook.CaminhoEbook, DbType.String);
                db.AddParameter("@Editora", ebook.Editora, DbType.String);
                db.AddParameter("@sinopse", ebook.Sinopse, DbType.String);
                db.AddParameter("@NomeLivro", ebook.NomeLivro, DbType.String);
                db.AddParameter("@DataAdicionado", ebook.dataAdd, DbType.DateTime);

               return db.ExecuteNoQuery("INSERT INTO Ebook(Id_Ebook," +
                                                           "Autor," +
                                                           "CaminhoEbook," +
                                                           "Editora," +
                                                           "sinopse," +
                                                           "NomeLivro," +
                                                           "DataAdicionado)" +
                                                       "Values(@id," +
                                                              "@Autor," +
                                                              "@CaminhoEbook," +
                                                              "@Editora," +
                                                              "@sinopse," +
                                                              "@NomeLivro," +
                                                              "@DataAdicionado)");
            }
            catch(Exception)
            {               
                throw;
            }
            finally
            {
                db.CloseConection();
            }
        }
        public int DeleteEbook(string _id)
        {            
            DataBase db = new DataBase();

            try {
                db.OpenConnection();
                db.AddParameter("@id", _id, DbType.String);
                return db.ExecuteNoQuery("Delete from Ebook where Id_Ebook = @id");
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                db.CloseConection();
            }

       }
        public int UpdateEbook(Ebook ebook)
        {
            DataBase db = new DataBase();
            try
            {                
                db.OpenConnection();
                db.AddParameter("@id", ebook.idEbook, DbType.String);
                db.AddParameter("@Autor", ebook.autor, DbType.String);
                db.AddParameter("@CaminhoEbook", ebook.CaminhoEbook, DbType.String);
                db.AddParameter("@Editora", ebook.Editora, DbType.String);
                db.AddParameter("@sinopse", ebook.Sinopse, DbType.String);
                db.AddParameter("@NomeLivro", ebook.NomeLivro, DbType.String);
                db.AddParameter("@DataAdicionado", ebook.dataAdd, DbType.DateTime);
                return db.ExecuteNoQuery("UPDATE Ebook SET (Id_Ebook        = @id," +
                                                            "Autor          = @Autor," +
                                                            "CaminhoEbook   = @CaminhoEbook," +
                                                            "Editora        = @Editora," +
                                                            "sinopse        = @sinopse," +
                                                            "NomeLivro      = @NomeLivro," +
                                                            "DataAdicionado = @DataAdicionado)" +
                                                         "WHERE Id_Ebook = @id");
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
        public List<Ebook> GetAll()
        {
            DataBase db = new DataBase();
            try {
                db.OpenConnection();
                SQLiteDataReader dr;
                dr = db.ExecuteReader("select * from Ebook");
                List<Ebook> ebooks = new List<Ebook>();
                Ebook ebook = new Ebook();
                while (dr.Read())
                {
                    ebook.autor = Convert.ToString(dr["Autor"]);
                    ebook.CaminhoEbook = Convert.ToString(dr["CaminhoEbook"]);
                    ebook.dataAdd = Convert.ToDateTime(dr["DataAdicionado"]);
                    ebook.Editora = Convert.ToString(dr["Editora"]);
                    ebook.Sinopse = Convert.ToString(dr["sinopse"]);
                    ebook.idEbook = Convert.ToString(dr["Id_Ebook"]);
                    ebook.NomeLivro = Convert.ToString(dr["NomeLivro"]);
                    ebooks.Add(ebook);
                }
                return ebooks;
            }
            catch(Exception)
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


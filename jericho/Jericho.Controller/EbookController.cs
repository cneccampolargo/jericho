using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jericho.Model;

namespace Jericho.Controller
{
    public class EbookController
    {
        public static List<Ebook> GetEbookByNome(string nomeEbook)
        {
            EbookDao ebookDao = new EbookDao();
            return ebookDao.GetEbookByName(nomeEbook);
        }
        public static List<Ebook> GetEbookByAutor(string Autor)
        {
            EbookDao ebookDao = new EbookDao();
            return ebookDao.GetEbookByAutor(Autor);
        }
        public static int InsertEbook(Ebook ebook)
        {
            EbookDao ebookDao = new EbookDao();
            return ebookDao.InsertEbook(ebook);
        }
        public static List<Ebook> GetAllEbooks()
        {
            EbookDao ebookDao = new EbookDao();
            return ebookDao.GetAll();
        }
        public static int DeleteEbook(string idEbook)
        {
            EbookDao ebookDao = new EbookDao();
            return ebookDao.DeleteEbook(idEbook);
        }
        public static int UpdateEbook(Ebook ebook)
        {
            EbookDao ebookDao = new EbookDao();
            return ebookDao.UpdateEbook(ebook);
        }
        public static List<Ebook> GetAllEbooks(string _parameter)
        {
            EbookDao ebookDao = new EbookDao();
            return ebookDao.GetAllEbooks(_parameter);

        }
    }
}

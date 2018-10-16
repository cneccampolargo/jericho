using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jericho.Model
{
    public class Ebook
    {
       
        public string idEbook { get; set; }
        public string autor { get; set; }
        public string Editora { get; set; }
        public string NomeLivro { get; set; }
        public string CaminhoEbook { get; set; }
        public string Sinopse { get; set; }
        public DateTime dataAdd { get; set; }       

        public Ebook()
        {

        }

        public Ebook(string idEbook, string autor, string editora, string nomeLivro, string caminhoEbook, string sinopse, DateTime dataAdd)
        {
            this.idEbook = idEbook;
            this.autor = autor;
            Editora = editora;
            NomeLivro = nomeLivro;
            CaminhoEbook = caminhoEbook;
            Sinopse = sinopse;
            this.dataAdd = dataAdd;
        }
    }
}

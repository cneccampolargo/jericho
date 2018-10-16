using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jericho.Model
{
    public class Ebook
    {
        string idEbook, autor, Editora, NomeLivro, CaminhoEbook, Sinopse;
        DateTime dataAdd;

        public string IdEbook
        {
            get
            {
                return idEbook;
            }

            set
            {
                idEbook = value;
            }
        }

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }

        public string Editora1
        {
            get
            {
                return Editora;
            }

            set
            {
                Editora = value;
            }
        }

        public string NomeLivro1
        {
            get
            {
                return NomeLivro;
            }

            set
            {
                NomeLivro = value;
            }
        }

        public string CaminhoEbook1
        {
            get
            {
                return CaminhoEbook;
            }

            set
            {
                CaminhoEbook = value;
            }
        }

        public string Sinopse1
        {
            get
            {
                return Sinopse;
            }

            set
            {
                Sinopse = value;
            }
        }

        public DateTime DataAdd
        {
            get
            {
                return dataAdd;
            }

            set
            {
                dataAdd = value;
            }
        }

        public Ebook()
        {

        }

        public Ebook(string idEbook, string autor, string editora, string nomeLivro, string caminhoEbook, string sinopse, DateTime dataAdd)
        {
            this.IdEbook = idEbook;
            this.Autor = autor;
            Editora1 = editora;
            NomeLivro1 = nomeLivro;
            CaminhoEbook1 = caminhoEbook;
            Sinopse1 = sinopse;
            this.DataAdd = dataAdd;
        }
    }
}

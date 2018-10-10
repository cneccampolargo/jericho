using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jericho.Model
{
    class Mp3
    {
        string NomeMusica, GeneroMusical, Artista, Id_mp3, CaminhoMp3;
        DateTime DataAdicionado;
        public Mp3()
        {

        }

        public string NomeMusica1
        {
            get
            {
                return NomeMusica;
            }

            set
            {
                NomeMusica = value;
            }
        }

        public string GeneroMusical1
        {
            get
            {
                return GeneroMusical;
            }

            set
            {
                GeneroMusical = value;
            }
        }

        public string Artista1
        {
            get
            {
                return Artista;
            }

            set
            {
                Artista = value;
            }
        }

        public string Id_mp31
        {
            get
            {
                return Id_mp3;
            }

            set
            {
                Id_mp3 = value;
            }
        }

        public string CaminhoMp31
        {
            get
            {
                return CaminhoMp3;
            }

            set
            {
                CaminhoMp3 = value;
            }
        }

        public DateTime DataAdicionado1
        {
            get
            {
                return DataAdicionado;
            }

            set
            {
                DataAdicionado = value;
            }
        }

        public Mp3(string nomeMusica, string generoMusical, string artista, string id_mp3, string caminhoMp3, DateTime dataAdicionado)
        {
            NomeMusica1 = nomeMusica;
            GeneroMusical1 = generoMusical;
            Artista1 = artista;
            Id_mp31 = id_mp3;
            CaminhoMp31 = caminhoMp3;
            DataAdicionado1 = dataAdicionado;
        }
    }
}
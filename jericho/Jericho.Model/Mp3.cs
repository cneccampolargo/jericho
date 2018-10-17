using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jericho.Model
{
    public class Mp3
    {
        public string nomeMusica { get; set; }
        public string generoMusical { get; set; }
        public string artista { get; set; }
        public string id_Mp3 { get; set; }
        public string caminhoMp3 { get; set; }
        public DateTime dataAdicionado { get; set; }



        public Mp3()
        {

        }


        public Mp3(string nomeMusica, string generoMusical, string artista, string id_mp3, string caminhoMp3, DateTime dataAdicionado)
        {
           this.nomeMusica= nomeMusica;
           this.generoMusical = generoMusical;
           this. artista = artista;
           this. id_Mp3 = id_mp3;
           this. caminhoMp3 = caminhoMp3;
           this. dataAdicionado = dataAdicionado;
        }
    }
}
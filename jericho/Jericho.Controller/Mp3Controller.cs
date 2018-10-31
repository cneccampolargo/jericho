using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jericho.Model;

namespace Jericho.Model
{
   public class Mp3Controller
    {
        public static List<Mp3> GetMp3ByName(string _nome)
        {
            Mp3Dao mp3Dao = new Mp3Dao();
            return mp3Dao.GetMp3ByName(_nome);
        }
        public static List<Mp3> GetMp3ByGenero(string _genero)
        {
            Mp3Dao mp3Dao = new Mp3Dao();
            return mp3Dao.GetMp3ByGenero(_genero);
        }
        public static List<Mp3> GetMp3ByArtista(string _Artista)
        {
            Mp3Dao mp3Dao = new Mp3Dao();
            return mp3Dao.GetMp3ByArtista(_Artista);
        }
        public static Mp3 GetMp3ById(string _Id)
        {
            Mp3Dao mp3Dao = new Mp3Dao();
           return mp3Dao.GetMp3ById(_Id);
        }
        public static int InsertMp3(Mp3 _Mp3)
        {
            Mp3Dao mp3Dao = new Mp3Dao();
            return mp3Dao.InsertMp3(_Mp3);
        }
        public static int DeleteMP3(int _IdMp3)
        {
            Mp3Dao mp3Dao = new Mp3Dao();
            return mp3Dao.DeleteMP3(_IdMp3);
        }
        public static int UpdateMp3(Mp3 _Mp3)
        {
            Mp3Dao mp3Dao = new Mp3Dao();
          return mp3Dao.UpdateMp3(_Mp3);
        }
       
        public static List<Mp3> BuscarTudo(string parameter)
        {
            Mp3Dao mp3Dao = new Mp3Dao();
            return mp3Dao.BuscarTudoMp3(parameter);

        }

    }
}

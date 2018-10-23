using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jericho.Model;

namespace Jericho.Controller
{
   public class FilesController
    {
        public void AddFiles(string id ,string nome, string banda, string genero, string url, string nomeFile)
        {
            Files add = new Files();
            add.AddFiles(id, nome, banda, genero, url, nomeFile);
        }

        public void DelFiles(string id)
        {
            Files del = new Files();
            del.DelFiles(id);
        }
    }
}

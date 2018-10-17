using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jericho.Model
{
   
    public class Radio
    {
        public string Id_Radio { get; set; }
        public string Nome { get; set; }
        public string Link { get; set; }
        public string Estacao { get; set; }

        public Radio()
        {
        }
        public Radio(string Id_Radio, string Nome, string Link, string Estacao)
        {
            this.Id_Radio = Id_Radio;
            this.Nome = Nome;
            this.Link = Link;
            this.Estacao = Estacao;
        }
    }
}
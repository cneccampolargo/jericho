using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jericho.Model
{
    public class Config
    {

        private string chave;
        private string valor;

        public Config()
        {

        }
        public Config(string chave, string valor)
        {
            this.chave = chave;
            this.valor = valor;
        }

        public string Chave
        {
            get
            {
                return chave;
            }

            set
            {
                chave = value;
            }
        }

        public string Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }
    }
}


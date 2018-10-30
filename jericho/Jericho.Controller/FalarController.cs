using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jericho.Model;

namespace Jericho.Controller
{
    public class FalarController
    {
        public Falar falar = new Falar();

        public List<string> Vozes()
        {
            return falar.Vozes();
        }


        public void FalarNumero(string voz, string numero)
        {
            falar.FalarNumero(voz, numero);
        }

        public void FalarTexto(string voz, string texto)
        {
            falar.FalarTexto(voz, texto);

        }
        public void FalarTextoSemInterrupcao(string voz, string texto)
        {
            falar.FalarTextoSemInterrupcao(voz, texto);

        }

        public bool FalarState()
        {
           return  falar.FalarState();



        }

        public void ParaVoz()
        {
            falar.ParaVoz();
        }





    }
}

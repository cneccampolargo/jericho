using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jericho.Model;

namespace Jericho.Controller
{
    public static class FalarController
    {
        private static Falar Falar = new Falar();

        public static List<string> Vozes()
        {
            return Falar.Vozes();
        }

        public static void FalarNumero(string voz, string numero)
        {
            Falar.FalarNumero(voz, numero);
        }


    }
}

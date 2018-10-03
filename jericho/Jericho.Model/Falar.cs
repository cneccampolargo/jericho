using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Jericho.Model
{
    public class Falar
    {
        SpeechSynthesizer voz;
        SpeechSynthesizer speech = new SpeechSynthesizer();


        public Falar()
        {
            voz = new SpeechSynthesizer();
        }
        public List<string> Vozes()
        {
            List<string> listaDeVozes = new List<string>();
            foreach (var vozes in voz.GetInstalledVoices())
            {
                listaDeVozes.Add(vozes.VoiceInfo.Name);
            }
            return listaDeVozes;
        }


        public void FalarNumero(string voz, string numero)
        {
            speech = new SpeechSynthesizer();
            speech.SelectVoice(voz);
            speech.SetOutputToDefaultAudioDevice();
            speech.Rate = 0;
            speech.SpeakAsync(numero);
        }
    }
}

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

        // FALA TEXTO COMPLETO
        public void FalarTexto(string voz, string texto)
        {
            speech = new SpeechSynthesizer();
            speech.SelectVoice(voz);
            speech.SetOutputToDefaultAudioDevice();
            speech.Rate = 0;
            speech.SpeakAsync(texto);
        }

        // FALA LETRA A LETRA CONFORME É DIGITADO
        public void FalarNumero(string voz, string numero)
        {

            if (numero == "a")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "b")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
                if (numero == "c")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "d")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "e")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "f")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "g")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "h")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "i")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "j")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "k")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "l")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "m")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "n")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "o")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "p")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "q")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "r")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "s")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "t")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "u")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "v")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "w")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "x")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "y")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "z")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "A")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "B")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "C")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "D")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "E")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "F")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "G")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "H")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "I")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "J")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "K")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "L")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "M")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "N")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "O")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "P")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "Q")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "R")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "S")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "T")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "U")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "V")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "W")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "X")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "Y")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
                if (numero == "Z")
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = -1;
                speech.SpeakAsync(numero);
            }
            else
            {
                speech = new SpeechSynthesizer();
                speech.SelectVoice(voz);
                speech.SetOutputToDefaultAudioDevice();
                speech.Rate = 0;
                speech.SpeakAsync(numero);
            }
        }
    }
}

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
        // SpeechSynthesizer voz;
        SpeechSynthesizer Speech = new SpeechSynthesizer();
         public Falar(){}
        /// <summary>
        /// Lista as vozes do sistema
        /// </summary>
        /// <returns></returns>

         public List<string> Vozes()
        {

            List<string> listaDeVozes = new List<string>();
            foreach (var vozes in Speech.GetInstalledVoices())
            {
                listaDeVozes.Add(vozes.VoiceInfo.Name);
            }
            return listaDeVozes;
        }
        /// <summary>
        /// Para qualquer voz que esteja rodando
        /// </summary>

        public void ParaVoz()
        {
            Speech.Pause();
            Speech.Dispose();

        }
        /// <summary>
        /// Retorno verdade se uma voz estiver sendo executada;
        /// </summary>
        /// <returns></returns>

        public bool FalarState()
        {
            if (Speech.State == SynthesizerState.Ready)
            {

                return true;
            }
            return false;

        }

        // FALA TEXTO COMPLETO
        public void FalarTexto(string voz, string texto)
        {

            if (Speech.State == SynthesizerState.Ready)
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(voz);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(texto);
            }

        }

        public void FalarTextoSemInterrupcao(string voz, string texto)
        {

            Speech = new SpeechSynthesizer();
            Speech.SelectVoice(voz);
            Speech.SetOutputToDefaultAudioDevice();
            Speech.Rate = -1;
            Speech.SpeakAsync(texto);


        }

        // FALA LETRA A LETRA CONFORME É DIGITADO
        public void FalarNumero(string vozSystem, string numero)
        {

            if (numero == "a")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
                if (numero == "b")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            if (numero == "c")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "d")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "e")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "f")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "g")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "h")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "i")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "j")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "k")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "l")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "m")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "n")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "o")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "p")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "q")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "r")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "s")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "t")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "u")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "v")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "w")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "x")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "y")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "z")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "A")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "B")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "C")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "D")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "E")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "F")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "G")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "H")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "I")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "J")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "K")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "L")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "M")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "N")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "O")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "P")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "Q")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "R")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "S")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "T")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "U")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "V")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "W")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "X")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "Y")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            if (numero == "Z")
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = -1;
                Speech.SpeakAsync(numero);
            }
            else
            {
                Speech = new SpeechSynthesizer();
                Speech.SelectVoice(vozSystem);
                Speech.SetOutputToDefaultAudioDevice();
                Speech.Rate = 0;
                Speech.SpeakAsync(numero);
            }
        }
    }
}

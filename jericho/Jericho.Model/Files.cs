using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jericho.Model
{
    public class Files
    {
        // NOME DO ARQUIVO MP3
        //string ano = Convert.ToString(DateTime.Now.Year);
        //string mes = Convert.ToString(DateTime.Now.Month);
        //string dia = Convert.ToString(DateTime.Now.Day);
        //string hora = Convert.ToString(DateTime.Now.Hour);
        //string minuto = Convert.ToString(DateTime.Now.Minute);
        //string segundo = Convert.ToString(DateTime.Now.Second);
        //string id = ano + mes + dia + hora + minuto + segundo;

        public void AddFiles(string id, string nome, string banda, string genero, string url, string nomeFile)
        {

            try
            {
                if (url == "openFileDialog1" | nomeFile == "openFileDialog1")
                {
                    throw new Exception("Não foi possível mover o arquivo !");

                }
                else
                {
                    string nomeArquivoPath = url;
                    string nomeArquivo = nomeFile;

                    File.Copy(nomeArquivoPath, Path.Combine(AppDomain.CurrentDomain.BaseDirectory + @"\arquivos\musicas\", id + ".mp3"));
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());

            }

        }

        public void DelFiles(string id)
        {
            try
            {
                if (id != null)
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"arquivos\musicas\" + id + ".mp3");
                }
                else
                {
                    throw new Exception("Não foi possível mover o arquivo !");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

    }
}

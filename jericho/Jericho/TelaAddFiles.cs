using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jericho.Controller;
using System.IO;

namespace Jericho
{
    public partial class TelaAddFiles : Form
    {
        public TelaAddFiles()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(TelaAddFiles_DragEnter);
            this.DragDrop += new DragEventHandler(TelaAddFiles_DragDrop);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaAddFiles_Load(object sender, EventArgs e)
        {
          

        }

        private void TelaAddFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void TelaAddFiles_DragDrop(object sender, DragEventArgs e)
        {
          if (Directory.Exists(@"C:\Jericho\Arquivos\"))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    string extensaoArquivo = Path.GetExtension(file);
                    if  (!File.Exists(@"C:\Jericho\Arquivos\" + Path.GetFileName(file)))
                    {                          
                        if (extensaoArquivo.ToUpper() == ".MP3")
                        {                        
                            FilesController.AddFiles(file + DateTime.Now, Path.GetFileNameWithoutExtension(file), "Windows", "Pacífico", file, "Kalimba");
                        }
                        else
                        {
                            FalarController falarController = new FalarController();
                            falarController.FalarTexto(falarController.Vozes()[1], "Você deve adicionar um arquivo com extensão ponto mp3. O arquivo que você está tentando adicionar possui a extensão ponto " + extensaoArquivo);
                            MessageBox.Show("Você deve adicionar um arquivo com extensão .mp3. O arquivo que você está tentando adicionar possui a extensão " + extensaoArquivo);
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O arquivo já existe na pasta!");
                        FalarController falarController = new FalarController();
                        falarController.FalarTexto(falarController.Vozes()[1], "O arquivo já existe na pasta!");
                    }
                }
            }
            else
            {
                FalarController falarController = new FalarController();
                falarController.FalarTexto(falarController.Vozes()[1], "O Diretório não existe. Uma pasta no disco C: será criado para armazenar seus arquivos.");
                MessageBox.Show("O Diretório não existe. Uma pasta no disco C será criado para armazenar seus arquivos.");                       
                Directory.CreateDirectory(@"C:\Jericho\Arquivos\");
            }
           
        }
    }
}

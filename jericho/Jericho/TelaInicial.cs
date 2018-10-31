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
using Jericho.Model;

namespace Jericho
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        FalarController falarController;


        private void TelaInicial_Load(object sender, EventArgs e)
        {
            
           




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void but_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Leave(object sender, EventArgs e)
        {
            falarController.ParaVoz();
        }

        private void btn_1_Enter(object sender, EventArgs e)
        {

            FalarTexto("MP3");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {

            Ebook ebook = new Ebook("ebook 1", "xx", "xx", "xx", "xx", "xx", DateTime.Now);
            EbookDao ebookDao = new EbookDao();
            ebookDao.InsertEbook(ebook);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            EbookDao ebookDao = new EbookDao();


            foreach (var item in ebookDao.GetAll())
            {
                MessageBox.Show(item.idEbook);
            }
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIntro_Enter(object sender, EventArgs e)
        {
            FalarTexto("Você esta utilizando o Jericho," +
                    "Bom dia Marcos Aurélio Ribeiro" +
                    "Utilize as teclas para cima ou para " +
                    " baixo para listar as opções e tecle enter para selecioná-la." +
                    "Se desejar ou não essa introdução tecla enter ou alt mais s  ");



        }

        private void btnIntro_Leave(object sender, EventArgs e)
        {
            falarController.ParaVoz();
            btnIntro.Enabled = false;
        }

        private void TelaInicial_Click(object sender, EventArgs e)
        {

        }

        private void PararVoz()
        {

            if (falarController.FalarState())
            {
                falarController.ParaVoz();
            }
        }

        private void FalarTexto(string texto)
        {
            Console.Beep(5000, 500);
            falarController = new FalarController();
            if (true)
            {
                string voz =  falarController.Vozes()[0];
                falarController.FalarTexto(voz, texto);
            }



        }

        private void btn_2_Enter(object sender, EventArgs e)
        {
            FalarTexto("AudioBook");
        }

        private void btn_2_Leave(object sender, EventArgs e)
        {
            PararVoz();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {

        }

        private void btn_3_Enter(object sender, EventArgs e)
        {
            FalarTexto("Rádio Online");
        }

        private void btn_3_Leave(object sender, EventArgs e)
        {
            PararVoz();
        }

        private void btn_4_Enter(object sender, EventArgs e)
        {
            FalarTexto("Ajuda");
        }

        private void btn_4_Leave(object sender, EventArgs e)
        {
            PararVoz();
        }

        private void btn_6_Enter(object sender, EventArgs e)
        {
            FalarTexto("Calculadora");
        }

        private void btn_6_Leave(object sender, EventArgs e)
        {
            PararVoz();
        }

        private void btn_7_Enter(object sender, EventArgs e)
        {
            FalarTexto("Email");
        }

        private void btn_7_Leave(object sender, EventArgs e)
        {
            PararVoz();
        }

        private void btn_8_Enter(object sender, EventArgs e)
        {
            FalarTexto("Navegador de internet");
        }

        private void btn_8_Leave(object sender, EventArgs e)
        {
            PararVoz();
        }

        private void btn_5_Enter(object sender, EventArgs e)
        {
            FalarTexto("Jogos");
        }

        private void btn_5_Leave(object sender, EventArgs e)
        {
            PararVoz();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            Player_Mp3 player = new Player_Mp3(@"C:\Users\17000001504\Downloads\Queen-WeAreTheChampions(RockMontreal).mp3", "");
            player.ShowDialog();
        }
    }
}

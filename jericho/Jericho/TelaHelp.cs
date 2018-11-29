using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jericho
{
   

    

    public partial class telaHelp : Form
    {
        public telaHelp()
        {
           
            InitializeComponent();



            Ajuda.Add(new Ajuda("PESQUISA MP3"));
            Ajuda.Add(new Ajuda("AUDIOEBOOK"));
            Ajuda.Add(new Ajuda("RADIO ONLINE"));
            Ajuda.Add(new Ajuda("CALCULADORA"));
            Ajuda.Add(new Ajuda("REPRODUTOR DE MP3"));
            Ajuda.Add(new Ajuda("TELA DE CONFIGURAÇÕES"));
            Ajuda.Add(new Ajuda("INSERÇÃO DE ARQUIVOS"));
            Ajuda.Add(new Ajuda("FALAR"));
            ListaAjuda.DataSource = Ajuda.ToList();

        }


        List<Ajuda> Ajuda = new List<Ajuda>();





        private void ListaAjuda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      public void ListaAjuda_DoubleClick(object sender, EventArgs e)
        {
            if (ListaAjuda.CurrentCell.RowIndex == 0)
            {
                EscolhaAjuda esc_ajuda = new EscolhaAjuda("VOCÊ ESTA NA TELA DE AJUDA PARA PESQUISA DE ARQUIVOS MP3 \n 1 PARA COMEÇAR A PESQUISAR AS SUAS MÚSICAS VOCÊ IRA PRECISAR DIGITAR PELO MENOS 3 LETRAS \n 2 UTILIZE AS SETAS PARA CIMA E PARA BAIXO PARA NAVEGAR\n 3 DIGITE CONTROL+P PARA ADICIONAR A SUA LISTA MP3 \n 4 UTILIZE A TECLA ENTER PARA SELECIONAR A MÚSICA DESEJADA 5 UTILIZE AS TECLAS CONTROL+V PARA VOLTAR A TELA ANTERIOR");
                esc_ajuda.Text = "Ajuda mp3";
                
                
                esc_ajuda.ShowDialog();

            }
            else if(ListaAjuda.CurrentCell.RowIndex==1)
                {

                EscolhaAjuda esc_ajuda = new EscolhaAjuda("ajuda para você amiguinho ");
                esc_ajuda.Text = "Ajuda AudioEbook";
                esc_ajuda.ShowDialog();

            }
            else if (ListaAjuda.CurrentCell.RowIndex == 2)
            {

                EscolhaAjuda esc_ajuda = new EscolhaAjuda( "ajuda para você amiguinho ");
                esc_ajuda.Text = "Ajuda RadioOnline";
                esc_ajuda.ShowDialog();

            }
            else if (ListaAjuda.CurrentCell.RowIndex == 3)
            {

                EscolhaAjuda esc_ajuda = new EscolhaAjuda( "ajuda para você amiguinho ");
                esc_ajuda.Text = "Ajuda Calculadora";
                esc_ajuda.ShowDialog();

            }
            else if (ListaAjuda.CurrentCell.RowIndex == 4)
            {

                EscolhaAjuda esc_ajuda = new EscolhaAjuda( "ajuda para você amiguinho ");
                esc_ajuda.Text = "Ajuda ReprodutorMp3";
                esc_ajuda.ShowDialog();

            }
            else if (ListaAjuda.CurrentCell.RowIndex == 5)
            {

                EscolhaAjuda esc_ajuda = new EscolhaAjuda( "ajuda para você amiguinho ");
                esc_ajuda.Text = "Ajuda TelaCOnfigurações";
                esc_ajuda.ShowDialog();

            }
            else if (ListaAjuda.CurrentCell.RowIndex == 6)
            {

                EscolhaAjuda esc_ajuda = new EscolhaAjuda( "ajuda para você amiguinho ");
                esc_ajuda.Text = "Ajuda Inserção de dados";
                esc_ajuda.ShowDialog();

            }
            else if (ListaAjuda.CurrentCell.RowIndex == 7)
            {

                EscolhaAjuda esc_ajuda = new EscolhaAjuda( "ajuda para você amiguinho ");
                esc_ajuda.Text = "Ajuda Falar";
                esc_ajuda.ShowDialog();

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
       
    }
    public class Ajuda
    {
        public Ajuda(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
    }
}

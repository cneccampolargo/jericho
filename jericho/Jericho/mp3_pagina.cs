using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jericho.Model;
using Jericho.Controller;

namespace Jericho
{
    public partial class mp3_pagina : Form
    {
       
        Bitmap imagem;

        public mp3_pagina(Bitmap imagem)
        {
            InitializeComponent();
            this.imagem = imagem;
        }
        private void mp3_pagina_Load(object sender, EventArgs e)
        {

            button3.Image = imagem;
            button4.Image = imagem;
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length > 2)
            {
                DataGridMusicas.DataSource = Mp3Controller.BuscarTudo(textBox1.Text);
                //DataGridMusicas.DataBindings;
                DataGridMusicas.Columns[0].HeaderText = "Nome da Música";
                DataGridMusicas.Columns[1].HeaderText = "Genero";
                DataGridMusicas.Columns[2].HeaderText = "Artista";
                DataGridMusicas.Columns[3].Visible = false;
                DataGridMusicas.Columns[4].Visible = false;
                DataGridMusicas.Columns[5].HeaderText = "Data Adicionado";
            }
            else
            {
                DataGridMusicas.DataSource = null;
            }
          }
        private void DataGridMusicas_DoubleClick(object sender, EventArgs e)
        {
            Mp3 mp3 = (Mp3)DataGridMusicas.CurrentRow.DataBoundItem;
            Player_Mp3 playerMp3 = new Player_Mp3(mp3.caminhoMp3, mp3.nomeMusica);
            playerMp3.ShowDialog();


        }

        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void mp3_pagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.F10)
            {
                List<Mp3> Mp3list = Mp3Controller.GetAll();
                Player_Mp3 playerMp3 = new Player_Mp3(Mp3list);
                playerMp3.ShowDialog();
            }           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<Mp3> Mp3list = Mp3Controller.GetAll();
            Player_Mp3 playerMp3 = new Player_Mp3(Mp3list);
            playerMp3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

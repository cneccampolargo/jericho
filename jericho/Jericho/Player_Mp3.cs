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
    public partial class Player_Mp3 : Form
    {
        public string url { get; set; }
        public string nomeMusica { get; set; }

        public Player_Mp3(string url, string nome)
        {
            InitializeComponent();
            this.url = url;
        }

        private void Player_Mp3_Load(object sender, EventArgs e)
        {
            
            Player.settings.autoStart = true;
            Player.URL = url;

        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();                         
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void btn_volumeMais_Click(object sender, EventArgs e)
        {
            Player.settings.volume += 1;
        }

        private void btn_volumeMenos_Click(object sender, EventArgs e)
        {
            Player.settings.volume -= 1;
        }

        private void Player_Mp3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Player.Ctlcontrols.stop();
        }
    }
}

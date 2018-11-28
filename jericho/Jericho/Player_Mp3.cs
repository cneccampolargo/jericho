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

namespace Jericho
{
    public partial class Player_Mp3 : Form
    {
        public string url { get; set; }
        public string nomeMusica { get; set; }
        public List<Mp3> Mp3List { get; set; }
        public bool isList;
        public Player_Mp3(string url, string nome)
        {
            isList = false;
            InitializeComponent();
            this.url = url;
        }
        public Player_Mp3(List<Mp3> mp3s)
        {
            InitializeComponent();
            var myPlayList = Player.playlistCollection.newPlaylist("minhalista");
            foreach (Mp3 file in mp3s)
            {
                var mediaItem = Player.newMedia(file.caminhoMp3);
                myPlayList.appendItem(mediaItem);
            }

            Player.currentPlaylist = myPlayList;
            Player.Ctlcontrols.play();
        }

        private void Player_Mp3_Load(object sender, EventArgs e)
        {
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;            
            this.TopMost = true;

            Player.URL = url;
            Player.Ctlcontrols.play();
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
            Player.settings.volume += 10;
        }

        private void btn_volumeMenos_Click(object sender, EventArgs e)
        {
            Player.settings.volume -= 10;
        }

        private void Player_Mp3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Player.Ctlcontrols.stop();
        }
    }
}

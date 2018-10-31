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
    public partial class Player_RadioOnline : Form

    {    
        
        public string url { get; set; }
        public string nome { get; set; }


    
        public Player_RadioOnline(string url, string nome)
        {
            InitializeComponent();      
            this .url = url;

            }
        

        private void btn_Play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = url;
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btn_vol_mais_Click(object sender, EventArgs e)
        {
             axWindowsMediaPlayer1.settings.volume +=5;
            
            
        }

        private void btn_Vol_menos_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -=5;
           

        }

        private void Player_RadioOnline_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = url;
            axWindowsMediaPlayer1.settings.autoStart=true;
        }
    }
}

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

namespace Jericho
{

    public partial class EscolhaAjuda : Form
    {
        
        string  texto;
        public EscolhaAjuda(string texto)
        {
            InitializeComponent();
           
            this.texto = texto;

        }


        private void EscolhaAjuda_Load(object sender, EventArgs e)
        {
            
            telaHelp tela_help = new telaHelp();
           
            lbl_TextoAjuda.Text = texto;


            
    
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {

            telaHelp tela_help = new telaHelp();
            tela_help.ShowDialog();
        }

        private void lbl_tit_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        double resultado;
        string operadores;
        bool conta = true;
        public string op;

        //0
        private void button6_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "0")
            {
                return;
            }
            else
            {
                textResultado.Text = textResultado.Text += 0;
            }
        }

        //1
        private void button7_Click(object sender, EventArgs e)
        {
            if (conta)
            {
                textResultado.Text = textResultado.Text = "";
                textResultado.Text = textResultado.Text = "1";
                conta = false;
            }
            else
            {
                textResultado.Text = textResultado.Text += 1;
            }
        }

        //2
        private void button8_Click(object sender, EventArgs e)
        {
            if (conta)
            {
                textResultado.Text = textResultado.Text = "";
                textResultado.Text = textResultado.Text = "2";
                conta = false;
            }
            else
            {
                textResultado.Text = textResultado.Text += 2;
            }
        }

        //3
        private void button9_Click(object sender, EventArgs e)
        {
            if (conta)
            {
                textResultado.Text = textResultado.Text = "";
                textResultado.Text = textResultado.Text = "3";
                conta = false;
            }
            else
            {
                textResultado.Text = textResultado.Text += 3;
            }
        }

        //4
        private void button10_Click(object sender, EventArgs e)
        {
            if (conta)
            {
                textResultado.Text = textResultado.Text = "";
                textResultado.Text = textResultado.Text = "4";
                conta = false;
            }
            else
            {
                textResultado.Text = textResultado.Text += 4;
            }
        }

        //5
        private void button11_Click(object sender, EventArgs e)
        {
            if (conta)
            {
                textResultado.Text = textResultado.Text = "";
                textResultado.Text = textResultado.Text = "5";
                conta = false;
            }
            else
            {
                textResultado.Text = textResultado.Text += 5;
            }
        }

        //6
        private void button12_Click(object sender, EventArgs e)
        {
            if (conta)
            {
                textResultado.Text = textResultado.Text = "";
                textResultado.Text = textResultado.Text = "6";
                conta = false;
            }
            else
            {
                textResultado.Text = textResultado.Text += 6;
            }
        }

        //7
        private void button13_Click(object sender, EventArgs e)
        {
            if (conta)
            {
                textResultado.Text = textResultado.Text = "";
                textResultado.Text = textResultado.Text = "7";
                conta = false;
            }
            else
            {
                textResultado.Text = textResultado.Text += 7;
            }
        }

        //8
        private void button14_Click(object sender, EventArgs e)
        {
            if (conta)
            {
                textResultado.Text = textResultado.Text = "";
                textResultado.Text = textResultado.Text = "8";
                conta = false;
            }
            else
            {
                textResultado.Text = textResultado.Text += 8;
            }
        }

        //9
        private void button15_Click(object sender, EventArgs e)
        {
            if (conta)
            {
                textResultado.Text = textResultado.Text = "";
                textResultado.Text = textResultado.Text = "9";
                conta = false;
            }
            else
            {
                textResultado.Text = textResultado.Text += 9;
            }
        }

        //Igual
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(textResultado.Text);
            textResultado.Text = "";
            operadores = "=";
            conta = true;

            if (op == "+")
            {
                double result = num1 + num2;
                textResultado.Text = Convert.ToString(result);
            }

            if (op == "-")
            {
                double result = num1 - num2;
                textResultado.Text = Convert.ToString(result);
            }

            if (op == "/")
            {
                double result = num1 / num2;
                textResultado.Text = Convert.ToString(result);
            }

            if (op == "*")
            {
                double result = num1 * num2;
                textResultado.Text = Convert.ToString(result);
            }

        }

        //Adição
        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textResultado.Text);
            textResultado.Text = "";
            operadores = "+";
            textResultado.Text = textResultado.Text + operadores;
            conta = true;
            op = "+";
        }

        //Subtração
        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textResultado.Text);
            textResultado.Text = "";
            operadores = "-";
            textResultado.Text = textResultado.Text + operadores;
            conta = true;
            op = "-";

        }

        //Divisão
        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textResultado.Text);
            textResultado.Text = "";
            operadores = "/";
            textResultado.Text = textResultado.Text + operadores;
            conta = true;
            op = "/";

        }

        //Multiplicação
        private void button5_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textResultado.Text);
            textResultado.Text = "";
            operadores = "*";
            textResultado.Text = textResultado.Text + operadores;
            conta = true;
            op = "*";

        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {
            //textResultado.Text = textResultado.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

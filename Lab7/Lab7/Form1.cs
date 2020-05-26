using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        double numero1;
        double numero2;
        double result;
        string operation;
        List<string> historial = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cero_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void uno_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ",";
        }

        private void Ans_Click(object sender, EventArgs e)
        {
            pantalla.Text = result.ToString();
        }

        private void suma_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "+";
                numero1 = double.Parse(pantalla.Text);
                pantalla.Clear();
            }
            catch
            {
                pantalla.Clear();
                pantalla.Text = "SINTAX ERROR";
            }
        }

        private void resta_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "-";
                numero1 = double.Parse(pantalla.Text);
                pantalla.Clear();
            }
            catch
            {
                pantalla.Clear();
                pantalla.Text = "SINTAX ERROR";
            }


        }

        private void divide_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "÷";
                numero1 = double.Parse(pantalla.Text);
                pantalla.Clear();
            }
            catch
            {
                pantalla.Clear();
                pantalla.Text = "SINTAX ERROR";
            }
        }

        private void multiplica_Click(object sender, EventArgs e)
        {
            try
            {
                operation = "x";
                numero1 = double.Parse(pantalla.Text);
                pantalla.Clear();
            }
            catch
            {
                pantalla.Clear();
                pantalla.Text = "SINTAX ERROR";
            }
        }

        private void seis_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void AC_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            try
            {
                numero2 = Convert.ToDouble(pantalla.Text);
                if (operation == "+")
                {
                    result = numero1 + numero2;
                    pantalla.Text = result.ToString();
                    string h = Convert.ToString(numero1 + "+" + numero2 + "=" + result);
                    historial.Add(h);
                }
                if (operation == "-")
                {
                    result = numero1 - numero2;
                    pantalla.Text = result.ToString();
                    string h = Convert.ToString(numero1 + "-" + numero2 + "=" + result);
                    historial.Add(h);
                }
                if (operation == "x")
                {
                    result = numero1 * numero2;
                    pantalla.Text = result.ToString();
                    string h = Convert.ToString(numero1 + "x" + numero2 + "=" + result);
                    historial.Add(h);
                }
                if (operation == "÷")
                {
                    if (numero2 != 0)
                    {
                        result = numero1 / numero2;
                        pantalla.Text = result.ToString();
                        string h = Convert.ToString(numero1 + "x" + numero2 + "÷" + result);
                        historial.Add(h);
                    }
                    else
                    {
                        pantalla.Clear();
                        pantalla.Text = "MATH ERROR";
                    }
                }
            }
            catch
            {
                pantalla.Clear();
                pantalla.Text = "MATH ERROR";
            }

        }
        private void DEL_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length == 1)
                pantalla.Text = "0";
            else
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);
        }

        private void hist_Click(object sender, EventArgs e)
        {
            foreach (string datos in historial)
            {
                pantalla.Clear();
                pantalla.Text += datos + "\r\n";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_RRC
{
    public partial class Form1 : Form
    {

        double numero1 = 0, numero2 = 0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregar_numero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if (txt_resultado.Text == "0")
                txt_resultado.Text = "";

            txt_resultado.Text += boton.Text;
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txt_resultado.Text);

            if (operador == '+')
            {
                txt_resultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txt_resultado.Text);
            }
            else if (operador == '-')
            {
                txt_resultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txt_resultado.Text);
            }
            else if (operador == 'x')
            {
                txt_resultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txt_resultado.Text);
            }
            else if (operador == '÷')
            {
                if (txt_resultado.Text != "0")
                {
                    txt_resultado.Text = (numero1 / numero2).ToString();
                    numero1 = Convert.ToDouble(txt_resultado.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre cero.");
                }
            }
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if(txt_resultado.Text.Length>1)
            {
                txt_resultado.Text=txt_resultado.Text.Substring(0, txt_resultado.Text.Length-1);
            }
            else
            {
                txt_resultado.Text = "0";
            }
        }

        private void btn_borratodo_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = '\0';
            txt_resultado.Text = "0";
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "0";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            if(!txt_resultado.Text.Contains("."))
            {
                txt_resultado.Text += ".";
            }
        }

        private void btn_signo_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txt_resultado.Text);
            numero1 *= -1;
            txt_resultado.Text = numero1.ToString();

        }

        private void clickoperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            numero1 = Convert.ToDouble(txt_resultado.Text);
            operador = Convert.ToChar(boton.Text);

            txt_resultado.Text = "0";

        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoras
{
    public partial class Calculadoras : Form
    {
        double numero1 = 0, numero2 = 0;
        char Operador;


        public Calculadoras()
        {
            InitializeComponent();
        }



        private void AgregarNumero(object sender, EventArgs e)
        {

            var boton = ((Button)sender);

            if (txtresultado.Text == "0")
                txtresultado.Text = "";

            txtresultado.Text += boton.Text;

        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtresultado.Text);
            if (Operador == '+')
            {
                txtresultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (Operador == '-')
            {
                txtresultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (Operador == '*')
            {
                txtresultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (Operador == '/')
            {
                txtresultado.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
        }

        private void btnlimpiar1_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Length > 1)
            {
                txtresultado.Text = txtresultado.Text.Substring(0, txtresultado.Text.Length - 1);
            }
            else
            {
                txtresultado.Text = "0";
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            Operador = '\0';
            txtresultado.Text = "0";
        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text.Contains("."))
                {
                txtresultado.Text += ".";
                 }
        }

        private void btnsigno_Click(object sender, EventArgs e)
        {
            if(numero2 !=0)
            {
                numero1 = Convert.ToDouble(txtresultado.Text);
                numero1 *= -1;
                txtresultado.Text = numero1.ToString();
            }
            else
            {
                numero1 = Convert.ToDouble(txtresultado.Text);
                numero1 *= -1;
                txtresultado.Text = numero1.ToString();
            }

            
                
          
                
        }

        private void clickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            numero1 = Convert.ToDouble(txtresultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                numero1 = Math.Pow(numero1,2);
                txtresultado.Text = numero1.ToString();
            }

            else if (Operador == 'ⱱ')
            {
                numero1 = Math.Sqrt(numero1);
                txtresultado.Text =  numero1.ToString();
            }
            else
            {
                txtresultado.Text = "0";

            }
            

          

        }
}   }
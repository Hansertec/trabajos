using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ejercicio_6._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string titulo;
        string operacion;
        double num1;
        double num2;
        double resultado;
        bool reiniciar = false;
        bool punto = true; 
        private void Form1_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = titulo;
            DibujarTecladoNumerico();
        }

        private void DibujarTecladoNumerico()
        {
            char[] numeros;
            numeros = "7894563210.".ToCharArray();
            panelnumerico.Controls.Clear();
            foreach (char numero in numeros)
            {
                Button btnnumero = new Button();
                btnnumero.Text = numero.ToString();
                btnnumero.Size = new Size(55, 55);
                btnnumero.FlatStyle = FlatStyle.Flat;
                btnnumero.ForeColor = Color.White;
                btnnumero.BackColor = Color.Transparent;
                btnnumero.BackgroundImage = Properties.Resources.boton3;
                btnnumero.BackgroundImageLayout = ImageLayout.Stretch;
                btnnumero.FlatAppearance.BorderSize = 0;
                btnnumero.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnnumero.FlatAppearance.MouseOverBackColor = Color.Transparent;
                panelnumerico.Controls.Add(btnnumero);
                btnnumero.Click += Btnnumero_Click;

            }
        }
        private void Btnnumero_Click(object sender, EventArgs e)
        {
            ReiniciarProcesos();
            string numerostring = ((Button)sender).Text;
            if (numerostring == ".")
            {
                punto = true;
                if (txtpantalla.Text.Contains("."))
                {
                    punto = false;
                }
                if (punto==true)
                {
                    if(txtpantalla.Text!="")
                    {
                        txtpantalla.Text += "."; 
                    }
                }
            }
            else
            {
                if (txtpantalla.Text == "0")
                {
                    txtpantalla.Clear();
                }
                txtpantalla.Text += numerostring;
            }

           
        }
        private void ReiniciarProcesos()
        {
            if (reiniciar == true)
            {
                txtpantalla.Text = "0";
                reiniciar = false;
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operacion = btndiv.Text;
            definirOperacion();

        }
        private void definirOperacion()
        {
            Asignardatos();
            if (num2 > 0) ;
            {
                lblnum1.Text = txtpantalla.Text;
                lbloperacion1.Text = operacion;
                txtpantalla.Text = "0";
                lblnum1.Visible = true;
                lbloperacion1.Visible = true; 
                

            }
        }
        private void Asignardatos()
        {
            num1 = Convert.ToDouble(lblnum1.Text);
            num2 = Convert.ToDouble(txtpantalla.Text);
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            calcular();

        }


        private void calcular()
        {
            Asignardatos();
            if (lbloperacion1.Text == btndiv.Text)
            {
                Dividir();
            }
            if (lbloperacion1.Text == btnmult.Text)

            {
                Multiplicar();
            }
            if (lbloperacion1.Text == btnresta.Text)
            {
                restar();
            }
            if (lbloperacion1.Text == btnsuma.Text)
            {
                Suma();
            }
            if (lbloperacion1.Text == btnporcent.Text)
            {
                porcentaje();
            }
        }
        private void porcentaje()
        {
            resultado = num1 * num2 / 100;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void Multiplicar()
        {
            resultado = num1 * num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void restar()
        {
            resultado = num1 - num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void Limpiar()
        {
            reiniciar = true;
            lbloperacion1.Text = "0";
            lblnum1.Text = "0";
            lblnum1.Visible = false;
            lbloperacion1.Visible = false;

        }
        private void Dividir()
        {
            resultado = num1 / num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }
        private void Suma()
        {
            resultado = num1 + num2;
            txtpantalla.Text = resultado.ToString();
            Limpiar();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            operacion = btnmult.Text;
            definirOperacion();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = btnresta.Text;
            definirOperacion();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            operacion = btnsuma.Text;
            definirOperacion();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnporcent_Click(object sender, EventArgs e)
        {
            operacion = btnporcent.Text;
            definirOperacion();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            borrar();
        }
        private void borrar()
        {
            txtpantalla.Text = "0";
            lbloperacion1.Text = "0";
            lblnum1.Text = "0";

        }

        private void btncopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtpantalla.Text);
        }
    }
    
}   


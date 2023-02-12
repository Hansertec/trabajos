using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loteriaV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random numerosaleatorios = new Random();
      


        private void button1_Click(object sender, EventArgs e)
        {
            int Primera;
            int Segunda;
            int Tercera;
            int numnero;



            Primera = numerosaleatorios.Next(0, 99);
            Segunda = numerosaleatorios.Next(0, 99);
            Tercera = numerosaleatorios.Next(0, 99);





            numnero = Convert.ToInt32(txtjugarnumero.Text);

            lbl1.Text = Primera.ToString();
            Lbl2.Text = Segunda.ToString();
            Lbl3.Text = Tercera.ToString();

            if (numnero == Primera)
            {
                label4.Text = "te sacaste en primera ";
            }
            else if (numnero == Segunda)
            {
                label4.Text = "te sacaste en segunda ";

            }
            else if (numnero == Tercera)
            {
                label4.Text = "te sacaste en tercera ";
            }
            else
            {
                label4.Text = "te guayaste  ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
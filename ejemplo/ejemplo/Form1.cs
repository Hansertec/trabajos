using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            
        }



        private void button1_Click(object sender, EventArgs e)
        {

            {
                var listado = new[]
                {
                    new {Nombre= "Jose", Apellido="Sanchez" },
                    new {Nombre= "Mario", Apellido="Sanchez" },
                    new {Nombre= "Jose", Apellido="Santos" },
                    new {Nombre= "Maria", Apellido="Sanchez"},
                    new {Nombre= "Pedro", Apellido="perez" },
                    new {Nombre= "Maria", Apellido="Santos"},
                    new {Nombre= "Manuel", Apellido="perez", },
                    new {Nombre= "Pedro", Apellido="Santos"},


                };

                XElement personas = new XElement("personas", // Este es la raiz
                    from a in listado
                    select new XElement("persona", new XAttribute("Nombre", a.Nombre),
                    new XElement("Apellido", a.Apellido)

                     )
                     );

                string[] Listado = { "Listado" };
                /* { "Jose Sanchez", "Mario Sanchez", "Jose Santos", "Maria Sanchez", "Pedro Perez", "Maria Santos", "Manuel Perez", "Pedro Santos" };*/
                //hacemos un query
                IEnumerable<string> encontrados = from e in Listado
                                                  where e.Contains()
                                                  orderby e
                                                  select e;

                //mostramos los resultados
                foreach (string Nombre in encontrados)

                    int n = DTG.Rows.Add();
                
                //    Console.WriteLine(Nombre);
                //Console.WriteLine("_______");



                //Console.WriteLine(personas);
                personas.Save("Peronas.xml");









                DataSet ds = new DataSet();
                ds.ReadXml("C://Users//hanse//source//repos//ejemplo//ejemplo//bin//Debug/peronas.xml");


                DTG.DataSource = ds.Tables[0];




                //ds.ReadXml("C://Users//hanse//OneDrive//Escritorio/peronas.xml");














            }




















        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
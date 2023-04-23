using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace buscar_el_hombre
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            //DataSet ds = new DataSet();
            //ds.ReadXml("C://Users//hanse//OneDrive//Escritorio/peronas.xml");
            //DTG.DataSource = ds.Tables[0];


            //string[] Nombres = { "Jose Sanchez", "Mario Sanchez", "Jose Santos", "Maria Sanchez", "Pedro Perez", "Maria Santos", "Manuel Perez", "Pedro Santos" };
            //////hacemos un query
            //IEnumerable<string> encontrados = from txt1 in Nombres
            //                                  where txt1.Contains("Manuel, Mario, Jose, Maria")
            //                                  orderby txt1
            //                                  select txt1;

            ////mostramos los resultados 
            //foreach (string Nombre in encontrados)
            //    Console.WriteLine(Nombre);
            //Console.WriteLine("_______");

            //var filename = "C://Users//hanse//source//repos//buscar el hombre//XMLFile1.xml";
            //XElement personassss = XElement.Load(filename); 

            //var personas = from a in personassss.Elements("personas").Elements("persona")
            //               where a.Attribute("persona").Value=="ba"
            //               orderby a.Value
            //               select a;

            //foreach( var persona in personas)
            //{
            //    DTG.Rows[personas].Cells[0].Value = persona.Name;

            //}


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

                //TxtNombre.Text = personas.ToString();
                //txtApellido.Text = personas.ToString();
               
                string[] Listado = { "Listado" };
                /* { "Jose Sanchez", "Mario Sanchez", "Jose Santos", "Maria Sanchez", "Pedro Perez", "Maria Santos", "Manuel Perez", "Pedro Santos" };*/
                //hacemos un query
                IEnumerable<string> encontrados = from l in Listado
                                                  where l.Contains(TxtNombre.Text)
                                                  orderby l
                                                  select l;

                //mostramos los resultados
                foreach (string Nombre in encontrados)
                    DTG.Text = Nombre;
                //DTG = personas.ToString()


                //int e = DTG.Rows.Add();
                DTG.Rows[0].Cells[0].Value = new List<XElement>();
                //    Console.WriteLine(Nombre);
                //Console.WriteLine("_______");



                //Console.WriteLine(personas);
                personas.Save("Peronas.xml");










            }


        }
    }
}

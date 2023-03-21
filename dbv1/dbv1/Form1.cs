using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using static dbv1.Program;

namespace dbv1
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
            using (var db1= new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db1.GetCollection<Customer>("customers");
                


                // Create your new customer instance
                var customer = new Customer
                {
                    Name = "John Doe",
                    Phones = new string[] { "8000-0000", "9000-0000" },
                    IsActive = true
                };







                // Insert new customer document (Id will be auto-incremented)
                col.Insert(customer);



                var cliente1 = new Customer
                {
                    Name = "Derick Peralta",
                    Phones = new string[] { "809-345-2020", "809-456-6785" },
                    IsActive = true
                };
                col.Insert(cliente1);



                var cliente2 = new Customer
                {
                    Name = "Dera Josefa",
                    Phones = new string[] { "809-404-0440", "809-456-2341" },
                    IsActive = false
                };
                col.Insert(cliente2);






                // Update a document inside a collection
                customer.Name = "Carlos Doe";



                col.Update(customer);



                // Index document using document Name property
                col.EnsureIndex(x => x.Name);



                // Use LINQ to query documents (filter, sort, transform)
                var results = col.Query()
                    .Where(x => x.Name.StartsWith("D"))
                    .OrderBy(x => x.Name)
                    .Select(x => new { x.Name, NameUpper = x.Name.ToUpper() })
                    .Limit(10)
                    .ToList();



                // Let's create an index in phone numbers (using expression). It's a multikey index
                col.EnsureIndex(x => x.Phones);



                // and now we can query phones
                var r = col.FindOne(x => x.Phones.Contains("8888-5555"));

                int n = dtgvpersonas.Rows.Add();

                dtgvpersonas.Rows[n].Cells[0].Value = txtNombre.Text;
                dtgvpersonas.Rows[n].Cells[1].Value = txtapellido.Text;
                dtgvpersonas.Rows[n].Cells[2].Value = txttelefono.Text;
                dtgvpersonas.Rows[n].Cells[0].Value = txtcedula.Text;

            }
        }

        private void dtgvpersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
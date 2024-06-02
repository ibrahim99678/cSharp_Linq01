using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_LINQ01
{
    public partial class Form1 : Form
    {
        List<customer> customers = new List<customer>
        {
            new customer() {CustomerID="ALFKI", CompanyName="Alfreds Futterkiste" , Country="Germany"},
            new customer() {CustomerID="ANATR", CompanyName="Ana Trujillo Emparedados y helados" , Country="Mexico"},
            new customer() {CustomerID="ANTON", CompanyName="Antonio Moreno Taquería" , Country="Mexico"},
            new customer() {CustomerID="AROUT", CompanyName="Around the Horn" , Country="Germany"},
            new customer() {CustomerID="BERGS", CompanyName="Berglunds snabbköp" , Country="UK"},
            new customer() {CustomerID="BLAUS", CompanyName="Blauer See Delikatessen" , Country="Germany"},
            new customer() {CustomerID="BLONP", CompanyName="Blondesddsl père et fils" , Country="France"},
            new customer() {CustomerID="BOLID", CompanyName="Bólido Comidas preparadas" , Country="Spain"},
            new customer() {CustomerID="BONAP", CompanyName="Bon app'" , Country="France"},
            new customer() {CustomerID="BOTTM", CompanyName="Bottom-Dollar Markets" , Country="Canada"},

        };
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = customers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQ1_Click(object sender, EventArgs e)
        {
            //Query Experation 

            //var result = from c in customers
            //             select new { c.CustomerID, c.CompanyName };
            //dataGridView1 .DataSource = result.ToList();
           
            //Lambda Experation 

            var res = customers.Select(c => new { c.CustomerID, c.CompanyName } );
            dataGridView1.DataSource = res.ToList();

        }

        private void btnQ2_Click(object sender, EventArgs e)
        {
            //Query Expreation 


            //var result = from c in customers
            //             where c.CompanyName.Equals(textBox1.Text)
            //             select c;
            //dataGridView1.DataSource = result.ToList();


            //Lambda Experation

            var res = customers.Where(c => c.Country == textBox1.Text).Select(c => c);
            dataGridView1.DataSource =res.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            ////Query Expration 
            
            //var result =from c in customers
            //            where  c.CompanyName.StartsWith(textBox1.Text)
            //            select c;   
            //dataGridView1.DataSource = result.ToList();

            //Lambda Expration 

            var res = customers.Where(c => c.Country.ToLower().Contains(textBox1.Text.ToLower()));
            dataGridView1.DataSource = res.ToList();    
        }

        private void btnQ4_Click(object sender, EventArgs e)
        {
            //Query Expration 
           
            //var result = (from c in customers
            //             select c).Count();
            //dataGridView1.DataSource = new[] { new { TotalCustomer = result } };

            //Lambda Expration 

            var res = customers.Count;
            dataGridView1.DataSource = new[] { new {Totalcustomer= res} };
        }
    }
}

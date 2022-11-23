using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PovezanDostop
{
    public partial class Form1 : Form
    {
        string povezava = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\D disk\git\baza\NorthPrava\northwnd.mdf"";Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "select * from employees";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            p.Open();
            SqlDataReader bralec = u.ExecuteReader();
            while (bralec.Read())
            {
                string r = bralec["TitleOfCourtesy"] + " " + bralec["Firstname"] + " " + bralec["Lastname"];
                listBox1.Items.Add(r);
            }
            bralec.Close();
            p.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "select * from employees where city = @City";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            SqlParameter par = new SqlParameter("@City", SqlDbType.NVarChar);
            u.Parameters.Add(par);
            //par.Value = textBox1.Text;
            p.Open();
            SqlDataReader bralec = u.ExecuteReader();
            while (bralec.Read())
            {
                string r = bralec["TitleOfCourtesy"] + " " + bralec["Firstname"] + " " + bralec["Lastname"] + " " + bralec["City"];
                listBox1.Items.Add(r);
            }
            bralec.Close();
            p.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "select sum(unitprice*quantity) as sum from [order details]";
            SqlCommand u = new SqlCommand(ukaz, p);
            p.Open();
            double resoult = double.Parse(u.ExecuteScalar().ToString());
            listBox1.Items.Clear();
            listBox1.Items.Add("vsota je " + resoult);
            p.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "update employees set region = 'X' where region is null";
            SqlCommand u = new SqlCommand(ukaz, p);
            p.Open();
            int štvrstic = u.ExecuteNonQuery();
            listBox1.Items.Clear();
            listBox1.Items.Add("posodobljeno " + štvrstic);
            p.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "SELECT TerritoryDescription, RegionDescription FROM Territories, Region WHERE Territories.RegionID = Region.RegionID";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            p.Open();
            SqlDataReader bralec = u.ExecuteReader();
            while (bralec.Read())
            {
                string r = bralec["TerritoryDescription"] + " " + bralec["RegionDescription"];
                listBox1.Items.Add(r);
            }
            bralec.Close();
            p.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "UPDATE Region SET RegionDescription='East' WHERE RegionDescription='Vzhod'";
            SqlCommand u = new SqlCommand(ukaz, p);
            p.Open();
            int štvrstic = u.ExecuteNonQuery();
            listBox1.Items.Clear();
            listBox1.Items.Add("posodobljeno " + štvrstic);
            p.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŠtudentWF
{
    public partial class Form1 : Form
    {
        string povezava = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\D disk\git\baza\študent\ŠtudentNet.mdf"";Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void Izpis_ocene(object sender, EventArgs e)
        {
            lrezultat.Text = "rezultat ";
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "select s.imeštudenta, o.ocena from ocene o join predmet p on o.idpredmeta = p.idpredmeta join študent s on o.idštudenta = s.idvpisa where p.imepredmeta = '" + tbpredmet.Text + "'";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            p.Open();
            SqlDataReader bralec = u.ExecuteReader();
            while (bralec.Read())
            {
                lrezultat.Text += Environment.NewLine + bralec[0] + bralec[1];
            }
            bralec.Close();
            p.Close();
        }

        private void Izpis_povprecje(object sender, EventArgs e)
        {
            lrezultat.Text = "rezultat ";
            SqlConnection p = new SqlConnection(povezava);
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            p.Open();
            string avg = "select avg(o.ocena) from študent s join ocene o on s.idvpisa = o.idštudenta where SUBSTRING(s.imeštudenta, CHARINDEX(' ', s.imeštudenta) + 1, LEN(s.imeštudenta) - CHARINDEX(' ', s.imeštudenta)) = '" + tbstudent.Text + "'";
            u.CommandText = avg;
            SqlDataReader bralec = u.ExecuteReader();
            u.CommandText = "update študent set povprečnaocena = ( " + avg + " )";
            u.CommandType = CommandType.Text;
            bralec.Close();
            u.ExecuteNonQuery();
            u.CommandText = "select s.imeštudenta, s.povprečnaocena from študent s where SUBSTRING(s.imeštudenta, CHARINDEX(' ', s.imeštudenta) + 1, LEN(s.imeštudenta) - CHARINDEX(' ', s.imeštudenta)) = '" + tbstudent.Text + "'";
            bralec.Close();
            bralec = u.ExecuteReader();
            while (bralec.Read())
            {
                lrezultat.Text += Environment.NewLine + bralec[0] + bralec[1];
            }
            bralec.Close();
            p.Close();
        }

        private void Izpis_predmetov(object sender, EventArgs e)
        {
            lrezultat.Text = "rezultat ";
            SqlConnection p = new SqlConnection(povezava);
            string ukaz = "select * from predmet";
            SqlCommand u = new SqlCommand();
            u.Connection = p;
            u.CommandText = ukaz;
            u.CommandType = CommandType.Text;
            p.Open();
            SqlDataReader bralec = u.ExecuteReader();

            bralec.Close();
            p.Close();
        }
    }
}

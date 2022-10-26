using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GoFish
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        Kup kup1;
        Kup kup2;
        public Form1()
        {
            InitializeComponent();
            kup1 = new Kup();
            kup2 = new Kup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Karta> kup = new List<Karta>();
            string rez = "nove karta " + Environment.NewLine;
            
            for (int i = 0; i < 5; i++)
            {
                kup.Add(new Karta((Barve)rand.Next(4), (Vrednosti)rand.Next(1, 14)));
                rez += kup[i].Ime + Environment.NewLine;
            }
            
            kup.Sort(new Primerjava());
            
            rez += Environment.NewLine + "urejen kup" + Environment.NewLine;
            
            foreach (Karta i in kup)
                rez += i.Ime + Environment.NewLine;

            MessageBox.Show(rez);
        }
        //>> btn
        private void btndesno_Click(object sender, EventArgs e)
        {

        }
        //<< btn
        private void btnlevo_Click(object sender, EventArgs e)
        {

        }
        //postavi 1
        private void postaviena_Click(object sender, EventArgs e)
        {

        }
        //postavi 2
        private void postavidva_Click(object sender, EventArgs e)
        {

        }
        //mešaj 1
        private void mešajena_Click(object sender, EventArgs e)
        {

        }
        //mešaj 2
        private void mešajdva_Click(object sender, EventArgs e)
        {

        }
    }
}

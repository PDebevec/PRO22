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
            kup1 = new Kup(5);
            kup2 = new Kup();
            add(lblevo.Items, kup1);
            add(lbdesno.Items, kup2);
        }
        private void add(dynamic lb, Kup kup)
        {
            List<string> ls = kup.ImenaKart();
            for (int i = 0; i < kup.count; i++)
            {
                lb.Add(ls[i]);
            }
        }
        private void update(dynamic lb, Kup kup)
        {
            List<string> ls = kup.ImenaKart();
            for (int i = 0; i < lb.Count; i++)
            {
                lb[i] = ls[i];
            }
        }
        //btn >>
        private void btndesno_Click(object sender, EventArgs e)
        {
            if (lblevo.SelectedIndex != -1)
            {
                kup2.add(kup1.Deli(lblevo.SelectedIndex));
                lbdesno.Items.Add(lblevo.Items[lblevo.SelectedIndex]);
                lblevo.Items.RemoveAt(lblevo.SelectedIndex);
            }
        }
        //btn <<
        private void btnlevo_Click(object sender, EventArgs e)
        {
            if (lbdesno.SelectedIndex != -1)
            {
                kup1.add(kup2.Deli(lbdesno.SelectedIndex));
                lblevo.Items.Add(lbdesno.Items[lbdesno.SelectedIndex]);
                lbdesno.Items.RemoveAt(lbdesno.SelectedIndex);
            }
        }
        //ponastavi 1
        private void ponastaviena_Click(object sender, EventArgs e)
        {
            kup1.sort();
            update(lblevo.Items, kup1);
        }
        //ponastavi 2
        private void ponastavidva_Click(object sender, EventArgs e)
        {
            kup2.sort();
            update(lbdesno.Items, kup2);
        }
        //mešaj 1
        private void mešajena_Click(object sender, EventArgs e)
        {
            kup1.mešaj();
            update(lblevo.Items, kup1);
        }
        //mešaj 2
        private void mešajdva_Click(object sender, EventArgs e)
        {
            kup2.mešaj();
            update(lbdesno.Items, kup2);
        }
    }
}

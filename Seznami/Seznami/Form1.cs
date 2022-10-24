using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seznami
{
    public partial class Form1 : Form
    {
        ArrayList seznam = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            //dodaj v senam vsebino txtvsebina
            seznam.Add(tbvnos.Text);
            tbkonzola.Text = "dodali v tabelo " + tbvnos.Text;
        }

        private void btnizpis_Click(object sender, EventArgs e)
        {
            string rezultat = "Elementi so:"+Environment.NewLine;
            for (int i = 0; i < seznam.Count; i++)
                rezultat += seznam[i] + Environment.NewLine;
            tbkonzola.Text = rezultat;
        }

        private void btnodstrani_Click(object sender, EventArgs e)
        {
            seznam.Remove(tbvnos.Text);
            if(seznam.Contains(tbvnos.Text))
                tbkonzola.Text = "Element " + tbvnos.Text + " je bil odstranjen";
        }

        private void btnprvi_Click(object sender, EventArgs e)
        {
            try {
                tbkonzola.Text = "Prvi element je " + seznam[0].ToString();
            }
            catch (Exception ex)
            {
                tbkonzola.Text = ex.GetHashCode().ToString();
            }
        }

        private void btnzadnji_Click(object sender, EventArgs e)
        {
            try
            {
                tbkonzola.Text = "Prvi element je " + seznam[seznam.Count-1].ToString();
            }
            catch (Exception ex)
            {
                tbkonzola.Text = ex.GetHashCode().ToString();
            }
        }

        private void btnprazen_Click(object sender, EventArgs e)
        {
            if (seznam.Count < 0)
                tbkonzola.Text = "seznam je prazen";
            else
                tbkonzola.Text = "seznam ni prazen";
        }

        private void btnvsebuje_Click(object sender, EventArgs e)
        {
            if (seznam.Contains(tbvnos.Text))
                tbkonzola.Text = "seznam vsebje " + tbvnos.Text;
        }

        private void btnlokacija_Click(object sender, EventArgs e)
        {
            tbkonzola.Text = "niz " + tbvnos.Text + " je na index " + seznam.IndexOf(tbvnos.Text);
        }

        private void btntrim_Click(object sender, EventArgs e)
        {
            seznam.TrimToSize();
            tbkonzola.Text = "seznam je skrajšan";
        }

        private void btnstatistika_Click(object sender, EventArgs e)
        {
            tbkonzola.Text = "št elementov :" + seznam.Count + Environment.NewLine;
            tbkonzola.Text += "kapaciteta :" + seznam.Capacity;
        }
    }
}

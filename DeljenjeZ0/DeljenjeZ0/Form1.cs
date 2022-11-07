using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeljenjeZ0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rez.Text = "rezultat " + (int.Parse(tb1.Text) / int.Parse(tb2.Text));
            }
            catch (ArithmeticException)
            {
                rez.Text = "deljenje z 0 je prepovedano";
            }
            catch (Exception)
            {
                rez.Text = "neki ni številka";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                rez2.Text = "rezultat " + Math.Sqrt(double.Parse(tb3.Text));
            }
            catch (NegativnoException n)
            {
                rez2.Text = n.Message;
            }
            catch (Exception)
            {
                rez2.Text = "neki ni številka";
            }
        }
    }
}

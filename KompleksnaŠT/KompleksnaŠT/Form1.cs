using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KompleksnaŠT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kompleksno k1;
        Kompleksno k2;
        private void b1_Click(object sender, EventArgs e)
        {
            k1 = new Kompleksno(Convert.ToDouble(tb11.Text), Convert.ToDouble(tb12));
            k2 = new Kompleksno(Convert.ToDouble(tb21.Text), Convert.ToDouble(tb22));
        }

        private void b2_Click(object sender, EventArgs e)
        {
            k1 = new Kompleksno(Convert.ToDouble(tb11.Text), Convert.ToDouble(tb12));
            k2 = new Kompleksno(Convert.ToDouble(tb21.Text), Convert.ToDouble(tb22));
        }

        private void b3_Click(object sender, EventArgs e)
        {
            k1 = new Kompleksno(Convert.ToDouble(tb11.Text), Convert.ToDouble(tb12));
            k2 = new Kompleksno(Convert.ToDouble(tb21.Text), Convert.ToDouble(tb22));
        }

        private void cls_Click(object sender, EventArgs e)
        {
            rez.Text = "";
        }
    }
}

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
        Kompleksno k1, k2;
        public Form1()
        {
            InitializeComponent();
            k1 = new Kompleksno();
            k2 = new Kompleksno();
        }
        private void NovaKompleksnašt()
        {
            k1.Re = Convert.ToDouble(tb11.Text); k1.Im = Convert.ToDouble(tb12.Text);
            k2.Re = Convert.ToDouble(tb21.Text); k2.Im = Convert.ToDouble(tb22.Text);
        }
        
        private void b1_Click(object sender, EventArgs e)
        {
            NovaKompleksnašt();
            rez.Text = (k1 + k2).ToString();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            NovaKompleksnašt();
            rez.Text = (k1 - k2).ToString();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            NovaKompleksnašt();
            rez.Text = (k1 * k2).ToString();
        }

        private void cls_Click(object sender, EventArgs e)
        {
            rez.Text = "";
        }
    }
}

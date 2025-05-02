using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tip__tax_and_total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double charges, tax, tip, total;
            if (double.TryParse(chargetxt.Text, out charges))
            {
                charges = double.Parse(chargetxt.Text);
                tax = charges * 0.07;
                tip = charges * 0.15;
                total = charges + tax + tip;
                labletip.Text = tip.ToString("c");
                labletex.Text = tax.ToString("c");
                labletotal.Text = total.ToString("c");
            }
            else
            {
                MessageBox.Show("Please enter a valid food charge value.");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

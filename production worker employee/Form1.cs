using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace production_worker_employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void show_employee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EName.Text) || string.IsNullOrWhiteSpace(ENumber.Text) ||
                 string.IsNullOrWhiteSpace(SNumber.Text) || string.IsNullOrWhiteSpace(Hour_pay_rate.Text))
            {
                MessageBox.Show("Please enter valid data in all fields.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = EName.Text;
            int id, shift;
            decimal pay;

            if (!int.TryParse(ENumber.Text, out id) || !int.TryParse(SNumber.Text, out shift) ||
                !decimal.TryParse(Hour_pay_rate.Text, out pay))
            {
                MessageBox.Show("Please enter valid numeric data in the appropriate fields.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            production_worker worker = new production_worker(name, id, shift, pay);
            result.Text = worker.ToString();
        }
    }
}

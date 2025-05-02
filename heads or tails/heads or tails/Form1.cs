using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heads_or_tails
{
    public partial class heads_or_tails : Form
    {
        public heads_or_tails()
        {
            InitializeComponent();
        }

        private void show_heads_Click(object sender, EventArgs e)
        {
            heads_coin.Visible = true;
            tails_coin.Visible = false;
        }

        private void show_tails_Click(object sender, EventArgs e)
        {
            heads_coin.Visible = false;
            tails_coin.Visible = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

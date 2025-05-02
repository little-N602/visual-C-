using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Counter
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

        private void count_Click(object sender, EventArgs e)
        {
            
                string word = textBox1.Text.Trim();
                int count = countword(word);
            if (count > 0)
            {
                total.Text = count.ToString();
            }
            else
            {
                MessageBox.Show("Please enter text into the text box.", "Word Count");
            }
        }
        private int countword(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return 0;
            }
            string[] allwords = word.Split(' ');
            return allwords.Length;
        }
    }
}

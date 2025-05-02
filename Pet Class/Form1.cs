//Author: Luis Nigoa 
//Class: CIS162AD
//Section: (16285)
//Assignment: Chapter 10 Program 10
//SUBMISSION DATE: 6/28/23
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Class
{
    public partial class pet_class : Form
    {
        public pet_class()
        {
            InitializeComponent();
        }

        
        Pet pet;

        
        private void display_Click(object sender, EventArgs e)
        {
            
            string name = nametxt.Text;
            string type = typetxt.Text;
            string ageString = agetxt.Text;
            decimal age;

              if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && decimal.TryParse(agetxt.Text, out age))
                {
                    
                    pet = new Pet(name, type, age);


                    result.Text = "Pet's name: " + pet.Name + "\n"
                         + "Pet's type: " + pet.Type + "\n"
                         + "Pet's age: " + pet.Age.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter valid data");
                }
          
        }

        
        private void exit_Click(object sender, EventArgs e)
        {
         
            this.Close();
        }

     
        private void clear_Click(object sender, EventArgs e)
        {

            result.Text = "";
        }
    }
}

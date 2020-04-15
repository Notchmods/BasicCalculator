//Those are components
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplecalculator 
{
	//These codes are copyright free 
    public partial class Form : System.Windows.Forms.Form
    {
		//Upon intialization  
        public Form()
        {
			//Initialize the forms
            InitializeComponent();
        }

		//Button onclick 
		private void button1_Click(object sender, EventArgs e)
		{
			//Check the user inserted a legit numbers.
			try
			{ 
				//Analyze the numbers
				float jepht = float.Parse(textBox1.Text);
				float Jeam = float.Parse(textBox2.Text);
				//float - Define a variables with a fractional value example float = 1.756 , int = 1 
				//Add or subtract or multiply or divide the numbers into one a single float
				float Jones = jepht + Jeam;
				textBox3.Text = Jones.ToString();
			}
			//If it isn't a number then this message will show up
			catch
			{
				MessageBox.Show("That's not a number enter a legit number");
			}
		}

		//When the mouse touch the button the buttons background color will turn to any color other then its original
		private void button1_MouseEnter(object sender, EventArgs e)
		{  
			button1.BackColor = Color.Yellow;
		}

		//If the mouse leaves the button the button will return to its original color.
		private void button1_MouseLeave(object sender, EventArgs e)
		{
			button1.BackColor = Color.Transparent;
		}
	}
}

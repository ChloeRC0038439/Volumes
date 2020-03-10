using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Declare Variables
            double Radius, Volume;

            //Read values from text box
            try
            {
                Radius = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Type a number in the Radius Box!");
                Radius = 0.0;

            }

            //Calcualte Volume
            Volume= 4.0 / 3.0 * Math.PI * Radius * Radius * Radius;

            //Display Volume
            Text = "Volume= = " + Volume + "m^3";

            }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

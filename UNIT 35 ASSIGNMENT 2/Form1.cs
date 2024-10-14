using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIT_35_ASSIGNMENT_2
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
             double length = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);
                double height = double.Parse(textBox3.Text);
             double surfacearea = 2*(length * height + length * width + width * height);
              textBox4.Clear();
             textBox4.AppendText(surfacearea.ToString("0.000"));

                double volume = (length * width * height);
                textBox5.Clear();
                textBox5.AppendText(volume.ToString("0.000"));
            }
            catch 
            
            {
             MessageBox.Show("Type values into length,width and height boxes before calculating.");
            }
        }
       


 private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }




        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double pi = Math.PI;
                double radius = double.Parse(textBox6.Text);
                double radius_cubed = Math.Pow(radius, 3);
                double radius_squared = Math.Pow(radius, 2);
                double four_three = 4.0 / 3.0;

                double surfacearea = 4 * pi * radius_squared;
                textBox7.Clear();
                textBox7.AppendText(surfacearea.ToString("0.000"));

                double volume = four_three * pi * radius_cubed;
                textBox8.Clear();
                textBox8.Text = volume.ToString("0.000");

            }
            catch
            {
                MessageBox.Show("Type a value into the radius which is valid.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double pi = Math.PI;
                double radius = double.Parse(textBox10.Text);
               double height = double.Parse(textBox9.Text);
              double radius_squared = Math.Pow(radius, 2);
               double height_squared = Math.Pow(height, 2);
                double root = Math.Sqrt(height_squared + radius_squared);
                double one_five = 1.0 / 2.0;

                double surface_area = pi * radius * (radius + root);  
                textBox11.Clear(); 
                textBox11.Text = surface_area.ToString("0.000");

                double volume = one_five * pi * radius_squared * height;
               textBox12.Clear();
                textBox12.Text = volume.ToString("0.000");
            }
            catch
            {
                MessageBox.Show("Type a value into the radius and height which is valid.");
            }
        }
    }
}
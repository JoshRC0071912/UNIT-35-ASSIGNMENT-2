using System;
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
            //using try-catch to catch any input errors.
            try
            {
                //reading the values for length, width, height.
             double length = double.Parse(textBox2.Text);
                double width = double.Parse(textBox1.Text);
                double height = double.Parse(textBox3.Text);
                //calculating surface area of the values which are entered. 
             double surfacearea = 2*(length * height + length * width + width * height);
                //clearibg the read only text box so answers don't stack onto each other. 
              textBox4.Clear();
                //putting the surface area calculated into the textbox, while also using decimal places to make the answer more readable.
                textBox4.AppendText(surfacearea.ToString("0.000"));
                //calculating the volume from the values put in. 
                double volume = (length * width * height);
                //clearing the read only text box so answers do not stack onto each other.
                textBox5.Clear();
                //putting the volume into the textbox, while also using decimal places to make the answer more readable.
                textBox5.AppendText(volume.ToString("0.000"));
            }
            catch 
            
            {
                //the message that will show up as a result of errors, utilising the try-catch incase of errors. 
             MessageBox.Show("Type values into length,width and height boxes before calculating.");
            }
        }
       


 private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }




        private void button2_Click(object sender, EventArgs e)
        {
            //using try-catch to catch any input errors.
            try
            {
                // this will let the computer use pi, so the number version isn't needed to be typed into the code. 
                double pi = Math.PI;
                //reading the values for radius from the textboxes. 
                double radius = double.Parse(textBox6.Text);
                //using math code to simplify the code, meaning that 'radius_cubed' can be entered into the calculation rather than 'radius * radius * radius*.'
                double radius_cubed = Math.Pow(radius, 3);
                //same rule mentioned in the cubed part applies for the squared, essentially simplifying code. 
                double radius_squared = Math.Pow(radius, 2);
            
                //calculating the surface area from the values entered
                double surfacearea = 4 * pi * radius_squared;
                //clearing the textbox which the answer will be in so that answers do not become a mess, and stack onto each other. 
                textBox7.Clear();
                //putting the answer calculated into the text box used for the answer.
                textBox7.AppendText(surfacearea.ToString("0.000"));
                //calculating the volume, using the formula and the values entered. 
                double volume =  4.0/3.0 * pi * radius_cubed;
                //clearing this text box so that answers can be more clear. 
                textBox8.Clear();
                //putting the answer into the answer box. 
                textBox8.Text = volume.ToString("0.000");

            }
            catch
            {
              //the message that will show up as a result of errors, utilising the try-catch incase of errors.
                MessageBox.Show("Type a value into the radius which is valid.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //using try-catch to catch any input errors.
            try
            {
                //making the code more readable by entering this, the computer will now recognise ''pi'' as the acutal value of pi.
                double pi = Math.PI;
                //reading the values for radius and height. 
                double radius = double.Parse(textBox10.Text);
               double height = double.Parse(textBox9.Text);
                //using the math commands to use indicies, simplifying the code.
              double radius_squared = Math.Pow(radius, 2);
               double height_squared = Math.Pow(height, 2);
                //putting the square root part of the formula into a single word, including the inside part of the root. 
                double root = Math.Sqrt(height_squared + radius_squared);
                //calculating the surface area of the values put in. 
                double surface_area = pi * radius * (radius + root);
                //clearing the answer text box so that answers become stand out and dont stay in the box.
                textBox11.Clear();
                //putting the answer into the answer box which has been set to clear once the button has been pressed again with new values. 
                textBox11.Text = surface_area.ToString("0.000");
                //calculating the volume, again using the numbers entered into the text boxes which can be interacted with.
                double volume = 1.0/3.0 * pi * radius_squared * height;
                //clearing the text box each time the button is pressed again,so the answer box doesn't become jammed with different answers merging as one. 
                textBox12.Clear();
                //putting the answer into the text box.
                textBox12.Text = volume.ToString("0.000");
            }
            catch
            {
             //the message that will show up as a result of errors, utilising the try-catch incase of errors.
            MessageBox.Show("Type a value into the radius and height which is valid.");
            }
        }
    }
}
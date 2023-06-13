using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double height;
        double weight;
        double BMI;
        bool isMan;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            height = Convert.ToDouble(height1.Text) / 100;
            weight = Convert.ToDouble(weight1.Text);
            BMI = Math.Round(weight / (height * height));
            trackBar1.Value = Convert.ToInt32(BMI);
            if(trackBar1.Value < 19)
            {
                if (isMan == true)
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\ЬШ\\Downloads\\BMI calc\\bmi-underweight-icon.png");
                    labelCondition.Text = "Недостаточный";
                }
                else
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\ЬШ\\Downloads\\BMI calc\\marathon-skills-2016-gender-icons\\female-icon.png");
                    labelCondition.Text = "Недостаточный";
                }
            }
            if(trackBar1.Value >= 19 && trackBar1.Value < 25)
            {   
                if (isMan == true) 
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\ЬШ\\Downloads\\BMI calc\\bmi-healthy-icon.png");
                    labelCondition.Text = "Здоровый";
                }
                else
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\ЬШ\\Downloads\\BMI calc\\marathon-skills-2016-gender-icons\\female-icon.png");
                    labelCondition.Text = "Здоровый";
                }
                
            }
            if(trackBar1.Value >=25 && trackBar1.Value < 30)
            {
                if (isMan == true)
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\ЬШ\\Downloads\\BMI calc\\bmi-overweight-icon.png");
                    labelCondition.Text = "Избыточный";
                }
                else
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\ЬШ\\Downloads\\BMI calc\\marathon-skills-2016-gender-icons\\female-icon.png");
                    labelCondition.Text = "Избыточный";
                }

            }
            if(trackBar1.Value >= 30)
            {
                if (isMan == true)
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\ЬШ\\Downloads\\BMI calc\\bmi-obese-icon.png");
                    labelCondition.Text = "Ожирение";
                }
                else
                {
                    pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\ЬШ\\Downloads\\BMI calc\\marathon-skills-2016-gender-icons\\female-icon.png");
                    labelCondition.Text = "Ожирение";
                }
            }
        }

        private void weight1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            weight1.Text = null;
            height1.Text = null;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\ЬШ\\Downloads\\BMI calc\\marathon-skills-2016-gender-icons\\female-icon.png");
            isMan = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox.Image = System.Drawing.Image.FromFile("C:\\Users\\ЬШ\\Downloads\\BMI calc\\marathon-skills-2016-gender-icons\\male-icon.png");
            isMan = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public object TextBox1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            float h = Convert.ToInt32(textBox1.Text);
            float m = Convert.ToInt32(textBox2.Text);
            h = Convert.ToInt32(h/100);
            float bmi = m / (h * h);
            label11.Text = Convert.ToString(bmi);

            if (bmi <= 18.5) { label11.Text = "Недостаточный вес";  }
            else if (bmi > 18.5 && bmi <= 24.9) { label11.Text = "Здоровый вес"; }
            else if (bmi > 24.9 && bmi <= 29.9) { label11.Text = "Избыточный вес"; }
            else { label11.Text = "Ожирение"; }

            if (bmi < 50 ) { trackBar1.Value = Convert.ToInt32(bmi); }
            else { trackBar1.Value = 50; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null; 
            textBox2.Text = null;
        }

        private void clear()
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox2.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

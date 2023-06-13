using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Text = "МЦК Лужники";
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox9.Visible = false;
            label1.Visible = true; label2.Visible = true; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name.Text = "Новодевичей монастырь";;
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox9.Visible = false;
            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name.Text = "Метро Киевская";
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox9.Visible = false;
            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = false; label5.Visible = false; label6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            name.Text = "МИД";
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox9.Visible = true;
            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = false; label5.Visible = false; label6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            name.Text = "Парк Горького";
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = false; pictureBox9.Visible = false;
            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = false; label6.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            name.Text = "Здания РАН";
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = false; pictureBox5.Visible = false; pictureBox9.Visible = false;
            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = false; label5.Visible = false; label6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            name.Text = "Метро Воробевы горыи";
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox9.Visible = false;
            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            name.Text = "Стадион Лужники";
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; pictureBox5.Visible = true; pictureBox9.Visible = false;
            label1.Visible = true; label2.Visible = true; label3.Visible = true; label4.Visible = true; label5.Visible = true; label6.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            name.Text = "Старт гонки";
            invis();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            name.Text = "Старт гонки";
            invis();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            name.Text = "Старт гонки";
            invis();
        }

        private void invis() {
            pictureBox1.Visible = false; pictureBox2.Visible = false; pictureBox3.Visible = false; pictureBox4.Visible = false; pictureBox5.Visible = false;
            pictureBox9.Visible = false; label1.Visible = false; label2.Visible = false; label3.Visible = false; label4.Visible = false; label5.Visible = false; label6.Visible = false;
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

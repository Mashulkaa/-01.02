using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           richTextBox1.Cut();
           richTextBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Open_CLick_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox1.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь кнему.
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаемсодержимое файла в richTextBox
}

        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251));
            }
            richTextBox1.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox1.DeselectAll();
        }

        private void поЛевойСторонеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox1.DeselectAll();
        }

        private void поПравойСторонеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Select();
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox1.DeselectAll();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void pageSetupDialog1_HelpRequest(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void printDialog1_HelpRequest(object sender, EventArgs e)
        {
           

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void About_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Программа для редактирования текста  печати текста на принтере v.0.0.1");

        }

        private void button10_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox1.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь кнему.
                richTextBox1.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаемсодержимое файла в richTextBox
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Blue;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox1.SelectedRtf = Clipboard.GetText(TextDataFormat.Rtf);
            }
            else if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                richTextBox1.SelectedText = Clipboard.GetText(TextDataFormat.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            richTextBox1.SelectionColor = color;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] fonts = { "Arial", "Times New Roman", "Verdana", "Calibri", "Comic Sans MS" };
            int index = random.Next(fonts.Length);
            Font font = new Font(fonts[index], richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            richTextBox1.SelectionFont = font;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.DefaultExt = ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBox1.Text, Encoding.GetEncoding(1251));
            }
            richTextBox1.Clear();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = richTextBox1.Font;
            float lineHeight = font.GetHeight(e.Graphics);
            float y = e.MarginBounds.Top;
            string text = richTextBox1.Text;
            int charsPerPage = (int)(e.MarginBounds.Height / lineHeight);
            int startIndex = 0;
            while (startIndex < text.Length)
            {
                int endIndex = startIndex + charsPerPage;
                if (endIndex > text.Length)
                {
                    endIndex = text.Length;
                }
                string pageText = text.Substring(startIndex, endIndex - startIndex);
                e.Graphics.DrawString(pageText, font, Brushes.Black, e.MarginBounds.Left, y);
                y += lineHeight;
                startIndex += charsPerPage;
            }
        }

       

        private void предварительныйПросмотрToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            richTextBox1.SelectionColor = color;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] fonts = { "Arial", "Times New Roman", "Verdana", "Calibri", "Comic Sans MS" };
            int index = random.Next(fonts.Length);
            Font font = new Font(fonts[index], richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            richTextBox1.SelectionFont = font;
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            richTextBox1.Clear();
        }

        private void печатьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}

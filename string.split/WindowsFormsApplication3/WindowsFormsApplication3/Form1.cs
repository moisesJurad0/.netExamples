using System;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox5.Clear();
            foreach (var item in richTextBox1.Text.Split(textBox1.Text.ToCharArray()))
            {
                richTextBox5.Text += item + "-";
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            richTextBox5.Clear();
            foreach (var item in richTextBox2.Text.Split(textBox2.Text.ToCharArray()))
            {
                richTextBox5.Text += item + "-";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox5.Clear();
            foreach (var item in richTextBox3.Text.Split(textBox3.Text.ToCharArray()))
            {
                richTextBox5.Text += item + "-";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox5.Clear();
            foreach (var item in richTextBox4.Text.Split(textBox4.Text.ToCharArray()))
            {
                richTextBox5.Text += item + "-";
            }
        }
    }
}
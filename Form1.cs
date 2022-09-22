using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] currencies = { "UAH", "USD", "EUR", "RUB" };
            listBox1.Items.AddRange(currencies);
            listBox2.Items.AddRange(currencies);

            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string валюта1, валюта2;
            if  ( textBox2.Text == "")
            {
                валюта1 = listBox1.SelectedItem.ToString();
            }
            else
            {
                валюта1 = textBox2.Text;
            }
            if (textBox3.Text == "")
            {
                валюта2 = listBox2.SelectedItem.ToString();
            }
            else
            {
                валюта2 = textBox3.Text;
            }
            if (валюта1 == валюта2)
            {
                MessageBox.Show("Це одна й та ж валюта. Конвертація неможлива!", "Увага!");
            }
            else if ( textBox1.Text == "")
            {
                MessageBox.Show("Уведіть кількість валюти для конвертації!", "Увага!");
            }
            else
            {
                webBrowser1.Navigate("https://www.google.com/search?q=" + textBox1.Text + " " + валюта1 + " %D0%B2" + валюта2);

            }
        }

    }
}

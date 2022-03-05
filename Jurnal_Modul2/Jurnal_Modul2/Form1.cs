using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurnal_Modul2
{
    public partial class Form1 : Form
    {
        string pertama = "";
        string kedua = "";
        char function;
        double result = 0.0;
        string userInput = "";
      
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "2";
            textBox1.Text += userInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "3";
            textBox1.Text += userInput;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "4";
            textBox1.Text += userInput;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "5";
            textBox1.Text += userInput;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "6";
            textBox1.Text += userInput;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "7";
            textBox1.Text += userInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "8";
            textBox1.Text += userInput;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "9";
            textBox1.Text += userInput;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "0";
            textBox1.Text += userInput;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            function = "+";
            pertama = userInput;
            userInput = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kedua = userInput;
            double pertamaNUm, keduaNUm;
            pertamaNUm = Convert.ToDouble(pertama);
            keduaNUm = Convert.ToDouble(kedua);

            if (function == "+")
            {
                result = pertamaNUm + keduaNUm;
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            userInput += "1";
            textBox1.Text += userInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

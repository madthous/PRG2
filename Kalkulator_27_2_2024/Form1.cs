using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_27_2_2024
{
    public partial class Form1 : Form
    {
        public bool blemc = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            blemc = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            blemc = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            blemc = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            blemc = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            blemc = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            blemc = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            blemc = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            blemc = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            blemc = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            blemc = true;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (blemc)
            {
                textBox1.Text += "÷";
                blemc = false;
            }
        }
        private void buttonMulti_Click(object sender, EventArgs e)
        {
            if (blemc)
            {
                textBox1.Text += "×";
                blemc = false;
            }
        }
        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (blemc)
            {
                textBox1.Text += "-";
                blemc = false;
            }
        }
        private void buttonAddit_Click(object sender, EventArgs e)
        {
            if (blemc)
            {
                textBox1.Text += "+";
                blemc = false;
            }
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string tmp;
            List<char> radek = new List<char>(); 
            foreach (char character in textBox1.Text)
            {
                radek.Add(character);
            }
            List<int> bramborcisla = new List<int>();
            for (int i = 0; i < radek.Count; i++)
            {
                switch (radek[i])
                {
                    case(char) 1:
                        tmp += "1";
                       break;

                    default:
                        break;
                            }
            }
            List<int> bramborznaky = new List<int>();
        }
    }
}

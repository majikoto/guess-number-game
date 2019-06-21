using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        private int rightCount = 0;
        private int failedCount = 0;
        private int inputErrorCount = 0;
        private Random randomBuilder = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 1) return;
            int inputNumber; 
            if(int.TryParse(textBox1.Text,out inputNumber))
            {
                if(inputNumber<1||inputNumber>3)
                {
                    inputErrorCount++;
                }
                else if(inputNumber==randomBuilder.Next(1,4))
                {
                    rightCount++;
                }
                else
                {
                    failedCount++;
                }
            }
            else
            {
                inputErrorCount++;
            }
            textBox2.Text = rightCount.ToString();
            textBox3.Text = failedCount.ToString();
            textBox4.Text = inputErrorCount.ToString();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

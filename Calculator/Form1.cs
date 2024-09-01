using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string expression;

        private void Calc()//read value
        {
           expression= textBox1.Text;
        }

        private void sUM_Click(object sender, EventArgs e)//submit button
        {
            Calc();
            var result = new DataTable().Compute(expression, null);
            //double d=double.Parse(result.ToString());
            textBox1.Text = $"{result}";
        }

        private void aDD_Click(object sender, EventArgs e)//add button
        {
            Calc();
            expression += "+";
            textBox1.Text = $"{expression}";
        }

        private void sUB_Click(object sender, EventArgs e)//substract button
        {
            Calc();
            expression += "-";
            textBox1.Text = $"{expression}";
        }

        private void mulTI_Click(object sender, EventArgs e)//multiplication button
        {
            Calc();
            expression += "*";
            textBox1.Text = $"{expression}";
        }

        private void dIV_Click(object sender, EventArgs e)//divstion button
        {
            Calc();
            expression += "/";
            textBox1.Text = $"{expression}";
        }

        private void mOD_Click(object sender, EventArgs e)//mod
        {
            Calc();
            expression += "%";
            textBox1.Text = $"{expression}";

        }

        private void produCT_Click(object sender, EventArgs e)//squer
        {
            Calc();
            //expression="";
            double d = double.Parse(expression.ToString());
            double square = Math.Pow(d, 2);
            textBox1.Text = $"{square}";
        }

        private void cleAR_Click(object sender, EventArgs e)//clear
        {
            Calc();
            expression = "";
            textBox1.Text = $"{expression}";
        }

        private void oNE_Click(object sender, EventArgs e)//one
        {
            Calc(); 
            expression += "1";
            textBox1.Text = $"{expression}";
        }

        private void tWO_Click(object sender, EventArgs e)//two
        {
            Calc();
            expression += "2";
            textBox1.Text = $"{expression}";
        }

        private void thrEE_Click(object sender, EventArgs e)//three
        {
            Calc();
            expression += "3";
            textBox1.Text = $"{expression}";
        }

        private void foUR_Click(object sender, EventArgs e)//four
        {
            Calc();
            expression += "4";
            textBox1.Text = $"{expression}";
        }

        private void button6_Click(object sender, EventArgs e)//five
        {
            Calc();
            expression += "5";
            textBox1.Text = $"{expression}";
        }
        private void sIX_Click(object sender, EventArgs e)//six
        {
            Calc();
            expression += "6";
            textBox1.Text = $"{expression}";
        }

        private void sevEN_Click(object sender, EventArgs e)//seven
        {
            Calc();
            expression += "7";
            textBox1.Text = $"{expression}";
        }

        private void eigHT_Click(object sender, EventArgs e)//eight
        {
            Calc();
            expression += "8";
            textBox1.Text = $"{expression}";
        }

        private void niNE_Click(object sender, EventArgs e)//nine
        {
            Calc();
            expression += "9";
            textBox1.Text = $"{expression}";
        }

        private void zeRO_Click(object sender, EventArgs e)//zero
        {
            Calc();
            expression += "0";
            textBox1.Text = $"{expression}";
        }

        private void dOT_Click(object sender, EventArgs e)//dot
        {
            Calc();
            expression += ".";
            textBox1.Text = $"{expression}";
        }

        

        private void baCK_Click(object sender, EventArgs e)//back
        {
            //Calc();
            //expression = "^";
            //textBox1.Text = $"{expression}";
           int index = textBox1.TextLength;
            if (index > 0)
            {
                textBox1.Text = textBox1.Text.Remove(index - 1, 1); // Remove one character
                textBox1.Select(index - 1, 0); // Move cursor back
            }
        }

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}

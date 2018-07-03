using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstValuetext = textBox1.Text; 
            double firstValue = Convert.ToDouble(firstValuetext);
            string secondValuetext = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValuetext);
            double result = secondValue + firstValue;
            textBox3.Text = result.ToString();
        }
    }
}

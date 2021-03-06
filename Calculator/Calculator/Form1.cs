﻿using System;
using System.Windows.Forms;
using Calculator.OneArgument;
using Calculator.TwoArgument;

namespace Calculator
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }
        private void Click(object sender, EventArgs e)
        {
            try
            {
                string firstValuetext = textBox1.Text;
                double firstValue = Convert.ToDouble(firstValuetext);
                string secondValuetext = textBox2.Text;
                double secondValue = Convert.ToDouble(secondValuetext);
                string caluclateName = ((Button) sender).Name;
                ICalculateTwoArguments calculator = CalculatorTwoFactory.CreateCalculator(caluclateName);
                double result = calculator.Calculator(firstValue, secondValue);
                textBox3.Text = result.ToString();
            }
            catch(Exception TwoArgumentException)
            {
                MessageBox.Show("Неверное выражение" + TwoArgumentException);
            }
        }
        private void Click1(object sender, EventArgs e)
        {
            try
            {
                string firstValuetext = textBox1.Text;
                double firstValue = Convert.ToDouble(firstValuetext);
                string caluclateName = ((Button) sender).Name;
                ICalculatorOneArgument calculator1 = CalculatorOneFactory.CreateCalculator(caluclateName);
                double result = calculator1.Calculator(firstValue);
                textBox3.Text = result.ToString();
            }
            catch (Exception OneArgumentException)
            {
                MessageBox.Show("Неверное выражение" + OneArgumentException);
            }
        } 
    }
}

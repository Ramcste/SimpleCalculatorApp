using System;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class Form1 : Form
    {
        private double firstNumber;

        private double secondNumber;

        private double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(firstNumberTextBox.Text);
            secondNumber = double.Parse(secondNumbertextBox.Text);
            result = firstNumber + secondNumber;

            resultTextBox.Text = result.ToString();
    

        }

        private void subtractionButton_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(firstNumberTextBox.Text);
            secondNumber = double.Parse(secondNumbertextBox.Text);
            result = firstNumber - secondNumber;

            resultTextBox.Text = result.ToString();
         
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(firstNumberTextBox.Text);
            secondNumber = double.Parse(secondNumbertextBox.Text);
            result = firstNumber * secondNumber;

            resultTextBox.Text = result.ToString();
            
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(firstNumberTextBox.Text);
            secondNumber = double.Parse(secondNumbertextBox.Text);
            result = firstNumber / secondNumber;

            resultTextBox.Text = result.ToString();
         
        }

      
    }
}

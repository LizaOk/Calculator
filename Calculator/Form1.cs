using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    { 
        public Calculator()
        {
            InitializeComponent();
        }

        private string operation = "";


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        static double EnterNumbers()
        {
            string line = Console.ReadLine();
            double number = Convert.ToDouble(line);

            return number;
        }

        double number1 = EnterNumbers();
        double number2 = EnterNumbers();

      
        private void button10_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "3";
             
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "6";
             
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "7";
             
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "/";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "*";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "2";
             
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "4";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "5";
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "8";
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "9";
             
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += ".";
             
        }

        private void buttonRubber_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNumbers.Text))
            {
                textBoxNumbers.Text = textBoxNumbers.Text.Remove(textBoxNumbers.Text.Length - 1);
            }
        }


        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "-";
        }     

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text += "+";
             
        }

        private void buttonEquality_Click(object sender, EventArgs e)
        {
            string expression = textBoxNumbers.Text;

            int operationIndex = expression.IndexOfAny(new char[] { '+', '-', '*', '/' });

            if (operationIndex == -1 || operationIndex == 0 || operationIndex == expression.Length - 1)
            {
                MessageBox.Show("Invalid expression format!");
                return;
            }

            double.TryParse(expression.Substring(0, operationIndex), out number1);
            double.TryParse(expression.Substring(operationIndex + 1), out number2);

            operation = expression[operationIndex].ToString();
            switch (operation)
            {
                case "+":
                    textBoxNumbers.Text = (number1 + number2).ToString();
                    break;

                case "-":
                    textBoxNumbers.Text = (number1 - number2).ToString();
                    break;

                case "*":
                    textBoxNumbers.Text = (number1 * number2).ToString();
                    break;

                case "/":
                    if (number2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero!");
                    }
                    else
                    {
                        textBoxNumbers.Text = (number1 / number2).ToString();
                    }
                    break;

                default:
                    MessageBox.Show("Error! Invalid operation.");
                    break;
            }
            
        }

        private void buttonCleanAll_Click(object sender, EventArgs e)
        {
            textBoxNumbers.Text = "";
        }
    }
    
}

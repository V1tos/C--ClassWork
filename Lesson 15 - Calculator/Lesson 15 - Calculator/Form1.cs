using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_15___Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string firstOperand = String.Empty;
        string secondOperand = String.Empty;
        string operaTor = String.Empty;
        double result = 0;
        bool isFirstOperand = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            firstOperand = "0";
            textDisplay.Focus();
            textDisplay.Text = firstOperand;           
        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            Button currentDigit = sender as Button;
            if (isFirstOperand)
            {
                if (firstOperand == "0")
                    firstOperand = firstOperand.Remove(firstOperand.Length - 1);

                firstOperand += currentDigit.Text;
                textDisplay.Text = firstOperand;
                return;
            }

            if (secondOperand == "0")
                secondOperand = secondOperand.Remove(secondOperand.Length - 1);

            secondOperand += currentDigit.Text;
            textDisplay.Text = firstOperand + operaTor + Environment.NewLine + secondOperand;          
        }


        private void buttonOperator_Click(object sender, EventArgs e)
        {
            Button currentOperator = sender as Button;
            if (isFirstOperand&&firstOperand != String.Empty)
            {
                operaTor = currentOperator.Text;              
                isFirstOperand = !isFirstOperand;
            }
            else if (!isFirstOperand && operaTor == currentOperator.Text)
            {
                firstOperand = ResultOperation(operaTor).ToString();
            }
            else
            {
                firstOperand = ResultOperation(operaTor).ToString();
                operaTor = currentOperator.Text;
            }
            secondOperand = "0";
            textDisplay.Text = firstOperand + operaTor + Environment.NewLine + secondOperand;
        }    

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (isFirstOperand)
                return;   
            
            result = ResultOperation(operaTor);
            textDisplay.Text = firstOperand + " " + operaTor + " " + secondOperand + " = " + result.ToString();
            firstOperand = result.ToString();
            secondOperand = String.Empty;
            isFirstOperand = true;
        }

        private double ResultOperation(string operaTor)
        {
            double first = double.Parse(firstOperand);
            double second = double.Parse(secondOperand);
            switch (operaTor)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "*":
                    return first * second;
                case "/":
                    return first / second;
                default:
                    return 0;
            }
        }

        

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (isFirstOperand)
            {
                if (firstOperand == "")
                {
                    textDisplay.Text = "0";
                    return;
                }
                else if (firstOperand.Length == 1)
                {
                    firstOperand = firstOperand.Remove(firstOperand.Length - 1);
                    textDisplay.Text = "0";
                    return;
                }
                firstOperand = firstOperand.Remove(firstOperand.Length-1);           
            }
            else
            {
                if (secondOperand == "")
                {
                    secondOperand = "0";
                    textDisplay.Text = firstOperand + operaTor + Environment.NewLine + secondOperand;
                    return;
                }
                else if (secondOperand.Length == 1)
                {
                    secondOperand = secondOperand.Remove(secondOperand.Length - 1);
                    secondOperand = "0";
                    textDisplay.Text = firstOperand + operaTor + Environment.NewLine + secondOperand;
                    return;
                }
                secondOperand = secondOperand.Remove(secondOperand.Length - 1);               
            }
            textDisplay.Text = firstOperand + operaTor + Environment.NewLine + secondOperand;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (isFirstOperand)
            {
                firstOperand = String.Empty;
                textDisplay.Text = "0";
            }
            else
            {
                secondOperand = "0";
                textDisplay.Text = firstOperand + operaTor + Environment.NewLine + secondOperand;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            firstOperand = secondOperand = operaTor = String.Empty;
            textDisplay.Text = "0";
            result = 0;
            isFirstOperand = true;
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                    buttonDigit_Click(button1, null);
                    break;
                case Keys.D2:
                    buttonDigit_Click(button2, null);
                    break;
                case Keys.D3:
                    buttonDigit_Click(button3, null);
                    break;
                case Keys.D4:
                    buttonDigit_Click(button4, null);
                    break;
                case Keys.D5:
                    buttonDigit_Click(button5, null);
                    break;
                case Keys.D6:
                    buttonDigit_Click(button6, null);
                    break;
                case Keys.D7:
                    buttonDigit_Click(button7, null);
                    break;
                case Keys.D8:
                    buttonDigit_Click(button8, null);
                    break;
                case Keys.D9:
                    buttonDigit_Click(button9, null);
                    break;
                case Keys.D0:
                    buttonDigit_Click(button0, null);
                    break;
                case Keys.Add:
                    buttonOperator_Click(buttonPlus, null);
                    break;
                case Keys.Subtract:
                    buttonOperator_Click(buttonMinus, null);
                    break;
                case Keys.Multiply:
                    buttonOperator_Click(buttonMult, null);
                    break;
                case Keys.Divide:
                    buttonOperator_Click(buttonDiv, null);
                    break;
                case Keys.ShiftKey:
                    buttonResult_Click(null, null);
                    break;
                case Keys.Back:
                    buttonBackSpace_Click(null, null);
                    break;
                case Keys.Oemcomma:
                    buttonDigit_Click(buttonDec, null);
                    break;
                case Keys.F9:
                    buttonOpChange_Click(null, null);
                    break;
                default:
                    break;
            }
            Refresh();
        }

        private void buttonOpChange_Click(object sender, EventArgs e)
        {

            if (isFirstOperand)
            {
                firstOperand = ChangeSign(firstOperand);
            }
            else
            {
                secondOperand = ChangeSign(secondOperand);
            }

            textDisplay.Text = firstOperand + operaTor + Environment.NewLine + secondOperand;
        }

        private string ChangeSign(string operand)
        {          
         
            double tmpOperand = double.Parse(operand);
            operand = String.Empty;
            if (tmpOperand > 0)
            {
                operand = $"-{tmpOperand.ToString()}";
            }
            else
            {
                tmpOperand = (-tmpOperand);
                operand = tmpOperand.ToString();
            }
            return operand;
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {            
            if (isFirstOperand)
            {
                if (IsDecimal(firstOperand))
                    return;
                
                firstOperand += buttonDec.Text;
                textDisplay.Text = firstOperand;
                return;
            }

            if (IsDecimal(secondOperand))
                return;

            secondOperand += buttonDec.Text;
            textDisplay.Text = firstOperand + operaTor + Environment.NewLine + secondOperand;
        }

        private bool IsDecimal(string operand)
        {
            bool dec = false;
            foreach (char item in operand)
            {
                if (item == '.')
                    dec = true;
            }
            return dec;
        }
    }
}

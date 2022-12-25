using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double result;
        public char lastOperator;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txbTask.Text == "")
                txbResult.Text = string.Empty;
            else
            {
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) != '=')
                    txbResult.Text = string.Empty;
                else
                {
                    txbResult.Text = string.Empty;
                    txbTask.Text = String.Empty;
                }
            }

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txbResult.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txbResult.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txbResult.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txbResult.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txbResult.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txbResult.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txbResult.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txbResult.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txbResult.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txbResult.Text += "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txbResult.Text == "")
                txbResult.Text += "0.";
            else
            {
                if (!txbResult.Text.Contains('.'))
                    txbResult.Text += ".";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            bool access = true;

            if (txbResult.Text == "" && txbTask.Text == "")
                access = false;
            if (txbTask.Text != "")
            {
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '+' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '-' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '*' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '/' && txbResult.Text == "")
                    access = false;
            }

            if (access)
            {
                if (txbTask.Text == "")
                    result = Convert.ToDouble(txbResult.Text);
                else switch (lastOperator)
                    {
                        case '+':
                            result += Convert.ToDouble(txbResult.Text);
                            break;
                        case '-':
                            result -= Convert.ToDouble(txbResult.Text);
                            break;
                        case '*':
                            result *= Convert.ToDouble(txbResult.Text);
                            break;
                        case '/':
                            result /= Convert.ToDouble(txbResult.Text);
                            break;
                        default:
                            break;
                    }
                txbTask.Text = result.ToString() + "+";
                lastOperator = '+';
                txbResult.Clear();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            bool access = true;

            if (txbResult.Text == "" && txbTask.Text == "")
                access = false;
            if (txbTask.Text != "")
            {
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '+' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '-' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '*' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '/' && txbResult.Text == "")
                    access = false;
            }

            if (access)
            {
                if (txbTask.Text == "")
                    result = Convert.ToDouble(txbResult.Text);
                else switch (lastOperator)
                    {
                        case '+':
                            result += Convert.ToDouble(txbResult.Text);
                            break;
                        case '-':
                            result -= Convert.ToDouble(txbResult.Text);
                            break;
                        case '*':
                            result *= Convert.ToDouble(txbResult.Text);
                            break;
                        case '/':
                            result /= Convert.ToDouble(txbResult.Text);
                            break;
                        default:
                            break;
                    }
                txbTask.Text = result.ToString() + "-";
                lastOperator = '-';
                txbResult.Clear();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            bool access = true;

            if (txbResult.Text == "" && txbTask.Text == "")
                access = false;
            if (txbTask.Text != "")
            {
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '+' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '-' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '*' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '/' && txbResult.Text == "")
                    access = false;
            }

            if (access)
            {
                if (txbTask.Text == "")
                    result = Convert.ToDouble(txbResult.Text);
                else switch (lastOperator)
                    {
                        case '+':
                            result += Convert.ToDouble(txbResult.Text);
                            break;
                        case '-':
                            result -= Convert.ToDouble(txbResult.Text);
                            break;
                        case '*':
                            result *= Convert.ToDouble(txbResult.Text);
                            break;
                        case '/':
                            result /= Convert.ToDouble(txbResult.Text);
                            break;
                        default:
                            break;
                    }
                txbTask.Text = result.ToString() + "*";
                lastOperator = '*';
                txbResult.Clear();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            bool access = true;

            if (txbResult.Text == "" && txbTask.Text == "")
                access = false;
            if (txbTask.Text != "")
            {
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '+' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '-' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '*' && txbResult.Text == "")
                    access = false;
                if (txbTask.Text.ElementAt(txbTask.Text.Length - 1) == '/' && txbResult.Text == "")
                    access = false;
            }

            if (access)
            {
                if (txbTask.Text == "")
                    result = Convert.ToDouble(txbResult.Text);
                else switch (lastOperator)
                    {
                        case '+':
                            result += Convert.ToDouble(txbResult.Text);
                            break;
                        case '-':
                            result -= Convert.ToDouble(txbResult.Text);
                            break;
                        case '*':
                            result *= Convert.ToDouble(txbResult.Text);
                            break;
                        case '/':
                            result /= Convert.ToDouble(txbResult.Text);
                            break;
                        default:
                            break;
                    }
                txbTask.Text = result.ToString() + "/";
                lastOperator = '/';
                txbResult.Clear();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (!txbTask.Text.Contains('='))
                if (!(txbTask.Text == ""))
                    if (!(txbResult.Text == ""))
                    {
                        switch (lastOperator)
                        {
                            case '+':
                                result += Convert.ToDouble(txbResult.Text);
                                break;
                            case '-':
                                result -= Convert.ToDouble(txbResult.Text);
                                break;
                            case '*':
                                result *= Convert.ToDouble(txbResult.Text);
                                break;
                            case '/':
                                result /= Convert.ToDouble(txbResult.Text);
                                break;
                            default:
                                break;
                        }
                        txbTask.Text += txbResult.Text + "=";
                        txbResult.Text = result.ToString();
                    }

        }
    }
}

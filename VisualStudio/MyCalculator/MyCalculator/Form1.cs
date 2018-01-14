using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Calculator : Form
    {
        String displayChar, operation, firstNum, secondNum, resultS;
        float num1, num2, result;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void display_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if(display.Text!="0")
            {
                display.Text += "0";
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            if(display.Text=="0")
            {
                display.Clear();
            }
            display.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            display.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            display.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            display.Text += "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            display.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            display.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            display.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            display.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (display.Text == "0")
            {
                display.Clear();
            }
            display.Text += "9";
        }

        private void point_Click(object sender, EventArgs e)
        {
            display.Text += ".";
        }

        private void clear1char_Click(object sender, EventArgs e)
        {
            if(display.Text!="")
            {
                displayChar = display.Text;
                display.Text = displayChar.Remove(displayChar.Length - 1);
            }
        }

        private void root_Click(object sender, EventArgs e)
        {
            firstNum = display.Text;
            num1 = float.Parse(firstNum);
            result = (float)(Math.Sqrt(num1));
            resultS = result.ToString();
            display.Text = resultS;
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            operation = "%";
            firstNum = display.Text;
            num1 = float.Parse(firstNum);
            display.Text = "";
        }

        private void square_Click(object sender, EventArgs e)
        {
            firstNum = display.Text;
            num1 = float.Parse(firstNum);
            result = (float)(Math.Pow(num1,2));
            resultS = result.ToString();
            display.Text = resultS;
        }

        private void bin_Click(object sender, EventArgs e)
        {
            firstNum = display.Text;
            int dec = Int32.Parse(firstNum);
            //result = (float)(Math.Pow(num1, 2));
            string binary = Convert.ToString(dec, 2);
            resultS = binary.ToString();
            display.Text = resultS;
        }

        private void add_Click(object sender, EventArgs e)
        {
            operation = "+";
            firstNum = display.Text;
            num1 = float.Parse(firstNum);
            display.Text = "";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            operation = "-";
            firstNum = display.Text;
            num1 = float.Parse(firstNum);
            display.Text = "";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            operation = "*";
            firstNum = display.Text;
            num1 = float.Parse(firstNum);
            display.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            operation = "/";
            firstNum = display.Text;
            num1 = float.Parse(firstNum);
            display.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    {
                        secondNum = display.Text;
                        num2 = float.Parse(secondNum);
                        result = num1 + num2;
                        resultS = result.ToString();
                        display.Text = resultS;
                        break;
                    }
                    
                case "-":
                    {
                        secondNum = display.Text;
                        num2 = float.Parse(secondNum);
                        result = num1 - num2;
                        resultS = result.ToString();
                        display.Text = resultS;
                        break;
                    }

                case "*":
                    {
                        secondNum = display.Text;
                        num2 = float.Parse(secondNum);
                        result = num1 * num2;
                        resultS = result.ToString();
                        display.Text = resultS;
                        break;
                    }

                case "/":
                    {
                        secondNum = display.Text;
                        num2 = float.Parse(secondNum);
                        result = num1 / num2;
                        resultS = result.ToString();
                        display.Text = resultS;
                        break;
                    }
                case "%":
                    {
                        secondNum = display.Text;
                        num2 = float.Parse(secondNum);
                        result = (num2 / 100) * num1;
                        resultS = result.ToString();
                        display.Text = resultS;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }
    }
}

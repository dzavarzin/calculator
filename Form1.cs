using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Calculator.Model;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double number1 = 0;
        public double number2 = 0;
        public string op = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // save the number and the operation
            number1 = Convert.ToDouble(tbx_Number.Text);
            op = "+";
            tbx_Number.Text = "";
            tbx_Number.Focus();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(tbx_Number.Text);
            op = "-";
            tbx_Number.Text = "";
            tbx_Number.Focus();
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(tbx_Number.Text);
            op = "*";
            tbx_Number.Text = "";
            tbx_Number.Focus();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(tbx_Number.Text);
            op = "/";
            tbx_Number.Text = "";
            tbx_Number.Focus();
        }


        private void clear_button_Click(object sender, EventArgs e)
        {
            Calc.Clear();
            tbx_Result.Text = Calc.GetResult().ToString();
            tbx_Number.Text = Calc.GetResult().ToString();
            tbx_Number.Focus();
        }

        private void tbx_Number_TextChanged(object sender, EventArgs e)
        {
            // Regex - allow to insert just number in the TextBox and a comma
            Regex reg = new Regex("^\\d*,?\\d*$");
            bool checkText = reg.IsMatch(tbx_Number.Text);

            //remove the last char if it's not a number
            if (!checkText)
            {
                tbx_Number.Text = tbx_Number.Text.Remove(tbx_Number.Text.Length - 1, 1);
                tbx_Number.SelectionStart = tbx_Number.Text.Length;
                tbx_Number.SelectionLength = 0;
            }
        }

        private void eq_button_Click(object sender, EventArgs e)
        {
            double number2 = Convert.ToDouble(tbx_Number.Text);

            //choose the operation to do
            switch (op)
            {
                case "+":
                    Calc.Add(number1, number2);
                    break;
                case "-":
                    Calc.Substract(number1, number2);
                    break;
                case "*":
                    Calc.Multiply(number1, number2);
                    break;
                case "/":
                    Calc.Divide(number1, number2);
                    break;
                default:
                    MessageBox.Show("Try again");
                    break;
            }

            tbx_Result.Text = Calc.GetResult().ToString();
            tbx_Number.Text = Calc.GetResult().ToString();
            tbx_Number.Focus();
            tbx_Number.SelectionStart = tbx_Number.Text.Length;
            tbx_Number.SelectionLength = 0;
        }

        private void tbx_Number_KeyDown(object sender, KeyEventArgs e)
        {
            //KeyCode press
            if (e.KeyCode == Keys.Add)
                addButton_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.Subtract)
                subButton_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.Multiply)
                multButton_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.Divide)
                divButton_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.Enter)
                eq_button_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.Delete)
                clear_button_Click(this, new EventArgs());
        }
    }
}

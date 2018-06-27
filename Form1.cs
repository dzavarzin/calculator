using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Calculator calculatorProcessor;

        public Form1()
        {
            InitializeComponent();
            calculatorProcessor = new Calculator();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var number = long.Parse(tbx_Number.Text);
            calculatorProcessor.add(number);
            tbx_Result.Text = calculatorProcessor.GetResult().ToString();
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            var number = long.Parse(tbx_Number.Text);
            calculatorProcessor.substract(number);
            tbx_Result.Text = calculatorProcessor.GetResult().ToString();
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            var number = long.Parse(tbx_Number.Text);
            calculatorProcessor.multiply(number);
            tbx_Result.Text = calculatorProcessor.GetResult().ToString();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            var number = long.Parse(tbx_Number.Text);
            calculatorProcessor.divide(number);
            tbx_Result.Text = calculatorProcessor.GetResult().ToString();
        }
    }

    public class Calculator {
        private long currentResult = 0;

        public long GetResult() {
            return currentResult;
        }

        public void add(long arg) {
            //TODO: add test
            currentResult += arg;
        }

        public void substract(long arg) {
            //TODO: add test
            currentResult -= arg;
        }

        public void multiply(long arg) {
            //TODO: add test
            currentResult *= arg;
        }

        public void divide(long arg) {
            //TODO: add test
            currentResult /= arg;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void minus_btn(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int result = calculate.minus(int.Parse(first_num.Text), int.Parse(sec_num.Text));
                MessageBox.Show($"the result is {result}");
            }
                
        }

        private void plus_btn(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int result = calculate.plus(int.Parse(first_num.Text), int.Parse(sec_num.Text));
                MessageBox.Show($"the result is {result}");
            }
        }

        private void divide_btn(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int result = calculate.divide(int.Parse(first_num.Text), int.Parse(sec_num.Text));
                MessageBox.Show($"the result is {result}");
            }
        }

        private void multiple_btn(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                int result = calculate.mutiple(int.Parse(first_num.Text), int.Parse(sec_num.Text));
                MessageBox.Show($"the result is {result}");
            }
        }

        bool ValidateInputs()
        {
            bool IsValid = true;

            if (string.IsNullOrWhiteSpace(first_num.Text))
            {
                IsValid = false;
                MessageBox.Show("pls enter first number");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(sec_num.Text))
                {
                    IsValid = false;
                    MessageBox.Show("pls enter the second number");
                }
            }
            return IsValid;
        }
    }
}

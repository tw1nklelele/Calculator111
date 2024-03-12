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
        double operand1;
        double operand2;
        string opeation;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Принятия событий клавиатуры
        }

        // Обработчик события нажатия на клавиши
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                labelTextIn.Text += e.KeyChar;
            }
            else if (e.KeyChar == '+')
            {
                lbCalclutorUP.Text = labelTextIn.Text + "+";
                operand1 = Convert.ToDouble(labelTextIn.Text);
                labelTextIn.Text = "";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            labelTextIn.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            labelTextIn.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            labelTextIn.Text += "3";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lbCalclutorUP.Text = lbCalclutorUP.Text + labelTextIn.Text + "=";
            operand2 = Convert.ToDouble(labelTextIn.Text);
            labelTextIn.Text = Calculator.Addition(operand1, operand2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

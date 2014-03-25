using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcUL.BinaryOperations;

namespace CalcUL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            Hotdog("Substraction");
        }

        private void addition_Click(object sender, EventArgs e)
        {
            Hotdog("Addition");
        }

        private void division_Click(object sender, EventArgs e)
        {
           Hotdog("Division");
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            Hotdog("Multiplication");
        }

        private void Hotdog(string name)
        {
            double firstArg;
            double.TryParse(First.Text, out firstArg);
            double twoArg;
            double.TryParse(Second.Text, out twoArg);
            IBinaryOperation multi = BinaryOperationsFactory.CreateOperation(name);
            Result.Text = multi.Calc(firstArg, twoArg);
        }
    }
}

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
            double firstArg;
            double.TryParse(First.Text, out firstArg);
            double twoArg;
            double.TryParse(Second.Text, out twoArg);
            Substracter substracter = new Substracter();

            Result.Text = substracter.Calc(firstArg, twoArg);
        }

        private void addition_Click(object sender, EventArgs e)
        {
            double firstArg;
            double.TryParse(First.Text, out firstArg);
            double twoArg;
            double.TryParse(Second.Text, out twoArg);

            Adder adder = new Adder();

            Result.Text = adder.Calc(firstArg, twoArg);

        }

        private void division_Click(object sender, EventArgs e)
        {
            double firstArg;
            double.TryParse(First.Text, out firstArg);
            double twoArg;
            double.TryParse(Second.Text, out twoArg);

            Divider divider = new Divider();
            if(twoArg !=0 )
                Result.Text = divider.Calc(firstArg, twoArg);
            else
            {
                Result.Text = "Ноуп";
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            double firstArg;
            double.TryParse(First.Text, out firstArg);
            double twoArg;
            double.TryParse(Second.Text, out twoArg);

            Multiplicater muliplicater = new Multiplicater();

            Result.Text = muliplicater.Calc(firstArg, twoArg);
        }
    }
}

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
        public bool key = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void button5_Click_1(object sender, EventArgs e)//обработка числовых клавишь
        {
            Button B = sender as Button;
            key = true;
            if(Output.Text=="0" && B.Text!=".")
            {
                Output.Text = "" + B.Text;
            }
            else if (B.Text == ".")
            {
                if (!Output.Text.Contains(".")) Output.Text += B.Text;
            }
            else
            {
                Output.Text += B.Text;
            }
        }
        private void DEL_Click(object sender, EventArgs e)//удаление последней цифры
        {
            if(Output.Text.Length>1)
            {
                Output.Text = Output.Text.Remove(Output.Text.Length - 1);
            }
            else
            {
                Output.Text = "0";
            }
        }
        private void Div_Click(object sender, EventArgs e)//оработка знаков числовых операций
        {
            Button B = sender as Button;
            if(key)
            {
                Expression.Text += Output.Text + B.Text;
            }  
            if (Expression.Text.EndsWith("-") || Expression.Text.EndsWith("+")
               || Expression.Text.EndsWith("*") || Expression.Text.EndsWith("/"))
            {
                key = false;
                Expression.Text=Expression.Text.Remove(Expression.Text.Length-1).Insert(Expression.Text.Length - 1, B.Text);
            }        
           Output.Text = "0";
        }
        private void Result_Click(object sender, EventArgs e)//равно
        {   
            Expression.Text += Output.Text;
            if (Expression.Text.EndsWith("-") || Expression.Text.EndsWith("+")
                || Expression.Text.EndsWith("*") || Expression.Text.EndsWith("/"))
            {
                Output.Text = Output.Text.Remove(Output.Text.Length - 1);
            }
            Output.Text = new DataTable().Compute(Expression.Text, null).ToString();
            Expression.Text = "";
        }
        private void CE_Click(object sender, EventArgs e)//удаление текущего числа
        {
            Output.Text = "0";
        }

        private void C_Click(object sender, EventArgs e)//сброс всех операций
        {
            Output.Text = "0";
            Expression.Text = "";
        }
    }
}

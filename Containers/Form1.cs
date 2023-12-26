using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Containers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/sulinart");
            //label1.Text= label1.GetType().ToString();
        }
        private void ByRed_Click(object sender, EventArgs e)//как обратиться к свойствам sender
        {
            Form1.ActiveForm.BackColor = (System.Drawing.Color)sender.GetType().GetProperty("ForeColor").GetValue(sender, null);
            //if (sender == ByBlue) { Form1.ActiveForm.BackColor = Color.PowderBlue; }
            //if (sender == ByGreen) { Form1.ActiveForm.BackColor = Color.PaleGreen; }
            //if (sender == ByRed) { Form1.ActiveForm.BackColor = Color.LightCoral; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private const int  = 0;
        private object textBox4;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, r4, r5, seriesTotal, parallelTotal;
            try
            {
                r1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                r1 = 0;
            }

            try
            {
                r2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                r2 = 0;
            }
            try
            {
                r3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                r3 = 0;
            }
            try
            {
                r4 = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                r4 = 0;
            }
            try
            {
                r5 = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                r5 = 0;
            }
            seriesTotal = r1 + r2 + r3 + r4 + r5;
            label1.Text = "Series Total = " + seriesTotal;
            if (r1 == 0)
            {
                r1 = double.PositiveInfinity;
            }
            if (r2 == 0)
            {
                r2 = double.PositiveInfinity;
            }
            if (r3 == 0)
            {
                r3 = double.PositiveInfinity;
            }
            if (r4 == 0)
            {
                r4 = double.PositiveInfinity;
            }
            if (r5 == 0)
            {
                r5 = double.PositiveInfinity;
            }
            parallelTotal = 1/(1/r1 + 1/r2 + 1/r3 + 1/r4 + 1/r5);
            label2.Text = "parallel Total = " + parallelTotal;
        }
    }
}


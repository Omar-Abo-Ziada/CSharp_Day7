using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (MeterToKilometer.Checked)
            {
                if (ValueTextBox.TextLength != 0)
                {
                    //int meters = Convert.ToInt32(ValueTextBox.Text);
                    decimal.TryParse(ValueTextBox.Text, out decimal meters);
                    decimal kilometers = meters / 1000;
                    ResultTextBox.Text = kilometers.ToString();
                }
                else
                {
                    ResultTextBox.Text = "Enter a value first ! ";
                }
            }
            else if (MeterToDecemeter.Checked)
            {
                if (ValueTextBox.TextLength != 0)
                {
                    //int meters = Convert.ToInt32(ValueTextBox.Text);
                    decimal.TryParse(ValueTextBox.Text, out decimal meters);
                    decimal decemeters = meters * 10 ;
                    ResultTextBox.Text = decemeters.ToString();
                }
                else
                {
                    ResultTextBox.Text = "Enter a value first ! ";
                }
            }
            else if (MeterToFoot.Checked)
            {
                if (ValueTextBox.TextLength != 0)
                {
                    //int meters = Convert.ToInt32(ValueTextBox.Text);
                    decimal.TryParse(ValueTextBox.Text, out decimal meters);
                    decimal foots = meters * 12;
                    ResultTextBox.Text = foots.ToString();
                }
                else
                {
                    ResultTextBox.Text = "Enter a value first ! ";
                }
            }
        }
        private void ConvertRadios_CheckedChanged(object sender, EventArgs e)
        {
          
        }
    }
}

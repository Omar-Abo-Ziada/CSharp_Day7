using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Registeration : Form
    {
        public Registeration()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool IsValid = true;

            InvalidNameMessage.Visible = false;
            InvalidEmailMessage.Visible = false;
            InvalidGenderMessage.Visible = false;
            InvalidHobbyMessage.Visible = false;
            ValidRegisterationMessage.Visible = false;

            if (NameTextBox.Text.Length < 5)
            {
                InvalidNameMessage.Visible = true;
                 IsValid = false;
            }

            if (!EmailTextBox.Text.Contains('@'))
            {
                InvalidEmailMessage.Visible = true;
                IsValid = false;
            }

            if (!MaleRadioButton.Checked && !FemaleRadioButton.Checked)
            {
                InvalidGenderMessage.Visible = true;
                IsValid = false;
            }

            if (!ReadingCheckBox.Checked && !SwimmingCheckBox.Checked && !RunningCheckBox.Checked)
            {
                InvalidHobbyMessage.Visible = true;
                IsValid = false;
            }

            if (IsValid)
            {
                ValidRegisterationMessage.Visible = true;
            }
        }
    }
}

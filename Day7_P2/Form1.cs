using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day7_P2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //cmbCountries.Items.Add("Egypt");
            //cmbCountries.Items.Add("KSA");
            //cmbCountries.Items.Add("Libya");
            //cmbCountries.Items.Add("Germany");

            //cmbCountries.Items.AddRange(new string[] { "C1", "C2", "C3" });


            List<Country> countries = new List<Country>()
            {
                new Country { ID = 1, Name = "Egypt"},
                new Country { ID = 2, Name = "KSA"},
                new Country { ID = 3, Name = "Germany"},
            };

            //cmbCountries.Items.AddRange(countries.ToArray());

            cmbCountries.DisplayMember = "Name";
            cmbCountries.ValueMember = "ID";
            cmbCountries.DataSource = countries;

            //cmbCountries.SelectedIndex = -1;
        }

        private void cmbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Country country = cmbCountries.SelectedItem as Country;

            //if (country == null)
            //    return;

            //label1.Text = country.Name;

            if (cmbCountries.SelectedIndex == -1)
                return;

            int id = (int)cmbCountries.SelectedValue;
            label1.Text = id.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

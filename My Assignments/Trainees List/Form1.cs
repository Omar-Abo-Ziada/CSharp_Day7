using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Trainees_List
{
    public partial class Form1 : Form
    {
        public List<string> Trainees { get; set; }
        public List<string> LabTrainees { get; set; }
        public Form1()
        {
            InitializeComponent();

            Trainees = new List<string>() { "Omar", "Emad", "Ali", "Sara", "hesham" };

            checkedListBoxTrainees.Items.AddRange(Trainees.ToArray());

            checkedListBoxTrainees.CheckOnClick = true;

            LabTrainees = new List<string>();
            checkedListBoxLabTrainees.CheckOnClick = true;

            oneToLeftBtn.Enabled = false;
            allToLeftBtn.Enabled = false;

            oneToRightBtn.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxTrainees.CheckedItems.Count == 0
                                       ||
             checkedListBoxTrainees.CheckedItems.Count == Trainees.Count)
            {
                oneToRightBtn.Enabled = false;
            }
            else
            {
                oneToRightBtn.Enabled = true;
                allToRightBtn.Enabled = true;
            }
        }
        private void checkedListBoxLabTrainees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxLabTrainees.CheckedItems.Count == 0
                                 ||
             checkedListBoxLabTrainees.CheckedItems.Count == LabTrainees.Count)
            {
                oneToLeftBtn.Enabled = false;
            }
            else
            {
                oneToLeftBtn.Enabled = true;
                allToLeftBtn.Enabled = true;
            }
        }

        private void allToRightBtn_Click(object sender, EventArgs e)
        {
            allToRightBtn.Enabled = false;
            oneToRightBtn.Enabled = false;

            for (int i = 0; i < Trainees.Count; i++)
            {
                LabTrainees.Add(Trainees[i]);
                checkedListBoxLabTrainees.Items.Add(Trainees[i]);
            }

            allToLeftBtn.Enabled = true;
            oneToLeftBtn.Enabled = true;

            Trainees.Clear();
            checkedListBoxTrainees.Items.Clear();
        }

        private void allToLeftBtn_Click(object sender, EventArgs e)
        {
            allToLeftBtn.Enabled = false;
            oneToLeftBtn.Enabled = false;

            for (int i = 0; i < LabTrainees.Count; i++)
            {
                Trainees.Add(LabTrainees[i]);
                checkedListBoxTrainees.Items.Add(LabTrainees[i]);
            }

            allToRightBtn.Enabled = true;
            oneToRightBtn.Enabled = true;

            LabTrainees.Clear();
            checkedListBoxLabTrainees.Items.Clear();
        }
        private void oneToRightBtn_Click(object sender, EventArgs e)
        {
            if (checkedListBoxTrainees.CheckedItems.Count == Trainees.Count)
            {
                allToRightBtn.Enabled = false;
            }

            //int count = checkedListBoxTrainees.CheckedItems.Count;

            for (int i = 0; i < checkedListBoxTrainees.CheckedItems.Count  ; i++)
            {
                LabTrainees.Add(Trainees[i]);
                Trainees.Remove(Trainees[i]);

                checkedListBoxLabTrainees.Items.Add(checkedListBoxTrainees.CheckedItems[i]);
                checkedListBoxTrainees.Items.Remove(checkedListBoxTrainees.CheckedItems[i]);

                i--;
            }

            oneToLeftBtn.Enabled = true;
            allToLeftBtn.Enabled = true;
        }
        private void oneToLeftBtn_Click(object sender, EventArgs e)
        {
            if (checkedListBoxLabTrainees.CheckedItems.Count == LabTrainees.Count)
            {
                allToLeftBtn.Enabled = false;
            }

            for (int i = 0; i < checkedListBoxLabTrainees.CheckedItems.Count; i++)
            {
                Trainees.Add(LabTrainees[i]);
                LabTrainees.Remove(LabTrainees[i]);

                checkedListBoxTrainees.Items.Add(checkedListBoxLabTrainees.CheckedItems[i]);
                checkedListBoxLabTrainees.Items.Remove(checkedListBoxLabTrainees.CheckedItems[i]);
                i--;
            }

            oneToRightBtn.Enabled = true;
            allToRightBtn.Enabled = true;
        }
    
    }
}

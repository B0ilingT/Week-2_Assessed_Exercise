using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Linked_List
{
    public partial class Form1 : Form
    {
        LinkListGen<Journal> journals;
        public Form1()
        {
            InitializeComponent();
            journals = new LinkListGen<Journal>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            Journal journalItem = new Journal(authorTextBox.Text, titleTextBox.Text, journalTitleTextBox.Text, pubYearTextBox.Text);
            journals.AddItem(journalItem);
            listBox1.Items.Add(journalItem);
            authorTextBox.Clear();
            titleTextBox.Clear();
            journalTitleTextBox.Clear();
            pubYearTextBox.Clear();
            journals.Sort();
            listBox1.Sorted = true;
        }

        private void removeButton_Click(object sender, EventArgs e) //FIX SORT
        {
            if (journals.Count() != 0)
            {
                string stringToEdit = listBox1.SelectedItem.ToString();
                stringToEdit = stringToEdit.Substring(8);
                int index = stringToEdit.IndexOf(",");
                if (index >= 0)
                    stringToEdit = stringToEdit.Substring(0, index);
                Journal tempJournalItem = new Journal(stringToEdit, "", "", "");
                listBox1.Items.Remove(listBox1.SelectedItem);
                journals.RemoveItem(tempJournalItem);
                journals.Sort();
                outputLabel.Text = "Successfully Removed";
                listBox1.Sorted = true;
            }

            else
            {
                outputLabel.Text = "The List is empty!";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void removeToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

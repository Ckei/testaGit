using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labb_1_Agilametoder_SUW
{
    public partial class Form1 : Form
    {
        List<String> ContantList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            ContantList.Add("Namn     Mejl     Nummer");
            ContantList.Add("Bengt     benga55@gmail.com     0701234567");
            ContantList.Add("Peter     ptr@hotspot.com     0701234576");
            ContantList.Add("Lina     lina_w@gmail.com     0701239654");
            ContantList.Add("Ahmed     ahmed_ahmed@gmail.com     0707654321");
            ContantList.Add("Angelica     angelangelica@gmail.com     0701212125");
            ContantList.Add("Olof     olof_olofsson5@gmail.com     0702223336");
            ContantList.Add("Clara     stensson_c@gmail.com     0730456789");
            ContantList.Add("Stina     stinastinastinastina@hotmail.com     0700554412");
            ContantList.Add("Bertil     beritochbertil@telia.com     0700000258");

        }

        //Adds a contact to our list
        private void addContactButton_Click(object sender, EventArgs e)
        {
            ContantList.Add(nameTextBox.Text +"     "+ mailTextBox.Text + "     "+ numberTextBox.Text);
            Clear();
        }

        //Updates our contactlist
        private void printAllContacts_Click(object sender, EventArgs e)
        {
            Clear();
            updateListItems();
        }

        //Method for list updates
        private void updateListItems()
        {
            int i = 0; while (i < ContantList.Count)
            {
                contactListBox.Items.Add(ContantList.ElementAt(i));
                i++;
            }
            //Sort my list
            ContantList.Sort();

        }

        //Clears all text from the list and textboxes
        private void Clear()
        {
            nameTextBox.Clear(); mailTextBox.Clear(); numberTextBox.Clear();
            contactListBox.Items.Clear();
        }

        //Search for contacts
        private void button3_Click(object sender, EventArgs e)
        {

            string str = searchTextBox.Text;int i = 0;
            while (i < ContantList.Count)
            {
                if (ContantList.ElementAt(i).Contains(str))
                {
                    MessageBox.Show("Hittade: " + ContantList.ElementAt(i));
                    i++;
                }
                else
                {
                    i++;
                }
            }
        }

        //Delete selected item from the list
        private void deleteButton_Click(object sender, EventArgs e)
        {
            ContantList.RemoveAt(contactListBox.SelectedIndex);
            Clear();
            updateListItems();
        }
    }
}

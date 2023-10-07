using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class InventoryManagementSystemForm : Form
    {
        DataTable inventory = new DataTable();

        public InventoryManagementSystemForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            inventory.Columns.Add("SKU");
            inventory.Columns.Add("NAME");
            inventory.Columns.Add("CAT");
            inventory.Columns.Add("COST");
            inventory.Columns.Add("DESC");
            inventory.Columns.Add("AMT");

            inventoryGridView1.DataSource = inventory;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            skuTextBox.Text = "";
            nameTextBox.Text = "";
            costTextBox.Text = "";
            descTextBox.Text = "";
            amtTextBox.Text = "";
            catComboBox.SelectedIndex = -1;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // save all the values from our fields to variables
            string sku = skuTextBox.Text;
            string name = nameTextBox.Text;
            string cost = costTextBox.Text;
            string desc = descTextBox.Text;
            string amt = amtTextBox.Text;
            string cat = (string)catComboBox.SelectedItem;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void inventoryGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

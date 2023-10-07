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

            // add these values to the database
            inventory.Rows.Add(sku, name, cat, cost, desc, amt);
            // clear fields after save
            addButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // user has a row selected so we can get the RowIndex of it, access the DataTable by that index and Delete
                inventory.Rows[inventoryGridView1.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {

                Console.WriteLine("There has been a Deletion error: " + err);
            }
        }

        private void inventoryGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                skuTextBox.Text = inventory.Rows[inventoryGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
                nameTextBox.Text = inventory.Rows[inventoryGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
                costTextBox.Text = inventory.Rows[inventoryGridView1.CurrentCell.RowIndex].ItemArray[3].ToString();
                descTextBox.Text = inventory.Rows[inventoryGridView1.CurrentCell.RowIndex].ItemArray[4].ToString();
                amtTextBox.Text = inventory.Rows[inventoryGridView1.CurrentCell.RowIndex].ItemArray[5].ToString();
            }
            catch (Exception err)
            {

                Console.WriteLine("There has been a Cell Double Click error: ", err);
            }
        }
    }
}

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

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void inventoryGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

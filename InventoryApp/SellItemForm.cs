using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class SellItemForm : Form
    {

        private List<Item> currentStock;
        public SellItemForm()
        {
            InitializeComponent();
            // Initialize the list with 0.
            currentStock = new List<Item>();
            currentStockTbl.ColumnCount = 4;
            currentStockTbl.Columns[0].Name = "ID";
            currentStockTbl.Columns[1].Name = "Name";
            currentStockTbl.Columns[2].Name = "Quantity";
            currentStockTbl.Columns[3].Name = "Price";

            FetchInventoryRecords();

        }

        public void FetchInventoryRecords()
        {
            InventoryManager ivm = new InventoryManager();
            currentStock = ivm.GetAllItems();

            // We have a list of stock items form the db. Step shows how to update the values to the grid view
            foreach (Item item in currentStock)
            {
                currentStockTbl.Rows.Add(item.ItemID, item.ItemName, item.Quantity, item.Price);
            }
        }

        private void currentStockTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sellItem_Click(object sender, EventArgs e)
        {

        }
    }
}

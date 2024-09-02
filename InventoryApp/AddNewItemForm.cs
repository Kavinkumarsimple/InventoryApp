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
    internal partial class AddNewItemForm : Form
    {

        public Employee employee1;
        public AddNewItemForm(Employee employee)
        {
            InitializeComponent();
            this.employee1 = employee;
        }

        private void AddNewItemForm_Load(object sender, EventArgs e)
        {

        }

        private void additembtn_Click(object sender, EventArgs e)
        {
            InventoryManager inventoryManager = new InventoryManager();
            Item item = new Item("Laptop", 23, 231123);
            inventoryManager.AddNewItem(item);
        }

        private void sellItembtn_Click(object sender, EventArgs e)
        {
            Form sellItemform = new SellItemForm();
            sellItemform.ShowDialog();
        }
    }
}

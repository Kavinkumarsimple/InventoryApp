using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    internal class Item
    {

        public int ItemID;
        public string ItemName;
        public int Quantity;
        public double Price;


        public Item(int itemID, string itemName, int quantity, double price)
        {
            ItemID = itemID;
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }
        public Item(string itemName, int quantity, double price)
        {
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }
    }
}


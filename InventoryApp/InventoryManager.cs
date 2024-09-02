using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryApp
{
    internal class InventoryManager
    {
        public void AddNewItem(Item newItem)
        {
            DbConnection dbConnection = new DbConnection();

            string query = "INSERT INTO inventory (ItemName, Quantity, Price) VALUES (@name, @price, @quantity)";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            cmd.Parameters.AddWithValue("@name", newItem.ItemName);
            cmd.Parameters.AddWithValue("@price", newItem.Price);
            cmd.Parameters.AddWithValue("@quantity", newItem.Quantity);

            try
            {
                dbConnection.OpenConnection();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }

        }
    
        public List<Item> GetAllItems()
        {
            List<Item> currentStock = new List<Item>();
            // To fetch records from the db and show in the table
            DbConnection dbConnection = new DbConnection();
            string query = "SELECT * FROM inventory";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            try
            {
                dbConnection.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();

                // Iterate the response coming from db and create item objects               
                while (reader.Read())
                {
                    int id = int.Parse(reader["ItemID"].ToString());
                    string name = reader["ItemName"].ToString();
                    int quanity = int.Parse(reader["Quantity"].ToString());
                    double price = double.Parse(reader["Price"].ToString());

                    // Contruct the item object

                    Item item = new Item(id, name, quanity, price);
                    currentStock.Add(item);

                }
                reader.Close();
                return currentStock;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return [];
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
    
        public void SellItem(int id, int quantity_to_sell)
        {
            // Fetch Current Quantity
            DbConnection dbConnection = new DbConnection();

            string query = "SELECT inventory.quantity FROM inventory WHERE inventory.id = @id";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                // Validate the reader object, if present username is correct
                if (reader.Read())
                {
                    int currentQuantity = int.Parse(reader["quantity"].ToString());
                    // Validation
                    if (currentQuantity >= quantity_to_sell)
                    {
                        // Can sell
                        // Update the stock
                        int new_quantity = currentQuantity - quantity_to_sell;

                        // Call the DB again
                        string query2 = "Have your update query";
                        MySqlCommand cmd2 = new MySqlCommand(query, dbConnection.GetConnection());

                        //cmd.Parameters.AddWithValue("@name", newItem.ItemName);
                        //cmd.Parameters.AddWithValue("@price", newItem.Price);
                        //cmd.Parameters.AddWithValue("@quantity", newItem.Quantity);

                        cmd2.ExecuteNonQuery();

                    }
                    else
                    {
                        // Cant Sell
                    }
                }
                else
                {
                    // Return something to indicate id doesn't exist
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }


        }
    }
}

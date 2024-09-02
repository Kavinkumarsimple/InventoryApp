using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    internal class EmployeeManager
    {
        public Employee Authentication(String username, String password)
        {

            // Connect to the DB and run our query
            DbConnection dbConnection = new DbConnection();
            string query = "SELECT * FROM employees WHERE employees.Username = '"+ username + "'";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            try
            {
                dbConnection.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();

                // Validate the reader object, if present username is correct
                if (reader.Read())
                {
                    // Now check the password
                    String pass = reader["password"].ToString();

                    if (pass == password) {
                        // User is authenticated and good to go

                        // Get All Employee values
                        int empID =  int.Parse(reader["EmployeeID"].ToString());
                        String name = reader["name"].ToString();
                        String role = reader["role"].ToString();

                        Employee emp = new Employee(empID, name, role, username, password);
                        return emp;
                    }
                    else
                    {
                        reader.Close();
                        return null;
                    }
                }
                else
                {
                    reader.Close();
                    return null;
                }
          


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }

            return null;
        }
    }
}

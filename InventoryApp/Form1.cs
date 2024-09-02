using MySql.Data.MySqlClient;

namespace InventoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbConnection dbConnection = new DbConnection();
            string query = "SELECT * FROM employees";
            MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());

            try
            {
                dbConnection.OpenConnection();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string username = reader["username"].ToString();

                    // Show each student's details in a MessageBox
                    MessageBox.Show($"Username: {username}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            EmployeeManager empManager = new EmployeeManager();
            Employee empObj =  empManager.Authentication(usernametxt.Text, passwordtxt.Text);
            if (empObj != null) {
                // Authentication is successful
                MessageBox.Show("Success");

                Form dashbaord = new AddNewItemForm(empObj);
                dashbaord.ShowDialog();
                // Navigate to the add item form / dashboard

            }
            else
            {
                // Authentication Failed
                MessageBox.Show("Failed");
            }
        }
    }
}

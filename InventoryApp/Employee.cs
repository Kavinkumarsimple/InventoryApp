using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    internal class Employee
    {
        private int EmployeeID;
        private string Name;
        private string Role;
        private string Username;
        private string Password;

        public Employee(int EmployeeID, string Name, string Role, string Username, string Password)
        {
            this.EmployeeID = EmployeeID;
            this.Name = Name;
            this.Role = Role;
            this.Username = Username;
            this.Password = Password;

        }

        public int GetEployeeID() { return EmployeeID; }
        public string GetName() { return Name; }
        public string GetRole() { return Role; }
        public string GetUserName() { return Username; }
        public string GetPassword() { return Password; }

        public void SetEmployeeID(int EmployeeID) { this.EmployeeID = EmployeeID; }
        public void SetName(string Name) { this.Name = Name; }
        public void SetRole(string Role) { this.Role = Role; }
        public void SetUsername(string Username) { this.Username = Username; }
        public void SetPassword(string Password) { this.Password = Password; }


    }
}

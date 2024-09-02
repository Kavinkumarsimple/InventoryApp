using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp
{
    internal class SalesEmployee : Employee
    {
        public SalesEmployee(int EmployeeID, string Name, string Role, string Username, string Password) : base(EmployeeID, Name, Role, Username, Password)
        {
        }
    }
}

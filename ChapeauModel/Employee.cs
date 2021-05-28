using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Employee
    {
        public int Employee_Number { get; set; } 

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public EmployeeRole Employee_Role { get; set; }

        public int Employee_Password { get; set; } //4-digit pin
    }
}

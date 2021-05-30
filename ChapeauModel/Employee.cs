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

        public Employee(int employee_Number, string first_Name, string last_Name, int employee_Password, EmployeeRole role)
        {

            this.Employee_Number = employee_Number;
            this.First_Name = first_Name;
            this.Last_Name = last_Name;
            this.Employee_Password = employee_Password;
            this.Employee_Role = role;
        }
    }
}

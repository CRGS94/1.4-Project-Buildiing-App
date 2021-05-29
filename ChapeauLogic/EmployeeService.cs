using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class EmployeeService
    {
        EmployeeDAO employeedb;

        public EmployeeService()
        {
            employeedb= new EmployeeDAO();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = employeedb.GetAll();
            return employeeList;
            
        }

        public Employee GetByMenuId(int employee_number)
        {
            Employee employee = employeedb.GetById(employee_number);
            return employee;
        }
    }
}

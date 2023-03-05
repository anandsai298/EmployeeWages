// See https://aka.ms/new-console-template for more information
using EmployeeWages;
using System;
namespace employeeWages
{
    class program
    {
        static void Main(String[] args)
        {
            EmployeeWages.EmployeeWage Wage = new EmployeeWages.EmployeeWage();
            Wage.Attendence();
            Wage.Daily_Emp_Wage();
        }
    }
}

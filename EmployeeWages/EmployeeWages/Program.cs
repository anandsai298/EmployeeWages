// See https://aka.ms/new-console-template for more information
using EmployeeWages;
using System;
namespace employeeWages
{
    class program
    {
        public static void Main(String[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.Attendence();
            EmployeeWage.EmpWage("jio", 30, 2, 20);
            EmployeeWage.EmpWage("Idea", 20, 4, 10);
        }
    }
}

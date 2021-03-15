using System;
using StrategyPattern.Models;
using StrategyPattern.Services;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
           var employeeService = new EmployeeService();
           
           var employeeJessy = new Employee("Jessy", ContractType.Permanent); 
           Console.WriteLine($"Jessy salary is: {employeeService.CalculateSalary(employeeJessy)}");
           
           var employeeMeg = new Employee("Meg", ContractType.Casual); 
           Console.WriteLine($"Jessy salary is: {employeeService.CalculateSalary(employeeMeg)}");
        }
    }
}
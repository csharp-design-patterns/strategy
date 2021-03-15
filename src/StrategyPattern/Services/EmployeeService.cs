using StrategyPattern.Models;
using StrategyPattern.Strategies;

namespace StrategyPattern.Services
{
    public class EmployeeService
    {
        public double CalculateSalary(Employee employee)
        {
            var calculateSalaryStrategy =
                CalculateSalaryStrategyFactory.GetCalculateSalaryStrategy(employee.ContractType); 
            return calculateSalaryStrategy.Calculate(employee);
        }
    }
}
using System;
using StrategyPattern.Models;

namespace StrategyPattern.Strategies
{
    public class CalculateSalaryCasualStrategy : ICalculateSalaryStrategy
    {
        public double Calculate(Employee employee)
        {
            // ... do something
            Console.WriteLine("Calculating casual employee salary...");
            return double.MaxValue;
        }
    }
}
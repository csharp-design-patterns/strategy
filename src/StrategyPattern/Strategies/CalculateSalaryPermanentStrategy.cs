using System;
using StrategyPattern.Models;

namespace StrategyPattern.Strategies
{
    public class CalculateSalaryPermanentStrategy : ICalculateSalaryStrategy
    {
        public double Calculate(Employee employee)
        {
            // ... do something
            Console.WriteLine("Calculating permanent employee salary...");
            return double.MaxValue;
        }
    }
}
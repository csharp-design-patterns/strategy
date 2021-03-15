using System;
using StrategyPattern.Models;

namespace StrategyPattern.Strategies
{
    public static class CalculateSalaryStrategyFactory
    {
        public static ICalculateSalaryStrategy GetCalculateSalaryStrategy(ContractType type) =>
            type switch
            {
                ContractType.Permanent => new CalculateSalaryPermanentStrategy(),
                ContractType.Casual => new CalculateSalaryCasualStrategy(),
                _ => throw new NotImplementedException()
            };
    }
}
using StrategyPattern.Models;

namespace StrategyPattern.Strategies
{
    public interface ICalculateSalaryStrategy
    {
        double Calculate(Employee employee);
    }
}
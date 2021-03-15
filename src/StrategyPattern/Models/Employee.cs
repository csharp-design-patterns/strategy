namespace StrategyPattern.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public ContractType ContractType { get; set; }

        public Employee(string name, ContractType contractType)
        {
            Name = name;
            ContractType = contractType;
        }
    }
}
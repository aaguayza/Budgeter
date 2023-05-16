namespace Budgets.Models
{
    public class Account
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? TotalMoney { get; set; }
        public int? MonthlyIncome { get; set; }
        public int? BudgetPerMonth { get; set;}
        public List<BudgetItem>? BudgetItems {get; set;}
        public Account()
        {
           
        }
        public int AddMonthlyIncome()
        {
            TotalMoney += MonthlyIncome;
            return (int)TotalMoney;
        }
    }
}

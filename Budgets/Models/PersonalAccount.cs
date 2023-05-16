namespace Budgets.Models
{
    public class PersonalAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalMoney { get; set; }
        public int MonthlyIncome { get; set; }
        public int BudgetPerMonth { get; set;}
        public List<BudgetItem> BudgetItems {get; set;}
        public PersonalAccount()
        {
           
        }
        public int AddMonthlyIncome()
        {
            TotalMoney += MonthlyIncome;
            return TotalMoney;
        }
    }
}

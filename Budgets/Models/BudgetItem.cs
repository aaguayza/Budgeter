namespace Budgets.Models
{
    public class BudgetItem
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int MoneyToBudget { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public BudgetItem()
        {
        }
    }
}

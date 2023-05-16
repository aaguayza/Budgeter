
using System.ComponentModel.DataAnnotations;

namespace Budgets.View_Model
{
    public class CreateAccountViewModel
    {
        [Required(ErrorMessage ="Name Required")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Please add money ammount")]
        public int? TotalMoney { get; set; }
        [Required(ErrorMessage = "Please provide goal budget")]
        public int? BudgetPerMonth { get; set; }
        [Required(ErrorMessage = "Please provide monthly income")]
        public int? MonthlyIncome { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Budgets.Controllers
{
    public class BudgetItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

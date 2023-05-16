using Microsoft.AspNetCore.Mvc;

namespace Budgets.Controllers
{
    public class Account : Controller
    {
        //Need an interface that displays the user's budgget items, all the money thats been used, money saved, and money for motnth
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        //User will need to create an account with all the money in there.  View Model will be required
        [HttpPost]
        public IActionResult Create(string placeholder)
        {
            return View();
        }
    }
}

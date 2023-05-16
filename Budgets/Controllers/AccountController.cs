﻿using Budgets.Data;
using Budgets.Models;
using Budgets.View_Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Budgets.Controllers
{
    public class AccountController : Controller
    {
        private BudgetDbContext context;
        public AccountController(BudgetDbContext dbContext) 
        {
            context = dbContext;
        }
        //Need an interface that displays the user's budgget items, all the money thats been used, money saved, and money for motnth
        public IActionResult Index()
        {
            List<Account> accounts = context.Accounts.Include(j => j.BudgetItems).ToList();
            return View();
        }
        public IActionResult Create()
        {
            CreateAccountViewModel createAccountViewModel = new CreateAccountViewModel();
            return View(createAccountViewModel);
        }
        //User will need to create an account with all the money in there.  View Model will be required
        [HttpPost]
        public IActionResult Create(string placeholder)
        {
            return View();
        }
    }
}
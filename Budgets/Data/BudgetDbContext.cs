using Microsoft.EntityFrameworkCore;
using Budgets.Models;

namespace Budgets.Data
{
    public class BudgetDbContext : DbContext
    {
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<BudgetItem>? BudgetItems { get; set; }
        public BudgetDbContext(DbContextOptions<BudgetDbContext> options) : base(options) { }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<PersonalAccount>().HasMany(p => p.BudgetItems).WithOne(b => b.PersonalAccount);
        
        //        } 
    }
}
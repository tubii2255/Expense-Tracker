using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {

        }
        public DbSet<Transactions> TransactionsTable { get; set; }
        public DbSet<Category> CategoryTable { get; set; }

    }
}

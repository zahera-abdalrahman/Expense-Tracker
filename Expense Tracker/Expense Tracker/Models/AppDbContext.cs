using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Transaction> Transaction { get; set; }

        public DbSet<Category> Category { get; set; }
    }
}

using GlobalGamesGS.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace GlobalGamesGS.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Newsletter> Newsletter { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<BudgetForm> BudgetForm { get; set; }
    }
    
}

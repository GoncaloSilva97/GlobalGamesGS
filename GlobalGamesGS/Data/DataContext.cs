using GlobalGamesGS.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace GlobalGamesGS.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Newsletter> Newsletter { get; set; }
        public DbSet<BudgetForm> BudgetForm { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        
    }
    
}

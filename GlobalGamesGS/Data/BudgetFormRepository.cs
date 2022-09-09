using GlobalGamesGS.Data.Entities;

namespace GlobalGamesGS.Data
{
    public class BudgetFormRepository : GenericRepository<BudgetForm>, IBudgetFormRepository
    {
        public BudgetFormRepository(DataContext context) : base(context)
        {
        }
    }
}

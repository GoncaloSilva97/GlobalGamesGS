using GlobalGamesGS.Data.Entities;

namespace GlobalGamesGS.Data
{
    public class NewsletterRepository : GenericRepository<Newsletter>, INewsletterRepository
    {
        public NewsletterRepository(DataContext context) : base(context)
        {
        }
    }
}

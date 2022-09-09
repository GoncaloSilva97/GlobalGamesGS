using GlobalGamesGS.Data.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesGS.Data
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();

        Task<T> GetByEmailAsync(string email);

        Task CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task<bool> ExistAsync(string email);
    }
}

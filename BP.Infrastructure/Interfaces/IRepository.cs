using Microsoft.EntityFrameworkCore;

namespace BP.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        Task<IEnumerable<T>> GetAllAsync();

        T GetById(object id);

        Task<T> GetByIdAsync(object id);

        void Insert(T obj);

        T Update(T obj);

        void Delete(object id);

        void Save();

        Task SaveAsync();

        DbSet<T> GetTable();
    }
}
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> FindEntityAsync(int id);
        Task<int> AddEntityAsync(T entity);
        Task<int> UpdateEntityAsync(T entity);
        Task<int> DeleteEntityAsync(int id);
        Task<IEnumerable<T>> GetEntityListAsync();
        IEnumerable<T> GetEntityList();
        DbContext getDbContext();
        DbSet<T> getDbSet();
        DbSet<TOther> GetDbSet<TOther>() where TOther : class;
    }
}

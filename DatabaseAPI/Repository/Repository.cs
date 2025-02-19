using DatabaseAPI.Data;
using DatabaseAPI.Models.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAPI.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseDatatable
    {
        private readonly DbContext dbContext;
        private readonly DbSet<T> dbSet;

        public Repository(DbContextOptions<DatabaseAPIContext> options)
        {
            this.dbContext = new DatabaseAPIContext(options);
            this.dbSet = dbContext.Set<T>();
        }

        public async Task<T> FindEntityAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetEntityListAsync()
        {
            return await dbSet.ToListAsync();
        }

        public IEnumerable<T> GetEntityList()
        {
            return dbSet.ToList();
        }

        public async Task<int> AddEntityAsync(T entity)
        {
            entity.ModifiedAt = DateTime.Now;
            entity.CreatedAt = DateTime.Now;
            await dbSet.AddAsync(entity);
            return await dbContext.SaveChangesAsync();
        }

        public DbContext getDbContext()
        {
            return dbContext;
        }

        public DbSet<T> getDbSet()
        {
            return dbSet;
        }
        public async Task<int> UpdateEntityAsync(T entity)
        {
            entity.ModifiedAt = DateTime.Now;
            dbSet.Update(entity);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteEntityAsync(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
            }
            return await dbContext.SaveChangesAsync();
        }
        public DbSet<TOther> GetDbSet<TOther>() where TOther : class
        {
            return dbContext.Set<TOther>();
        }
    }
}

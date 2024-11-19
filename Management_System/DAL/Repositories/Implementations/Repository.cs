using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations
{
    public class Repository<T>(ManagementSystemDBContext db) : IRepository<T> where T : class, IEntity
    {
        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
        {
            return await db.Set<T>().ToListAsync(cancellationToken);
        }

        public IQueryable<T> GetAll(int page, int pageSize, CancellationToken cancellationToken)
        {
            return db.Set<T>()
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize)
                     .AsNoTracking();
        }

        public IQueryable<T> GetById(Guid id)
        {
            return db.Set<T>()
                .Where(entity => entity.Id == id) 
                .AsNoTracking();
        }

        public async Task<T> Add(T entity, CancellationToken cancellationToken)
        {
            await db.AddAsync(entity, cancellationToken);
            await db.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async Task<T> Update(T entity, CancellationToken cancellationToken)
        {
            db.Update(entity);
            await db.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async Task Delete(T entity, CancellationToken cancellationToken)
        {
            db.Remove(entity);
            await db.SaveChangesAsync(cancellationToken);
        }
    }
}

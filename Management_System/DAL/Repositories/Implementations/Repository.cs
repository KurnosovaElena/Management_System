using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Implementations
{
    public class Repository<T>(ManagementSystemDBContext db) : IRepository<T> where T : class, IEntity
    {
        public IQueryable<T> GetAll(CancellationToken cancellationToken)
        {
            return db.Set<T>();
        }

        public IQueryable<T> GetAll(int page, int pageSize, CancellationToken cancellationToken)
        {
            return db.Set<T>()
                     .Skip((page - 1) * pageSize)
                     .Take(pageSize)
                     .AsNoTracking();
        }

        public IQueryable<T> GetById(Expression<Func<T, bool>> predicate)
        {
            return db.Set<T>()
                .Where(predicate)
                .AsNoTracking();
        }

        public async Task Add(T entity, CancellationToken cancellationToken)
        public async Task<T> Add(T entity, CancellationToken cancellationToken)
        {
            await db.AddAsync(entity, cancellationToken);
            await db.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async Task Update(T entity, CancellationToken cancellationToken)
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

using DAL.Context;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Implementations;
public class Repository<T>(ManagementSystemDBContext db) : IRepository<T> where T : class
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

    public async Task Add(T entity, CancellationToken cancellationToken)
    {
        await db.AddAsync(entity, cancellationToken);
        await db.SaveChangesAsync(cancellationToken);
    }
    public async Task Update(T entity, CancellationToken cancellationToken)
    {
        db.Update(entity);
        await db.SaveChangesAsync(cancellationToken);
    }
    public async Task Delete(T entity, CancellationToken cancellationToken)
    {
        db.Remove(entity);
        await db.SaveChangesAsync(cancellationToken);
    }
}

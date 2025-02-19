using Microsoft.EntityFrameworkCore;
using UserMicroserviceDAL.Context;
using UserMicroserviceDAL.Entities;
using UserMicroserviceDAL.Repositories.Interfaces;

namespace UserMicroserviceDAL.Repositories.Implementations;

public class Repository<T>(UserMicriserviceDBContext db) : IRepository<T> where T : BaseEntity
{
    public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
    {
        return await db.Set<T>().ToListAsync(cancellationToken);
    }

    public virtual async Task<T?> GetById(Guid id, CancellationToken cancellationToken)
    {
        return await db.Set<T>()
            .AsNoTracking()
            .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken);
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

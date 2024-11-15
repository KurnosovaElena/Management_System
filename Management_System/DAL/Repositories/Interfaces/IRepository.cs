namespace DAL.Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    IQueryable<T> GetAll(CancellationToken cancellationToken);
    IQueryable<T> GetAll(int page, int pageSize, CancellationToken cancellationToken);
    Task Add(T entity, CancellationToken cancellationToken);
    Task Update(T entity, CancellationToken cancellationToken);
    Task Delete(T entity, CancellationToken cancellationToken);
}
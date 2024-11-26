namespace DAL.Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);
    IQueryable<T> GetAll(int page, int pageSize, CancellationToken cancellationToken);
    Task<T> GetById(Guid id, CancellationToken cancellationToken);
    Task<T> Add(T entity, CancellationToken cancellationToken);
    Task<T> Update(T entity, CancellationToken cancellationToken);
    Task Delete(T entity, CancellationToken cancellationToken);
}
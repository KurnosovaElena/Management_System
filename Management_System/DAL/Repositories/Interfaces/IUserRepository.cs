using DAL.Entities;

namespace DAL.Repositories.Interfaces;

public interface IUserRepository : IRepository<UserEntity>
{
    Task<UserEntity> GetById(Guid id, CancellationToken cancellationToken);
}
using UserMicroserviceDAL.Entities;

namespace UserMicroserviceDAL.Repositories.Interfaces;

public interface IUsersRepository : IRepository<UserEntity>
{
    Task<UserEntity> GetById(Guid id, CancellationToken cancellationToken);
}

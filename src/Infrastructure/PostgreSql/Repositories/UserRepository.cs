using Core.Entities;
using Core.Repositories;

namespace Infrastructure.PostgreSql.Repositories
{
    internal sealed class UserRepository : IUserRepository
    {
        public Task AddAsync(Guid userId, Note note, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserAsync(Guid userId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

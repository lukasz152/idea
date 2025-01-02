
using Core.Entities;

namespace Core.Repositories
{
    public interface IUserRepository
    {
        Task<IReadOnlyList<User>> GetAllUsersAsync();
        Task<User> GetUserAsync(Guid userId, CancellationToken cancellationToken = default);
        Task AddAsync(Guid userId, Note note, CancellationToken cancellationToken = default);
        void DeleteUser(Guid userId);
        void UpdateUser(User user);
        Task SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}

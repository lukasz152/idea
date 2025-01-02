using Core.Entities;

namespace Core.Repositories
{
    public interface INoteRepository
    {
        Task<IReadOnlyList<Note>> GetAsync(CancellationToken cancellationToken = default);
        Task<Note> GetAsync(Guid id, CancellationToken cancellationToken = default);
        Task<bool> ExistsAsync(Guid noteId, CancellationToken cancellationToken = default);
        void AddAsync(Note note, CancellationToken cancellationToken = default);
        void Update(Note note);
        void Delete(Note note);
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

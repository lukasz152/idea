using Core.Entities;
using Core.ValueObjects;

namespace Core.Services
{
    public interface INoteService
    {
        Task CreateNote(Topic topic, Description description, Status status, DateTime createdAt, CancellationToken ct);
        void UpdateNote(Guid noteId, Topic topic, Description description, Status status,
            DateTime occuredAt);
        Task<Note> GetNote(Guid noteId, CancellationToken ct);
        Task<IReadOnlyList<Note>> GetListOfNotes(AssignedBy assignedBy, CancellationToken ct);
    }
}

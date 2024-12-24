using Abstractions.Kernel;
using Core.Entities;

namespace Core.Events
{
    public sealed record NoteUpdated(Note note, DateTime OccurredAt) : IDomainEvent;
}

using Abstractions.Kernel;
using Core.Entities;

namespace Core.Events
{
    public sealed record TopicOfNoteUpdated(Note note,DateTime updatedAt) : IDomainEvent;
}

using Abstractions.Kernel;
using Core.Entities;

namespace Core.Events
{
    public sealed record DescriptionOfNoteUpdated(Note note, DateTime updatedAt) : IDomainEvent;
}

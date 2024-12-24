using Abstractions.Kernel;
using Core.Entities;

namespace Core.Events
{
    public sealed record StatusOfNoteUpdated(Status status, DateTime updatedAt) : IDomainEvent;
}

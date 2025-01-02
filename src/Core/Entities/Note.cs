using Abstractions.Kernel;
using Core.Events;
using Core.ValueObjects;

namespace Core.Entities
{
    public sealed class Note :AggregateRoot
    {
        public Topic Topic { get; private set; }
        public Description Description { get; private set; }
        public AssignedBy AssignedBy { get; private set; }
        public Status? Status {  get; private set; }
        public DateTime CreatedAt {  get; private set; }
        public DateTime UpdatedAt { get; private set; }
#pragma warning disable S1144
        public Guid? UserId { get; private set; }
        public User? User { get; private set; }
#pragma warning disable S1144

        private Note() { } //EntityFramework >?
        public Note(Guid noteId, Topic topic, Description description, AssignedBy assignedBy,
            Status status, DateTime occuredAt) : base(noteId)
        {
            Topic = topic;
            Description = description;
            AssignedBy = assignedBy;
            Status = status;
            CreatedAt = occuredAt;
            UpdatedAt = occuredAt;
        }
        public void AssingTo(AssignedBy assignedBy, DateTime occuredAt)
        {
            AssignedBy = assignedBy;
            UpdatedAt = occuredAt;
        }
        public void Update(Topic topic, Description description, DateTime occuredAt)
        {
            if(Topic == topic && Description == description)
            {
                //Idempotency check
                return;
            }
            Topic = topic;
            Description = description;
            UpdatedAt = occuredAt;

            AddEvent(new NoteUpdated(this, occuredAt));
        }

        public void UpdateTopic(Topic topic ,DateTime updatedAt)
        {
            if(Topic == topic)
            {
                //Idempotency check
                return;
            }
            Topic = topic;
            UpdatedAt = updatedAt;

            AddEvent(new TopicOfNoteUpdated(this, updatedAt));
        }

        public void UpdateDescription(Description description, DateTime updatedAt)
        {
            if (Description == description)
            {
                //Idempotency check
                return;
            }
            Description = description;
            UpdatedAt = updatedAt;

            AddEvent(new DescriptionOfNoteUpdated(this, updatedAt));
        }

        public void UpdateStatusOfNote(Status status,DateTime updatedAt) 
        {
            if(Status == status)
            {
                //Idempotency check
                return;
            }
            Status = status;
            UpdatedAt = updatedAt;

            AddEvent(new StatusOfNoteUpdated(status, updatedAt));
        }
    }
}

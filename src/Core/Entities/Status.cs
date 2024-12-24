using Abstractions.Kernel;
using Core.ValueObjects;

namespace Core.Entities
{
    public sealed class Status : Entity
    {
        public Guid NoteId { get; private set; }  //czy moze byc nullable ? 
        public AssignedBy AssignedBy { get; private set; }
        public DateTime? DateToFinish { get; private set; }
        public StatusCode StatusCode { get; private set; }
        public Status(Guid noteId, AssignedBy assignedBy, DateTime? dateToFinish, StatusCode statusCode)
        {
            NoteId = noteId;
            AssignedBy = assignedBy;
            DateToFinish = dateToFinish;
            StatusCode = statusCode;
        }

        internal void Update(AssignedBy assignedBy, DateTime? dateToFinish, StatusCode statusCode)
        {
            AssignedBy = assignedBy;
            DateToFinish = dateToFinish;
            StatusCode = statusCode;
        }

        internal void UpdateAssignedBy(AssignedBy assignedBy)
        {
            AssignedBy = assignedBy;
        }

        internal void UpdateDateToFinish(DateTime? dateToFinish) 
        {
            DateToFinish = dateToFinish;
        }

        internal void UpdateStatusCode(StatusCode statusCode) 
        {
            StatusCode = statusCode;
        }
    }
}

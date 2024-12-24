using Abstractions.Kernel;
using Core.ValueObjects;

namespace Core.Exceptions
{
    public sealed class IncorrectStatusOfNoteException : DomainException
    {
        public override string Code { get; } = "inncorect_status_of_note";
        public IncorrectStatusOfNoteException(StatusCode.Statuses passedStatus) 
            : base($"Passed status {passedStatus} is incorrect") { }
        private IncorrectStatusOfNoteException() { }
        private IncorrectStatusOfNoteException(string passedStatus, Exception innerException)
            : base(passedStatus, innerException) { }
    }
}

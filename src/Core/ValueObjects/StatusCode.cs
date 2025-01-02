using Core.Exceptions;

namespace Core.ValueObjects
{
    public sealed record StatusCode
    {
        public Statuses? Value { get; }

        public StatusCode(Statuses? status)
        {
            if (!Enum.IsDefined(typeof(Statuses), status))
            {
                throw new IncorrectStatusOfNoteException(status.Value);
            }
            if (string.IsNullOrEmpty(status.Value.ToString())) 
            {
                throw new InvalidOperationException();
            }
        }
        public enum Statuses
        {
            Without,
            Completed,
            InProgress,
        };
    }
}

using Core.Exceptions;

namespace Core.ValueObjects
{
    public sealed record StatusCode
    {
        public string Value { get;}
        
        public enum Statuses
        {
            Without,
            Completed,
            InProgress,
        };
        public StatusCode(Statuses status)
        {
            if (!Enum.IsDefined(typeof(Statuses), status))
            {
                throw new IncorrectStatusOfNoteException(status);
            }
        }
    }
}

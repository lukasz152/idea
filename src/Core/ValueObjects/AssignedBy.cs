using Core.Exceptions;

namespace Core.ValueObjects
{
    public sealed record AssignedBy
    {
        public string? Value { get; }
        public AssignedBy(string? value)
        {
            if (string.IsNullOrEmpty(value)) 
            {
                throw new AssignedByCannotBeEmptyException();
            }
            Value = value;
        }
    }
}

using Abstractions.Kernel;

namespace Core.Exceptions
{
    public sealed class AssignedByCannotBeEmptyException :DomainException
    {
        public override string Code { get; } = "Assigned_by_cannot_be_empty";
        public AssignedByCannotBeEmptyException() : base() { }
        private AssignedByCannotBeEmptyException(string message) : base(message) { }
        private AssignedByCannotBeEmptyException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}

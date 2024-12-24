
namespace Abstractions.Kernel
{
    public abstract class DomainException : Exception
    {
        public abstract string Code { get; }

        protected DomainException(string message): base(message) { }
        protected DomainException() { }
        protected DomainException(string message, Exception innerException) 
            : base(message, innerException) { }
    }
}

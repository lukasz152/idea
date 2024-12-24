using Abstractions.Kernel;

namespace Core.Exceptions
{
    public sealed class NoDescriptionOfNoteGivenException : DomainException
    {
        public override string Code { get; } = "no_description_of_note_given";
        public NoDescriptionOfNoteGivenException() : base("No Description Of Note Given"){ }
        private NoDescriptionOfNoteGivenException(string message) : base(message){ }
        private NoDescriptionOfNoteGivenException(string message , Exception innerException) 
            :base(message , innerException) { }
    }
}

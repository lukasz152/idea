using Abstractions.Kernel;

namespace Core.Exceptions
{
    public sealed class NoTopicOfNoteGivenException :DomainException
    {
        public override string Code { get; } = "no_topic_of_note_was_given";
        public NoTopicOfNoteGivenException() :base("No Topic Of Note Was Given"){ }
        private NoTopicOfNoteGivenException(string message) : base(message){ }
        private NoTopicOfNoteGivenException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}

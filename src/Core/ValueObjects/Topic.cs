using Core.Exceptions;

namespace Core.ValueObjects
{
    public sealed class Topic
    {
        public string Value { get; }
        public Topic(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new NoTopicOfNoteGivenException();
            }
            Value = value;
        }
    }
}

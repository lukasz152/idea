using Core.Exceptions;

namespace Core.ValueObjects
{
    public sealed record Description
    {
        public string Value { get;}
        public Description(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new NoDescriptionOfNoteGivenException();
            }
            Value = value;
        }
    }
}

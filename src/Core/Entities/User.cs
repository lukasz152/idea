using Abstractions.Kernel;
using Core.Entities;

public class User : AggregateRoot
{
    public string Name { get; private set; }
    public List<Note> Notes { get; private set; }

    private User(){} //entityframework
    public User(Guid userId, string name) : base(userId)
    {
        Name = name;
        Notes = new List<Note>();
    }
    public void AssignNoteToUser(Note note)
    {
        Notes.Add(note);
    }
    public void RemoveNoteFromUser(Guid noteId)
    {
        var note = Notes.FirstOrDefault(n => n.NoteId == noteId);
        if (note != null)
        {
            Notes.Remove(note);
        }
    }
}

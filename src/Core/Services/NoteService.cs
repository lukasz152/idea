using Core.Entities;
using Core.Repositories;
using Core.ValueObjects;

namespace Core.Services
{
    internal class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public async Task CreateNote(Topic topic, Description description, Status status,
            DateTime createdAt, CancellationToken ct)
        {
            var note = new Note(Guid.NewGuid(), topic, description, status, DateTime.UtcNow);

            await _noteRepository.AddAsync(note, ct);
        }

        public async Task<IReadOnlyList<Note>> GetListOfNotes(AssignedBy assignedBy, CancellationToken ct)
        {
            var notes = await _noteRepository.GetAsync(ct);
            return notes.Where(note => note.Status.AssignedBy == assignedBy).ToList();
        }

        public async Task<Note> GetNote(Guid noteId, CancellationToken ct)
        {
            var note = await _noteRepository.GetAsync(noteId, ct);
            if (note == null)
            {
                throw new Exception("note does not exists"); // gdzie exceptiona dac i czy nulla moge zwrocic ?
            }
            return note;
        }

        public void UpdateNote(Guid noteId, Topic topic, Description description, Status status,
            DateTime occuredAt)
        {
            var newNote = new Note(noteId, topic, description, status, occuredAt);
            if(newNote == null)
            {
                throw new Exception("cant update cause note does not exists"); // tu tez?
            }
            _noteRepository.Update(newNote);

        }
    }
}

using Abstractions.time;
using Application.Notes.Cms.Contracts.Responses;
using Core.Entities;
using Core.Repositories;
using Core.ValueObjects;
using MediatR;

namespace Application.Notes.Cms.Commands
{
    internal sealed class CreateNoteCommandHandler : IRequestHandler<CreateNoteCommand, NoteCreatedResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IClock _clock;

        public CreateNoteCommandHandler(IClock clock,
            IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _clock = clock;
        }

        public async Task<NoteCreatedResponse> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserAsync(request.userId, cancellationToken);

            if (user == null)
            {
                throw new Exception(); // dodac not found
            }

            var noteId = Guid.NewGuid();
            var now = _clock.GetCurrecntDate();

            var topic = new Topic(request.TopicOfNote);
            var description = new Description(request.Description);
            var assignedBy = new AssignedBy(request.status?.AssignedBy);
            var newStatusCode = new StatusCode(request.status?.StatusCode);
            var status = new Status(request.DateToFinish, newStatusCode);

            var note = new Note(noteId, topic, description, assignedBy, status, now);
            
            user.AssignNoteToUser(note);

            await _userRepository.AddAsync(request.userId ,note, cancellationToken);
            await _userRepository.SaveChangesAsync(cancellationToken);

            return new NoteCreatedResponse(noteId);
        }
    }
}

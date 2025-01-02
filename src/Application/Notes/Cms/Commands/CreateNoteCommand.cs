using Application.Notes.Cms.Contracts.Requests;// moge uzywac requesta w commandzie ? (mam tam enuma)
using Application.Notes.Cms.Contracts.Responses;
using MediatR;

namespace Application.Notes.Cms.Commands
{
    public sealed record CreateNoteCommand(Guid userId, string TopicOfNote, 
        string Description, StatusRequest? status, DateTime? DateToFinish) : IRequest<NoteCreatedResponse>;
}

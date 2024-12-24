using Application.Notes.Cms.Contracts.Requests;// moge uzywac requesta w commandzie ? (mam tam enuma)
using Application.Notes.Cms.Contracts.Responses;
using MediatR;

namespace Application.Notes.Cms.Commands
{
    public sealed record CreateNoteCommand(string TopicOfNote, string Description, 
        string? AssignedBy, Statuses? status, DateTime? DateToFinish) : IRequest<NoteCreatedResponse>;
}

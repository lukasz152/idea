using static Core.ValueObjects.StatusCode;

namespace Application.Notes.Cms.Contracts.Requests
{
    public record class CreateNoteRequest
    {
        public Guid userId { get; init; }
        public string TopicOfNote { get; init; } = null!;
        public string Description { get; init; } = null!;
        public StatusRequest? Status { get; set; }
    }

    public record class StatusRequest
    {
        public string AssignedBy { get; init; } = null!;
        public Statuses StatusCode { get; set; } = Statuses.Without;
        public DateTime? DateTofinish { get;set; }
    }
}

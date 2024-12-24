
namespace Application.Notes.Cms.Contracts.Requests
{
    public record class CreateNoteRequest
    {
        public string TopicOfNote { get; init; } = null!;
        public string Description { get; init; } = null!;
        public StatusRequest? Status { get; set; }
    }

    public record class StatusRequest
    {
        public string AssignedBy { get; init; } = null!;
        public Statuses StatusCode { get; set; }
        public DateTime? DateTofinish { get;set; }
    }

    public enum Statuses
    {
        Without,
        Completed,
        InProgress,
    };
}

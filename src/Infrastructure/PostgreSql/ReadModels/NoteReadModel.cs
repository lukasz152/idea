namespace Infrastructure.PostgreSql.ReadModels
{
    public sealed class NoteReadModel
    {
        public Guid NoteId { get; init; }
        public string Topic { get; init; } = null!;
        public string Description { get; init; } = null!; 
        public string AssignedBy { get; init; } = null!;
        public DateTime DateToFinish { get; init; }
        int Status { get; init; }
        public DateTime CreatedAt { get; init; }
        public DateTime UpdatedAt { get; init; }
    }
}

namespace Infrastructure.PostgreSql.ReadModels
{
    public sealed class UserReadModel
    {
        public Guid UserId { get; init; }
        public string Name { get; init; }
        public IList<NoteReadModel> Notes { get; set; } = new List<NoteReadModel>();
    }
}

namespace Infrastructure.PostgreSql.ReadModels
{
    public sealed class StatusReadModel
    {
        public DateTime? DateToFinish { get; init; }
        public int StatusCode { get; init; }
    }
}

namespace Shared.Infrastructure.Storage
{
    internal class PostgreSqlOptions
    {
        public const string Name = "PostgreSql";
        public string DefaultConnection { get; init; } = null!;
        public bool MigrateAutomatically { get; set; }
    }
}

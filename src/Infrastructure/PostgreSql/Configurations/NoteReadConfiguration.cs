using Infrastructure.PostgreSql.ReadModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.PostgreSql.Configurations
{
    internal sealed class NoteReadConfiguration : IEntityTypeConfiguration<NoteReadModel>
    {
        public void Configure(EntityTypeBuilder<NoteReadModel> builder)
        {
            builder.ToTable("Notes"); //nazwa tabelki w bazie danych 

            builder.HasKey(p => p.NoteId); //klucz glowny primary key
        }
    }
}

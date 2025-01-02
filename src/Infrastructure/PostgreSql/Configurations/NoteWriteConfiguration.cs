using Core.Entities;
using Core.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.PostgreSql.Configurations
{
    internal sealed class NoteWriteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.ToTable("Notes");

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Topic)
                .IsRequired()
                .HasConversion(t => t.Value, v => new Topic(v));

            builder.OwnsOne(p => p.Status, sb =>
            {
                sb.Property(p => p.DateToFinish)
                    .IsRequired();
                //.HasColumnName nazwa kolumny
                sb.Property(p => p.StatusCode)
                    .IsRequired()
                    .HasConversion(p => p.Value, v => new StatusCode(v));

            });
        }
    }
}

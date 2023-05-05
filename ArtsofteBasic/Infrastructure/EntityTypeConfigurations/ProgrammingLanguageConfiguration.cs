using ArtsofteBasic.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtsofteBasic.Infrastructure.EntityTypeConfigurations;

internal class ProgrammingLanguageConfiguration : IEntityTypeConfiguration<ProgrammingLanguage>
{
    public void Configure(EntityTypeBuilder<ProgrammingLanguage> builder)
    {
        builder.ToTable(nameof(ArtsofteContext.ProgrammingLanguages));
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.Id).ValueGeneratedNever();
    }
}
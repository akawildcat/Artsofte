using ArtsofteBasic.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtsofteBasic.Infrastructure.EntityTypeConfigurations;

internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable(nameof(ArtsofteContext.Employees));
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.Id).ValueGeneratedNever();
        builder
            .HasOne(entity => entity.Department)
            .WithMany()
            .HasForeignKey(elem => elem.DepartmentId);
        builder
            .HasOne(entity => entity.ProgrammingLanguage)
            .WithMany()
            .HasForeignKey(elem => elem.ProgrammingLanguageId);
        builder.Property(employee => employee.Gender).HasConversion<string>();
    }
}
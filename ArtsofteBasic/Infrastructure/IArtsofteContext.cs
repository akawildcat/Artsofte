using ArtsofteBasic.Domain;
using Microsoft.EntityFrameworkCore;

namespace ArtsofteBasic.Infrastructure;

public interface IArtsofteContext
{
    DbSet<Department> Departments { get; }
    DbSet<Employee> Employees { get; }
    DbSet<ProgrammingLanguage> ProgrammingLanguages { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}

using ArtsofteBasic.Domain;
using Microsoft.EntityFrameworkCore;

namespace ArtsofteBasic.Infrastructure;

public class ArtsofteContext : 
    DbContext, 
    IArtsofteContext

{
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Employee> Employees => Set<Employee>();
    public DbSet<ProgrammingLanguage> ProgrammingLanguages => Set<ProgrammingLanguage>();
    
    public ArtsofteContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
                                 "Db:Name=test_artsoftebasic" +
        "Db:Host=localhost" +
        "Db:Port=49000" +
        "Db:Username=postgres" +
        "Db:Password=298180");
    }
}
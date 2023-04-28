namespace ArtsofteBasic.Domain;

/// <summary>
/// Programming language
/// </summary>
public class ProgrammingLanguage
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; init; } = string.Empty;
    
    /// <summary>
    /// Id of employees in this language
    /// </summary>
    public IReadOnlyCollection<Employee> Employees { get; init; } = new List<Employee>();
}
namespace ArtsofteBasic.Domain;

/// <summary>
/// Department
/// </summary>
public class Department
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
    /// Floor
    /// </summary>
    public int Floor { get; init; }

    /// <summary>
    /// Id of employees in this department
    /// </summary>
    public IReadOnlyCollection<Employee> Employees { get; init; } = new List<Employee>();
}
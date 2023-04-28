/// <summary>
/// Employee
/// </summary>
public class Employee
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
    /// Surname
    /// </summary>
    public string Surname { get; init; } = string.Empty;

    /// <summary>
    /// Date of birth
    /// </summary>
    public DateTime DateBirth { get; init; }

    /// <summary>
    /// Gender
    /// </summary>
    public Genders Gender { get; init; }

    /// <summary>
    /// Department
    /// </summary>
    public Guid DepartmentId { get; set; }
}
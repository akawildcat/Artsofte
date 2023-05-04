using ArtsofteBasic.Domain;

namespace ArtsofteBasic.DTOs;

/// <summary>
/// ДТО сотрудника
/// </summary>
public class EmployeeDto
{
    /// <summary>
    /// Идентификатор
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
    /// Age
    /// </summary>
    public int Age { get; init; }

    /// <summary>
    /// Gender
    /// </summary>
    public Genders Gender { get; init; }

    /// <summary>
    /// Department
    /// </summary>
    public string DepartmentName { get; set; } = string.Empty;

    /// <summary>
    /// Programming language
    /// </summary>
    public string ProgrammingLanguageName { get; set; } = string.Empty;
}

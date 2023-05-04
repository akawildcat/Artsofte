using System;

namespace ArtsofteBasic.Domain;

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
    public Department Department { get; set; } = new();
    public Guid DepartmentId { get; set; }
    
    /// <summary>
    /// Programming language
    /// </summary>
    public ProgrammingLanguage ProgrammingLanguage { get; set; } = new();
    public Guid ProgrammingLanguageId { get; set; }
}
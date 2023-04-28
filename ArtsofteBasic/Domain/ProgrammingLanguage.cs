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
}
namespace Hotel.Domain.Models;

/// <summary>
/// Клиент гостиницы
/// </summary>
public class Client
{
    /// <summary>
    /// Номер паспорта
    /// </summary>
    public string PassportNumber { get; set; } = string.Empty;

    /// <summary>
    /// ФИО клиента
    /// </summary>
    public string FullName { get; set; } = string.Empty;

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateOnly BirthDate { get; set; }

    /// <summary>
    /// Гражданство
    /// </summary>
    public string Citizenship { get; set; } = string.Empty;
}
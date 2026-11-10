namespace Hotel.Domain.Models;

/// <summary>
/// Гостиничный номер
/// </summary>
public class Room
{
    /// <summary>
    /// Номер комнаты
    /// </summary>
    public string RoomNumber { get; set; } = string.Empty;

    /// <summary>
    /// Этаж
    /// </summary>
    public int Floor { get; set; }

    /// <summary>
    /// Наличие балкона
    /// </summary>
    public bool HasBalcony { get; set; }

    /// <summary>
    /// Ссылка на тип номера
    /// </summary>
    public RoomType Type { get; set; } = new();
}
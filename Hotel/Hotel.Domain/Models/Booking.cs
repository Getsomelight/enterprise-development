namespace Hotel.Domain.Models;

/// <summary>
/// Факт заселения клиента в номер
/// </summary>
public class Booking
{
    /// <summary>
    /// Уникальный идентификатор бронирования
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Клиент
    /// </summary>
    public Client Client { get; set; } = new();

    /// <summary>
    /// Номер
    /// </summary>
    public Room Room { get; set; } = new();

    /// <summary>
    /// Дата заезда
    /// </summary>
    public DateOnly CheckInDate { get; set; }

    /// <summary>
    /// Количество суток проживания
    /// </summary>
    public int Nights { get; set; }
}
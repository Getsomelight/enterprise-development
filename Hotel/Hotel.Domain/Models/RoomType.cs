using Hotel.Domain.Enums;

namespace Hotel.Domain.Models;

/// <summary>
/// Справочник типов номеров с характеристиками и стоимостью
/// </summary>
public class RoomType
{
    /// <summary>
    /// Идентификатор типа
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Категория номера
    /// </summary>
    public RoomCategory Category { get; set; }

    /// <summary>
    /// Площадь номера в кв. м
    /// </summary>
    public double Area { get; set; }

    /// <summary>
    /// Количество кроватей
    /// </summary>
    public int BedCount { get; set; }

    /// <summary>
    /// Наличие ванны/душа
    /// </summary>
    public bool HasBathroom { get; set; }

    /// <summary>
    /// Стоимость проживания за сутки
    /// </summary>
    public decimal PricePerNight { get; set; }
}
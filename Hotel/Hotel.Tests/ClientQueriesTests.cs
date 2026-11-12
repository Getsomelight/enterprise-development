using Hotel.Domain.Data;
using Hotel.Domain.Enums;

namespace Hotel.Tests;

/// <summary>
/// Тесты аналитических запросов по клиентам
/// </summary>
public class ClientQueriesTests
{
    /// <summary>
    /// Проверяет вывод клиентов, проживавших в номерах указанного типа,
    /// с сортировкой по ФИО
    /// </summary>
    [Fact]
    public void ClientsByRoomType_OrderedByFullName()
    {
        var data = new TestData();
        var targetCategory = RoomCategory.Standard;

        var result = (from b in data.Bookings
                      where b.Room.Type.Category == targetCategory
                      select b.Client)
                     .GroupBy(c => c.PassportNumber)
                     .Select(g => g.First())
                     .OrderBy(c => c.FullName)
                     .ToList();

        Assert.NotEmpty(result);

        var expectedOrder = result.OrderBy(c => c.FullName).Select(c => c.PassportNumber).ToList();
        Assert.Equal(expectedOrder, result.Select(c => c.PassportNumber).ToList());

        Assert.Contains(result, c => c.FullName == "Борисов Борис Борисович");
        Assert.Contains(result, c => c.FullName == "Волкова Виктория Владимировна");
    }

    /// <summary>
    /// Проверяет топ 5 клиентов по суммарной стоимости проживания
    /// </summary>
    [Fact]
    public void Top5ClientsByTotalSpent()
    {
        var data = new TestData();

        var result = data.Bookings
            .GroupBy(b => b.Client.PassportNumber)
            .Select(g => new
            {
                ClientName = g.First().Client.FullName,
                TotalSpent = g.Sum(b => b.Nights * b.Room.Type.PricePerNight)
            })
            .OrderByDescending(x => x.TotalSpent)
            .ThenBy(x => x.ClientName)
            .Take(5)
            .ToList();

        Assert.Equal(5, result.Count);
        for (var i = 1; i < result.Count; i++)
        {
            Assert.True(result[i - 1].TotalSpent >= result[i].TotalSpent);
        }
    }
}
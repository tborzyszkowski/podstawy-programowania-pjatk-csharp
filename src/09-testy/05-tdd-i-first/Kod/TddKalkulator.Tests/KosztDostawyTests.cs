using TddKalkulator;
using Xunit;

namespace TddKalkulator.Tests;

public sealed class KosztDostawyTests
{
    [Theory]
    [InlineData(0, false, 15)]
    [InlineData(199.99, false, 15)]
    [InlineData(0, true, 30)]
    [InlineData(199.99, true, 30)]
    public void Oblicz_TaniKoszyk_ReturnsDeliveryCost(
        decimal wartoscKoszyka,
        bool ekspres,
        decimal oczekiwany)
    {
        decimal wynik = KosztDostawy.Oblicz(wartoscKoszyka, ekspres);

        Assert.Equal(oczekiwany, wynik);
    }

    [Theory]
    [InlineData(200, false)]
    [InlineData(500, true)]
    public void Oblicz_DuzyKoszyk_ReturnsFreeDelivery(
        decimal wartoscKoszyka,
        bool ekspres)
    {
        decimal wynik = KosztDostawy.Oblicz(wartoscKoszyka, ekspres);

        Assert.Equal(0m, wynik);
    }

    [Fact]
    public void Oblicz_NegativeCartValue_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => KosztDostawy.Oblicz(-1m, false));
    }
}

using Xunit;
using ZadaniaTestowe;

namespace ZadaniaTestowe.Tests;

public sealed class RozwiazaniaTests
{
    [Theory]
    [InlineData(0, true)]
    [InlineData(50, true)]
    [InlineData(100, true)]
    [InlineData(-1, false)]
    [InlineData(101, false)]
    public void CzyPoprawnaOcena_ReturnsExpectedResult(int punkty, bool oczekiwany)
    {
        bool wynik = Walidator.CzyPoprawnaOcena(punkty);

        Assert.Equal(oczekiwany, wynik);
    }

    [Theory]
    [InlineData(new[] { 2 }, 2)]
    [InlineData(new[] { 2, 4, 6 }, 4)]
    [InlineData(new[] { 1, 2 }, 1.5)]
    public void Srednia_ValidGrades_ReturnsAverage(int[] oceny, decimal oczekiwany)
    {
        decimal wynik = Statystyka.Srednia(oceny);

        Assert.Equal(oczekiwany, wynik);
    }

    [Fact]
    public void Srednia_EmptyCollection_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => Statystyka.Srednia([]));
    }

    [Fact]
    public void NajczestszeSlowo_RepeatedWords_IgnoresCase()
    {
        string? wynik = AnalizatorTekstu.NajczestszeSlowo("Ala ala kot");

        Assert.Equal("ala", wynik);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void NajczestszeSlowo_EmptyInput_ReturnsNull(string? tekst)
    {
        string? wynik = AnalizatorTekstu.NajczestszeSlowo(tekst);

        Assert.Null(wynik);
    }

    [Theory]
    [InlineData(100, 0, 100)]
    [InlineData(100, 20, 80)]
    [InlineData(100, 100, 0)]
    public void CenaPoRabacie_ValidData_ReturnsDiscountedPrice(
        decimal cena,
        decimal rabat,
        decimal oczekiwany)
    {
        decimal wynik = Rabat.CenaPoRabacie(cena, rabat);

        Assert.Equal(oczekiwany, wynik);
    }

    [Theory]
    [InlineData(-1, 20)]
    [InlineData(100, -1)]
    [InlineData(100, 101)]
    public void CenaPoRabacie_InvalidData_ThrowsArgumentOutOfRangeException(
        decimal cena,
        decimal rabat)
    {
        Assert.Throws<ArgumentOutOfRangeException>(
            () => Rabat.CenaPoRabacie(cena, rabat));
    }
}

using SklepLogiczny;
using Xunit;

namespace SklepLogiczny.Tests;

public sealed class KoszykTests
{
    [Fact]
    public void Dodaj_ValidProduct_IncreasesTotal()
    {
        Koszyk koszyk = new();
        koszyk.Dodaj(new Produkt("notes", 12m));

        Assert.Equal(12m, koszyk.Suma());
    }

    [Fact]
    public void Suma_EmptyCart_ReturnsZero()
    {
        Koszyk koszyk = new();

        Assert.Equal(0m, koszyk.Suma());
    }

    [Fact]
    public void Dodaj_NegativePrice_ThrowsArgumentOutOfRangeException()
    {
        Koszyk koszyk = new();

        Assert.Throws<ArgumentOutOfRangeException>(
            () => koszyk.Dodaj(new Produkt("bledny", -1m)));
    }

    [Fact]
    public void NajtanszyProdukt_EmptyCart_ReturnsNull()
    {
        Koszyk koszyk = new();

        Assert.Null(koszyk.NajtanszyProdukt());
    }

    [Fact]
    public void NajtanszyProdukt_SeveralProducts_ReturnsCheapest()
    {
        Koszyk koszyk = new();
        koszyk.Dodaj(new Produkt("notes", 12m));
        koszyk.Dodaj(new Produkt("dlugopis", 4m));
        koszyk.Dodaj(new Produkt("teczka", 8m));

        Produkt? wynik = koszyk.NajtanszyProdukt();

        Assert.Equal("dlugopis", wynik?.Nazwa);
    }
}

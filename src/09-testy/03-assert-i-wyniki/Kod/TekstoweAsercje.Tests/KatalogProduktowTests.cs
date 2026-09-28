using TekstoweAsercje;
using Xunit;

namespace TekstoweAsercje.Tests;

public sealed class KatalogProduktowTests
{
    [Fact]
    public void ZnajdzCene_ExistingCode_ReturnsPrice()
    {
        KatalogProduktow katalog = new();

        decimal? cena = katalog.ZnajdzCene("kawa");

        Assert.Equal(12.50m, cena);
    }

    [Fact]
    public void CzyZawiera_ExistingCode_ReturnsTrue()
    {
        KatalogProduktow katalog = new();

        bool znaleziono = katalog.CzyZawiera("herbata");

        Assert.True(znaleziono);
    }

    [Theory]
    [InlineData("brak-kodu", false)]
    [InlineData("", false)]
    public void CzyZawiera_InvalidOrUnknownCode_ReturnsFalse(
        string kod,
        bool oczekiwany)
    {
        KatalogProduktow katalog = new();

        bool znaleziono = katalog.CzyZawiera(kod);

        Assert.Equal(oczekiwany, znaleziono);
    }

    [Fact]
    public void ZnajdzCene_UnknownCode_ReturnsNull()
    {
        KatalogProduktow katalog = new();

        decimal? cena = katalog.ZnajdzCene("brak-kodu");

        Assert.Null(cena);
    }

    [Fact]
    public void Dodaj_EmptyCode_ThrowsArgumentException()
    {
        KatalogProduktow katalog = new();

        Assert.Throws<ArgumentException>(() => katalog.Dodaj("", 10m));
    }
}

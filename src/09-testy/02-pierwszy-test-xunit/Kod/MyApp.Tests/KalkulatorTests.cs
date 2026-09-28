using MyApp;
using Xunit;

namespace MyApp.Tests;

public sealed class KalkulatorTests
{
    [Fact]
    public void Add_TwoNumbers_ReturnsTheirSum()
    {
        // Arrange
        Kalkulator kalkulator = new();

        // Act
        int wynik = kalkulator.Add(2, 3);

        // Assert
        Assert.Equal(5, wynik);
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(7, false)]
    [InlineData(0, true)]
    public void IsEven_ReturnsExpectedResult(int liczba, bool oczekiwany)
    {
        // Arrange
        Kalkulator kalkulator = new();

        // Act
        bool wynik = kalkulator.IsEven(liczba);

        // Assert
        Assert.Equal(oczekiwany, wynik);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(9, 3, 3)]
    [InlineData(-8, 2, -4)]
    public void Divide_ValidArguments_ReturnsQuotient(
        int dzielna,
        int dzielnik,
        int oczekiwany)
    {
        // Arrange
        Kalkulator kalkulator = new();

        // Act
        int wynik = kalkulator.Divide(dzielna, dzielnik);

        // Assert
        Assert.Equal(oczekiwany, wynik);
    }

    [Fact]
    public void Divide_DivisorIsZero_ThrowsArgumentException()
    {
        // Arrange
        Kalkulator kalkulator = new();

        // Act and Assert
        Assert.Throws<ArgumentException>(() => kalkulator.Divide(10, 0));
    }
}

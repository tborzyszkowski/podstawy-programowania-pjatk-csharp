Console.WriteLine("Przypadki do ręcznego sprawdzenia:");
Console.WriteLine($"100 zł, rabat 20% -> {KalkulatorCen.CenaPoRabacie(100, 20):F2} zł");
Console.WriteLine($"0 zł, rabat 100% -> {KalkulatorCen.CenaPoRabacie(0, 100):F2} zł");

try
{
    KalkulatorCen.CenaPoRabacie(100, 120);
}
catch (ArgumentException wyjatek)
{
    Console.WriteLine($"Błędne dane -> {wyjatek.GetType().Name}");
}

public static class KalkulatorCen
{
    public static decimal CenaPoRabacie(decimal cena, decimal rabatProcent)
    {
        if (cena < 0)
        {
            throw new ArgumentException("Cena nie może być ujemna.", nameof(cena));
        }

        if (rabatProcent is < 0 or > 100)
        {
            throw new ArgumentException("Rabat musi mieścić się w zakresie 0-100.", nameof(rabatProcent));
        }

        return cena * (100 - rabatProcent) / 100;
    }
}

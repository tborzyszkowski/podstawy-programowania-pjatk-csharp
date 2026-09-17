public static class Obliczenia
{
    public static decimal PoleProstokata(decimal bokA, decimal bokB)
    {
        if (bokA < 0 || bokB < 0)
        {
            throw new ArgumentOutOfRangeException("Boki nie mogą być ujemne.");
        }

        return bokA * bokB;
    }

    public static decimal Srednia(IReadOnlyList<decimal> wartosci)
    {
        ArgumentNullException.ThrowIfNull(wartosci);
        if (wartosci.Count == 0)
        {
            throw new ArgumentException("Lista nie może być pusta.", nameof(wartosci));
        }

        decimal suma = 0;
        foreach (decimal wartosc in wartosci)
        {
            suma += wartosc;
        }

        return suma / wartosci.Count;
    }

    public static decimal CelsjuszNaFahrenheit(decimal celsjusz)
    {
        return celsjusz * 9 / 5 + 32;
    }

    public static int NajwiekszyWspolnyDzielnik(int a, int b)
    {
        if (a <= 0 || b <= 0)
        {
            throw new ArgumentOutOfRangeException("Liczby muszą być dodatnie.");
        }

        while (b != 0)
        {
            int reszta = a % b;
            a = b;
            b = reszta;
        }

        return a;
    }

    public static decimal CenaPoRabacie(decimal cena, decimal procentRabatu)
    {
        if (cena < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(cena), "Cena nie może być ujemna.");
        }

        if (procentRabatu < 0 || procentRabatu > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(procentRabatu), "Rabat musi być w zakresie 0-100.");
        }

        return cena * (100 - procentRabatu) / 100;
    }
}
namespace ZadaniaTestowe;

public static class Walidator
{
    public static bool CzyPoprawnaOcena(int punkty)
    {
        return punkty is >= 0 and <= 100;
    }
}

public static class Statystyka
{
    public static decimal Srednia(IReadOnlyList<int> oceny)
    {
        ArgumentNullException.ThrowIfNull(oceny);

        if (oceny.Count == 0)
        {
            throw new ArgumentException("Lista ocen nie może być pusta.", nameof(oceny));
        }

        if (oceny.Any(ocena => !Walidator.CzyPoprawnaOcena(ocena)))
        {
            throw new ArgumentException("Ocena musi mieścić się w zakresie 0-100.", nameof(oceny));
        }

        return oceny.Select(ocena => (decimal)ocena).Average();
    }
}

public static class AnalizatorTekstu
{
    public static string? NajczestszeSlowo(string? tekst)
    {
        if (string.IsNullOrWhiteSpace(tekst))
        {
            return null;
        }

        return tekst
            .Split([' ', ',', '.', ';', '!', '?'], StringSplitOptions.RemoveEmptyEntries)
            .Select(slowo => slowo.ToLowerInvariant())
            .GroupBy(slowo => slowo)
            .OrderByDescending(grupa => grupa.Count())
            .ThenBy(grupa => grupa.Key, StringComparer.Ordinal)
            .Select(grupa => grupa.Key)
            .FirstOrDefault();
    }
}

public static class Rabat
{
    public static decimal CenaPoRabacie(decimal cena, decimal rabatProcent)
    {
        if (cena < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(cena));
        }

        if (rabatProcent is < 0 or > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(rabatProcent));
        }

        return cena * (100 - rabatProcent) / 100;
    }
}

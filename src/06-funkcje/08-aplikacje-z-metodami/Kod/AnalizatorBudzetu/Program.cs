using System.Globalization;

internal sealed record Wydatek(string Opis, string Kategoria, decimal Kwota);

internal static class Program
{
    private static void Main()
    {
        List<Wydatek> wydatki =
        [
            new("Czynsz", "Dom", 1800m),
            new("Zakupy spożywcze", "Jedzenie", 420.50m),
            new("Bilet miesięczny", "Transport", 120m),
            new("Książka", "Edukacja", 89.99m),
            new("Obiad", "Jedzenie", 46.50m)
        ];

        const decimal limitMiesieczny = 3000m;
        WypiszRaport(wydatki, limitMiesieczny);

        if (SprobujUtworzycWydatek("Kawa", "Jedzenie", "14.50", out Wydatek nowyWydatek))
        {
            wydatki.Add(nowyWydatek);
            Console.WriteLine($"Dodano wydatek: {nowyWydatek.Opis}");
        }

        if (!SprobujUtworzycWydatek("Błędne dane", "Jedzenie", "nie-kwota", out _))
        {
            Console.WriteLine("Nie dodano wydatku z niepoprawną kwotą.");
        }
    }

    private static decimal ObliczSume(IEnumerable<Wydatek> wydatki)
    {
        return wydatki.Sum(wydatek => wydatek.Kwota);
    }

    private static decimal ObliczSume(IEnumerable<Wydatek> wydatki, string kategoria)
    {
        return ObliczSume(WydatkiWKategorii(wydatki, kategoria));
    }

    private static IEnumerable<Wydatek> WydatkiWKategorii(
        IEnumerable<Wydatek> wydatki,
        string kategoria)
    {
        foreach (Wydatek wydatek in wydatki)
        {
            if (string.Equals(wydatek.Kategoria, kategoria, StringComparison.OrdinalIgnoreCase))
            {
                yield return wydatek;
            }
        }
    }

    private static decimal ProcentLimitu(decimal suma, decimal limit)
    {
        return limit <= 0 ? 0 : suma / limit * 100;
    }

    private static bool SprobujUtworzycWydatek(
        string opis,
        string kategoria,
        string tekstKwoty,
        out Wydatek wydatek)
    {
        bool poprawnyTekst = !string.IsNullOrWhiteSpace(opis)
            && !string.IsNullOrWhiteSpace(kategoria);
        bool poprawnaKwota = decimal.TryParse(
            tekstKwoty,
            NumberStyles.Number,
            CultureInfo.InvariantCulture,
            out decimal kwota);

        if (!poprawnyTekst || !poprawnaKwota || kwota <= 0)
        {
            wydatek = new Wydatek(string.Empty, string.Empty, 0);
            return false;
        }

        wydatek = new Wydatek(opis.Trim(), kategoria.Trim(), kwota);
        return true;
    }

    private static void WypiszRaport(
        IReadOnlyCollection<Wydatek> wydatki,
        decimal limitMiesieczny)
    {
        decimal suma = ObliczSume(wydatki);
        decimal procent = ProcentLimitu(suma, limitMiesieczny);

        Console.WriteLine("=== Raport budżetu ===");
        foreach (Wydatek wydatek in wydatki)
        {
            Console.WriteLine(
                $"{wydatek.Kategoria,-12} {wydatek.Opis,-22} {wydatek.Kwota,8:F2} zł");
        }

        Console.WriteLine($"Suma: {suma:F2} zł");
        Console.WriteLine($"Jedzenie: {ObliczSume(wydatki, "Jedzenie"):F2} zł");
        Console.WriteLine($"Wykorzystanie limitu: {procent:F1}%");
    }
}
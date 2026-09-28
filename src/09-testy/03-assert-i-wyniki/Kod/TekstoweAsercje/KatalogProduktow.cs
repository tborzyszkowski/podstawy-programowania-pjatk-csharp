namespace TekstoweAsercje;

public sealed class KatalogProduktow
{
    private readonly Dictionary<string, decimal> ceny = new(StringComparer.OrdinalIgnoreCase)
    {
        ["kawa"] = 12.50m,
        ["herbata"] = 8.00m
    };

    public decimal? ZnajdzCene(string? kod)
    {
        if (string.IsNullOrWhiteSpace(kod))
        {
            return null;
        }

        return ceny.TryGetValue(kod, out decimal cena) ? cena : null;
    }

    public bool CzyZawiera(string kod)
    {
        return !string.IsNullOrWhiteSpace(kod) && ceny.ContainsKey(kod);
    }

    public void Dodaj(string kod, decimal cena)
    {
        if (string.IsNullOrWhiteSpace(kod))
        {
            throw new ArgumentException("Kod nie może być pusty.", nameof(kod));
        }

        if (cena < 0)
        {
            throw new ArgumentException("Cena nie może być ujemna.", nameof(cena));
        }

        ceny.Add(kod, cena);
    }
}

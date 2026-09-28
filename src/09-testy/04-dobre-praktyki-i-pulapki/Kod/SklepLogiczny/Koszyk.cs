namespace SklepLogiczny;

public sealed record Produkt(string Nazwa, decimal Cena);

public sealed class Koszyk
{
    private readonly List<Produkt> produkty = [];

    public void Dodaj(Produkt produkt)
    {
        ArgumentNullException.ThrowIfNull(produkt);

        if (produkt.Cena < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(produkt), "Cena nie może być ujemna.");
        }

        produkty.Add(produkt);
    }

    public decimal Suma()
    {
        return produkty.Sum(produkt => produkt.Cena);
    }

    public Produkt? NajtanszyProdukt()
    {
        return produkty.MinBy(produkt => produkt.Cena);
    }
}

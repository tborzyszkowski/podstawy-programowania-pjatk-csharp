namespace TddKalkulator;

public static class KosztDostawy
{
    public const decimal DarmowaDostawaOd = 200m;
    public const decimal KosztZwykly = 15m;
    public const decimal KosztEkspresowy = 30m;

    public static decimal Oblicz(decimal wartoscKoszyka, bool ekspres)
    {
        if (wartoscKoszyka < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(wartoscKoszyka));
        }

        if (wartoscKoszyka >= DarmowaDostawaOd)
        {
            return 0m;
        }

        return ekspres ? KosztEkspresowy : KosztZwykly;
    }
}

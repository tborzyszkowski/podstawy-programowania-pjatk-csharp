Console.WriteLine($"Pole kwadratu: {Kalkulator.Pole(4)}");
Console.WriteLine($"Pole prostokąta: {Kalkulator.Pole(4, 5)}");
Console.WriteLine($"Pole koła: {Kalkulator.Pole(4.0):F2}");

Console.WriteLine($"Suma dwóch liczb: {Kalkulator.Sumuj(2, 3)}");
Console.WriteLine($"Suma wielu liczb: {Kalkulator.Sumuj(2, 3, 4, 5)}");
Console.WriteLine(Kalkulator.Formatuj(12.5));
Console.WriteLine(Kalkulator.Formatuj(12.5, "PLN"));

internal static class Kalkulator
{
    public static int Pole(int bok)
    {
        return bok * bok;
    }

    public static int Pole(int bokA, int bokB)
    {
        return bokA * bokB;
    }

    public static double Pole(double promien)
    {
        return Math.PI * promien * promien;
    }

    public static int Sumuj(int a, int b)
    {
        return a + b;
    }

    public static int Sumuj(params int[] liczby)
    {
        return liczby.Sum();
    }

    public static string Formatuj(double kwota)
    {
        return $"{kwota:F2}";
    }

    public static string Formatuj(double kwota, string waluta)
    {
        return $"{kwota:F2} {waluta}";
    }
}
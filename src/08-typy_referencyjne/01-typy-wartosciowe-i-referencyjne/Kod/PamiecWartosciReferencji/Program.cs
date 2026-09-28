int liczba = 10;
int kopiaLiczby = liczba;
kopiaLiczby = 20;

Console.WriteLine($"Liczba: {liczba}, kopia: {kopiaLiczby}");

Wspolrzedne pierwszeWspolrzedne = new(1, 2);
Wspolrzedne drugieWspolrzedne = pierwszeWspolrzedne;
drugieWspolrzedne.X = 99;

Console.WriteLine(
    $"Struktura: ({pierwszeWspolrzedne.X}, {pierwszeWspolrzedne.Y}) " +
    $"i ({drugieWspolrzedne.X}, {drugieWspolrzedne.Y})");

Punkt pierwszyPunkt = new(1, 2);
Punkt drugiPunkt = pierwszyPunkt;
drugiPunkt.X = 99;

Console.WriteLine($"Klasa po mutacji: {pierwszyPunkt}");
Console.WriteLine($"Wspólny obiekt: {ReferenceEquals(pierwszyPunkt, drugiPunkt)}");

ZmienObiekt(pierwszyPunkt);
Console.WriteLine($"Po metodzie: {pierwszyPunkt}");

object pudelko = 42;
int odzyskanaWartosc = (int)pudelko;
Console.WriteLine($"Boxing i unboxing: {odzyskanaWartosc}");

static void ZmienObiekt(Punkt punkt)
{
    punkt.Y = 77;
    punkt = new Punkt(-1, -1);
}

internal struct Wspolrzedne(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
}

internal sealed class Punkt(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public override string ToString() => $"({X}, {Y})";
}
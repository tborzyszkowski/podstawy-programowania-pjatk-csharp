Console.WriteLine("Odliczanie:");
Odlicz(3);

Console.WriteLine($"Silnia 4: {Silnia(4)}");

int[] liczby = [2, 4, 6, 8];
Console.WriteLine($"Suma tablicy: {Suma(liczby, 0)}");

static void Odlicz(int liczba)
{
    if (liczba == 0)
    {
        Console.WriteLine("Start");
        return;
    }

    Console.WriteLine(liczba);
    Odlicz(liczba - 1);
}

static long Silnia(int n)
{
    if (n < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(n));
    }

    return n == 0 ? 1 : n * Silnia(n - 1);
}

static int Suma(int[] liczby, int indeks)
{
    if (indeks == liczby.Length)
    {
        return 0;
    }

    return liczby[indeks] + Suma(liczby, indeks + 1);
}
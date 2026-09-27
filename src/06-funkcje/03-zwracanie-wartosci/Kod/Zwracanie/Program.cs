int pole = PoleProstokata(4, 5);
Console.WriteLine($"Pole: {pole}");

(int iloraz, int reszta) = Podziel(17, 5);
Console.WriteLine($"Iloraz: {iloraz}, reszta: {reszta}");

if (SprobujPodwoic(21, out int podwojona))
{
    Console.WriteLine($"Wynik przez out: {podwojona}");
}

Console.WriteLine("Iterator rozpoczyna pracę dopiero podczas foreach:");
foreach (int liczba in ParzysteDo(6))
{
    Console.WriteLine($"  Odebrano: {liczba}");
}

static int PoleProstokata(int a, int b)
{
    return a * b;
}

static (int iloraz, int reszta) Podziel(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException();
    }

    return (a / b, a % b);
}

static bool SprobujPodwoic(int liczba, out int wynik)
{
    if (liczba < 0)
    {
        wynik = 0;
        return false;
    }

    wynik = liczba * 2;
    return true;
}

static IEnumerable<int> ParzysteDo(int maksimum)
{
    for (int liczba = 0; liczba <= maksimum; liczba += 2)
    {
        Console.WriteLine($"  Iterator przygotowuje: {liczba}");
        yield return liczba;
    }
}
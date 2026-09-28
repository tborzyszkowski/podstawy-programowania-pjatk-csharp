int[] liczby = [2, 4, 6, 8, 10, 12, 14];
Node drzewo = new(
    8,
    new Node(4, new Node(2), new Node(6)),
    new Node(12, new Node(10), new Node(14)));

Console.WriteLine($"Silnia(5): {Silnia(5)}");
Console.WriteLine($"NWD(84, 30): {Nwd(84, 30)}");
Console.WriteLine($"Indeks 10: {ZnajdzBinarnie(liczby, 10, 0, liczby.Length - 1)}");
Console.WriteLine($"Preorder: {string.Join(", ", Preorder(drzewo))}");

static long Silnia(int n)
{
    if (n < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(n));
    }

    return n == 0 ? 1 : checked(n * Silnia(n - 1));
}

static int Nwd(int a, int b)
{
    a = Math.Abs(a);
    b = Math.Abs(b);
    return b == 0 ? a : Nwd(b, a % b);
}

static int ZnajdzBinarnie(int[] liczby, int szukana, int lewy, int prawy)
{
    if (lewy > prawy)
    {
        return -1;
    }

    int srodek = lewy + (prawy - lewy) / 2;
    if (liczby[srodek] == szukana)
    {
        return srodek;
    }

    return szukana < liczby[srodek]
        ? ZnajdzBinarnie(liczby, szukana, lewy, srodek - 1)
        : ZnajdzBinarnie(liczby, szukana, srodek + 1, prawy);
}

static IEnumerable<int> Preorder(Node? wezel)
{
    if (wezel is null)
    {
        yield break;
    }

    yield return wezel.Wartosc;
    foreach (int wartosc in Preorder(wezel.Lewe))
    {
        yield return wartosc;
    }

    foreach (int wartosc in Preorder(wezel.Prawe))
    {
        yield return wartosc;
    }
}

internal sealed record Node(int Wartosc, Node? Lewe = null, Node? Prawe = null);
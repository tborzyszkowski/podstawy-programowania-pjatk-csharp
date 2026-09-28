Console.WriteLine($"Silnia rekurencyjna 10: {SilniaRekurencyjnie(10)}");
Console.WriteLine($"Silnia iteracyjna 10: {SilniaIteracyjnie(10)}");

Dictionary<int, long> pamiec = [];
Console.WriteLine($"Fibonacci memoizowany 40: {FibonacciMemo(40, pamiec)}");
Console.WriteLine($"Fibonacci iteracyjny 40: {FibonacciIteracyjnie(40)}");

static long SilniaRekurencyjnie(int n)
{
    if (n < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(n));
    }

    return n == 0 ? 1 : n * SilniaRekurencyjnie(n - 1);
}

static long SilniaIteracyjnie(int n)
{
    if (n < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(n));
    }

    long wynik = 1;
    for (int liczba = 2; liczba <= n; liczba++)
    {
        wynik = checked(wynik * liczba);
    }

    return wynik;
}

static long FibonacciMemo(int n, Dictionary<int, long> pamiec)
{
    if (n < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(n));
    }

    if (n <= 1)
    {
        return n;
    }

    if (pamiec.TryGetValue(n, out long zapamietany))
    {
        return zapamietany;
    }

    long wynik = checked(FibonacciMemo(n - 1, pamiec)
        + FibonacciMemo(n - 2, pamiec));
    pamiec[n] = wynik;
    return wynik;
}

static long FibonacciIteracyjnie(int n)
{
    if (n < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(n));
    }

    long poprzedni = 0;
    long nastepny = 1;
    for (int indeks = 0; indeks < n; indeks++)
    {
        (poprzedni, nastepny) =
            (nastepny, checked(poprzedni + nastepny));
    }

    return poprzedni;
}
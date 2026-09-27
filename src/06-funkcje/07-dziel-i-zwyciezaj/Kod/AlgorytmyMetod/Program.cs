int[] liczby = [2, 4, 6, 8, 10, 12];
int suma = SumaPrzedzialu(liczby, 0, liczby.Length - 1);
Console.WriteLine($"Suma: {suma}");

int szukana = 8;
int indeks = ZnajdzBinarnie(liczby, szukana, 0, liczby.Length - 1);
Console.WriteLine($"Indeks liczby {szukana}: {indeks}");

Console.WriteLine($"NWD(84, 30): {Nwd(84, 30)}");

static int SumaPrzedzialu(int[] liczby, int lewy, int prawy)
{
    if (lewy > prawy)
    {
        return 0;
    }

    if (lewy == prawy)
    {
        return liczby[lewy];
    }

    int srodek = (lewy + prawy) / 2;
    return SumaPrzedzialu(liczby, lewy, srodek)
        + SumaPrzedzialu(liczby, srodek + 1, prawy);
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

static int Nwd(int a, int b)
{
    a = Math.Abs(a);
    b = Math.Abs(b);

    while (b != 0)
    {
        (a, b) = (b, a % b);
    }

    return a;
}
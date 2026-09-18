int[] dane = { 9, 2, 7, 2, 5, 1, 8, 4 };

var algorytmy = new (string Nazwa, Func<int[], SortReport> Sortowanie)[]
{
    ("Babelkowe", SortowanieBabelkowe),
    ("Przez wybieranie", SortowaniePrzezWybieranie),
    ("Przez wstawianie", SortowaniePrzezWstawianie),
    ("Przez scalanie", SortowaniePrzezScalanie),
    ("Szybkie", SortowanieSzybkie),
    ("Kopcowanie", SortowanieKopcowanie),
    ("Array.Sort", SortowanieBiblioteczne)
};

foreach (var algorytm in algorytmy)
{
    SortReport raport = algorytm.Sortowanie((int[])dane.Clone());
    Console.WriteLine($"{algorytm.Nazwa,-18} {string.Join(", ", raport.Wartosci),-24} " +
        $"porownania: {raport.Porownania,3}, operacje: {raport.Operacje,3}");
}

static SortReport SortowanieBabelkowe(int[] wartosci)
{
    long porownania = 0;
    long operacje = 0;

    for (int koniec = wartosci.Length - 1; koniec > 0; koniec--)
    {
        bool zamiana = false;
        for (int indeks = 0; indeks < koniec; indeks++)
        {
            porownania++;
            if (wartosci[indeks] > wartosci[indeks + 1])
            {
                (wartosci[indeks], wartosci[indeks + 1]) =
                    (wartosci[indeks + 1], wartosci[indeks]);
                operacje++;
                zamiana = true;
            }
        }

        if (!zamiana)
        {
            break;
        }
    }

    return new SortReport(wartosci, porownania, operacje);
}

static SortReport SortowaniePrzezWybieranie(int[] wartosci)
{
    long porownania = 0;
    long operacje = 0;

    for (int poczatek = 0; poczatek < wartosci.Length - 1; poczatek++)
    {
        int indeksMinimum = poczatek;
        for (int indeks = poczatek + 1; indeks < wartosci.Length; indeks++)
        {
            porownania++;
            if (wartosci[indeks] < wartosci[indeksMinimum])
            {
                indeksMinimum = indeks;
            }
        }

        if (indeksMinimum != poczatek)
        {
            (wartosci[poczatek], wartosci[indeksMinimum]) =
                (wartosci[indeksMinimum], wartosci[poczatek]);
            operacje++;
        }
    }

    return new SortReport(wartosci, porownania, operacje);
}

static SortReport SortowaniePrzezWstawianie(int[] wartosci)
{
    long porownania = 0;
    long operacje = 0;

    for (int indeks = 1; indeks < wartosci.Length; indeks++)
    {
        int klucz = wartosci[indeks];
        int pozycja = indeks - 1;

        while (pozycja >= 0)
        {
            porownania++;
            if (wartosci[pozycja] <= klucz)
            {
                break;
            }

            wartosci[pozycja + 1] = wartosci[pozycja];
            operacje++;
            pozycja--;
        }

        wartosci[pozycja + 1] = klucz;
        operacje++;
    }

    return new SortReport(wartosci, porownania, operacje);
}

static SortReport SortowanieSzybkie(int[] wartosci)
{
    long porownania = 0;
    long operacje = 0;
    Szybkie(wartosci, 0, wartosci.Length - 1, ref porownania, ref operacje);
    return new SortReport(wartosci, porownania, operacje);
}

static SortReport SortowaniePrzezScalanie(int[] wartosci)
{
    long porownania = 0;
    long operacje = 0;
    int[] bufor = new int[wartosci.Length];
    ScalajSortowanie(wartosci, bufor, 0, wartosci.Length - 1,
        ref porownania, ref operacje);
    return new SortReport(wartosci, porownania, operacje);
}

static void ScalajSortowanie(int[] wartosci, int[] bufor, int lewy, int prawy,
    ref long porownania, ref long operacje)
{
    if (lewy >= prawy)
    {
        return;
    }

    int srodek = lewy + (prawy - lewy) / 2;
    ScalajSortowanie(wartosci, bufor, lewy, srodek, ref porownania, ref operacje);
    ScalajSortowanie(wartosci, bufor, srodek + 1, prawy,
        ref porownania, ref operacje);
    Scalaj(wartosci, bufor, lewy, srodek, prawy, ref porownania, ref operacje);
}

static void Scalaj(int[] wartosci, int[] bufor, int lewy, int srodek, int prawy,
    ref long porownania, ref long operacje)
{
    int lewyIndeks = lewy;
    int prawyIndeks = srodek + 1;
    int buforIndeks = lewy;

    while (lewyIndeks <= srodek && prawyIndeks <= prawy)
    {
        porownania++;
        if (wartosci[lewyIndeks] <= wartosci[prawyIndeks])
        {
            bufor[buforIndeks++] = wartosci[lewyIndeks++];
        }
        else
        {
            bufor[buforIndeks++] = wartosci[prawyIndeks++];
        }
        operacje++;
    }

    while (lewyIndeks <= srodek)
    {
        bufor[buforIndeks++] = wartosci[lewyIndeks++];
        operacje++;
    }

    while (prawyIndeks <= prawy)
    {
        bufor[buforIndeks++] = wartosci[prawyIndeks++];
        operacje++;
    }

    for (int indeks = lewy; indeks <= prawy; indeks++)
    {
        wartosci[indeks] = bufor[indeks];
        operacje++;
    }
}

static SortReport SortowanieKopcowanie(int[] wartosci)
{
    long porownania = 0;
    long operacje = 0;

    for (int indeks = wartosci.Length / 2 - 1; indeks >= 0; indeks--)
    {
        PrzesiejKopiec(wartosci, wartosci.Length, indeks,
            ref porownania, ref operacje);
    }

    for (int koniec = wartosci.Length - 1; koniec > 0; koniec--)
    {
        (wartosci[0], wartosci[koniec]) = (wartosci[koniec], wartosci[0]);
        operacje++;
        PrzesiejKopiec(wartosci, koniec, 0, ref porownania, ref operacje);
    }

    return new SortReport(wartosci, porownania, operacje);
}

static void PrzesiejKopiec(int[] wartosci, int rozmiarKopca, int korzen,
    ref long porownania, ref long operacje)
{
    while (true)
    {
        int najwiekszy = korzen;
        int lewy = 2 * korzen + 1;
        int prawy = 2 * korzen + 2;

        if (lewy < rozmiarKopca)
        {
            porownania++;
            if (wartosci[lewy] > wartosci[najwiekszy])
            {
                najwiekszy = lewy;
            }
        }

        if (prawy < rozmiarKopca)
        {
            porownania++;
            if (wartosci[prawy] > wartosci[najwiekszy])
            {
                najwiekszy = prawy;
            }
        }

        if (najwiekszy == korzen)
        {
            return;
        }

        (wartosci[korzen], wartosci[najwiekszy]) =
            (wartosci[najwiekszy], wartosci[korzen]);
        operacje++;
        korzen = najwiekszy;
    }
}

static void Szybkie(int[] wartosci, int lewy, int prawy,
    ref long porownania, ref long operacje)
{
    if (lewy >= prawy)
    {
        return;
    }

    int granica = Podziel(wartosci, lewy, prawy, ref porownania, ref operacje);
    Szybkie(wartosci, lewy, granica - 1, ref porownania, ref operacje);
    Szybkie(wartosci, granica + 1, prawy, ref porownania, ref operacje);
}

static int Podziel(int[] wartosci, int lewy, int prawy,
    ref long porownania, ref long operacje)
{
    int pivot = wartosci[prawy];
    int mniejszy = lewy - 1;

    for (int indeks = lewy; indeks < prawy; indeks++)
    {
        porownania++;
        if (wartosci[indeks] <= pivot)
        {
            mniejszy++;
            (wartosci[mniejszy], wartosci[indeks]) =
                (wartosci[indeks], wartosci[mniejszy]);
            operacje++;
        }
    }

    (wartosci[mniejszy + 1], wartosci[prawy]) =
        (wartosci[prawy], wartosci[mniejszy + 1]);
    operacje++;
    return mniejszy + 1;
}

static SortReport SortowanieBiblioteczne(int[] wartosci)
{
    Array.Sort(wartosci);
    return new SortReport(wartosci, 0, 0);
}

record SortReport(int[] Wartosci, long Porownania, long Operacje);

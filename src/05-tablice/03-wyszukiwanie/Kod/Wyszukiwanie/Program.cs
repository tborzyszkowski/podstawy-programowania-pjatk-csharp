int[] liczby = { 42, 7, 19, 7, 31, 5, 88, 13, 27 };
int szukana = 31;

int porownaniaLiniowe = 0;
int indeksLiniowy = SzukajLiniowo(liczby, szukana, ref porownaniaLiniowe);
Console.WriteLine($"Liniowo: indeks = {indeksLiniowy}, porownania = {porownaniaLiniowe}");

Array.Sort(liczby);
Console.WriteLine($"Posortowana tablica: {string.Join(", ", liczby)}");

int porownaniaBinarne = 0;
int indeksBinarny = SzukajBinarnie(liczby, szukana, ref porownaniaBinarne);
Console.WriteLine($"Binarnie: indeks = {indeksBinarny}, porownania = {porownaniaBinarne}");

int indeksBiblioteczny = Array.BinarySearch(liczby, szukana);
Console.WriteLine($"Array.BinarySearch: indeks = {indeksBiblioteczny}");

static int SzukajLiniowo(int[] liczby, int szukana, ref int porownania)
{
    for (int indeks = 0; indeks < liczby.Length; indeks++)
    {
        porownania++;
        if (liczby[indeks] == szukana)
        {
            return indeks;
        }
    }
    return -1;
}

static int SzukajBinarnie(int[] liczby, int szukana, ref int porownania)
{
    int lewy = 0;
    int prawy = liczby.Length - 1;

    while (lewy <= prawy)
    {
        int srodek = lewy + (prawy - lewy) / 2;
        porownania++;

        if (liczby[srodek] == szukana)
        {
            return srodek;
        }

        if (liczby[srodek] < szukana)
        {
            lewy = srodek + 1;
        }
        else
        {
            prawy = srodek - 1;
        }
    }

    return -1;
}

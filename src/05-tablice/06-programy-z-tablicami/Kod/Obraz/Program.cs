int[,] obraz =
{
    { 20, 20, 20, 20, 20 },
    { 20, 30, 30, 30, 20 },
    { 20, 30, 255, 30, 20 },
    { 20, 30, 30, 30, 20 },
    { 20, 20, 20, 20, 20 }
};

Wypisz("Przed wygladzaniem", obraz);
int[,] wynik = FiltrSredniej(obraz);
Wypisz("Po wygladzaniu", wynik);

static int[,] FiltrSredniej(int[,] obraz)
{
    int[,] wynik = new int[obraz.GetLength(0), obraz.GetLength(1)];

    for (int wiersz = 0; wiersz < obraz.GetLength(0); wiersz++)
    {
        for (int kolumna = 0; kolumna < obraz.GetLength(1); kolumna++)
        {
            int suma = 0;
            int liczba = 0;
            for (int deltaWiersz = -1; deltaWiersz <= 1; deltaWiersz++)
            {
                for (int deltaKolumna = -1; deltaKolumna <= 1; deltaKolumna++)
                {
                    int sasiadWiersz = wiersz + deltaWiersz;
                    int sasiadKolumna = kolumna + deltaKolumna;
                    if (sasiadWiersz >= 0 && sasiadWiersz < obraz.GetLength(0) &&
                        sasiadKolumna >= 0 && sasiadKolumna < obraz.GetLength(1))
                    {
                        suma += obraz[sasiadWiersz, sasiadKolumna];
                        liczba++;
                    }
                }
            }
            wynik[wiersz, kolumna] = suma / liczba;
        }
    }

    return wynik;
}

static void Wypisz(string tytul, int[,] obraz)
{
    Console.WriteLine(tytul);
    for (int wiersz = 0; wiersz < obraz.GetLength(0); wiersz++)
    {
        for (int kolumna = 0; kolumna < obraz.GetLength(1); kolumna++)
        {
            Console.Write($"{obraz[wiersz, kolumna],4}");
        }
        Console.WriteLine();
    }
}

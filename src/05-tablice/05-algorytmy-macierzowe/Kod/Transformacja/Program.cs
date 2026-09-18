using System.Numerics;

int[,] macierz =
{
    { 10, 20, 30, 40 },
    { 20, 30, 40, 50 },
    { 30, 40, 50, 60 }
};

WypiszMacierz("Macierz pomiarow", macierz);

int[] sumyWierszy = new int[macierz.GetLength(0)];
int[] sumyKolumn = new int[macierz.GetLength(1)];
for (int wiersz = 0; wiersz < macierz.GetLength(0); wiersz++)
{
    for (int kolumna = 0; kolumna < macierz.GetLength(1); kolumna++)
    {
        sumyWierszy[wiersz] += macierz[wiersz, kolumna];
        sumyKolumn[kolumna] += macierz[wiersz, kolumna];
    }
}

Console.WriteLine($"Sumy wierszy: {string.Join(", ", sumyWierszy)}");
Console.WriteLine($"Sumy kolumn: {string.Join(", ", sumyKolumn)}");

int[,] transpozycja = Transponuj(macierz);
WypiszMacierz("Transpozycja", transpozycja);

int[,] obraz =
{
    { 10, 10, 10, 10, 10 },
    { 10, 20, 20, 20, 10 },
    { 10, 20, 255, 20, 10 },
    { 10, 20, 20, 20, 10 },
    { 10, 10, 10, 10, 10 }
};

WypiszMacierz("Obraz przed filtrem", obraz);
int[,] wygladzony = FiltrSredniej(obraz);
WypiszMacierz("Obraz po filtrze sredniej", wygladzony);

Vector3 punkt = new(1, 0, 0);
Matrix4x4 skala = Matrix4x4.CreateScale(2, 1, 1);
Matrix4x4 obrot = Matrix4x4.CreateRotationZ(MathF.PI / 2);
Matrix4x4 przesuniecie = Matrix4x4.CreateTranslation(10, 5, 0);
Matrix4x4 transformacja = skala * obrot * przesuniecie;
Vector3 wynik = Vector3.Transform(punkt, transformacja);

Console.WriteLine($"Punkt {punkt} po transformacji: ({wynik.X:F2}, {wynik.Y:F2}, {wynik.Z:F2})");
Console.WriteLine($"Oczekiwany punkt jest blisko (10, 7, 0): {Blisko(wynik, new Vector3(10, 7, 0))}");

static int[,] Transponuj(int[,] zrodlo)
{
    int[,] wynik = new int[zrodlo.GetLength(1), zrodlo.GetLength(0)];
    for (int wiersz = 0; wiersz < zrodlo.GetLength(0); wiersz++)
    {
        for (int kolumna = 0; kolumna < zrodlo.GetLength(1); kolumna++)
        {
            wynik[kolumna, wiersz] = zrodlo[wiersz, kolumna];
        }
    }
    return wynik;
}

static int[,] FiltrSredniej(int[,] obraz)
{
    int[,] wynik = new int[obraz.GetLength(0), obraz.GetLength(1)];

    for (int wiersz = 0; wiersz < obraz.GetLength(0); wiersz++)
    {
        for (int kolumna = 0; kolumna < obraz.GetLength(1); kolumna++)
        {
            int suma = 0;
            int liczbaSasiadow = 0;

            for (int przesuniecieWiersza = -1; przesuniecieWiersza <= 1; przesuniecieWiersza++)
            {
                for (int przesuniecieKolumny = -1; przesuniecieKolumny <= 1; przesuniecieKolumny++)
                {
                    int sasiadWiersz = wiersz + przesuniecieWiersza;
                    int sasiadKolumna = kolumna + przesuniecieKolumny;
                    if (sasiadWiersz >= 0 && sasiadWiersz < obraz.GetLength(0) &&
                        sasiadKolumna >= 0 && sasiadKolumna < obraz.GetLength(1))
                    {
                        suma += obraz[sasiadWiersz, sasiadKolumna];
                        liczbaSasiadow++;
                    }
                }
            }

            wynik[wiersz, kolumna] = suma / liczbaSasiadow;
        }
    }

    return wynik;
}

static void WypiszMacierz(string tytul, int[,] macierz)
{
    Console.WriteLine(tytul);
    for (int wiersz = 0; wiersz < macierz.GetLength(0); wiersz++)
    {
        for (int kolumna = 0; kolumna < macierz.GetLength(1); kolumna++)
        {
            Console.Write($"{macierz[wiersz, kolumna],4}");
        }
        Console.WriteLine();
    }
}

static bool Blisko(Vector3 pierwszy, Vector3 drugi)
{
    return Vector3.Distance(pierwszy, drugi) < 0.001f;
}

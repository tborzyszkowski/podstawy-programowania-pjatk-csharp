Console.WriteLine("Podawaj liczby nieujemne. -1 kończy dane.");
int suma = 0;
int licznik = 0;
int pominiete = 0;
int minimum = 0;
int maksimum = 0;
int liczba;

do
{
    liczba = WczytajLiczbe();
    if (liczba == -1)
    {
        continue;
    }

    if (liczba < -1)
    {
        pominiete++;
        continue;
    }

    if (licznik == 0)
    {
        minimum = liczba;
        maksimum = liczba;
    }
    else
    {
        if (liczba < minimum) minimum = liczba;
        if (liczba > maksimum) maksimum = liczba;
    }

    suma += liczba;
    licznik++;
}
while (liczba != -1);

if (licznik == 0)
{
    Console.WriteLine("Brak poprawnych danych.");
}
else
{
    Console.WriteLine($"Minimum: {minimum}");
    Console.WriteLine($"Maksimum: {maksimum}");
    Console.WriteLine($"Średnia: {(double)suma / licznik:0.00}");
    Console.WriteLine($"Pominięte wartości: {pominiete}");
}

static int WczytajLiczbe()
{
    Console.Write("Liczba: ");
    int wynik;
    while (!int.TryParse(Console.ReadLine(), out wynik))
    {
        Console.Write("Podaj liczbę całkowitą: ");
    }

    return wynik;
}
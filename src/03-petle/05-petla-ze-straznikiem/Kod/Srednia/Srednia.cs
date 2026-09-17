Console.WriteLine("Podawaj liczby. -1 kończy wczytywanie.");
int suma = 0;
int licznik = 0;
int liczba;

do
{
    liczba = WczytajLiczbe();
    if (liczba != -1)
    {
        suma += liczba;
        licznik++;
    }
}
while (liczba != -1);

if (licznik == 0)
{
    Console.WriteLine("Nie podano żadnych danych.");
}
else
{
    Console.WriteLine($"Średnia: {(double)suma / licznik:0.00}");
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
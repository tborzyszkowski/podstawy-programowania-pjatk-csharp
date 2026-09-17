Console.WriteLine("Podawaj nieujemne liczby. -1 kończy wczytywanie.");
int suma = 0;
int liczba = WczytajLiczbe();

while (liczba != -1)
{
    if (liczba >= 0)
    {
        suma += liczba;
    }
    else
    {
        Console.WriteLine("Odrzucono wartość ujemną inną niż strażnik.");
    }

    liczba = WczytajLiczbe();
}

Console.WriteLine($"Suma: {suma}");

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
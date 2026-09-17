Console.Write("Podaj początek zakresu: ");
if (!int.TryParse(Console.ReadLine(), out int poczatek))
{
    Console.WriteLine("Niepoprawny początek zakresu.");
    return;
}

Console.Write("Podaj koniec zakresu: ");
if (!int.TryParse(Console.ReadLine(), out int koniec) || koniec < poczatek)
{
    Console.WriteLine("Koniec musi być liczbą nie mniejszą od początku.");
    return;
}

int suma = 0;
for (int liczba = poczatek; liczba <= koniec; liczba++)
{
    suma += liczba;
}

Console.WriteLine($"Suma: {suma}");
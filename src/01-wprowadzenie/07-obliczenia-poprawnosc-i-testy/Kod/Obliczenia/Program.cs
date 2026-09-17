int wszystkie = 0;
int zaliczone = 0;

SprawdzDecimal("Pole 3 x 4", 12, Obliczenia.PoleProstokata(3, 4));
SprawdzDecimal("Pole z zerowym bokiem", 0, Obliczenia.PoleProstokata(0, 5));
SprawdzDecimal("Średnia [2, 4]", 3, Obliczenia.Srednia(new decimal[] { 2, 4 }));
SprawdzDecimal("Celsjusz 0", 32, Obliczenia.CelsjuszNaFahrenheit(0));
SprawdzDecimal("Celsjusz -40", -40, Obliczenia.CelsjuszNaFahrenheit(-40));
SprawdzInt("NWD 48 i 18", 6, Obliczenia.NajwiekszyWspolnyDzielnik(48, 18));
SprawdzInt("NWD liczby z samą sobą", 7, Obliczenia.NajwiekszyWspolnyDzielnik(7, 7));
SprawdzDecimal("Rabat 20%", 80, Obliczenia.CenaPoRabacie(100, 20));
SprawdzDecimal("Brak rabatu", 100, Obliczenia.CenaPoRabacie(100, 0));
SprawdzWyjatek("Ujemny bok", () => Obliczenia.PoleProstokata(-1, 5));
SprawdzWyjatek("Pusta średnia", () => Obliczenia.Srednia(Array.Empty<decimal>()));
SprawdzWyjatek("Rabat większy niż 100%", () => Obliczenia.CenaPoRabacie(100, 101));

Console.WriteLine($"Zaliczone testy: {zaliczone}/{wszystkie}");

void SprawdzDecimal(string nazwa, decimal oczekiwany, decimal rzeczywisty)
{
    wszystkie++;
    bool zaliczony = oczekiwany == rzeczywisty;
    if (zaliczony) zaliczone++;
    Console.WriteLine($"{(zaliczony ? "PASS" : "FAIL"),4} {nazwa}: oczekiwano {oczekiwany}, otrzymano {rzeczywisty}");
}

void SprawdzInt(string nazwa, int oczekiwany, int rzeczywisty)
{
    wszystkie++;
    bool zaliczony = oczekiwany == rzeczywisty;
    if (zaliczony) zaliczone++;
    Console.WriteLine($"{(zaliczony ? "PASS" : "FAIL"),4} {nazwa}: oczekiwano {oczekiwany}, otrzymano {rzeczywisty}");
}

void SprawdzWyjatek(string nazwa, Action operacja)
{
    wszystkie++;
    try
    {
        operacja();
        Console.WriteLine($" FAIL {nazwa}: nie zgłoszono oczekiwanego wyjątku");
    }
    catch (ArgumentException)
    {
        zaliczone++;
        Console.WriteLine($"PASS {nazwa}: zgłoszono wyjątek dla błędnych danych");
    }
}
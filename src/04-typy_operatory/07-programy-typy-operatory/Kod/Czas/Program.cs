Console.Write("Podaj liczbę sekund: ");
if (!int.TryParse(Console.ReadLine(), out int sekundy) || sekundy < 0)
{
    Console.WriteLine("Sekundy muszą być nieujemne.");
    return;
}

const int SekundyNaGodzine = 3600;
int godziny = sekundy / SekundyNaGodzine;
int pozostalePoGodzinach = sekundy % SekundyNaGodzine;
int minuty = pozostalePoGodzinach / 60;
int pozostaleSekundy = pozostalePoGodzinach % 60;
Console.WriteLine($"{godziny:00}:{minuty:00}:{pozostaleSekundy:00}");
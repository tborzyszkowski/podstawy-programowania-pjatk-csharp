const int MinimumPunktow = 0;
const int MaksimumPunktow = 100;

Console.Write("Podaj punkty: ");
if (!int.TryParse(Console.ReadLine(), out int punkty))
{
    Console.WriteLine("Punkty muszą być liczbą całkowitą.");
    return;
}

bool poprawne = punkty >= MinimumPunktow && punkty <= MaksimumPunktow;
Console.WriteLine(poprawne ? "Punkty są w zakresie." : "Punkty są poza zakresem.");
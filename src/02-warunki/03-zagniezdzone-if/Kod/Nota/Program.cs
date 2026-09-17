Console.Write("Podaj liczbę punktów: ");
if (!int.TryParse(Console.ReadLine(), out int punkty))
{
    Console.WriteLine("Punkty muszą być liczbą całkowitą.");
    return;
}

if (punkty >= 0 && punkty <= 100)
{
    if (punkty >= 90)
    {
        Console.WriteLine("Wynik: bardzo dobry.");
    }
    else
    {
        Console.WriteLine(punkty >= 50 ? "Wynik: zaliczony." : "Wynik: niezaliczony.");
    }
}
else
{
    Console.WriteLine("Błędny zakres punktów.");
}
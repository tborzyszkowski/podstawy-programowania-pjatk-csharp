Console.Write("Podaj liczbę punktów: ");
if (!int.TryParse(Console.ReadLine(), out int punkty) || punkty < 0 || punkty > 100)
{
    Console.WriteLine("Punkty muszą należeć do zakresu 0-100.");
    return;
}

string ocena;
if (punkty >= 90)
{
    ocena = punkty == 100 ? "celujący" : "bardzo dobry";
}
else if (punkty >= 50)
{
    ocena = "zaliczony";
}
else
{
    ocena = "niezaliczony";
}

Console.WriteLine($"Wynik: {ocena}");
Console.Write("Podaj liczbę punktów: ");
if (!int.TryParse(Console.ReadLine(), out int punkty))
{
    Console.WriteLine("Punkty muszą być liczbą całkowitą.");
    return;
}

string status = punkty >= 50 ? "zaliczony" : "niezaliczony";
Console.WriteLine($"Status: {status}");
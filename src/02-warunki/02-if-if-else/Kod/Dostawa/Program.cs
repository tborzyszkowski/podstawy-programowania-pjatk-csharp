Console.Write("Podaj wartość zamówienia: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal wartosc) || wartosc < 0)
{
    Console.WriteLine("Wartość zamówienia musi być nieujemna.");
    return;
}

decimal kosztDostawy;
if (wartosc >= 200)
{
    kosztDostawy = 0;
}
else
{
    kosztDostawy = 15;
}

Console.WriteLine($"Koszt dostawy: {kosztDostawy:0.00}");
Console.Write("Podaj wartość koszyka: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal wartosc) || wartosc < 0)
{
    Console.WriteLine("Wartość musi być nieujemna.");
    return;
}

decimal procent = wartosc >= 500 ? 20 : wartosc >= 200 ? 10 : 0;
decimal poRabacie = wartosc * (100 - procent) / 100;
string dostawa = poRabacie >= 200 ? "darmowa" : "płatna";

Console.WriteLine($"Rabat: {procent}%");
Console.WriteLine($"Do zapłaty: {poRabacie:0.00} zł, dostawa: {dostawa}");
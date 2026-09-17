Console.Write("Podaj liczbę całkowitą: ");
if (!int.TryParse(Console.ReadLine(), out int liczba))
{
    Console.WriteLine("Niepoprawne dane.");
    return;
}

int wartoscBezwzgledna = liczba < 0 ? -liczba : liczba;
Console.WriteLine($"Wartość bezwzględna: {wartoscBezwzgledna}");
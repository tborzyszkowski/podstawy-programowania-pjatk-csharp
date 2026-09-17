Console.Write("Podaj kwotę netto: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal netto) || netto < 0)
{
    Console.WriteLine("Kwota musi być nieujemna.");
    return;
}

decimal brutto = netto * 1.23m;
Console.WriteLine($"Brutto: {brutto:0.00}");
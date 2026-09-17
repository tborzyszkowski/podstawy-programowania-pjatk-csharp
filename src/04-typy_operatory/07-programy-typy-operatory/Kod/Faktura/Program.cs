const decimal Vat = 0.23m;
Console.Write("Cena netto: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal cenaNetto) || cenaNetto < 0)
{
    Console.WriteLine("Cena musi być nieujemna.");
    return;
}

Console.Write("Liczba sztuk: ");
if (!int.TryParse(Console.ReadLine(), out int ilosc) || ilosc < 0)
{
    Console.WriteLine("Liczba sztuk musi być nieujemna.");
    return;
}

decimal netto = cenaNetto * ilosc;
decimal brutto = netto * (1 + Vat);
Console.WriteLine($"Netto: {netto:0.00}, VAT: {netto * Vat:0.00}, brutto: {brutto:0.00}");
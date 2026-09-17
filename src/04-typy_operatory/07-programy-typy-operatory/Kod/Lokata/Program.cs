const decimal Podatek = 0.19m;
const decimal MinimalnaKwota = 100;
Console.Write("Kwota lokaty: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal kwota) || kwota < MinimalnaKwota)
{
    Console.WriteLine($"Kwota musi wynosić co najmniej {MinimalnaKwota:0.00}.");
    return;
}

Console.Write("Oprocentowanie roczne w procentach: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal oprocentowanie) || oprocentowanie < 0)
{
    Console.WriteLine("Oprocentowanie musi być nieujemne.");
    return;
}

decimal odsetkiBrutto = kwota * oprocentowanie / 100;
decimal odsetkiNetto = odsetkiBrutto * (1 - Podatek);
Console.WriteLine($"Odsetki netto: {odsetkiNetto:0.00}");
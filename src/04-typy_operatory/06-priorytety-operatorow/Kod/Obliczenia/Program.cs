Console.WriteLine($"2 + 3 * 4 = {2 + 3 * 4}");
Console.WriteLine($"(2 + 3) * 4 = {(2 + 3) * 4}");
Console.WriteLine($"20 / 5 * 2 = {20 / 5 * 2}");
Console.WriteLine($"20 / (5 * 2) = {20 / (5 * 2)}");

decimal netto = 100;
decimal dostawa = 20;
decimal stawkaVat = 0.23m;
decimal brutto = (netto + dostawa) * (1 + stawkaVat);
Console.WriteLine($"Brutto: {brutto:0.00}");
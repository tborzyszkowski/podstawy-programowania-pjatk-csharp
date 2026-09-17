Console.Write("Podaj wiek: ");
if (!int.TryParse(Console.ReadLine(), out int wiek) || wiek < 0)
{
    Console.WriteLine("Niepoprawny wiek.");
    return;
}

decimal cena;
if (wiek < 7)
{
    cena = 0;
}
else if (wiek < 18)
{
    cena = 10;
}
else
{
    cena = 20;
}

Console.WriteLine($"Cena biletu: {cena:0.00} zł");
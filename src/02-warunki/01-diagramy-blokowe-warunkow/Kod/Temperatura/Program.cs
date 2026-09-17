Console.Write("Podaj temperaturę: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal temperatura))
{
    Console.WriteLine("Niepoprawne dane.");
    return;
}

string komunikat;
if (temperatura < 0)
{
    komunikat = "mróz";
}
else
{
    komunikat = "brak mrozu";
}

Console.WriteLine(komunikat);
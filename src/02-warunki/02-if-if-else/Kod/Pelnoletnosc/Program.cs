Console.Write("Podaj wiek: ");
if (!int.TryParse(Console.ReadLine(), out int wiek) || wiek < 0)
{
    Console.WriteLine("Wiek musi być nieujemną liczbą całkowitą.");
    return;
}

string komunikat;
if (wiek >= 18)
{
    komunikat = "Osoba jest pełnoletnia.";
}
else
{
    komunikat = "Osoba jest niepełnoletnia.";
}

Console.WriteLine(komunikat);
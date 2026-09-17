Console.Write("Podaj liczbę całkowitą: ");
if (!int.TryParse(Console.ReadLine(), out int liczba))
{
    Console.WriteLine("Niepoprawne dane.");
    return;
}

bool wZakresie = liczba >= 0 && liczba <= 100;
if (!wZakresie)
{
    Console.WriteLine("Liczba jest poza zakresem 0-100.");
}
else
{
    bool czyParzysta = liczba % 2 == 0;
    Console.WriteLine(czyParzysta ? "Liczba jest parzysta." : "Liczba jest nieparzysta.");
}
Console.Write("Podaj liczbę od 0 do 100: ");
if (!int.TryParse(Console.ReadLine(), out int liczba))
{
    Console.WriteLine("Niepoprawna liczba.");
    return;
}

bool poprawny = liczba >= 0 && liczba <= 100;
bool parzysty = liczba % 2 == 0;
Console.WriteLine(poprawny && parzysty ? "Poprawna liczba parzysta." : "Warunek nie jest spełniony.");
Console.Write("Podaj wiek: ");
if (!int.TryParse(Console.ReadLine(), out int wiek) || wiek < 0)
{
    Console.WriteLine("Niepoprawny wiek.");
    return;
}

Console.Write("Czy masz bilet? (tak/nie): ");
bool maBilet = (Console.ReadLine() ?? "").Trim().ToLowerInvariant() == "tak";
bool maZgode = maBilet && wiek >= 18;
Console.WriteLine(maZgode ? "Możesz wejść." : "Brak zgody na wejście.");
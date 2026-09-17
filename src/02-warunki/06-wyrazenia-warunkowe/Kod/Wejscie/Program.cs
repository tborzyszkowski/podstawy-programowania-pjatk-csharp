Console.Write("Podaj wiek: ");
if (!int.TryParse(Console.ReadLine(), out int wiek) || wiek < 0)
{
    Console.WriteLine("Niepoprawny wiek.");
    return;
}

Console.Write("Czy masz bilet? (tak/nie): ");
bool maBilet = (Console.ReadLine() ?? "").Trim().ToLowerInvariant() == "tak";
Console.Write("Czy jesteś z opiekunem? (tak/nie): ");
bool jestZOpiekunem = (Console.ReadLine() ?? "").Trim().ToLowerInvariant() == "tak";
Console.Write("Czy masz zakaz wejścia? (tak/nie): ");
bool maZakaz = (Console.ReadLine() ?? "").Trim().ToLowerInvariant() == "tak";

bool pelnoletniZBiletem = wiek >= 18 && maBilet;
bool mozeWejsc = !maZakaz && (pelnoletniZBiletem || jestZOpiekunem);
Console.WriteLine(mozeWejsc ? "Możesz wejść." : "Nie możesz wejść.");
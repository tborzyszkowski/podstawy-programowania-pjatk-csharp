Console.Write("Wybierz tryb: dzien, noc albo auto: ");
string tryb = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
int jasnosc;

switch (tryb)
{
    case "dzien":
        jasnosc = 100;
        break;
    case "noc":
        jasnosc = 25;
        break;
    case "auto":
        Console.Write("Czy jest jasno? (tak/nie): ");
        bool jestJasno = (Console.ReadLine() ?? "").Trim().ToLowerInvariant() == "tak";
        jasnosc = jestJasno ? 100 : 25;
        break;
    default:
        Console.WriteLine("Nieznany tryb.");
        return;
}

Console.WriteLine($"Ustawiono jasność: {jasnosc}%");
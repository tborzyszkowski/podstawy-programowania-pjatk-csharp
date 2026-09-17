decimal saldo = 100;
Console.Write("Wybierz: saldo, wyplata albo koniec: ");
string komenda = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();

switch (komenda)
{
    case "saldo":
        Console.WriteLine($"Saldo: {saldo:0.00}");
        break;
    case "wyplata":
        Console.Write("Podaj kwotę: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal kwota) || kwota <= 0)
        {
            Console.WriteLine("Kwota musi być dodatnia.");
        }
        else if (kwota <= saldo)
        {
            saldo -= kwota;
            Console.WriteLine($"Wypłacono. Nowe saldo: {saldo:0.00}");
        }
        else
        {
            Console.WriteLine("Brak wystarczających środków.");
        }
        break;
    case "koniec":
        Console.WriteLine("Koniec pracy.");
        break;
    default:
        Console.WriteLine("Nieznana komenda.");
        break;
}
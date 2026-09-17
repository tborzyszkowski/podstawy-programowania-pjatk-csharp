Console.WriteLine("Ocena możliwości wykonania przelewu");
decimal saldo = WczytajDecimal("Podaj saldo: ");
decimal kwota = WczytajDecimal("Podaj kwotę przelewu: ");
decimal limit = WczytajDecimal("Podaj limit pojedynczego przelewu: ");

if (CzyPrzelewMozliwy(saldo, kwota, limit))
{
    decimal noweSaldo = saldo - kwota;
    Console.WriteLine($"Przelew zaakceptowany. Saldo po operacji: {noweSaldo:0.00}");
}
else
{
    Console.WriteLine("Przelew odrzucony: sprawdź kwotę, saldo i limit.");
}

static decimal WczytajDecimal(string komunikat)
{
    Console.Write(komunikat);
    decimal wynik;
    while (!decimal.TryParse(Console.ReadLine(), out wynik))
    {
        Console.Write("Niepoprawna liczba. Spróbuj ponownie: ");
    }

    return wynik;
}

static bool CzyPrzelewMozliwy(decimal saldo, decimal kwota, decimal limit)
{
    return kwota > 0 && kwota <= saldo && kwota <= limit;
}
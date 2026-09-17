Console.WriteLine("Obliczanie ceny koszyka");
decimal cena = WczytajDecimal("Cena jednej sztuki: ");
int ilosc = WczytajInt("Liczba sztuk: ");

if (cena <= 0 || ilosc <= 0)
{
    Console.WriteLine("Cena i liczba sztuk muszą być dodatnie.");
    return;
}

decimal suma = cena * ilosc;
decimal procentRabatu = suma >= 200 ? 10 : 0;
decimal kwotaRabatu = suma * procentRabatu / 100;
decimal doZaplaty = suma - kwotaRabatu;

Console.WriteLine($"Suma: {suma:0.00}");
Console.WriteLine($"Rabat: {procentRabatu:0}% ({kwotaRabatu:0.00})");
Console.WriteLine($"Do zapłaty: {doZaplaty:0.00}");

static decimal WczytajDecimal(string komunikat)
{
    Console.Write(komunikat);
    decimal wynik;
    while (!decimal.TryParse(Console.ReadLine(), out wynik))
    {
        Console.Write("Niepoprawna wartość. Spróbuj ponownie: ");
    }

    return wynik;
}

static int WczytajInt(string komunikat)
{
    Console.Write(komunikat);
    int wynik;
    while (!int.TryParse(Console.ReadLine(), out wynik))
    {
        Console.Write("Niepoprawna liczba. Spróbuj ponownie: ");
    }

    return wynik;
}
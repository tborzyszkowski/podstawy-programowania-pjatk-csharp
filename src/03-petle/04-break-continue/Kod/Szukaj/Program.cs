Console.Write("Podaj liczbę większą niż 1: ");
if (!int.TryParse(Console.ReadLine(), out int liczba) || liczba <= 1)
{
    Console.WriteLine("Liczba musi być większa niż 1.");
    return;
}

int dzielnik = 0;
for (int kandydat = 2; kandydat < liczba; kandydat++)
{
    if (liczba % kandydat == 0)
    {
        dzielnik = kandydat;
        break;
    }
}

Console.WriteLine(dzielnik == 0 ? "Liczba jest pierwsza." : $"Pierwszy znaleziony dzielnik: {dzielnik}");
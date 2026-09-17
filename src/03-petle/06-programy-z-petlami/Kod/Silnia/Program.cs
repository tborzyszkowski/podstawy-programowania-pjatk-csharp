Console.Write("Podaj n: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 0 || n > 12)
{
    Console.WriteLine("n musi należeć do zakresu 0-12.");
    return;
}

int wynik = 1;
int pozostalo = n;
while (pozostalo > 1)
{
    wynik *= pozostalo;
    pozostalo--;
}

Console.WriteLine($"{n}! = {wynik}");
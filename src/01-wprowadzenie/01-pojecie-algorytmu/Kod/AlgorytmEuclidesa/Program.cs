Console.WriteLine("Algorytm Euklidesa - największy wspólny dzielnik");
Console.Write("Podaj dodatnią liczbę a: ");
string? tekstA = Console.ReadLine();
Console.Write("Podaj dodatnią liczbę b: ");
string? tekstB = Console.ReadLine();

if (!int.TryParse(tekstA, out int a) || !int.TryParse(tekstB, out int b) || a <= 0 || b <= 0)
{
    Console.WriteLine("Błąd: oczekiwano dwóch dodatnich liczb całkowitych.");
    return;
}

Console.WriteLine($"Stan początkowy: a = {a}, b = {b}");
int wynik = NwdZLogiem(a, b);
Console.WriteLine($"NWD({a}, {b}) = {wynik}");

static int NwdZLogiem(int a, int b)
{
    while (b != 0)
    {
        int reszta = a % b;
        Console.WriteLine($"Krok: a = {a}, b = {b}, reszta = {reszta}");
        a = b;
        b = reszta;
    }

    return a;
}
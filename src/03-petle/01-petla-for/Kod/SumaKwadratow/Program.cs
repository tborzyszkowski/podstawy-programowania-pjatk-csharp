Console.Write("Podaj n: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
{
    Console.WriteLine("n musi być nieujemną liczbą całkowitą.");
    return;
}

int suma = 0;
for (int i = 1; i <= n; i++)
{
    suma += i * i;
}

Console.WriteLine($"Suma kwadratów od 1 do {n}: {suma}");
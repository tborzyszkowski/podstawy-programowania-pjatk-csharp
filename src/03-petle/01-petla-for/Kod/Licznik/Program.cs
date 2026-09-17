Console.Write("Podaj n: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
{
    Console.WriteLine("n musi być nieujemną liczbą całkowitą.");
    return;
}

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i);
}
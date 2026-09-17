Console.Write("Podaj n: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
{
    Console.WriteLine("n musi być dodatnie.");
    return;
}

for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }

    Console.WriteLine(i);
}
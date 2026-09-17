Console.Write("Podaj maksymalny mnożnik: ");
if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
{
    Console.WriteLine("n musi być dodatnie.");
    return;
}

for (int wiersz = 1; wiersz <= n; wiersz++)
{
    for (int kolumna = 1; kolumna <= n; kolumna++)
    {
        Console.Write($"{wiersz * kolumna,4}");
    }

    Console.WriteLine();
}
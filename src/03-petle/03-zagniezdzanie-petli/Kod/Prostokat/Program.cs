Console.Write("Podaj wysokość: ");
if (!int.TryParse(Console.ReadLine(), out int wysokosc) || wysokosc < 0)
{
    Console.WriteLine("Wysokość musi być nieujemna.");
    return;
}

Console.Write("Podaj szerokość: ");
if (!int.TryParse(Console.ReadLine(), out int szerokosc) || szerokosc < 0)
{
    Console.WriteLine("Szerokość musi być nieujemna.");
    return;
}

for (int wiersz = 0; wiersz < wysokosc; wiersz++)
{
    for (int kolumna = 0; kolumna < szerokosc; kolumna++)
    {
        Console.Write('*');
    }

    Console.WriteLine();
}
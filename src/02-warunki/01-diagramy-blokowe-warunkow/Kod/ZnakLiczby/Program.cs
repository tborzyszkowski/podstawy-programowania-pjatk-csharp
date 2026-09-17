Console.Write("Podaj liczbę całkowitą: ");
if (!int.TryParse(Console.ReadLine(), out int liczba))
{
    Console.WriteLine("Niepoprawne dane.");
    return;
}

if (liczba < 0)
{
    Console.WriteLine("Liczba jest ujemna.");
}
else if (liczba == 0)
{
    Console.WriteLine("Liczba jest równa zero.");
}
else
{
    Console.WriteLine("Liczba jest dodatnia.");
}
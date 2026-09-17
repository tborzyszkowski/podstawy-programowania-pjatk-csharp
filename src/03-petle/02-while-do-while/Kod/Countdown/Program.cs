Console.Write("Od jakiej liczby odliczać? ");
if (!int.TryParse(Console.ReadLine(), out int pozostalo) || pozostalo < 0)
{
    Console.WriteLine("Podaj liczbę nieujemną.");
    return;
}

while (pozostalo > 0)
{
    Console.WriteLine(pozostalo);
    pozostalo--;
}

Console.WriteLine("Start!");
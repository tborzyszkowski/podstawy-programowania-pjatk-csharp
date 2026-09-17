Console.Write("Podaj górną granicę: ");
if (!int.TryParse(Console.ReadLine(), out int granica) || granica < 2)
{
    Console.WriteLine("Granica musi być co najmniej 2.");
    return;
}

for (int kandydat = 2; kandydat <= granica; kandydat++)
{
    bool pierwsza = true;
    for (int dzielnik = 2; dzielnik * dzielnik <= kandydat; dzielnik++)
    {
        if (kandydat % dzielnik == 0)
        {
            pierwsza = false;
            break;
        }
    }

    if (pierwsza)
    {
        Console.Write($"{kandydat} ");
    }
}

Console.WriteLine();
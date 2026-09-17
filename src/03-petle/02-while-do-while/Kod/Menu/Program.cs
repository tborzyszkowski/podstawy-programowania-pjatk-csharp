string komenda;
do
{
    Console.Write("Wybierz: 1 - powitanie, 2 - stan, 0 - koniec: ");
    komenda = Console.ReadLine() ?? "";

    if (komenda == "1")
    {
        Console.WriteLine("Witaj!");
    }
    else if (komenda == "2")
    {
        Console.WriteLine("Program działa.");
    }
    else if (komenda != "0")
    {
        Console.WriteLine("Nieznana opcja.");
    }
}
while (komenda != "0");

Console.WriteLine("Koniec programu.");
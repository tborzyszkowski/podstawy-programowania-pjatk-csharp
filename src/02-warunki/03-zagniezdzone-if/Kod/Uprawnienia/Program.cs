Console.Write("Podaj PIN: ");
if (!int.TryParse(Console.ReadLine(), out int pin))
{
    Console.WriteLine("PIN musi być liczbą.");
    return;
}

Console.Write("Podaj rolę: ");
string rola = Console.ReadLine() ?? "";

if (pin == 1234)
{
    if (rola == "admin")
    {
        Console.WriteLine("Przyznano pełny dostęp.");
    }
    else
    {
        Console.WriteLine("Przyznano dostęp standardowy.");
    }
}
else
{
    Console.WriteLine("Odmowa dostępu.");
}
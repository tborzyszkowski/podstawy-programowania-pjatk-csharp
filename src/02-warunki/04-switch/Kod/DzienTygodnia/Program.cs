Console.Write("Podaj numer dnia (1-7): ");
if (!int.TryParse(Console.ReadLine(), out int numer) || numer < 1 || numer > 7)
{
    Console.WriteLine("Niepoprawny numer dnia.");
    return;
}

switch (numer)
{
    case 1:
        Console.WriteLine("Poniedziałek - dzień roboczy.");
        break;
    case 2:
        Console.WriteLine("Wtorek - dzień roboczy.");
        break;
    case 3:
        Console.WriteLine("Środa - dzień roboczy.");
        break;
    case 4:
        Console.WriteLine("Czwartek - dzień roboczy.");
        break;
    case 5:
        Console.WriteLine("Piątek - dzień roboczy.");
        break;
    case 6:
    case 7:
        Console.WriteLine("Weekend.");
        break;
}
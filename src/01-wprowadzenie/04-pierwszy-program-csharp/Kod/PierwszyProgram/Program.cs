Console.Write("Podaj imię: ");
string imie = Console.ReadLine() ?? "";

if (string.IsNullOrWhiteSpace(imie))
{
    imie = "student";
}

Console.WriteLine($"Witaj, {imie}!");
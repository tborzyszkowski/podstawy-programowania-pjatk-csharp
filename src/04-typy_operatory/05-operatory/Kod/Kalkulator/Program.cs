Console.Write("Podaj pierwszą liczbę: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal pierwsza))
{
    Console.WriteLine("Niepoprawna liczba.");
    return;
}

Console.Write("Podaj drugą liczbę: ");
if (!decimal.TryParse(Console.ReadLine(), out decimal druga))
{
    Console.WriteLine("Niepoprawna liczba.");
    return;
}

Console.Write("Podaj operator (+, -, *, /): ");
string operatorTekst = Console.ReadLine() ?? "";
if (operatorTekst == "/" && druga == 0)
{
    Console.WriteLine("Nie można dzielić przez zero.");
    return;
}

decimal wynik;
if (operatorTekst == "+") wynik = pierwsza + druga;
else if (operatorTekst == "-") wynik = pierwsza - druga;
else if (operatorTekst == "*") wynik = pierwsza * druga;
else if (operatorTekst == "/") wynik = pierwsza / druga;
else
{
    Console.WriteLine("Nieznany operator.");
    return;
}

Console.WriteLine($"Wynik: {wynik:0.####}");
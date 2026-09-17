Console.Write("Bok a: ");
if (!double.TryParse(Console.ReadLine(), out double a))
{
    Console.WriteLine("Niepoprawne dane.");
    return;
}

Console.Write("Bok b: ");
if (!double.TryParse(Console.ReadLine(), out double b))
{
    Console.WriteLine("Niepoprawne dane.");
    return;
}

Console.Write("Bok c: ");
if (!double.TryParse(Console.ReadLine(), out double c))
{
    Console.WriteLine("Niepoprawne dane.");
    return;
}

if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
{
    Console.WriteLine("Nie można zbudować trójkąta.");
    return;
}

double polowaObwodu = (a + b + c) / 2;
double pole = Math.Sqrt(polowaObwodu * (polowaObwodu - a) * (polowaObwodu - b) * (polowaObwodu - c));
Console.WriteLine($"Pole: {pole:0.00}, obwód: {a + b + c:0.00}");
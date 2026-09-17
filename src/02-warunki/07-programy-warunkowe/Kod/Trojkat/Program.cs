Console.WriteLine("Podaj trzy długości boków trójkąta.");
Console.Write("a = ");
if (!decimal.TryParse(Console.ReadLine(), out decimal a))
{
    Console.WriteLine("Niepoprawne dane.");
    return;
}

Console.Write("b = ");
if (!decimal.TryParse(Console.ReadLine(), out decimal b))
{
    Console.WriteLine("Niepoprawne dane.");
    return;
}

Console.Write("c = ");
if (!decimal.TryParse(Console.ReadLine(), out decimal c))
{
    Console.WriteLine("Niepoprawne dane.");
    return;
}

if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
{
    Console.WriteLine("Z podanych boków nie można zbudować trójkąta.");
}
else if (a == b && b == c)
{
    Console.WriteLine("Trójkąt równoboczny.");
}
else if (a == b || a == c || b == c)
{
    Console.WriteLine("Trójkąt równoramienny.");
}
else
{
    Console.WriteLine("Trójkąt różnoboczny.");
}
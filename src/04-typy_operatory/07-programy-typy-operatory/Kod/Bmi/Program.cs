Console.Write("Podaj masę w kg: ");
if (!double.TryParse(Console.ReadLine(), out double masa) || masa <= 0)
{
    Console.WriteLine("Masa musi być dodatnia.");
    return;
}

Console.Write("Podaj wzrost w metrach: ");
if (!double.TryParse(Console.ReadLine(), out double wzrost) || wzrost <= 0)
{
    Console.WriteLine("Wzrost musi być dodatni.");
    return;
}

double bmi = masa / (wzrost * wzrost);
string kategoria = bmi < 18.5 ? "niedowaga" : bmi < 25 ? "norma" : "powyżej normy";
Console.WriteLine($"BMI: {bmi:0.00}, kategoria: {kategoria}");
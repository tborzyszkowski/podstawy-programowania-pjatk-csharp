int[] domyslne = new int[4];
Console.WriteLine($"Wartosci domyslne: {string.Join(", ", domyslne)}");

int[,] dane =
{
    { 8, 3, 5 },
    { 2, 9, 4 }
};

Console.WriteLine($"Macierz: {dane.GetLength(0)} x {dane.GetLength(1)}, elementow: {dane.Length}");
int[] sumyWierszy = new int[dane.GetLength(0)];
for (int wiersz = 0; wiersz < dane.GetLength(0); wiersz++)
{
    for (int kolumna = 0; kolumna < dane.GetLength(1); kolumna++)
    {
        Console.Write($"{dane[wiersz, kolumna],3}");
        sumyWierszy[wiersz] += dane[wiersz, kolumna];
    }
    Console.WriteLine($"  suma = {sumyWierszy[wiersz]}");
}

int[,] transpozycja = new int[dane.GetLength(1), dane.GetLength(0)];
for (int wiersz = 0; wiersz < dane.GetLength(0); wiersz++)
{
    for (int kolumna = 0; kolumna < dane.GetLength(1); kolumna++)
    {
        transpozycja[kolumna, wiersz] = dane[wiersz, kolumna];
    }
}

Console.WriteLine("Transpozycja:");
for (int wiersz = 0; wiersz < transpozycja.GetLength(0); wiersz++)
{
    for (int kolumna = 0; kolumna < transpozycja.GetLength(1); kolumna++)
    {
        Console.Write($"{transpozycja[wiersz, kolumna],3}");
    }
    Console.WriteLine();
}

int[][] oceny =
{
    new[] { 5, 4, 5 },
    new[] { 3, 4 },
    new[] { 5, 5, 4, 5 }
};

for (int student = 0; student < oceny.Length; student++)
{
    double srednia = oceny[student].Average();
    Console.WriteLine($"Student {student}: srednia {srednia:F2}");
}

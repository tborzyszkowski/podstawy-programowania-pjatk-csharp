int[] pomiary = { 18, 21, 19, 23, 21, 17 };

Console.WriteLine($"Liczba pomiarow: {pomiary.Length}");
for (int indeks = 0; indeks < pomiary.Length; indeks++)
{
    Console.WriteLine($"pomiary[{indeks}] = {pomiary[indeks]}");
}

int suma = 0;
int minimum = pomiary[0];
int maksimum = pomiary[0];

foreach (int pomiar in pomiary)
{
    suma += pomiar;
    if (pomiar < minimum)
    {
        minimum = pomiar;
    }

    if (pomiar > maksimum)
    {
        maksimum = pomiar;
    }
}

double srednia = (double)suma / pomiary.Length;
Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Minimum: {minimum}");
Console.WriteLine($"Maksimum: {maksimum}");
Console.WriteLine($"Srednia: {srednia:F2}");

int[] kopia = new int[pomiary.Length];
Array.Copy(pomiary, kopia, pomiary.Length);
Array.Reverse(kopia);
Console.WriteLine($"Odwrocona kopia: {string.Join(", ", kopia)}");

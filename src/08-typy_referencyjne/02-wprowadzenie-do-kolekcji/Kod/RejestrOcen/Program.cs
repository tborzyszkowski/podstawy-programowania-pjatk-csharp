List<Student> studenci =
[
    new("Ala", 72),
    new("Bartek", 48),
    new("Celina", 96),
    new("Dawid", 72)
];

studenci.Sort((lewy, prawy) =>
{
    int porownaniePunktow = prawy.Punkty.CompareTo(lewy.Punkty);
    return porownaniePunktow != 0
        ? porownaniePunktow
        : string.Compare(lewy.Imie, prawy.Imie, StringComparison.Ordinal);
});

Console.WriteLine("Ranking:");
foreach (Student student in studenci)
{
    Console.WriteLine($"{student.Imie}: {student.Punkty} punktów");
}

IEnumerable<Student> zaliczeni = studenci.Where(student => student.Punkty >= 50);
double srednia = studenci.Average(student => student.Punkty);

Console.WriteLine($"\nZaliczeni: {zaliczeni.Count()}");
Console.WriteLine($"Średnia: {srednia:F2}");

internal sealed record Student(string Imie, int Punkty);
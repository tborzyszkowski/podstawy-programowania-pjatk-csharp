string opis = "  C# i .NET  ";
string[] slowa = opis.Trim().Split(' ');
Console.WriteLine($"Tekst: {string.Join("/", slowa)}");

double zaokraglona = Math.Round(12.567, 2);
int poziom = Math.Clamp(125, 0, 100);
Console.WriteLine($"Liczba: {zaokraglona:F2}, poziom: {poziom}, pierwiastek: {Math.Sqrt(81)}");

int[] oceny = [3, 5, 4, 2, 5];
int[] pozytywne = oceny.Where(ocena => ocena >= 3).ToArray();
Console.WriteLine($"Średnia ocen pozytywnych: {pozytywne.Average():F2}");
Console.WriteLine($"Oceny rosnąco: {string.Join(", ", oceny.OrderBy(ocena => ocena))}");

DateTime dzisiaj = DateTime.Today;
DateTime termin = dzisiaj.AddDays(14);
TimeSpan pozostalo = termin - dzisiaj;
Console.WriteLine($"Termin: {termin:d}, dni: {pozostalo.Days}");
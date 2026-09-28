List<string> uczestnicy = ["Ala", "Bartek", "Celina"];

IEnumerable<string> tylkoDlugieImiona = uczestnicy
    .Where(imie => imie.Length >= 5);

uczestnicy.Add("Daniel");
IReadOnlyCollection<string> snapshot = tylkoDlugieImiona.ToList();

DodajDomyslna(uczestnicy);
Console.WriteLine($"Liczba uczestników: {uczestnicy.Count}");
Console.WriteLine($"Snapshot: {string.Join(", ", snapshot)}");

uczestnicy.RemoveAll(imie => imie.StartsWith("B", StringComparison.Ordinal));
Console.WriteLine($"Po usunięciu: {string.Join(", ", uczestnicy)}");
Console.WriteLine($"Niepuste: {PoliczNiepuste(uczestnicy)}");

static int PoliczNiepuste(IEnumerable<string> elementy)
{
    return elementy.Count(element => !string.IsNullOrWhiteSpace(element));
}

static void DodajDomyslna(ICollection<string> elementy)
{
    if (!elementy.Contains("domyślna"))
    {
        elementy.Add("domyślna");
    }
}
string tekst = "Ala ma kota, a Bartek ma psa. Ala lubi kota.";
Dictionary<string, int> czestotliwosc = PoliczSlowa(tekst);
Console.WriteLine("Częstotliwość słów:");
foreach ((string slowo, int liczba) in czestotliwosc.OrderByDescending(wpis => wpis.Value))
{
    Console.WriteLine($"- {slowo}: {liczba}");
}

List<string> slowa = ["ala", "ma", "kota", "ala", "ma", "psa"];
Console.WriteLine($"Unikalne: {string.Join(", ", UsunDuplikaty(slowa))}");

Queue<string> kolejka = new(["zadanie A", "zadanie B", "zadanie C"]);
Console.WriteLine($"Obsłużone: {string.Join(", ", Obsluz(kolejka))}");

Dictionary<string, List<string>> graf = new()
{
    ["A"] = ["B", "C"],
    ["B"] = ["A", "D"],
    ["C"] = ["A", "D"],
    ["D"] = ["B", "C"]
};
Console.WriteLine($"BFS: {string.Join(" -> ", Bfs(graf, "A"))}");

static Dictionary<string, int> PoliczSlowa(string tekst)
{
    Dictionary<string, int> wynik = new(StringComparer.OrdinalIgnoreCase);
    string[] slowa = tekst.Split(
        [' ', ',', '.', ';', '!', '?'],
        StringSplitOptions.RemoveEmptyEntries);

    foreach (string slowo in slowa)
    {
        string klucz = slowo.Trim().ToLowerInvariant();
        wynik[klucz] = wynik.GetValueOrDefault(klucz) + 1;
    }

    return wynik;
}

static List<string> UsunDuplikaty(IEnumerable<string> slowa)
{
    HashSet<string> widziane = new(StringComparer.OrdinalIgnoreCase);
    List<string> wynik = [];

    foreach (string slowo in slowa)
    {
        if (widziane.Add(slowo))
        {
            wynik.Add(slowo);
        }
    }

    return wynik;
}

static List<string> Obsluz(Queue<string> kolejka)
{
    List<string> wynik = [];
    while (kolejka.TryDequeue(out string? zadanie))
    {
        wynik.Add(zadanie);
    }

    return wynik;
}

static List<string> Bfs(
    Dictionary<string, List<string>> graf,
    string start)
{
    if (!graf.ContainsKey(start))
    {
        return [];
    }

    Queue<string> kolejka = new([start]);
    HashSet<string> odwiedzone = [start];
    List<string> wynik = [];

    while (kolejka.TryDequeue(out string? aktualny))
    {
        wynik.Add(aktualny);
        foreach (string sasiad in graf[aktualny])
        {
            if (graf.ContainsKey(sasiad) && odwiedzone.Add(sasiad))
            {
                kolejka.Enqueue(sasiad);
            }
        }
    }

    return wynik;
}
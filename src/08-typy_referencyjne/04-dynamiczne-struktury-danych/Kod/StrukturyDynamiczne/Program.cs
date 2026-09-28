Stack<string> historia = new();
historia.Push("wstaw nagłówek");
historia.Push("zmień kolor");
historia.Push("dodaj tabelę");
Console.WriteLine($"Cofam: {historia.Pop()}");
Console.WriteLine($"Następna operacja: {historia.Peek()}");

Queue<string> kolejka = new();
kolejka.Enqueue("zgłoszenie A");
kolejka.Enqueue("zgłoszenie B");
kolejka.Enqueue("zgłoszenie C");
Console.WriteLine($"Obsługuję: {kolejka.Dequeue()}");
Console.WriteLine($"Pozostało zgłoszeń: {kolejka.Count}");

LinkedList<string> playlista = new(["Intro", "Finał"]);
LinkedListNode<string> final = playlista.Last!;
playlista.AddBefore(final, "Rozdział 1");
playlista.AddBefore(final, "Rozdział 2");
Console.WriteLine($"Playlista: {string.Join(" -> ", playlista)}");

Dictionary<string, List<string>> graf = new()
{
    ["A"] = ["B", "C"],
    ["B"] = ["A", "D"],
    ["C"] = ["A", "D"],
    ["D"] = ["B", "C"]
};

Console.WriteLine($"BFS od A: {string.Join(", ", PrzejdzBfs(graf, "A"))}");

static IEnumerable<string> PrzejdzBfs(
    Dictionary<string, List<string>> graf,
    string start)
{
    if (!graf.ContainsKey(start))
    {
        yield break;
    }

    Queue<string> kolejka = new();
    HashSet<string> odwiedzone = [start];
    kolejka.Enqueue(start);

    while (kolejka.Count > 0)
    {
        string aktualny = kolejka.Dequeue();
        yield return aktualny;

        foreach (string sasiad in graf[aktualny])
        {
            if (graf.ContainsKey(sasiad) && odwiedzone.Add(sasiad))
            {
                kolejka.Enqueue(sasiad);
            }
        }
    }
}
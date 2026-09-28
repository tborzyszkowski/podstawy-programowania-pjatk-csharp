List<Zadanie> zadania =
[
    new("Przeczytaj README", true),
    new("Napisz kod", false),
    new("Uruchom debugowanie", false)
];

zadania.Add(new Zadanie("Zbuduj projekt", false));
zadania[1] = zadania[1] with { Wykonane = true };

Console.WriteLine("Wszystkie zadania:");
Wypisz(zadania);

Console.WriteLine("\nDo wykonania:");
Wypisz(zadania.Where(zadanie => !zadanie.Wykonane));

int usuniete = zadania.RemoveAll(zadanie => zadanie.Wykonane);
Console.WriteLine($"\nUsunięto wykonanych: {usuniete}");
Console.WriteLine($"Pozostało: {zadania.Count}");

static void Wypisz(IEnumerable<Zadanie> zadania)
{
    foreach (Zadanie zadanie in zadania)
    {
        string status = zadanie.Wykonane ? "wykonane" : "otwarte";
        Console.WriteLine($"- {zadanie.Tytul} ({status})");
    }
}

internal sealed record Zadanie(string Tytul, bool Wykonane);
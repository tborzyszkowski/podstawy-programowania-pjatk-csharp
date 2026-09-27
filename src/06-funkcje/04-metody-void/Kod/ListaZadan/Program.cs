List<string> zadania = ["Przeczytać rozdział", "Napisać kod", "Uruchomić debuger"];

WypiszNaglowek("Lista zadań");
WypiszZadania(zadania);
DodajZadanie(zadania, "Sprawdzić przypadek brzegowy");
WypiszZadania(zadania);
Console.WriteLine($"Liczba zadań: {zadania.Count}");

static void WypiszNaglowek(string tekst)
{
    Console.WriteLine($"=== {tekst} ===");
}

static void WypiszZadania(IReadOnlyList<string> zadania)
{
    if (zadania.Count == 0)
    {
        Console.WriteLine("Brak zadań.");
        return;
    }

    for (int indeks = 0; indeks < zadania.Count; indeks++)
    {
        Console.WriteLine($"{indeks + 1}. {zadania[indeks]}");
    }
}

static void DodajZadanie(List<string> zadania, string noweZadanie)
{
    zadania.Add(noweZadanie);
}
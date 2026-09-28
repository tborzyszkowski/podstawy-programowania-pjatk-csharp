using System.Collections;

List<Kontakt> kontakty =
[
    new("Ala", "ala@example.com"),
    new("Bartek", "bartek@example.com"),
    new("Celina", "celina@example.com")
];

Kontakt? znaleziony = kontakty.Find(
    kontakt => kontakt.Email == "bartek@example.com");

if (znaleziony is not null)
{
    int indeks = kontakty.IndexOf(znaleziony);
    kontakty[indeks] = znaleziony with { Email = "b.nowy@example.com" };
}

kontakty.RemoveAll(kontakt => kontakt.Imie.StartsWith("C", StringComparison.Ordinal));

Console.WriteLine("Kontakty:");
foreach (Kontakt kontakt in kontakty)
{
    Console.WriteLine($"- {kontakt.Imie}: {kontakt.Email}");
}

ArrayList staraLista = [1, 2, 3];
int sumaArrayList = 0;
foreach (object element in staraLista)
{
    sumaArrayList += (int)element;
}

List<int> listaGeneryczna = [1, 2, 3];
int sumaList = listaGeneryczna.Sum();
Console.WriteLine($"Sumy: ArrayList={sumaArrayList}, List<int>={sumaList}");

internal sealed record Kontakt(string Imie, string Email);
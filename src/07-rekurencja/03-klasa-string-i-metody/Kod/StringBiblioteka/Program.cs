using System.Text;

string tekst = "  C#; rekurencja; metody  ";
string[] elementy = tekst
    .Trim()
    .Split(';', StringSplitOptions.RemoveEmptyEntries);

string[] oczyszczone = elementy
    .Select(element => element.Trim())
    .ToArray();

Console.WriteLine($"Elementy: {string.Join(" | ", oczyszczone)}");
Console.WriteLine($"Czy zawiera C#: {tekst.Contains("C#", StringComparison.Ordinal)}");
Console.WriteLine($"Napis wielkimi literami: {tekst.ToUpperInvariant()}");

StringBuilder raport = new();
foreach (string element in oczyszczone)
{
    raport.AppendLine($"- {element}");
}

Console.WriteLine(raport.ToString());
string[] identyfikatory = { "Ala", "Bartek", "Celina", "Dawid" };
int[] wyniki = { 87, 94, 94, 76 };

Array.Sort(wyniki, identyfikatory);
Array.Reverse(wyniki);
Array.Reverse(identyfikatory);

Console.WriteLine("Ranking:");
for (int pozycja = 0; pozycja < wyniki.Length; pozycja++)
{
    Console.WriteLine($"{pozycja + 1}. {identyfikatory[pozycja]} - {wyniki[pozycja]} pkt");
}

Console.WriteLine($"Podium: {string.Join(", ", identyfikatory[..Math.Min(3, identyfikatory.Length)])}");

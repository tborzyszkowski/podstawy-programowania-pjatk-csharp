double wartosc = 12.9;
int obciecie = (int)wartosc;
int zaokraglenie = (int)Math.Round(wartosc);
Console.WriteLine($"Obcięcie: {obciecie}, zaokrąglenie: {zaokraglenie}");

try
{
    int maksymalna = int.MaxValue;
    int wynik = checked(maksymalna + 1);
    Console.WriteLine(wynik);
}
catch (OverflowException)
{
    Console.WriteLine("Przepełnienie zostało wykryte.");
}
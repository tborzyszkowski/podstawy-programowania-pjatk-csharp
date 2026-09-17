Console.WriteLine("Program jako maszyna stanowa");
Console.Write("Podaj nazwę użytkownika: ");
string nazwa = Console.ReadLine() ?? "anonim";

int punkty = 0;
decimal saldo = 100.00m;
bool czyAktywne = true;
char pierwszaLitera = nazwa.Length > 0 ? nazwa[0] : '-';
StanKonta stan = czyAktywne ? StanKonta.Aktywne : StanKonta.Nieaktywne;

Console.WriteLine($"Użytkownik: {nazwa}, pierwsza litera: {pierwszaLitera}");
Console.WriteLine($"Stan początkowy: {stan}, punkty: {punkty}, saldo: {saldo:0.00}");

Console.Write("Podaj liczbę punktów do dodania: ");
if (int.TryParse(Console.ReadLine(), out int dodanePunkty) && dodanePunkty >= 0)
{
    punkty += dodanePunkty;
    saldo += dodanePunkty * 0.10m;
    stan = punkty >= 100 ? StanKonta.Zablokowane : StanKonta.Aktywne;
}
else
{
    Console.WriteLine("Niepoprawna liczba punktów - stan nie został zmieniony.");
}

Console.WriteLine($"Stan końcowy: {stan}, punkty: {punkty}, saldo: {saldo:0.00}");

enum StanKonta
{
    Nieaktywne,
    Aktywne,
    Zablokowane
}
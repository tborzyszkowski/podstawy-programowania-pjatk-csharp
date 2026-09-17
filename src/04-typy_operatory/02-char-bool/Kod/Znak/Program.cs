Console.Write("Podaj jeden znak: ");
string tekst = Console.ReadLine() ?? "";
if (tekst.Length != 1)
{
    Console.WriteLine("Oczekiwano dokładnie jednego znaku.");
    return;
}

char znak = tekst[0];
if (znak >= '0' && znak <= '9')
{
    Console.WriteLine("To cyfra.");
}
else if (znak >= 'A' && znak <= 'Z')
{
    Console.WriteLine("To wielka litera alfabetu łacińskiego.");
}
else
{
    Console.WriteLine("To inny znak.");
}
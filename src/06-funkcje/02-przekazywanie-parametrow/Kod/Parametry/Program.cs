int liczba = 10;
ZwiekszKopie(liczba);
Console.WriteLine($"Po przekazaniu przez wartość: {liczba}");

Zwieksz(ref liczba);
Console.WriteLine($"Po przekazaniu przez ref: {liczba}");

if (SprobujPodwoic(liczba, out int podwojona))
{
    Console.WriteLine($"Wynik przez out: {podwojona}");
}

Konto konto = new(100);
ZmienSaldo(konto);
Console.WriteLine($"Saldo po zmianie pola obiektu: {konto.Saldo}");

PodmienKonto(konto);
Console.WriteLine($"Saldo po podmianie lokalnej referencji: {konto.Saldo}");

Console.WriteLine($"Suma przez params: {Suma(2, 4, 6)}");

static void ZwiekszKopie(int liczba)
{
    liczba++;
}

static void Zwieksz(ref int liczba)
{
    liczba++;
}

static bool SprobujPodwoic(int liczba, out int wynik)
{
    wynik = liczba * 2;
    return true;
}

static void ZmienSaldo(Konto konto)
{
    konto.Saldo += 50;
}

static void PodmienKonto(Konto konto)
{
    konto = new Konto(0);
}

static int Suma(params int[] liczby)
{
    int suma = 0;
    foreach (int liczba in liczby)
    {
        suma += liczba;
    }

    return suma;
}

internal sealed class Konto
{
    public Konto(decimal saldo)
    {
        Saldo = saldo;
    }

    public decimal Saldo { get; set; }
}
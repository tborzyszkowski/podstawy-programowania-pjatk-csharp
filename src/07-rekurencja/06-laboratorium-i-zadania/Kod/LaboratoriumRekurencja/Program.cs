Console.WriteLine($"Suma cyfr 12345: {SumaCyfr(12345)}");
Console.WriteLine($"2^10: {PotegaSzybka(2, 10)}");

string zdanie = "Kobyła ma mały bok";
Console.WriteLine($"Palindrom: {CzyPalindromPoNormalizacji(zdanie)}");

static int SumaCyfr(int liczba)
{
    if (liczba < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(liczba));
    }

    return liczba < 10 ? liczba : liczba % 10 + SumaCyfr(liczba / 10);
}

static long PotegaSzybka(long podstawa, int wykladnik)
{
    if (wykladnik < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(wykladnik));
    }

    if (wykladnik == 0)
    {
        return 1;
    }

    long polowa = PotegaSzybka(podstawa, wykladnik / 2);
    long wynik = checked(polowa * polowa);
    return wykladnik % 2 == 0 ? wynik : checked(podstawa * wynik);
}

static bool CzyPalindromPoNormalizacji(string tekst)
{
    string oczyszczony = new string(
        tekst
            .Where(char.IsLetterOrDigit)
            .Select(char.ToUpperInvariant)
            .ToArray());

    return CzyPalindrom(oczyszczony, 0, oczyszczony.Length - 1);
}

static bool CzyPalindrom(string tekst, int lewy, int prawy)
{
    if (lewy >= prawy)
    {
        return true;
    }

    return tekst[lewy] == tekst[prawy]
        && CzyPalindrom(tekst, lewy + 1, prawy - 1);
}
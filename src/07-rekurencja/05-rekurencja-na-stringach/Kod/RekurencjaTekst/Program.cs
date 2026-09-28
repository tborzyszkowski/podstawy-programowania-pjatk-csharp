string tekst = "kajak";
Console.WriteLine($"Oryginał: {tekst}");
Console.WriteLine($"Odwrócony: {OdwrocZBuforem(tekst)}");
Console.WriteLine($"Palindrom: {CzyPalindrom(tekst, 0, tekst.Length - 1)}");
Console.WriteLine($"Liczba liter 'a': {PoliczZnak(tekst, 'a', 0)}");
Console.WriteLine($"Palindrom po normalizacji: {CzyPalindromPoNormalizacji("Kobyła ma mały bok")}");

static string OdwrocZBuforem(string tekst)
{
    char[] znaki = tekst.ToCharArray();
    OdwrocWTablicy(znaki, 0, znaki.Length - 1);
    return new string(znaki);
}

static void OdwrocWTablicy(char[] znaki, int lewy, int prawy)
{
    if (lewy >= prawy)
    {
        return;
    }

    (znaki[lewy], znaki[prawy]) = (znaki[prawy], znaki[lewy]);
    OdwrocWTablicy(znaki, lewy + 1, prawy - 1);
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

static int PoliczZnak(string tekst, char szukany, int indeks)
{
    if (indeks == tekst.Length)
    {
        return 0;
    }

    int znaleziony = tekst[indeks] == szukany ? 1 : 0;
    return znaleziony + PoliczZnak(tekst, szukany, indeks + 1);
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
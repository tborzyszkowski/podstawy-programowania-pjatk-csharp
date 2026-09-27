const double KilometryStart = 12450;
const double KilometryKoniec = 12680;
const double SpalanieNa100Km = 6.4;
const double CenaPaliwa = 6.49;

double dystans = ObliczDystans(KilometryStart, KilometryKoniec);
double koszt = ObliczKosztPaliwa(dystans, SpalanieNa100Km, CenaPaliwa);
WypiszPodsumowanie(dystans, koszt);

static double ObliczDystans(double licznikStart, double licznikKoniec)
{
    if (licznikKoniec < licznikStart)
    {
        throw new ArgumentException("Stan końcowy licznika nie może być mniejszy od początkowego.");
    }

    return licznikKoniec - licznikStart;
}

static double ObliczKosztPaliwa(double dystans, double spalanie, double cena)
{
    if (dystans < 0 || spalanie < 0 || cena < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(dystans), "Wartości kosztu nie mogą być ujemne.");
    }

    double litry = dystans * spalanie / 100;
    return litry * cena;
}

static void WypiszPodsumowanie(double dystans, double koszt)
{
    Console.WriteLine($"Dystans: {dystans:F1} km");
    Console.WriteLine($"Szacowany koszt paliwa: {koszt:F2} zł");
}
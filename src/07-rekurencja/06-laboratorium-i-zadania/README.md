# 6. Laboratorium i zadania z rozwiązaniami

## Cel laboratorium

Student ma przejść cały cykl: sformułować przypadek bazowy, zapisać krok rekurencyjny, uruchomić program, prześledzić stos wywołań, sprawdzić przypadki graniczne i ocenić, czy rekurencja nadaje się do dalszego użycia.

## Propozycje zadań

### Zadanie 1: suma cyfr

Napisz `SumaCyfr(int liczba)` dla nieujemnej liczby całkowitej. Dodaj walidację wartości ujemnej.

### Zadanie 2: potęgowanie

Zaimplementuj `PotegaSzybka(long podstawa, int wykladnik)` przez dzielenie wykładnika na pół. Obsłuż przepełnienie przez `checked`.

### Zadanie 3: palindrom

Napisz program sprawdzający, czy zdanie jest palindromem po usunięciu znaków niealfanumerycznych i ignorowaniu wielkości liter.

### Zadanie 4: drzewo katalogów

Zdefiniuj rekord `Folder(string Nazwa, IReadOnlyList<Folder> Dzieci)` i rekurencyjnie policz liczbę wszystkich folderów oraz maksymalną głębokość.

### Zadanie 5: Fibonacciego nie licz dwa razy

Porównaj wersję naiwną, memoizowaną i iteracyjną. Zapisz liczbę wywołań oraz pamięć pomocniczą.

### Zadanie 6: decyzja produkcyjna

Dla każdego poprzedniego zadania uzasadnij wybór rekurencji, pętli, jawnego stosu lub memoizacji. Uwzględnij rozmiar danych i ryzyko przepełnienia stosu.

## Rozwiązania i wyjaśnienia

```csharp
static int SumaCyfr(int liczba)
{
    if (liczba < 0)
    {
        throw new ArgumentOutOfRangeException(nameof(liczba));
    }

    return liczba < 10
        ? liczba
        : liczba % 10 + SumaCyfr(liczba / 10);
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
    return wykladnik % 2 == 0
        ? wynik
        : checked(podstawa * wynik);
}
```

Dla palindromu najpierw wyznacz normalizację, a potem wywołaj funkcję na zakresie indeksów. Dla folderów przypadkiem bazowym jest pusty zbiór dzieci; wynik folderu to `1` plus wyniki jego dzieci. Przy Fibonaccim memoizacja usuwa powtarzanie tych samych podproblemów, ale wersja iteracyjna nadal ma najmniejszy koszt stosu.

## Projekt kontrolny

Projekt [Kod/LaboratoriumRekurencja/Program.cs](Kod/LaboratoriumRekurencja/Program.cs) uruchamia zestaw przypadków dla sumy cyfr, potęgowania i palindromu. Służy jako punkt startowy do dopisywania własnych testów.

## Przypadki testowe

| Funkcja | Typowy | Graniczny | Błędny |
| --- | --- | --- | --- |
| `SumaCyfr` | `12345 -> 15` | `0 -> 0` | `-1` |
| `PotegaSzybka` | `2^10 -> 1024` | `x^0 -> 1` | ujemny wykładnik |
| palindrom | `kajak -> true` | pusty napis | `null`, jeśli kontrakt go nie dopuszcza |
| drzewo | kilka poziomów | `null` | cykliczna struktura |

## Instrukcja laboratoryjna

```powershell
dotnet build
dotnet run
```

1. Uruchom projekt kontrolny.
2. Ustaw breakpoint w przypadku bazowym.
3. Uruchom `F5` i obserwuj Call Stack.
4. Dodaj przypadek brzegowy.
5. Zmień jedną metodę na wersję iteracyjną lub z jawnym stosem.
6. Porównaj wynik, czas i zużycie pamięci.

## Kryteria oceny

- przypadek bazowy jest jawny i osiągalny,
- argument zmniejsza problem w każdym wywołaniu,
- metoda nie ukrywa błędnych danych,
- wynik jest poprawny dla pustego i typowego wejścia,
- student umie uzasadnić wybór rekurencji względem iteracji,
- kod ma osobne metody obliczeniowe i prezentację wyniku.

## Źródła

- [Unit testing in .NET](https://learn.microsoft.com/dotnet/core/testing/),
- [`Stack<T>`](https://learn.microsoft.com/dotnet/api/system.collections.generic.stack-1),
- [String Class](https://learn.microsoft.com/dotnet/api/system.string),
- [Recursion](https://en.wikipedia.org/wiki/Recursion),
- [Memoization](https://en.wikipedia.org/wiki/Memoization).

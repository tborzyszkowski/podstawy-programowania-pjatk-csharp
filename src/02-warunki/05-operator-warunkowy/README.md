# 05. Operator warunkowy `?:`

## Składnia i znaczenie

Operator warunkowy jest jedynym trójargumentowym operatorem C#. Ma postać:

```csharp
wynik = warunek ? wartośćDlaTrue : wartośćDlaFalse;
```

Najpierw obliczany jest `warunek`. Jeśli jest `true`, całe wyrażenie przyjmuje pierwszą wartość; jeśli `false`, drugą. Operator służy do wybrania wartości, a nie do zastępowania rozbudowanych bloków instrukcji.

Równoważny zapis z `if else`:

```csharp
string status;
if (punkty >= 50)
{
    status = "zaliczony";
}
else
{
    status = "niezaliczony";
}
```

można skrócić do:

```csharp
string status = punkty >= 50 ? "zaliczony" : "niezaliczony";
```

## Kiedy stosować?

Stosuj `?:`, gdy wybierasz jedną z dwóch prostych wartości i wyrażenie pozostaje czytelne. Użyj `if else`, gdy gałęzie zawierają kilka instrukcji, modyfikują wiele zmiennych albo potrzebują komentarza i osobnego debugowania. Nie łańcuchuj wielu operatorów `?:`, jeśli powstaje trudny do czytania kod.

## Przykład 1: status zaliczenia

Projekt [Kod/Status/Program.cs](Kod/Status/Program.cs) wybiera komunikat na podstawie liczby punktów.

```mermaid
flowchart TD
    A([Start]) --> B[/Wczytaj punkty/]
    B --> C{punkty >= 50?}
    C -- Tak --> D[status = "zaliczony"]
    C -- Nie --> E[status = "niezaliczony"]
    D --> F[/Wypisz status/]
    E --> F
    F --> G([Koniec])
```

Źródło: [diagram-operator.mmd](diagram-operator.mmd).

## Przykład 2: wartość bezwzględna

Projekt [Kod/WartoscBezwzgledna/Program.cs](Kod/WartoscBezwzgledna/Program.cs) wybiera między `-liczba` i `liczba`. To prosty przypadek, w którym `?:` dobrze pokazuje, że wynik jest wartością wyrażenia.

```csharp
int wartoscBezwzgledna = liczba < 0 ? -liczba : liczba;
Console.WriteLine(wartoscBezwzgledna);
```

## Typy obu wartości

Wartości po znaku `?` i `:` muszą dać się sprowadzić do wspólnego typu wyniku. Nie należy mieszać bez uzasadnienia tekstu i liczby. W razie niejasności jawnie wybierz typ lub użyj zwykłego `if else`, który lepiej pokaże intencję.

## Zadania z rozwiązaniami

1. Wybierz komunikat `rano` albo `wieczór` na podstawie godziny mniejszej niż `12`.
2. Oblicz opłatę: dla studenta `10`, dla pozostałych `25`.
3. Przepisz operator warunkowy z zadania 2 na `if else` i porównaj długość oraz czytelność.

Przykładowe rozwiązania:

```csharp
string poraDnia = godzina < 12 ? "rano" : "wieczór";
decimal oplata = czyStudent ? 10 : 25;
```

Jeśli dodasz trzeci wariant, na przykład `popołudnie`, nie twórz długiego łańcucha `?:` bez potrzeby. W takiej sytuacji użyj `if else if` albo `switch`.

## Laboratorium

```powershell
dotnet build
dotnet run
```

Uruchom oba programy dla wartości ujemnej, zera i dodatniej albo dla punktów poniżej i powyżej progu. Ustaw punkt przerwania na przypisaniu i sprawdź, którą wartość otrzymuje zmienna.

## Źródła

- [Conditional operator `?:`](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/conditional-operator),
- [Operator precedence](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/).

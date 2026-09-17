# 01. Warunki w diagramach blokowych

## Romb decyzyjny

W diagramie blokowym decyzję zapisujemy w rombie. Z rombu wychodzą co najmniej dwie opisane gałęzie, na przykład `Tak` i `Nie`. Każda gałąź prowadzi do kolejnej operacji, a po wykonaniu wariantu przepływ może połączyć się ponownie.

```mermaid
flowchart TD
    A([Start]) --> B[/Wczytaj liczbę/]
    B --> C{liczba >= 0?}
    C -- Tak --> D[Wypisz "nieujemna"]
    C -- Nie --> E[Wypisz "ujemna"]
    D --> F([Koniec])
    E --> F
```

Źródło: [diagram-liczba.mmd](diagram-liczba.mmd).

## Przykład 1: liczba dodatnia, ujemna lub zero

Jedna decyzja z trzema wynikami może być zbudowana z dwóch rombów. Najpierw sprawdzamy znak ujemny, a potem zero. Kod w [Kod/ZnakLiczby/Program.cs](Kod/ZnakLiczby/Program.cs) zachowuje kolejność z diagramu.

```mermaid
flowchart TD
    A([Start]) --> B[/Wczytaj liczbę/]
    B --> C{liczba < 0?}
    C -- Tak --> D[Wypisz "ujemna"]
    C -- Nie --> E{liczba == 0?}
    E -- Tak --> F[Wypisz "zero"]
    E -- Nie --> G[Wypisz "dodatnia"]
    D --> H([Koniec])
    F --> H
    G --> H
```

Źródło: [diagram-znak-liczby.mmd](diagram-znak-liczby.mmd).

```csharp
if (liczba < 0)
{
    Console.WriteLine("ujemna");
}
else if (liczba == 0)
{
    Console.WriteLine("zero");
}
else
{
    Console.WriteLine("dodatnia");
}
```

## Przykład 2: temperatura i komunikat

W projekcie `Kod/Temperatura/Program.cs` romb sprawdza, czy temperatura jest mniejsza niż `0`. Niezależnie od wybranej gałęzi program wykonuje wspólne końcowe wypisanie. Na diagramie wspólna operacja znajduje się po połączeniu gałęzi.

```mermaid
flowchart TD
    A([Start]) --> B[/Wczytaj temperaturę/]
    B --> C{temperatura < 0?}
    C -- Tak --> D[komunikat = "mróz"]
    C -- Nie --> E[komunikat = "brak mrozu"]
    D --> F[/Wypisz komunikat/]
    E --> F
    F --> G([Koniec])
```

## Jak czytać diagram?

1. Zacznij od `Start` i idź zgodnie ze strzałkami.
2. W rombie oblicz warunek, nie wykonuj obu gałęzi naraz.
3. Prześledź osobno przypadek `Tak` i `Nie`.
4. Sprawdź, czy każda ścieżka dochodzi do końca oraz czy warianty nie pomijają wspólnej operacji.

## Zadania z rozwiązaniami

1. Narysuj diagram dla sprawdzenia, czy liczba jest parzysta.
2. Narysuj diagram dla biletu: osoba poniżej 7 lat ma bilet bezpłatny, pozostali płatny.
3. W programie temperatury dodaj komunikat `upał` dla wartości większej niż `30`.

Rozwiązanie zadania 1 wymaga warunku `liczba % 2 == 0`. Dla zadania 3 najpierw sprawdź `temperatura > 30`, a dopiero potem `temperatura < 0`; po obu rozgałęzieniach połącz przepływ przed wypisaniem komunikatu. Każdy romb powinien mieć opisane obie gałęzie.

## Laboratorium

```powershell
dotnet build
dotnet run
```

Uruchom program znaku liczby dla wartości ujemnej, zera i dodatniej. Ustaw punkt przerwania na pierwszym `if` i sprawdź, że po wybraniu jednej gałęzi pozostałe nie są wykonywane.

## Źródła

- [Mermaid flowcharts](https://mermaid.js.org/syntax/flowchart.html),
- [if and switch statements](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements),
- [Arithmetic operators](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/arithmetic-operators).

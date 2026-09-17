# 03. Pętle w języku C sharp

Moduł pokazuje, jak wielokrotnie wykonywać instrukcje, kontrolować liczbę powtórzeń i zatrzymywać albo pomijać wybrane iteracje. Przykłady używają wyłącznie konstrukcji poznanych wcześniej: zmiennych, typów, wejścia/wyjścia, warunków i podstawowych operatorów.

## Mapa tematów

1. [Pętla `for`](01-petla-for/README.md) - licznik, kolejność kroków, diagram i proste przykłady.
2. [Pętle `while` i `do while`](02-while-do-while/README.md) - warunek na początku i na końcu oraz dobór konstrukcji.
3. [Zagnieżdżanie pętli](03-zagniezdzanie-petli/README.md) - wiersze, kolumny, tabliczki i zadania wymagające dwóch liczników.
4. [`break` i `continue`](04-break-continue/README.md) - wcześniejsze zakończenie i pominięcie iteracji.
5. [Pętla ze strażnikiem](05-petla-ze-straznikiem/README.md) - wartość kończąca wczytywanie danych.
6. [Programy z pętlami](06-programy-z-petlami/README.md) - pięć programów o rosnącym zróżnicowaniu.

## Cele modułu

Po zajęciach student potrafi:

- opisać kolejność wykonywania inicjalizacji, warunku, ciała i kroku pętli,
- dobrać `for`, `while` albo `do while` do problemu,
- śledzić wartość licznika i warunek zakończenia,
- budować pętle zagnieżdżone i wskazać koszt dodatkowych powtórzeń,
- stosować `break`, `continue` i wartość strażnika bez tworzenia pętli nieskończonej,
- zaproponować przypadki testowe dla zera, jednej iteracji, wielu iteracji i danych kończących.

## Przebieg laboratorium

1. Napisz, ile razy oczekujesz wykonania ciała pętli.
2. Zaznacz zmienną, która zmienia się w każdej iteracji.
3. Zapisz warunek zakończenia i przypadek, w którym ciało nie wykona się ani razu.
4. Uruchom program i porównaj wynik z przewidywaniem.
5. Ustaw punkt przerwania w ciele pętli, użyj `F10` i obserwuj licznik oraz wynik częściowy.

## Wspólna procedura

W katalogu wybranego projektu:

```powershell
dotnet build
dotnet run
```

Visual Studio Code z C# Dev Kit uruchamia debugowanie przez `F5`, a krokowanie przez `F10`. W Visual Studio użyj `F5`, okna Locals i punktu przerwania wewnątrz pętli.

## Przykłady przekrojowe

### Przykład 1: znany zakres

```csharp
int suma = 0;
for (int i = 1; i <= 5; i++)
{
    suma += i;
}

Console.WriteLine(suma);
```

To typowy przypadek dla `for`: liczba iteracji wynika z granic licznika.

### Przykład 2: nieznana liczba danych

```csharp
int suma = 0;
int liczba;
do
{
    liczba = int.Parse(Console.ReadLine()!);
    if (liczba != -1)
    {
        suma += liczba;
    }
}
while (liczba != -1);

Console.WriteLine(suma);
```

Wartość `-1` jest strażnikiem i nie trafia do sumy. Pełne przykłady tego wzorca znajdują się w [05-petla-ze-straznikiem](05-petla-ze-straznikiem/README.md).

## Zadania przekrojowe

1. Oblicz sumę liczb parzystych od `1` do `n` za pomocą `for`.
2. Napisz program z `while`, który wypisuje kolejne potęgi `2`, dopóki nie przekroczą limitu.
3. Wypisz trójkąt z gwiazdek z użyciem zagnieżdżonych pętli.
4. Znajdź pierwszą liczbę podzielną przez `7` i zakończ wyszukiwanie przez `break`.
5. Wczytuj liczby do strażnika `-1`, pomijaj wartości mniejsze niż `-1` przez `continue`, a następnie wypisz minimum i maksimum.

### Rozwiązania i wyjaśnienia

Rozwiązanie zadania 1:

```csharp
int suma = 0;
for (int i = 2; i <= n; i += 2)
{
    suma += i;
}
```

W zadaniu 3 pętla zewnętrzna wyznacza numer wiersza, a wewnętrzna wypisuje tyle gwiazdek, ile wynosi numer tego wiersza. W zadaniu 5 strażnik kończy pętlę, ale nie jest daną; `continue` pomija tylko błędną wartość i pozwala pobierać kolejne.

## Źródła

- [Iteration statements - C# reference](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/iteration-statements),
- [Jump statements: break and continue](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/jump-statements),
- [Arithmetic operators](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/arithmetic-operators),
- [Mermaid flowcharts](https://mermaid.js.org/syntax/flowchart.html),
- [Numerowany układ katalogów kursu Java](https://github.com/tborzyszkowski/oop-concepts-java/tree/main/02_OOP/src).

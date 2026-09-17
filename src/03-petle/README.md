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

## Źródła

- [Iteration statements - C# reference](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/iteration-statements),
- [Jump statements: break and continue](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/jump-statements),
- [Arithmetic operators](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/arithmetic-operators),
- [Mermaid flowcharts](https://mermaid.js.org/syntax/flowchart.html),
- [Numerowany układ katalogów kursu Java](https://github.com/tborzyszkowski/oop-concepts-java/tree/main/02_OOP/src).

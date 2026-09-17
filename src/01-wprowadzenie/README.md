# 01. Wprowadzenie do programowania (C#)

Moduł jest przeznaczony na początek kursu Podstaw Programowania. Kolejność tematów jest celowa: najpierw student opisuje rozwiązanie problemu, potem zapisuje je w C#, uruchamia, obserwuje stan programu i sprawdza wyniki.

## Mapa modułu

1. [Pojęcie algorytmu](01-pojecie-algorytmu/README.md) - czym jest algorytm, dane, wynik i warunek zakończenia.
2. [Przedstawianie algorytmów](02-przedstawianie-algorytmow/README.md) - opis słowny, diagram blokowy, kod C# i wybór właściwej reprezentacji.
3. [Program jako maszyna stanowa](03-program-jako-maszyna-stanowa/README.md) - zmienne, typy, przypisanie i wejście/wyjście.
4. [Pierwszy program w C#](04-pierwszy-program-csharp/README.md) - od koncepcji i diagramu do działającego programu.
5. [Środowisko .NET i edytory](05-srodowisko-dotnet-i-edytory/README.md) - .NET, Visual Studio i Visual Studio Code.
6. [Projekt, kompilacja i debugowanie](06-projekt-kompilacja-uruchamianie-debugowanie/README.md) - cykl pracy z aplikacją konsolową i śledzenie stanu.
7. [Obliczenia, poprawność i testy](07-obliczenia-poprawnosc-i-testy/README.md) - pięć algorytmów, przypadki testowe i pokrycie kodu.

## Proponowany przebieg zajęć

### Wykład

1. Postaw problem i nazwij dane wejściowe, dane wyjściowe oraz ograniczenia.
2. Pokaż rozwiązanie najpierw bez kodu: opisem i diagramem.
3. Przetłumacz kroki na C#, zwracając uwagę na typy i zmianę stanu.
4. Uruchom przykład dla typowego przypadku oraz przypadku brzegowego.
5. Zatrzymaj program w debugerze i pokaż wartości zmiennych po kolejnych instrukcjach.
6. Zakończ kryterium poprawności oraz zadaniem kontrolnym.

### Laboratorium

Student powinien przejść pełny cykl: utworzyć projekt, napisać kod, zbudować go, uruchomić, znaleźć i poprawić błąd oraz sprawdzić wynik na kilku danych.

## Wspólna procedura pracy

```powershell
dotnet new console -n NazwaProjektu -f net9.0
dotnet build
dotnet run
```

Debugowanie w Visual Studio Code uruchamia się przez `F5` po zainstalowaniu C# Dev Kit. W Visual Studio wybiera się projekt startowy i naciska `F5`. W obu środowiskach warto ustawić punkt przerwania przed instrukcją, której działanie chcemy obserwować, a następnie używać krokowania „Step Over”.

## Cele uczenia się

Po module student potrafi:

- sformułować prosty algorytm i wskazać jego dane wejściowe oraz wynik,
- przedstawić algorytm opisem, diagramem i programem C#,
- wyjaśnić, jak instrukcje zmieniają stan programu,
- rozróżnić typowanie statyczne i dynamiczne oraz uzasadnić, że C# jest językiem silnie typowanym,
- utworzyć, zbudować, uruchomić i debugować aplikację konsolową,
- zaproponować przypadki testowe, w tym przypadki brzegowe, i ocenić poprawność wyniku.

## Źródła

Materiały korzystają przede wszystkim z dokumentacji producenta języka i platformy:

- [C# documentation](https://learn.microsoft.com/dotnet/csharp/),
- [What's new in .NET](https://learn.microsoft.com/dotnet/core/whats-new/),
- [dotnet command](https://learn.microsoft.com/dotnet/core/tools/dotnet),
- [C# language specification](https://learn.microsoft.com/dotnet/csharp/language-reference/language-specification/).

Linki zostały dobrane jako stałe strony dokumentacji Microsoft Learn; warto sprawdzić ich aktualność przed wydaniem kolejnej wersji skryptu.

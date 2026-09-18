# 04. Typy i operatory w języku C sharp

Moduł wyjaśnia, jak wybór typu wpływa na zakres, dokładność i sposób wykonywania obliczeń. Następnie pokazuje konwersje, stałe, operatory oraz priorytety, a na końcu łączy te elementy w pięciu programach konsolowych.

## Mapa tematów

1. [Typy całkowite i zmiennoprzecinkowe](01-typy-liczbowe/README.md) - zakresy, reprezentacja, dokładność i dobór typu.
2. [Typ znakowy i logiczny](02-char-bool/README.md) - `char`, Unicode, `bool` i wyrażenia logiczne.
3. [Konwersje i rzutowania](03-konwersje-rzutowania/README.md) - konwersje niejawne, jawne, `Parse`, `TryParse` i `checked`.
4. [Kwalifikator `const`](04-const/README.md) - stałe czasu kompilacji i różnica względem zmiennej.
5. [Operatory C#](05-operatory/README.md) - arytmetyczne, relacyjne, równości i logiczne.
6. [Priorytety operatorów](06-priorytety-operatorow/README.md) - kolejność obliczeń, łączność i nawiasowanie.
7. [Programy z typami i operatorami](07-programy-typy-operatory/README.md) - pięć programów o zróżnicowanej trudności.

## Cele modułu

Student potrafi:

- dobrać `int`, `long`, `float`, `double` albo `decimal` do problemu,
- wyjaśnić, dlaczego liczby zmiennoprzecinkowe są przybliżone,
- użyć `char` i `bool` oraz rozumieć ich konwersje,
- odróżnić konwersję niejawną od jawnego rzutowania,
- użyć `const` do wartości znanej podczas kompilacji,
- przewidzieć wynik wyrażenia dzięki priorytetom i nawiasom,
- zbudować program wykorzystujący kilka typów i operatorów jednocześnie.

## Przebieg laboratorium

1. Wybierz reprezentację danych przed napisaniem obliczenia.
2. Zapisz zakres i oczekiwaną dokładność wyniku.
3. Sprawdź typ wyrażenia, konwersje i priorytety operatorów.
4. Uruchom przypadek zwykły, graniczny i taki, który może powodować utratę danych.
5. W debugerze obserwuj wartości przed i po konwersji.

## Wspólna procedura

W katalogu wybranego projektu:

```powershell
dotnet build
dotnet run
```

Debugowanie w Visual Studio Code uruchamia się przez `F5`, a krokowanie przez `F10`. W Visual Studio użyj `F5` i okna Locals.

## Zadania przekrojowe

1. Napisz kalkulator zamówienia. Wczytaj cenę jako `decimal` i liczbę sztuk jako `int` przez `TryParse`. Zastosuj `const` dla stawki VAT, progu rabatu i wysokości rabatu, a następnie oblicz kwotę netto i brutto z poprawnym nawiasowaniem.
2. Napisz konwerter temperatury. Wczytaj wartość jako `double` oraz znak skali `C` albo `F` przez `char.TryParse`. Użyj `bool` do sprawdzenia poprawności skali i wybierz właściwy wzór konwersji.
3. Napisz analizator trzech wyników. Wczytaj liczby całkowite przez `TryParse`, oblicz średnią jako `double`, a następnie sprawdź, czy średnia mieści się w zakresie od `0` do `100`. Wyjaśnij, dlaczego samo dzielenie całkowite daje inny wynik.
4. Napisz bezpieczny konwerter jednostek. Wczytaj odległość jako `long`, przelicz ją na większe jednostki z użyciem `/` i `%`, a wybrane wartości spróbuj przekonwertować do `int` w kontekście `checked`. Obsłuż przepełnienie i dane spoza zakresu.
5. Przeanalizuj i popraw program zawierający wyrażenia mieszanych typów, na przykład `int`, `double` i `decimal`. Najpierw zapisz przewidywany typ i wynik każdego wyrażenia, potem dodaj nawiasy albo jawne rzutowania i sprawdź wynik w debuggerze.

### Wskazówki i kryteria sprawdzenia

- Odrzucaj dane niepoprawne tekstowo oraz wartości niedodatnie tam, gdzie mają sens jako cena, liczba sztuk, temperatura lub odległość.
- Dla każdego zadania sprawdź przypadek typowy, wartość graniczną i dane błędne. W zadaniu 1 przetestuj kwotę dokładnie równą progowi rabatu, a w zadaniu 4 wartości bliskie `int.MaxValue`.
- Nazwij stałe zamiast powtarzać liczby w wyrażeniach. Porównaj wynik przed i po dodaniu nawiasów oraz po zmianie typu operandu.
- W opisie rozwiązania wskaż, gdzie występuje konwersja niejawna, jawna albo bezpieczna konwersja przez `TryParse`.

## Źródła

- [Built-in types](https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/built-in-types),
- [Numeric conversions](https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/numeric-conversions),
- [Operators and expressions](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/),
- [The `const` keyword](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/const),
- [Układ katalogów kursu Java](https://github.com/tborzyszkowski/oop-concepts-java/tree/main/02_OOP/src).

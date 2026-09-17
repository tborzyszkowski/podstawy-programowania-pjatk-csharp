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

## Źródła

- [Built-in types](https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/built-in-types),
- [Numeric conversions](https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/numeric-conversions),
- [Operators and expressions](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/),
- [The `const` keyword](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/const),
- [Układ katalogów kursu Java](https://github.com/tborzyszkowski/oop-concepts-java/tree/main/02_OOP/src).

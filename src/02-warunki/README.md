# 02. Instrukcje warunkowe w języku C sharp

Moduł rozwija pojęcie programu jako maszyny stanowej. Student uczy się, że warunek jest wyrażeniem typu `bool`, a instrukcja wyboru decyduje, które kolejne polecenia zostaną wykonane.

## Mapa tematów

1. [Warunki w diagramach blokowych](01-diagramy-blokowe-warunkow/README.md) - romb decyzyjny, gałęzie i łączenie przepływu.
2. [if i if else](02-if-if-else/README.md) - wybór jednej z dwóch ścieżek.
3. [Zagnieżdżona instrukcja if](03-zagniezdzone-if/README.md) - decyzja zależna od wcześniejszej decyzji.
4. [Instrukcja switch](04-switch/README.md) - wybór spośród wielu wariantów i współpraca z `if` oraz `break`.
5. [Operator warunkowy](05-operator-warunkowy/README.md) - krótkie wyrażenie `?:` zwracające jedną z dwóch wartości.
6. [Wyrażanie warunków](06-wyrazenia-warunkowe/README.md) - operatory porównań, logika boolowska, negacja i nawiasy.
7. [Programy wielowariantowe](07-programy-warunkowe/README.md) - pięć kompletnych programów łączących poznane konstrukcje.

## Cele wykładu

Student potrafi:

- odczytać i narysować diagram z rombem decyzyjnym,
- zapisać warunek w C# jako wyrażenie typu `bool`,
- użyć `if`, `if else`, zagnieżdżonego `if`, `switch` i `?:`,
- wybrać konstrukcję adekwatną do liczby i rodzaju wariantów,
- rozpoznać wspólną część gałęzi i unikać powtarzania instrukcji,
- sprawdzić wszystkie istotne ścieżki programu na przykładach.

## Proponowany przebieg laboratorium

1. Przeczytaj dane wejściowe i wypisz możliwe wyniki przed napisaniem kodu.
2. Narysuj diagram dla jednej decyzji, a potem dla dwóch decyzji.
3. Zaimplementuj rozwiązanie w C# i zbuduj projekt.
4. Uruchom przypadek typowy, graniczny i taki, który wybiera inną gałąź.
5. Ustaw punkt przerwania na warunku i prześledź wartość wyrażenia `bool` oraz następne instrukcje.

## Wspólna procedura

W katalogu wybranego projektu:

```powershell
dotnet build
dotnet run
```

Debugowanie w Visual Studio Code uruchamia się przez `F5` po zainstalowaniu C# Dev Kit. `F10` przechodzi do następnej instrukcji, a panel Variables pokazuje stan programu. W Visual Studio użyj `F5`, punktu przerwania i okna Locals.

## Źródła

- [if and switch statements - C# reference](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements),
- [Conditional operator `?:`](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/conditional-operator),
- [Boolean logical operators](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/boolean-logical-operators),
- [Comparison operators](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/comparison-operators),
- [Mermaid flowcharts](https://mermaid.js.org/syntax/flowchart.html).

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

## Przykłady przekrojowe

### Przykład 1: wybór jednej z dwóch ścieżek

```csharp
Console.Write("Podaj temperaturę: ");
decimal temperatura = decimal.Parse(Console.ReadLine()!);

if (temperatura < 0)
{
    Console.WriteLine("mróz");
}
else
{
    Console.WriteLine("brak mrozu");
}
```

Wersja z walidacją danych znajduje się w [01-diagramy-blokowe-warunkow](01-diagramy-blokowe-warunkow/README.md).

### Przykład 2: wybór wielowariantowy

```csharp
Console.Write("Wybierz 1, 2 albo 0: ");
string wybor = Console.ReadLine() ?? "";

switch (wybor)
{
    case "1":
        Console.WriteLine("Start");
        break;
    case "2":
        Console.WriteLine("Stan");
        break;
    case "0":
        Console.WriteLine("Koniec");
        break;
    default:
        Console.WriteLine("Nieznana opcja");
        break;
}
```

Pełny przykład interakcji `switch` z warunkiem `if` znajduje się w [04-switch](04-switch/README.md).

## Zadania przekrojowe

1. Napisz klasyfikator wyniku egzaminu: `0-49` niezaliczony, `50-89` zaliczony, `90-100` bardzo dobry, a pozostałe wartości błędne.
2. Napisz kalkulator kosztu dostawy z trzema wariantami wartości zamówienia. Użyj `if else if` albo `switch` i uzasadnij wybór.
3. Napisz walidator trzech boków trójkąta. Najpierw odrzuć dane niedodatnie i niespełniające nierówności trójkąta, potem rozpoznaj trójkąt równoboczny, równoramienny lub różnoboczny.

### Rozwiązania i wyjaśnienia

Warunek zakresu egzaminu można zapisać tak:

```csharp
if (punkty < 0 || punkty > 100)
{
    Console.WriteLine("Błędny zakres");
}
else if (punkty < 50)
{
    Console.WriteLine("Niezaliczony");
}
else if (punkty < 90)
{
    Console.WriteLine("Zaliczony");
}
else
{
    Console.WriteLine("Bardzo dobry");
}
```

W zadaniu 2 każdy przedział powinien mieć przypadek graniczny, na przykład dokładnie `200`. W zadaniu 3 walidacja musi poprzedzać klasyfikację, aby nie uznać nieistniejącego trójkąta za poprawny.

## Źródła

- [if and switch statements - C# reference](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements),
- [Conditional operator `?:`](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/conditional-operator),
- [Boolean logical operators](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/boolean-logical-operators),
- [Comparison operators](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/comparison-operators),
- [Mermaid flowcharts](https://mermaid.js.org/syntax/flowchart.html).

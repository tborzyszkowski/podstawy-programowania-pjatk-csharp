# 02. `if` i `if else`

## Składnia

Instrukcja `if` wykonuje blok tylko wtedy, gdy warunek ma wartość `true`:

```csharp
if (warunek)
{
    // instrukcje wykonane dla true
}
```

`if else` wybiera dokładnie jedną z dwóch ścieżek:

```csharp
if (warunek)
{
    // true
}
else
{
    // false
}
```

Warunek musi być typu `bool`. W C# liczba `1` nie jest automatycznie traktowana jako `true`, dlatego należy napisać jawne porównanie, na przykład `punkty > 0`.

## Przykład 1: sprawdzenie pełnoletności

Projekt [Kod/Pelnoletnosc/Program.cs](Kod/Pelnoletnosc/Program.cs) pokazuje `if else` z operatorem `>=`. Obie gałęzie przypisują różny komunikat, a wspólne `Console.WriteLine` znajduje się po instrukcji.

```mermaid
flowchart TD
    A([Start]) --> B[/Wczytaj wiek/]
    B --> C{wiek >= 18?}
    C -- Tak --> D[komunikat = "pełnoletnia"]
    C -- Nie --> E[komunikat = "niepełnoletnia"]
    D --> F[/Wypisz komunikat/]
    E --> F
    F --> G([Koniec])
```

## Przykład 2: opłata za przesyłkę

Jeśli wartość zamówienia wynosi co najmniej `200`, dostawa jest bezpłatna; w przeciwnym razie kosztuje `15`. Projekt [Kod/Dostawa/Program.cs](Kod/Dostawa/Program.cs) pokazuje warunek z `decimal` i przypisanie w dwóch gałęziach.

```csharp
decimal kosztDostawy;
if (wartosc >= 200)
{
    kosztDostawy = 0;
}
else
{
    kosztDostawy = 15;
}
```

Nie powtarzamy końcowego obliczenia w obu gałęziach. Taki układ zmniejsza ryzyko, że jedna ścieżka zostanie zaktualizowana, a druga zapomniana.

## Kiedy `if`, a kiedy `if else`?

- Użyj samego `if`, gdy dla `false` nie ma żadnej czynności.
- Użyj `if else`, gdy oba wyniki wymagają jawnego działania.
- Wspólną instrukcję umieść po bloku, jeśli ma wykonać się niezależnie od wyboru.
- Zawsze stosuj klamry, nawet gdy blok ma jedną instrukcję; ułatwia to późniejsze rozszerzenie i debugowanie.

## Zadania z rozwiązaniami

1. Napisz program, który dla wyniku egzaminu wypisuje `zaliczony`, gdy wynik jest co najmniej `50`, oraz `niezaliczony` w przeciwnym razie.
2. Oblicz cenę biletu: osoba poniżej 18 lat płaci `20`, a osoba pełnoletnia `35`.
3. Dodaj kontrolę, aby wynik egzaminu spoza zakresu `0-100` kończył program komunikatem o błędzie.

Rozwiązanie zadania 1 w dwóch instrukcjach:

```csharp
string wynik;
if (punkty >= 50)
{
    wynik = "zaliczony";
}
else
{
    wynik = "niezaliczony";
}
Console.WriteLine(wynik);
```

W zadaniu 3 walidację wykonaj przed obliczeniem biletu, ponieważ niepoprawne dane nie powinny przejść do następnej decyzji.

## Laboratorium

```powershell
dotnet build
dotnet run
```

Uruchom program dostawy dla wartości mniejszej niż `200`, równej `200` i większej. W debugerze obserwuj, czy `kosztDostawy` otrzymuje wartość dokładnie raz.

## Źródła

- [The `if` statement](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/selection-statements#if-statement),
- [Comparison operators](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/comparison-operators),
- [Local variable declarations](https://learn.microsoft.com/dotnet/csharp/language-reference/statements/declarations).

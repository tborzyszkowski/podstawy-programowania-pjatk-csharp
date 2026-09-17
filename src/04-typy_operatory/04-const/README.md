# 04. Kwalifikator `const`

## Stała czasu kompilacji

`const` deklaruje wartość, której nie można zmienić po zdefiniowaniu. Inicjalizator musi być wyrażeniem znanym podczas kompilacji:

```csharp
const decimal StawkaVat = 0.23m;
const int MaksymalnaLiczbaProb = 3;
const string NazwaKursu = "Podstawy programowania";
```

Stała nie jest zwykłą zmienną. Kompilator może wstawić jej wartość w kodzie używającym biblioteki, dlatego zmieniając publiczną stałą w bibliotece, trzeba przebudować kod klienta.

## Kiedy używać?

Użyj `const`, gdy wartość jest częścią niezmiennej reguły programu, na przykład liczba dni tygodnia albo stała matematyczna. Nie używaj go dla ceny lub wersji produktu, jeśli te wartości mogą się zmienić bez zmiany kodu.

`const` różni się od `readonly`: `readonly` można ustawić w deklaracji albo konstruktorze i nie musi być znany podczas kompilacji.

```mermaid
flowchart LR
    A[Wyrażenie stałe] --> B[const]
    B --> C[Wartość ustalona podczas kompilacji]
    C --> D[Nie można przypisać ponownie]
    E[Wartość z wejścia lub DateTime] --> F[Zwykła zmienna albo readonly]
```

Źródło: [diagram-const.mmd](diagram-const.mmd).

## Przykład 1: podatek

Projekt [Kod/Podatek/Program.cs](Kod/Podatek/Program.cs) używa stałej stawki VAT w obliczeniu kwoty brutto.

```csharp
const decimal StawkaVat = 0.23m;
decimal brutto = netto * (1 + StawkaVat);
```

## Przykład 2: limity gry

Projekt [Kod/Limity/Program.cs](Kod/Limity/Program.cs) używa stałych do sprawdzenia punktów. Nazwane stałe są czytelniejsze niż magiczne liczby rozrzucone po kodzie.

```csharp
const int MinimumPunktow = 0;
const int MaksimumPunktow = 100;
bool poprawne = punkty >= MinimumPunktow && punkty <= MaksimumPunktow;
```

## Zadania z rozwiązaniami

1. Zdefiniuj `const double Pi` z dokładnością `3.141592653589793` i oblicz pole koła.
2. Zastąp magiczne liczby w programie punktów nazwanymi stałymi.
3. Spróbuj zadeklarować `const int Rok = DateTime.Now.Year` i wyjaśnij błąd kompilacji.

`DateTime.Now.Year` jest znane dopiero podczas działania programu, więc nie może być inicjalizatorem `const`. Użyj zwykłej zmiennej albo `static readonly`, jeśli omawiany projekt ma już klasy.

## Laboratorium

```powershell
dotnet build
dotnet run
```

Ustaw punkt przerwania przy obliczeniu podatku i sprawdź, że stała nie może zostać przypisana ponownie. Spróbuj celowo zmienić `StawkaVat`, aby zobaczyć błąd kompilacji.

## Źródła

- [The `const` keyword](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/const),
- [The `readonly` keyword](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/readonly),
- [Constants in the C# language specification](https://learn.microsoft.com/dotnet/csharp/language-reference/language-specification/classes#154-constants).

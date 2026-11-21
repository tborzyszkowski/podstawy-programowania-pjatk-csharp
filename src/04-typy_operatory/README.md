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

### Przykładowe rozwiązania zadań przekrojowych

Poniższe fragmenty pokazują jedną z możliwych dróg rozwiązania. Wartości wejściowe w każdym przypadku należy testować również z danymi niepoprawnymi i granicznymi.

1. **Kalkulator zamówienia** — konwersja wejścia przez `TryParse`, stałe dla reguł i rabat naliczany przed VAT:

   ```csharp
   const decimal Vat = 0.23m;
   const decimal ProgRabatu = 500m;
   const decimal Rabat = 0.10m;

   bool poprawnaCena = decimal.TryParse(Console.ReadLine(), out decimal cena) && cena > 0;
   bool poprawnaIlosc = int.TryParse(Console.ReadLine(), out int ilosc) && ilosc > 0;

   if (poprawnaCena && poprawnaIlosc)
   {
       decimal netto = cena * ilosc;
       decimal nettoPoRabacie = netto > ProgRabatu ? netto * (1 - Rabat) : netto;
       decimal brutto = nettoPoRabacie * (1 + Vat);
       Console.WriteLine($"Netto po rabacie: {nettoPoRabacie:F2}, brutto: {brutto:F2}");
   }
   else
   {
       Console.WriteLine("Podaj dodatnią cenę i dodatnią liczbę sztuk.");
   }
   ```

2. **Konwerter temperatury** — oba wejścia sprawdź metodami `TryParse`, a skalę porównuj bez uwzględniania wielkości liter:

   ```csharp
   bool poprawnaTemperatura = double.TryParse(Console.ReadLine(), out double temperatura);
   bool poprawnaSkala = char.TryParse(Console.ReadLine(), out char skala);
   bool skalaCelsjusza = char.ToUpperInvariant(skala) == 'C';
   bool skalaFahrenheita = char.ToUpperInvariant(skala) == 'F';

   if (poprawnaTemperatura && poprawnaSkala && (skalaCelsjusza || skalaFahrenheita))
   {
       double wynik = skalaCelsjusza
           ? temperatura * 9 / 5 + 32
           : (temperatura - 32) * 5 / 9;
       Console.WriteLine(wynik);
   }
   else
   {
       Console.WriteLine("Podaj poprawną temperaturę oraz skalę C albo F.");
   }
   ```

3. **Analizator trzech wyników** — rzutuj przed dodawaniem, aby nie dopuścić do przepełnienia sumy typu `int`; dziel przez `3.0`, aby otrzymać średnią ułamkową:

   ```csharp
   bool poprawnyPierwszy = int.TryParse(Console.ReadLine(), out int pierwszy);
   bool poprawnyDrugi = int.TryParse(Console.ReadLine(), out int drugi);
   bool poprawnyTrzeci = int.TryParse(Console.ReadLine(), out int trzeci);
   bool poprawne = poprawnyPierwszy && poprawnyDrugi && poprawnyTrzeci;

   if (poprawne)
   {
       double srednia = ((double)pierwszy + drugi + trzeci) / 3;
       bool wZakresie = srednia >= 0 && srednia <= 100;
       Console.WriteLine($"Średnia: {srednia}, w zakresie: {wZakresie}");
   }
   else
   {
       Console.WriteLine("Podaj trzy poprawne liczby całkowite.");
   }
   ```

4. **Konwerter odległości** — przykład przyjmuje nieujemną odległość w milimetrach i rozkłada ją na kilometry, metry oraz pozostałe milimetry:

   ```csharp
   if (long.TryParse(Console.ReadLine(), out long milimetry) && milimetry >= 0)
   {
       long kilometry = milimetry / 1_000_000;
       long pozostaleMilimetry = milimetry % 1_000_000;
       long metry = pozostaleMilimetry / 1_000;
       long reszta = pozostaleMilimetry % 1_000;
       Console.WriteLine($"{kilometry} km, {metry} m, {reszta} mm");

       try
       {
           int kilometryJakoInt = checked((int)kilometry);
           Console.WriteLine($"Kilometry jako int: {kilometryJakoInt}");
       }
       catch (OverflowException)
       {
           Console.WriteLine("Liczba metrów nie mieści się w typie int.");
       }
   }
   else
   {
       Console.WriteLine("Podaj nieujemną odległość w milimetrach mieszczącą się w long.");
   }
   ```

5. **Wyrażenia mieszanych typów** — dodawanie ma niższy priorytet niż mnożenie; `int` może być niejawnie konwertowany do `double` albo `decimal`, ale `double` i `decimal` nie łączą się automatycznie:

   ```csharp
   int liczba = 5;
   double pomiar = 2.5;
   double wynikBezNawiasow = liczba + pomiar * 2; // 10
   double wynikZNawiasami = (liczba + pomiar) * 2; // 15

   decimal cena = 1.25m;
   int sztuki = 3;
   decimal wartosc = cena * sztuki; // 3.75m; int jest niejawnie konwertowany do decimal
   ```

   Wyrażenie `pomiar + cena` nie kompiluje się, ponieważ C# nie wybiera automatycznie między `double` a `decimal`. Wybierz jeden typ odpowiedni dla obliczenia; jawnie konwertuj tylko wtedy, gdy świadomie akceptujesz możliwą zmianę precyzji.

## Źródła

- [Built-in types](https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/built-in-types),
- [Numeric conversions](https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/numeric-conversions),
- [Operators and expressions](https://learn.microsoft.com/dotnet/csharp/language-reference/operators/),
- [The `const` keyword](https://learn.microsoft.com/dotnet/csharp/language-reference/keywords/const).

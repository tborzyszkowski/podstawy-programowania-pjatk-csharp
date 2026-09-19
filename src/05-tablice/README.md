# 05. Tablice i algorytmy w języku C sharp

Moduł wprowadza tablice jako pierwszą strukturę przechowującą wiele wartości tego samego typu. Student przechodzi od indeksowania i inicjalizacji, przez wyszukiwanie i sortowanie, do algorytmów macierzowych oraz małych programów inspirowanych analizą pomiarów, obrazów i danych technologicznych.

## Mapa tematów

1. [Tablice jednowymiarowe](01-tablice-jednowymiarowe/README.md) - indeksy, długość, przechodzenie po elementach i podstawowe statystyki.
2. [Inicjalizacja i tablice wielowymiarowe](02-inicjalizacja-tablice-wielowymiarowe/README.md) - inicjalizacja, wartości domyślne, macierze, tablice postrzępione i `GetLength`.
3. [Wyszukiwanie w tablicach](03-wyszukiwanie/README.md) - wyszukiwanie liniowe, binarne, warunki poprawności i koszt obliczeń.
4. [Sortowanie](04-sortowanie/README.md) - sortowanie bąbelkowe, przez wybieranie, przez wstawianie, szybkie, biblioteczne oraz porównanie algorytmów.
5. [Algorytmy macierzowe i przekształcenia 3D](05-algorytmy-macierzowe/README.md) - operacje na macierzach, sąsiedztwo, transpozycja, filtr oraz reprezentacja punktu i transformacji w 3D.
6. [Programy wykorzystujące tablice](06-programy-z-tablicami/README.md) - cztery kompletne przykłady zastosowań jednowymiarowych i wielowymiarowych.

## Cele modułu

Po module student potrafi:

- zadeklarować, zainicjalizować i przekazać tablicę do metody,
- wyjaśnić różnicę między `T[]`, `T[,]`, `T[,,]` i `T[][]`,
- bezpiecznie przechodzić po elementach bez przekraczania zakresu indeksu,
- dobrać wyszukiwanie liniowe albo binarne do własności danych,
- zaimplementować i prześledzić podstawowe algorytmy sortowania,
- ocenić koszt algorytmu w notacji $O$ oraz wpływ danych wejściowych na działanie,
- wykonać typowe operacje na macierzy i opisać współrzędne w tablicy 2D,
- zastosować macierze i `System.Numerics` do prostego przekształcenia 3D,
- zaprojektować program, który łączy tablicę, pętle, metody, walidację i testy przypadków brzegowych.

## Proponowany wykład

1. Zacznij od problemu: wiele pomiarów tego samego typu zamiast wielu zmiennych.
2. Narysuj indeksy tablicy i zaznacz, że pierwszy indeks to `0`, a ostatni to `Length - 1`.
3. Porównaj tablicę jednowymiarową, macierz `[,]` i tablicę postrzępioną `[][]`.
4. Prześledź jeden algorytm wyszukiwania i jeden algorytm sortowania na małym wejściu.
5. Omów niezmiennik, przypadki brzegowe i koszt obliczeń.
6. Pokaż, jak macierz danych może reprezentować obraz, planszę, pomiary wielu sensorów lub współrzędne.
7. Zakończ demonstracją programu i analizą błędów w debuggerze.

## Proponowane laboratorium

Laboratorium można rozłożyć na dwa spotkania:

- **Laboratorium 1:** tablice 1D, inicjalizacja, macierze, wyszukiwanie liniowe i binarne.
- **Laboratorium 2:** implementacja sortowań, pomiar liczby porównań, operacje macierzowe i program zastosowaniowy.

Przed kodowaniem student powinien zapisać: typ elementu, rozmiar tablicy, znaczenie każdego indeksu, warunek zakończenia pętli oraz oczekiwany wynik dla danych typowych i brzegowych.

## Wspólna procedura uruchamiania

W katalogu konkretnego projektu:

```powershell
dotnet build
dotnet run
```

Projekty są aplikacjami konsolowymi `net9.0`. W Visual Studio Code otwórz katalog projektu, ustaw punkt przerwania i uruchom `F5`. Krok `F10` pozwala obserwować indeksy, wartości elementów, granice przedziału oraz wartości pośrednie. W Visual Studio użyj `F5`, okna Locals i Watch.

## Zasady testowania

Dla każdej metody przygotuj co najmniej:

- tablicę pustą albo o jednym elemencie, jeśli metoda ma ją obsługiwać,
- tablicę już uporządkowaną,
- tablicę uporządkowaną odwrotnie,
- powtarzające się wartości,
- wartość szukaną na początku, na końcu i nieobecną,
- macierz niekwadratową, jeśli algorytm nie zakłada kwadratu.

Nie należy zakładać, że `Array.Sort` sortuje macierz `[,]`: dokumentacja .NET opisuje `Array.Sort` dla tablic jednowymiarowych. Macierz trzeba przetwarzać własnymi pętlami albo najpierw spłaszczyć świadomie do `T[]`.

## Zadania przekrojowe

1. Zbuduj analizator pomiarów temperatury: wczytaj `n`, utwórz `double[]`, oblicz minimum, maksimum, średnią i liczbę odczytów poza zakresem. Obsłuż `n <= 0`.
2. Dla tablicy identyfikatorów urządzeń zaimplementuj wyszukiwanie liniowe oraz binarne. Zmierz liczbę porównań i opisz, dlaczego tablica binarna musi być posortowana.
3. Zaimplementuj trzy sortowania omawiane na wykładzie. Dla tego samego wejścia wypisz liczbę porównań i zamian, a następnie porównaj wynik z `Array.Sort`.
4. Napisz program dla macierzy pomiarów `wiersze x kolumny`, który oblicza sumy wierszy, sumy kolumn, minimum globalne i transpozycję.
5. Rozszerz macierz obrazu o filtr średniej z sąsiedztwa. Dla pikseli brzegowych wybierz i opisz jedną konwencję: pomijanie brakujących sąsiadów albo dopełnienie zerami.
6. Zaimplementuj transformację punktów 3D: skalowanie, obrót wokół osi Z i przesunięcie. Wyjaśnij kolejność składania macierzy oraz sprawdź jeden punkt ręcznie.

### Kryteria rozwiązania

- Kod nie odwołuje się do `array[array.Length]` i nie używa stałej liczby elementów zamiast `Length` lub `GetLength`.
- Metody mają jeden wyraźny cel, a nazwy indeksów wskazują ich znaczenie, na przykład `wiersz`, `kolumna`, `lewy`, `prawy`.
- Wyszukiwanie binarne jest uruchamiane dopiero po sortowaniu według tego samego porządku.
- Sortowanie zachowuje wszystkie elementy, także duplikaty.
- Przy macierzach student rozróżnia liczbę wierszy od liczby kolumn.
- Do każdego rozwiązania dołączone są dane wejściowe, oczekiwany wynik oraz krótka analiza kosztu.

## Źródła

Linki sprawdzone przed dodaniem do materiałów:

- [Arrays - C# reference](https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/arrays) - deklarowanie, indeksowanie, tablice wielowymiarowe i postrzępione.
- [Array class](https://learn.microsoft.com/dotnet/api/system.array) - właściwości i metody wspólne dla tablic.
- [Array.Sort method](https://learn.microsoft.com/dotnet/api/system.array.sort) - sortowanie tablic 1D, porównywarki i koszt.
- [Array.BinarySearch method](https://learn.microsoft.com/dotnet/api/system.array.binarysearch) - wyszukiwanie binarne w posortowanej tablicy.
- [Matrix4x4 structure](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4) - macierze transformacji w `System.Numerics`.
- [Vector3.Transform method](https://learn.microsoft.com/dotnet/api/system.numerics.vector3.transform) - przekształcanie punktu lub wektora.

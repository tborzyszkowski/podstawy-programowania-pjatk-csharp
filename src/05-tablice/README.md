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

## Zadania przekrojowe do samodzielnego rozwiązania

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

### Rozwiązania zadań przekrojowych

1. **Analizator temperatury.** Poniżej zakres alarmowy wynosi od `-50` do `50`. Inicjalizacja minimum i maksimum pierwszym pomiarem działa także wtedy, gdy wszystkie wartości są ujemne:

   ```csharp
   const double MinimumZakresu = -50;
   const double MaksimumZakresu = 50;

   if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
   {
       Console.WriteLine("Liczba pomiarów musi być dodatnia.");
       return;
   }

   double[] pomiary = new double[n];
   for (int indeks = 0; indeks < pomiary.Length; indeks++)
   {
       if (!double.TryParse(Console.ReadLine(), out pomiary[indeks]) ||
           !double.IsFinite(pomiary[indeks]))
       {
           Console.WriteLine("Podaj skończoną wartość temperatury.");
           return;
       }
   }

   double minimum = pomiary[0];
   double maksimum = pomiary[0];
   double suma = 0;
   int pozaZakresem = 0;
   foreach (double pomiar in pomiary)
   {
       if (pomiar < minimum) minimum = pomiar;
       if (pomiar > maksimum) maksimum = pomiar;
       suma += pomiar;
       if (pomiar < MinimumZakresu || pomiar > MaksimumZakresu) pozaZakresem++;
   }

   Console.WriteLine($"Min: {minimum}, max: {maksimum}, średnia: {suma / pomiary.Length}");
   Console.WriteLine($"Poza zakresem: {pozaZakresem}");
   ```

   Analiza ma koszt $O(n)$ czasu i $O(n)$ pamięci na przechowanie pomiarów.

2. **Wyszukiwanie identyfikatorów.** Posortuj kopię identyfikatorów przed wyszukiwaniem binarnym. Metody `Liniowo` i `Binarnie` wraz z licznikami porównań są rozwiązane w [temacie wyszukiwania](03-wyszukiwanie/README.md#rozwiązania):

   ```csharp
   int[] identyfikatory = { 42, 17, 81, 17, 55 };
   int[] posortowane = (int[])identyfikatory.Clone();
   Array.Sort(posortowane);

   _ = Liniowo(identyfikatory, 17, out int porownaniaLiniowe);
   _ = Binarnie(posortowane, 17, out int porownaniaBinarne);
   Console.WriteLine($"Liniowo: {porownaniaLiniowe}; binarnie: {porownaniaBinarne}");
   ```

   Wyszukiwanie liniowe nie wymaga porządku i ma koszt $O(n)$; binarne wymaga posortowanej tablicy i ma koszt $O(log n)$. Jeśli dane sortujemy tylko raz i wykonujemy wiele wyszukiwań, koszt sortowania może się opłacić.

3. **Porównanie sortowań.** Algorytmy bąbelkowe, przez wybieranie i przez wstawianie opisano w [temacie sortowania](04-sortowanie/README.md#rozwiązania). Każdy dostaje odrębną kopię wejścia:

   ```csharp
   int[] dane = { 8, 3, 5, 3, 1 };
   int[][] wyniki = new int[4][];

   wyniki[0] = (int[])dane.Clone();
   SortowanieBabelkowe(wyniki[0]);
   wyniki[1] = (int[])dane.Clone();
   SortowaniePrzezWybieranie(wyniki[1]);
   wyniki[2] = (int[])dane.Clone();
   SortowaniePrzezWstawianie(wyniki[2]);
   wyniki[3] = (int[])dane.Clone();
   Array.Sort(wyniki[3]);

   foreach (int[] wynik in wyniki)
   {
       Console.WriteLine(string.Join(", ", wynik));
   }
   ```

   Każda linia powinna zawierać `1, 3, 3, 5, 8`. Wszystkie algorytmy muszą zachować duplikaty; ich koszty i eksperyment pomiarowy opisano w temacie sortowania.

4. **Macierz pomiarów.** Ten przykład oblicza sumy wierszy i kolumn, minimum globalne oraz transpozycję dla dowolnej niepustej macierzy:

   ```csharp
   int[,] dane = { { 4, 1, 7 }, { 2, 9, 3 } };
   int wiersze = dane.GetLength(0);
   int kolumny = dane.GetLength(1);
   int[] sumyWierszy = new int[wiersze];
   int[] sumyKolumn = new int[kolumny];
   int minimum = dane[0, 0];

   for (int wiersz = 0; wiersz < wiersze; wiersz++)
   {
       for (int kolumna = 0; kolumna < kolumny; kolumna++)
       {
           int wartosc = dane[wiersz, kolumna];
           sumyWierszy[wiersz] += wartosc;
           sumyKolumn[kolumna] += wartosc;
           if (wartosc < minimum) minimum = wartosc;
       }
   }

   int[,] transpozycja = new int[kolumny, wiersze];
   for (int wiersz = 0; wiersz < wiersze; wiersz++)
   {
       for (int kolumna = 0; kolumna < kolumny; kolumna++)
       {
           transpozycja[kolumna, wiersz] = dane[wiersz, kolumna];
       }
   }
   ```

   Dla przykładu sumy wierszy to `[12, 14]`, sumy kolumn `[6, 10, 10]`, minimum `1`, a transpozycja ma rozmiar `3 x 2`. Czas działania to $O(r \cdot c)$.

5. **Filtr średniej.** Dla każdego piksela sumuj tylko sąsiadów mieszczących się w obrazie i zapisz wynik do nowej macierzy. Dzielenie przez liczbę faktycznie zebranych pikseli realizuje konwencję pomijania brakujących sąsiadów:

   ```csharp
   static int[,] FiltrSredniej(int[,] obraz)
   {
       int wiersze = obraz.GetLength(0);
       int kolumny = obraz.GetLength(1);
       int[,] wynik = new int[wiersze, kolumny];

       for (int y = 0; y < wiersze; y++)
       {
           for (int x = 0; x < kolumny; x++)
           {
               long suma = 0;
               int licznik = 0;
               for (int dy = -1; dy <= 1; dy++)
               {
                   for (int dx = -1; dx <= 1; dx++)
                   {
                       int ny = y + dy;
                       int nx = x + dx;
                       if (ny >= 0 && ny < wiersze && nx >= 0 && nx < kolumny)
                       {
                           suma += obraz[ny, nx];
                           licznik++;
                       }
                   }
               }

               wynik[y, x] = (int)Math.Round((double)suma / licznik);
           }
       }
       return wynik;
   }
   ```

   Wynik zapisuje się do nowej tablicy, więc piksel po filtracji nie wpływa na obliczenia sąsiadów. Pełny filtr medianowy i przykład zakłóconego piksela znajdują się w [rozwiązaniu algorytmów macierzowych](05-algorytmy-macierzowe/README.md#rozwiązania).

6. **Transformacja 3D.** Dla punktu `(1, 0, 0)` najpierw skalowanie `(2, 1, 1)` daje `(2, 0, 0)`, obrót o 90° wokół Z daje `(0, 2, 0)`, a przesunięcie `(10, 5, 0)` kończy się punktem `(10, 7, 0)`:

   ```csharp
   Vector3 punkt = new(1, 0, 0);
   Matrix4x4 transformacja =
       Matrix4x4.CreateScale(2, 1, 1) *
       Matrix4x4.CreateRotationZ(MathF.PI / 2) *
       Matrix4x4.CreateTranslation(10, 5, 0);
   Vector3 wynik = Vector3.Transform(punkt, transformacja);
   Console.WriteLine(wynik); // w przybliżeniu <10, 7, 0>
   ```

   Ręczne obliczenie potwierdza kolejność: skalowanie, obrót, a następnie przesunięcie. Ze względu na obliczenia zmiennoprzecinkowe współrzędne porównuj z tolerancją.

## Źródła

Linki sprawdzone przed dodaniem do materiałów:

- [Arrays - C# reference](https://learn.microsoft.com/dotnet/csharp/language-reference/builtin-types/arrays) - deklarowanie, indeksowanie, tablice wielowymiarowe i postrzępione.
- [Array class](https://learn.microsoft.com/dotnet/api/system.array) - właściwości i metody wspólne dla tablic.
- [Array.Sort method](https://learn.microsoft.com/dotnet/api/system.array.sort) - sortowanie tablic 1D, porównywarki i koszt.
- [Array.BinarySearch method](https://learn.microsoft.com/dotnet/api/system.array.binarysearch) - wyszukiwanie binarne w posortowanej tablicy.
- [Matrix4x4 structure](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4) - macierze transformacji w `System.Numerics`.
- [Vector3.Transform method](https://learn.microsoft.com/dotnet/api/system.numerics.vector3.transform) - przekształcanie punktu lub wektora.

# 05. Algorytmy macierzowe i przekształcenia 3D

Macierz zapisana jako `double[,]` jest tablicą danych z dwoma indeksami. W programie pierwszy indeks przyjmujemy jako wiersz, a drugi jako kolumnę. To tylko konwencja modelowania; sam typ `[,]` nie nadaje znaczenia indeksom.

## Operacje na macierzach 2D

### Sumy wierszy i kolumn

Dla macierzy `r x c` suma wiersza wymaga przejścia po `c` kolumnach, a suma kolumny po `r` wierszach. Jedno przejście po wszystkich elementach ma koszt $O(r \cdot c)$.

```csharp
static int[] SumyWierszy(int[,] macierz)
{
    int[] sumy = new int[macierz.GetLength(0)];
    for (int wiersz = 0; wiersz < macierz.GetLength(0); wiersz++)
    {
        for (int kolumna = 0; kolumna < macierz.GetLength(1); kolumna++)
        {
            sumy[wiersz] += macierz[wiersz, kolumna];
        }
    }
    return sumy;
}
```

### Transpozycja

Transpozycja zamienia pozycję `[wiersz, kolumna]` na `[kolumna, wiersz]`. Dla prostokątnej macierzy trzeba utworzyć nową tablicę o odwróconych rozmiarach. Dla macierzy kwadratowej można zamieniać elementy nad przekątną, dzięki czemu pracujemy w miejscu.

### Mnożenie macierzy

Jeżeli `A` ma rozmiar `r x k`, a `B` ma rozmiar `k x c`, wynik `C` ma rozmiar `r x c`. Element:

$$C_{i,j} = \sum_{t=0}^{k-1} A_{i,t} B_{t,j}.$$

W C# oznacza to trzy zagnieżdżone pętle. Warunkiem poprawności jest zgodność liczby kolumn `A` z liczbą wierszy `B`. Naiwna implementacja ma koszt $O(r \cdot k \cdot c)$.

### Sąsiedztwo i filtr obrazu

Macierz wartości może reprezentować obraz w odcieniach szarości, gdzie `obraz[y, x]` jest jasnością piksela. Filtr średniej odwiedza piksel i jego sąsiadów w oknie, np. `3 x 3`, a następnie zapisuje średnią do nowej macierzy. Nie należy nadpisywać wejścia podczas obliczania, ponieważ zmieniony piksel stałby się wejściem dla kolejnych obliczeń.

Dla brzegów trzeba wybrać konwencję:

1. pominąć współrzędne spoza obrazu i dzielić przez liczbę istniejących sąsiadów,
2. przyjąć wartość `0`,
3. powtórzyć wartość najbliższego piksela.

W dydaktycznym przykładzie wybieramy pierwszą konwencję, bo nie wprowadza sztucznej czerni na brzegu.

## Przekształcenia 3D

Punkt w przestrzeni zapisujemy jako `Vector3`, na przykład `(x, y, z)`. Typ `Matrix4x4` przechowuje macierz używaną przez `System.Numerics` do skalowania, obrotu, przesunięcia i projekcji. Czwarty wymiar macierzy pozwala reprezentować przesunięcie w jednolitym mechanizmie współrzędnych jednorodnych.

### Skalowanie

Skalowanie przez `(sx, sy, sz)` zmienia punkt zgodnie z:

$$x' = s_x x, \quad y' = s_y y, \quad z' = s_z z.$$

### Obrót wokół osi Z

Dla kąta $\theta$ obrót w płaszczyźnie XY opisują równania składowych:

$$x' = x\cos\theta - y\sin\theta$$

$$y' = x\sin\theta + y\cos\theta$$

$$z' = z$$

Oznacza to, że obrót wokół osi Z zmienia współrzędne $x$ i $y$, ale pozostawia współrzędną $z$ bez zmian. Dla kąta $90^\circ$ punkt $(1, 0, 0)$ przechodzi w punkt $(0, 1, 0)$, z dokładnością do błędu obliczeń zmiennoprzecinkowych.

W `System.Numerics` nie trzeba przepisywać wzoru ręcznie:

```csharp
Vector3 punkt = new(1, 0, 0);
Matrix4x4 skala = Matrix4x4.CreateScale(2, 1, 1);
Matrix4x4 obrot = Matrix4x4.CreateRotationZ(MathF.PI / 2);
Matrix4x4 przesuniecie = Matrix4x4.CreateTranslation(10, 5, 0);

Matrix4x4 transformacja = skala * obrot * przesuniecie;
Vector3 wynik = Vector3.Transform(punkt, transformacja);
Console.WriteLine(wynik);
```

Dla tego przykładu najpierw otrzymujemy `(2, 0, 0)`, po obrocie `(0, 2, 0)`, a po przesunięciu `(10, 7, 0)`, z niewielkim błędem zmiennoprzecinkowym przy cosinusie kąta $90^\circ$. Kolejność jest ważna: macierze transformacji na ogół nie przemieniają się, czyli `A * B` daje inny efekt niż `B * A`.

### Obrót wokół innych osi

- `Matrix4x4.CreateRotationX` obraca w płaszczyźnie YZ,
- `Matrix4x4.CreateRotationY` obraca w płaszczyźnie XZ,
- `Matrix4x4.CreateRotationZ` obraca w płaszczyźnie XY.

Dla obrotu wokół dowolnej osi można użyć `Matrix4x4.CreateFromAxisAngle`. W aplikacjach 3D zwykle wykonuje się transformację modelu, następnie świata i kamery, a na końcu projekcję do ekranu. Ten moduł zatrzymuje się na transformacji punktu, aby nie mieszać jej z pełnym renderingiem.

```mermaid
flowchart LR
    A[Punkt 3D Vector3] --> B[Skalowanie]
    B --> C[Obrót]
    C --> D[Przesunięcie]
    D --> E[Vector3.Transform]
    E --> F[Punkt w nowym układzie]
```

Źródło: [diagram-macierz-3d.mmd](diagram-macierz-3d.mmd).

## Projekt demonstracyjny

Projekt [Kod/Transformacja/Program.cs](Kod/Transformacja/Program.cs) wykonuje sumy wierszy i kolumn, transpozycję, filtr średniej na małej macierzy obrazu oraz transformację punktów sześcianu. Jest to przykład połączenia tablic wielowymiarowych z biblioteką `System.Numerics`.

## Zadania do samodzielnego rozwiązania

1. Zaimplementuj mnożenie dwóch macierzy `double[,]` z kontrolą zgodności wymiarów.
2. Napisz filtr medianowy `3 x 3` i porównaj go ze średnią dla macierzy zawierającej pojedynczy zakłócony piksel.
3. Zaimplementuj obrót wszystkich punktów kwadratu w płaszczyźnie XY o `90` stopni.
4. Zastosuj transformację skalowania, obrotu i przesunięcia do ośmiu wierzchołków prostopadłościanu.
5. Oblicz największą wartość w każdym wierszu i zaznacz jej współrzędne.

### Rozwiązania

1. Wynik mnożenia ma rozmiar `lewa.GetLength(0) x prawa.GetLength(1)`. Metoda odrzuca niezgodne wymiary:

   ```csharp
   static double[,] Pomnoz(double[,] lewa, double[,] prawa)
   {
       int wiersze = lewa.GetLength(0);
       int wspolnyWymiar = lewa.GetLength(1);
       if (wspolnyWymiar != prawa.GetLength(0))
       {
           throw new ArgumentException("Liczba kolumn lewej macierzy musi równać się liczbie wierszy prawej.");
       }

       int kolumny = prawa.GetLength(1);
       double[,] wynik = new double[wiersze, kolumny];
       for (int wiersz = 0; wiersz < wiersze; wiersz++)
       {
           for (int kolumna = 0; kolumna < kolumny; kolumna++)
           {
               for (int indeks = 0; indeks < wspolnyWymiar; indeks++)
               {
                   wynik[wiersz, kolumna] += lewa[wiersz, indeks] * prawa[indeks, kolumna];
               }
           }
       }
       return wynik;
   }
   ```

2. Filtr pomija współrzędne poza obrazem, sortuje wartości z danego sąsiedztwa i wybiera górną medianę, gdy ich liczba jest parzysta:

   ```csharp
   static int[,] FiltrMedianowy(int[,] obraz)
   {
       int wiersze = obraz.GetLength(0);
       int kolumny = obraz.GetLength(1);
       int[,] wynik = new int[wiersze, kolumny];

       for (int y = 0; y < wiersze; y++)
       {
           for (int x = 0; x < kolumny; x++)
           {
               List<int> sasiedzi = new();
               for (int dy = -1; dy <= 1; dy++)
               {
                   for (int dx = -1; dx <= 1; dx++)
                   {
                       int ny = y + dy;
                       int nx = x + dx;
                       if (ny >= 0 && ny < wiersze && nx >= 0 && nx < kolumny)
                       {
                           sasiedzi.Add(obraz[ny, nx]);
                       }
                   }
               }

               sasiedzi.Sort();
               wynik[y, x] = sasiedzi[sasiedzi.Count / 2];
           }
       }
       return wynik;
   }
   ```

   Dla obrazu `{{10, 10, 10}, {10, 255, 10}, {10, 10, 10}}` środkowy piksel po filtrze medianowym ma wartość `10`; filtr średniej da w środku około `37`. Mediana ogranicza wpływ pojedynczego jasnego zakłócenia.

3. Obrót punktu `(x, y, z)` o 90° wokół osi Z daje `(-y, x, z)`:

   ```csharp
   Vector3[] punkty =
   {
       new(1, 0, 0), new(0, 1, 0),
       new(-1, 0, 0), new(0, -1, 0)
   };

   Vector3[] obrocone = new Vector3[punkty.Length];
   for (int indeks = 0; indeks < punkty.Length; indeks++)
   {
       Vector3 punkt = punkty[indeks];
       obrocone[indeks] = new Vector3(-punkt.Y, punkt.X, punkt.Z);
   }
   ```

   Na przykład `(1, 0, 0)` przechodzi w `(0, 1, 0)`.

4. Utwórz osiem wierzchołków, zbuduj jedną macierz transformacji i zastosuj ją do każdego punktu:

   ```csharp
   Vector3[] wierzcholki =
   {
       new(-1, -1, -1), new(1, -1, -1), new(-1, 1, -1), new(1, 1, -1),
       new(-1, -1, 1), new(1, -1, 1), new(-1, 1, 1), new(1, 1, 1)
   };
   Matrix4x4 transformacja =
       Matrix4x4.CreateScale(2, 1, 1) *
       Matrix4x4.CreateRotationZ(MathF.PI / 2) *
       Matrix4x4.CreateTranslation(10, 5, 0);

   Vector3[] wynik = new Vector3[wierzcholki.Length];
   for (int indeks = 0; indeks < wierzcholki.Length; indeks++)
   {
       wynik[indeks] = Vector3.Transform(wierzcholki[indeks], transformacja);
   }
   ```

   W tej kolejności punkt jest skalowany, obracany, a następnie przesuwany. Ta sama macierz utrzymuje spójność wszystkich wierzchołków.

5. Zapisuj maksimum i jego kolumnę osobno dla każdego wiersza. Aktualizacja tylko przy `>` zachowuje pierwszą pozycję w przypadku remisu:

   ```csharp
   static (int Wartosc, int Kolumna)[] MaksimaWierszy(int[,] macierz)
   {
       int wiersze = macierz.GetLength(0);
       int kolumny = macierz.GetLength(1);
       if (kolumny == 0)
       {
           throw new ArgumentException("Każdy wiersz musi zawierać co najmniej jedną wartość.");
       }

       var maksima = new (int Wartosc, int Kolumna)[wiersze];
       for (int wiersz = 0; wiersz < wiersze; wiersz++)
       {
           int kolumnaMaksimum = 0;
           for (int kolumna = 1; kolumna < kolumny; kolumna++)
           {
               if (macierz[wiersz, kolumna] > macierz[wiersz, kolumnaMaksimum])
               {
                   kolumnaMaksimum = kolumna;
               }
           }
           maksima[wiersz] = (macierz[wiersz, kolumnaMaksimum], kolumnaMaksimum);
       }
       return maksima;
   }
   ```

   Współrzędne maksimum to `[wiersz, wynik[wiersz].Kolumna]`. Wybór `>` zamiast `>=` zwraca pierwsze maksimum w wierszu.

## Laboratorium

```powershell
dotnet build
dotnet run
```

1. Zatrzymaj program przed i po transpozycji.
2. Zmień wartość środkowego piksela i obserwuj działanie filtra.
3. Porównaj `skala * obrot * przesuniecie` z inną kolejnością mnożenia.
4. Sprawdź ręcznie punkt `(1, 0, 0)` i porównaj go z wynikiem `Vector3.Transform`.
5. Dodaj asercje dla wymiarów macierzy i tolerancji obliczeń zmiennoprzecinkowych.

## Źródła

- [Multidimensional arrays](https://learn.microsoft.com/dotnet/csharp/programming-guide/arrays/multidimensional-arrays),
- [Matrix4x4 structure](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4),
- [Matrix4x4.CreateScale](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4.createscale),
- [Matrix4x4.CreateRotationZ](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4.createrotationz),
- [Matrix4x4.CreateTranslation](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4.createtranslation),
- [Vector3.Transform](https://learn.microsoft.com/dotnet/api/system.numerics.vector3.transform).

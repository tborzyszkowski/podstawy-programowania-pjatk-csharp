<p align="left">
  <a href="#wykorzystanie-ai-w-materiałach">
    <kbd style="background-color: #0056b3; color: white; padding: 5px 10px; border-radius: 4px; font-weight: bold; border: none; font-family: sans-serif; font-size: 13px;">🤖 AI-Assisted</kbd>
    <kbd style="background-color: #6c757d; color: white; padding: 5px 10px; border-radius: 4px; font-weight: bold; border: none; font-family: sans-serif; font-size: 13px;">Edukacja</kbd>
  </a>
</p>

# Podstawy programowania w C#

Materiały do zajęć z Podstaw Programowania na PJATK w Gdańsku.

## Zawartość

- **01. Wprowadzenie** - [algorytmy, program i środowisko pracy](src/01-wprowadzenie/README.md): od pojęcia algorytmu do pierwszych obliczeń, debugowania i sprawdzania poprawności programu.
- **02. Warunki** - [instrukcje wyboru](src/02-warunki/README.md): wybór kolejnych instrukcji wykonywanych przez program.
- **03. Pętle** - [wielokrotne wykonywanie instrukcji](src/03-petle/README.md): pętle `for`, `while`, `do while`, zagnieżdżanie oraz sterowanie iteracją.
- **04. Typy i operatory** - [typy danych, konwersje i operatory](src/04-typy_operatory/README.md): dobór reprezentacji danych, konwersje, stałe, operatory i ich priorytety.
- **05. Tablice** - [tablice i algorytmy](src/05-tablice/README.md): tablice jednowymiarowe i wielowymiarowe, wyszukiwanie, sortowanie, macierze oraz proste transformacje 3D.

Każdy temat zawiera:

- osobny plik `README.md` przeznaczony do wykorzystania na wykładzie i laboratorium,
- diagramy Mermaid (`.mmd`), które można wyświetlić w Visual Studio Code z rozszerzeniem Mermaid,
- kompletny projekt konsolowy `net9.0`,
- zadania dla studentów, rozwiązania i instrukcje uruchamiania.

Numerowany układ katalogów jest inspirowany strukturą [kursu programowania obiektowego w Javie](https://github.com/tborzyszkowski/oop-concepts-java/tree/main/02_OOP/src), ale wszystkie przykłady w tym repozytorium odnoszą się do C# i .NET.

## Wymagania

- .NET SDK 9.0 lub nowszy,
- Visual Studio 2022 z obciążeniem „Programowanie aplikacji klasycznych .NET” albo Visual Studio Code z rozszerzeniem C# Dev Kit,
- podstawowa znajomość pracy w terminalu.

## Szybki start

W katalogu repozytorium:

```powershell
dotnet --version
dotnet run --project src/01-wprowadzenie/01-pojecie-algorytmu/Kod/AlgorytmEuclidesa/AlgorytmEuclidesa.csproj
```

Pozostałe projekty można uruchamiać poleceniem `dotnet run --project <ścieżka-do-csproj>`. Budowanie bez uruchamiania wykonuje `dotnet build <ścieżka-do-csproj>`.

## Licencja

Materiały są udostępnione zgodnie z warunkami opisanymi w [LICENSE.md](LICENSE.md).

## Wykorzystanie AI w materiałach

Materiały dydaktyczne zawarte w tym repozytorium są przygotowywane przy wsparciu narzędzi sztucznej inteligencji (Generative AI), które pełnią rolę asystenta twórcy. 

Sztuczna inteligencja jest wykorzystywana w celach pomocniczych, w szczególności do:
- Współtworzenia i optymalizacji bazowych przykładów kodu oraz konfiguracji.
- Formatowania, strukturyzacji oraz automatyzacji generowania dokumentacji.
- Wsparcia procesu redakcyjnego, korekty językowej oraz generowania alternatywnych wyjaśnień pojęć technicznych.

Wszystkie materiały, schematy oraz kody źródłowe podlegają **weryfikacji merytorycznej i edycji przez człowieka**.
Ostateczna treść oraz układ dydaktyczny są wynikiem autorskiego nadzoru, co zapewnia ich poprawność oraz zgodność ze standardami akademickimi.

Console.WriteLine("Informacje o środowisku uruchomieniowym");
Console.WriteLine($"Wersja .NET: {Environment.Version}");
Console.WriteLine($"System operacyjny: {Environment.OSVersion}");
Console.WriteLine($"Katalog aplikacji: {AppContext.BaseDirectory}");
Console.WriteLine($"Liczba argumentów: {args.Length}");
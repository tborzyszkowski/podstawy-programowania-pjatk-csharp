int liczbaStudentow = 120;
long liczbaOperacji = 5_000_000_000L;
byte poziom = 255;
float temperatura = 21.5f;
double odleglosc = 12.75;
decimal cena = 19.99m;

Console.WriteLine($"int: {liczbaStudentow}, rozmiar: {sizeof(int)} bajty");
Console.WriteLine($"long: {liczbaOperacji}, rozmiar: {sizeof(long)} bajty");
Console.WriteLine($"byte: {poziom}, rozmiar: {sizeof(byte)} bajt");
Console.WriteLine($"float: {temperatura}");
Console.WriteLine($"double: {odleglosc}");
Console.WriteLine($"decimal: {cena:0.00}");

double sumaDouble = 0.1 + 0.2;
decimal sumaDecimal = 0.1m + 0.2m;
Console.WriteLine($"0.1 + 0.2 jako double == 0.3: {sumaDouble == 0.3}");
Console.WriteLine($"0.1m + 0.2m == 0.3m: {sumaDecimal == 0.3m}");
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

Console.WriteLine();
Console.WriteLine("Odstępy między sąsiednimi wartościami");

float odstepFloatNadJedynka = MathF.BitIncrement(1f) - 1f;
double odstepDoubleNadJedynka = Math.BitIncrement(1d) - 1d;
float odstepFloatPodJedynka = 1f - MathF.BitDecrement(1f);
double odstepDoublePodJedynka = 1d - Math.BitDecrement(1d);

Console.WriteLine($"float: pierwszy krok od zera: {MathF.BitIncrement(0f):G9}");
Console.WriteLine($"float: odstęp nad 1: {odstepFloatNadJedynka:G9}");
Console.WriteLine($"float: odstęp pod 1: {odstepFloatPodJedynka:G9}");
Console.WriteLine($"float.Epsilon (to nie jest odstęp przy 1): {float.Epsilon:G9}");
Console.WriteLine($"float: odstęp przed MaxValue: {float.MaxValue - MathF.BitDecrement(float.MaxValue):G9}");
Console.WriteLine($"float: wartość po MaxValue: {MathF.BitIncrement(float.MaxValue)}");

Console.WriteLine($"double: pierwszy krok od zera: {Math.BitIncrement(0d):G17}");
Console.WriteLine($"double: odstęp nad 1: {odstepDoubleNadJedynka:G17}");
Console.WriteLine($"double: odstęp pod 1: {odstepDoublePodJedynka:G17}");
Console.WriteLine($"double.Epsilon (to nie jest odstęp przy 1): {double.Epsilon:G17}");
Console.WriteLine($"double: odstęp przed MaxValue: {double.MaxValue - Math.BitDecrement(double.MaxValue):G17}");
Console.WriteLine($"double: wartość po MaxValue: {Math.BitIncrement(double.MaxValue)}");

decimal najmniejszaDodatniaDecimal = 1E-28m;
Console.WriteLine($"decimal: pierwszy krok od zera: {najmniejszaDodatniaDecimal:G29}");
Console.WriteLine($"decimal: następna wartość po 1: {1m + najmniejszaDodatniaDecimal:G29}");
Console.WriteLine($"decimal: odstęp przed MaxValue: {decimal.MaxValue - (decimal.MaxValue - 1m):G29}");
Console.WriteLine($"decimal: MaxValue: {decimal.MaxValue:G29}");
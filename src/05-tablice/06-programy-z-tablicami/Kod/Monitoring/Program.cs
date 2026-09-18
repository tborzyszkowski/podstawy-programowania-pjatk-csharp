const double LimitAlarmu = 30.0;
double[] temperatury = { 21.5, 22.0, 31.2, 32.1, 29.4, 27.8, 33.0 };

double minimum = temperatury[0];
double maksimum = temperatury[0];
double suma = 0;
int alarmy = 0;
int pierwszyAlarm = -1;

for (int indeks = 0; indeks < temperatury.Length; indeks++)
{
    double temperatura = temperatury[indeks];
    suma += temperatura;
    minimum = Math.Min(minimum, temperatura);
    maksimum = Math.Max(maksimum, temperatura);

    if (temperatura > LimitAlarmu)
    {
        alarmy++;
        if (pierwszyAlarm == -1)
        {
            pierwszyAlarm = indeks;
        }
    }
}

double srednia = suma / temperatury.Length;
Console.WriteLine($"Odczytow: {temperatury.Length}");
Console.WriteLine($"Minimum: {minimum:F1} C");
Console.WriteLine($"Maksimum: {maksimum:F1} C");
Console.WriteLine($"Srednia: {srednia:F1} C");
Console.WriteLine($"Alarmow: {alarmy}");
Console.WriteLine(pierwszyAlarm >= 0
    ? $"Pierwszy alarm: indeks {pierwszyAlarm}"
    : "Brak alarmow");

using System.Numerics;

Vector3[] wierzcholki =
{
    new(-1, -1, -1), new(1, -1, -1), new(1, 1, -1), new(-1, 1, -1),
    new(-1, -1, 1), new(1, -1, 1), new(1, 1, 1), new(-1, 1, 1)
};

Matrix4x4 transformacja =
    Matrix4x4.CreateScale(1.5f, 1.0f, 0.5f) *
    Matrix4x4.CreateRotationY(MathF.PI / 4) *
    Matrix4x4.CreateTranslation(3, 2, 1);

Vector3[] przeksztalcone = new Vector3[wierzcholki.Length];
for (int indeks = 0; indeks < wierzcholki.Length; indeks++)
{
    przeksztalcone[indeks] = Vector3.Transform(wierzcholki[indeks], transformacja);
    Console.WriteLine($"{indeks}: {wierzcholki[indeks]} -> {przeksztalcone[indeks]}");
}

Vector3 minimum = przeksztalcone[0];
Vector3 maksimum = przeksztalcone[0];
foreach (Vector3 punkt in przeksztalcone)
{
    minimum = Vector3.Min(minimum, punkt);
    maksimum = Vector3.Max(maksimum, punkt);
}

Console.WriteLine($"Zakres X: {minimum.X:F2} .. {maksimum.X:F2}");
Console.WriteLine($"Zakres Y: {minimum.Y:F2} .. {maksimum.Y:F2}");
Console.WriteLine($"Zakres Z: {minimum.Z:F2} .. {maksimum.Z:F2}");

long pamiecPrzed = GC.GetTotalMemory(forceFullCollection: false);
long alokacjePrzed = GC.GetAllocatedBytesForCurrentThread();

object nowyObiekt = new();
Console.WriteLine($"Generacja nowego obiektu: {GC.GetGeneration(nowyObiekt)}");

List<byte[]> bufory = [];
for (int indeks = 0; indeks < 5; indeks++)
{
    bufory.Add(new byte[100_000]);
}

WeakReference slabeOdwolanie = UtworzObiektTymczasowy();
Console.WriteLine($"Alokacje wątku: {GC.GetAllocatedBytesForCurrentThread() - alokacjePrzed}");
Console.WriteLine($"Pamięć przed czyszczeniem: {pamiecPrzed}");
Console.WriteLine($"Pamięć po buforach: {GC.GetTotalMemory(false)}");

bufory.Clear();
nowyObiekt = new object();
GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine($"WeakReference po GC: {slabeOdwolanie.IsAlive}");
Console.WriteLine($"Pamięć po eksperymencie: {GC.GetTotalMemory(false)}");

using (MemoryStream strumien = new())
{
    strumien.WriteByte(42);
    Console.WriteLine($"Zasób w using: {strumien.Length} bajt");
}

static WeakReference UtworzObiektTymczasowy()
{
    object obiekt = new byte[2048];
    return new WeakReference(obiekt);
}
namespace MyApp;

public sealed class Kalkulator
{
    public int Add(int pierwsza, int druga)
    {
        return pierwsza + druga;
    }

    public int Divide(int dzielna, int dzielnik)
    {
        if (dzielnik == 0)
        {
            throw new ArgumentException("Dzielnik nie może być zerem.", nameof(dzielnik));
        }

        return dzielna / dzielnik;
    }

    public bool IsEven(int liczba)
    {
        return liczba % 2 == 0;
    }
}

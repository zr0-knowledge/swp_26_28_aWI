public class Mathematik
{
    public int Fakultaet(int n)
    {
        if (n < 0) throw new ArgumentException("Zahl darf nicht negativ sein.");
        if (n == 0 || n == 1) return 1;

        int ergebnis = 1;
        for (int i = 2; i <= n; i++)
        {
            ergebnis *= i;
        }
        return ergebnis;
    }
}

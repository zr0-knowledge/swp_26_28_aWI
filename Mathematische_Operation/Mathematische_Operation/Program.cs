using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Geben Sie eine natürliche Zahl ein: ");
        int zahl = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nGeben Sie eine Zahl zwischen 1 und 3 ein, um eine mathematische Operation auszuwählen:");
        Console.WriteLine("1) Quadrat");
        Console.WriteLine("2) Wurzel");
        Console.WriteLine("3) Fakultät");
        Console.Write("Ihre Auswahl: ");

        int auswahl = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch (auswahl)
        {
            case 1:
                int quadrat = zahl * zahl;
                Console.WriteLine($"Das Quadrat von {zahl} ist: {quadrat}");
                break;

            case 2:
                double wurzel = Math.Sqrt(zahl);
                Console.WriteLine($"Die Wurzel aus {zahl} ist: {wurzel:F2}");
                break;

            case 3:
                long fakultaet = 1;
                for (int i = 1; i <= zahl; i++)
                {
                    fakultaet *= i;
                }
                Console.WriteLine($"Die Fakultät von {zahl} ({zahl}!) ist: {fakultaet}");
                break;

            default:
                Console.WriteLine("Fehler: Ungültige Auswahl! Bitte wählen Sie eine Zahl zwischen 1 und 3.");
                break;
        }

        Console.WriteLine("\nDrücken Sie eine beliebige Taste zum Beenden...");
        Console.ReadKey();
    }
}

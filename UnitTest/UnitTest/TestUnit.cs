using System.Diagnostics;

class Program
{
    static void Main()
    {
        var mathe = new Mathematik();
        int eingabeZahl = 5;
        int erwartetesErgebnis = 120;

        int tatsaechlichesErgebnis = mathe.Fakultaet(eingabeZahl);

        Debug.Assert(tatsaechlichesErgebnis == erwartetesErgebnis, $"Test fehlgeschlagen: {eingabeZahl}! sollte {erwartetesErgebnis} sein, war aber {tatsaechlichesErgebnis}");

        Console.WriteLine("Fakultäts-Test erfolgreich bestanden!");
    }
}


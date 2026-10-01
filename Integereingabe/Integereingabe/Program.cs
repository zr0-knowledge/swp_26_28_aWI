using System;

class Program
{
    static void Main()
    {
        string antwort = "";

        while (antwort != "kolibri")
        {
            Console.Write("Welcher Vogel ist der einzige Vogel, der rückwärts fliegen kann? ");
            string input = (Console.ReadLine() ?? "").Trim();
            antwort = input.ToLower();

            string typ = input switch
            {
                _ when int.TryParse(input, out _) => "Das ist kein Vogel, das ist ein Integer (Ganzzahl)",
                _ when bool.TryParse(input, out _) => "Das ist kein Vogel, das ist ein Boolean (Wahr/Falsch)",
                _ when double.TryParse(input, out _) => "Das ist kein Vogel, das ist ein Double (Kommazahl)",
                _ => "Das ist ein Vogel, das ist ein String (Text)"
            };

            Console.WriteLine($"-> Erkannter Datentyp: {typ}");
            Console.WriteLine(antwort == "kolibri" ? "Richtig!" : "Falsch! Versuch es noch einmal.\n");
        }
    }
}

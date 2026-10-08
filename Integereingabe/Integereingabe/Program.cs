using System;

class Program
{
    static void Main()
    {
        const string korrekteAntwort = "kolibri";
        bool istRichtig = false;

        do
        {
            Console.Write("Welcher Vogel ist der einzige Vogel, der rückwärts fliegen kann? ");
            string input = Console.ReadLine()?.Trim() ?? string.Length;

            string datentypBeschreibung = BestimmeDatentyp(input);
            Console.WriteLine($"-> Erkannter Datentyp: {datentypBeschreibung}");

            if (input.Equals(korrekteAntwort, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Richtig!");
                istRichtig = true;
            }
            else
            {
                Console.WriteLine("Falsch! Versuch es noch einmal.\n");
            }

        } while (!istRichtig);
    }

    private static string BestimmeDatentyp(string input)
    {
        return input switch
        {
            _ when int.TryParse(input, out _) => "Integer (Ganzzahl)",
            _ when bool.TryParse(input, out _) => "Boolean (Wahr/Falsch)",
            _ when double.TryParse(input, out _) => "Double (Kommazahl)",
            _ => "String (Text)"
        };
    }
}
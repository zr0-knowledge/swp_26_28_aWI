using System;

class Program
{
    static void Main()
    {
        Console.Write("Bitte geben Sie etwas ein: ");
        string eingabe = Console.ReadLine();

        if (int.TryParse(eingabe, out int zahl))
        {
            Console.WriteLine("\nSie haben eine ganze Zahl eingegeben, welche mathematische Operation möchten Sie darauf ausführen?");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Multiplikation");
            Console.WriteLine("3) Division");
            Console.WriteLine("4) Fakultät");
            Console.WriteLine("5) Wurzelziehen");
            Console.Write("Ihre Auswahl: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.Write("Geben Sie die zweite Zahl ein: ");
                    int zahl2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Resultat: " + (zahl + zahl2));
                    break;

                case 2:
                    Console.Write("Geben Sie die zweite Zahl ein: ");
                    zahl2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Resultat: " + (zahl * zahl2));
                    break;

                case 3:
                    Console.Write("Geben Sie die zweite Zahl ein: ");
                    double zahl2Div = Convert.ToDouble(Console.ReadLine());
                    if (zahl2Div != 0)
                    {
                        Console.WriteLine("Resultat: " + ((double)zahl / zahl2Div));
                    }
                    else
                    {
                        Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt.");
                    }
                    break;

                case 4:
                    if (zahl >= 0)
                    {
                        long fakultaet = 1;
                        for (int i = 1; i <= zahl; i++)
                        {
                            fakultaet = fakultaet * i;
                        }
                        Console.WriteLine("Resultat: " + fakultaet);
                    }
                    else
                    {
                        Console.WriteLine("Fehler: Negative Zahl.");
                    }
                    break;

                case 5:
                    if (zahl >= 0)
                    {
                        Console.WriteLine("Resultat: " + Math.Sqrt(zahl));
                    }
                    else
                    {
                        Console.WriteLine("Fehler: Negative Zahl.");
                    }
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("\nSie haben eine Zeichenkette eingeben. Was wollen Sie damit machen?");
            Console.WriteLine("1) Alle Selbstlaute (a,e,i,o,u) entfernen");
            Console.WriteLine("2) Die Zeichenkette \"umdrehen\"");
            Console.WriteLine("3) Die Anzahl an Zeichen ausgeben");
            Console.Write("Ihre Auswahl: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    string ergebnisOhneVokale = "";
                    foreach (char zeichen in eingabe)
                    {
                        char klein = char.ToLower(zeichen);
                        if (klein != 'a' && klein != 'e' && klein != 'i' && klein != 'o' && klein != 'u')
                        {
                            ergebnisOhneVokale = ergebnisOhneVokale + zeichen;
                        }
                    }
                    Console.WriteLine("Resultat: " + ergebnisOhneVokale);
                    break;

                case 2:
                    string umgedreht = "";
                    for (int i = eingabe.Length - 1; i >= 0; i--)
                    {
                        umgedreht = umgedreht + eingabe[i];
                    }
                    Console.WriteLine("Resultat: " + umgedreht);
                    break;

                case 3:
                    Console.WriteLine("Resultat: " + eingabe.Length);
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }

        Console.WriteLine("\nDrücken Sie eine beliebige Taste zum Beenden...");
        Console.ReadKey();
    }
}
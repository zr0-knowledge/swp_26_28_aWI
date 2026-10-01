string antwort = "";

while (antwort != "kolibri")
{
    Console.Write("Welcher Vogel ist der einzige Vogel, der rückwärts fliegen kann? ");
    antwort = Console.ReadLine()?.ToLower().Trim() ?? "";

    Console.WriteLine(antwort == "kolibri" ? "Richtig!" : "Falsch! Versuch es noch einmal.\n");
}

/*

==========================================================================

DATENTYPEN IN C#

==========================================================================
 
--------------------------------------------------------------------------

A) ELEMENTARE DATENTYPEN (einfache Wertetypen)

--------------------------------------------------------------------------
 
Ganzzahlen

----------

sbyte    System.SByte    8 Bit    -128 bis 127

byte     System.Byte     8 Bit    0 bis 255

short    System.Int16    16 Bit   -32.768 bis 32.767

ushort   System.UInt16   16 Bit   0 bis 65.535

int      System.Int32    32 Bit   ca. -2,1 Mrd. bis 2,1 Mrd.

uint     System.UInt32   32 Bit   0 bis ca. 4,29 Mrd.

long     System.Int64    64 Bit   ca. -9,2 * 10^18 bis 9,2 * 10^18

ulong    System.UInt64   64 Bit   0 bis ca. 1,8 * 10^19

nint     System.IntPtr   32/64 Bit (plattformabhaengig, mit Vorzeichen)

nuint    System.UIntPtr  32/64 Bit (plattformabhaengig, ohne Vorzeichen)

(Int128 / UInt128: 128 Bit, ab .NET 7)
 
Gleitkomma- und Dezimalzahlen

-----------------------------

float    System.Single   32 Bit   ca. 6-9 Stellen     Suffix f (36.6f)

double   System.Double   64 Bit   ca. 15-17 Stellen   Standard fuer Kommazahlen

decimal  System.Decimal  128 Bit  28-29 Stellen       Suffix m (19.99m), ideal fuer Geld

(Half: System.Half, 16 Bit)
 
Sonstige elementare Typen

-------------------------

bool     System.Boolean  true oder false

char     System.Char     ein Unicode-Zeichen (16 Bit), z. B. 'A'
 
 
--------------------------------------------------------------------------

B) NICHT-ELEMENTARE DATENTYPEN (zusammengesetzte Typen)

--------------------------------------------------------------------------
 
Eingebaute Referenztypen

------------------------

string   Zeichenkette (unveraenderlich), z. B. "Hallo"

object   Basistyp aller Typen

dynamic  Typpruefung erst zur Laufzeit

Arrays   feste Anzahl gleicher Elemente: int[], string[,], int[][]
 
Selbst definierbare Typen

-------------------------

class          Referenztyp   Objekt mit Feldern, Eigenschaften, Methoden

record         Referenztyp   Klasse mit Wertvergleich (record class)

struct         Wertetyp      leichtgewichtiger Verbund von Feldern

record struct  Wertetyp      Struct mit Wertvergleich

enum           Wertetyp      Aufzaehlung benannter Konstanten

interface      Referenztyp   Vertrag ohne Implementierung

delegate       Referenztyp   typsicherer Verweis auf eine Methode

Tupel          Wertetyp      (int, string), ValueTuple

Nullable<T>    Wertetyp      T?, Wertetyp der auch null sein darf, z. B. int?
 
Typen aus der Standardbibliothek

--------------------------------

Datum/Zeit:   DateTime, DateOnly, TimeOnly, TimeSpan, DateTimeOffset

Strukturen:   Guid, Index, Range

Sammlungen:   List<T>              dynamische Liste

               Dictionary<K,V>      Schluessel-Wert-Paare

               HashSet<T>           Menge ohne Duplikate

               Queue<T>             Warteschlange (FIFO)

               Stack<T>             Stapel (LIFO)

               LinkedList<T>        doppelt verkettete Liste

               SortedList<K,V>      sortierte Liste

               SortedDictionary<K,V> sortiertes Dictionary

Weitere:      StringBuilder        veraenderbare Zeichenketten

               Action, Func<>, Predicate<>   vordefinierte Delegates

               Exception und Ableitungen

               Task, Task<T>        asynchrone Abloeufe

               Span<T>              speichereffizienter Ausschnitt
 
Zeigertypen (nur im unsafe-Kontext)

-----------------------------------

int*, char*, ...   selten gebraucht
 
 
--------------------------------------------------------------------------

C) MERKREGELN

--------------------------------------------------------------------------

- Wertetypen werden beim Zuweisen kopiert.

- Referenztypen teilen sich beim Zuweisen dasselbe Objekt.

- Standard: int (Ganzzahl), double (Kommazahl), decimal (Geld).

- string ist ein Referenztyp, verhaelt sich aber beim Vergleichen

   und Zuweisen wie ein Wertetyp.

- var laesst den Compiler den Typ ableiten; der Typ bleibt trotzdem fest.

*/

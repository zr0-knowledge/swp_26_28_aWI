using System;
using System.IO; 
using KuhTest2;

try
{
    var myKuh = new Kuh("Paula", "Schwarz");
    var myKuh2 = new Kuh("Luna", "Braun");

    Console.WriteLine(myKuh.Colour);
    Console.WriteLine(myKuh.Name);
    Console.WriteLine(myKuh2.Colour);
    Console.WriteLine(myKuh2.Name); 
}
catch (InvalidDataException ex)
{
    Console.WriteLine($"Fehler: {ex.Message}");
}

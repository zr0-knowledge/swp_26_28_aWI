using System;
using System.Globalization;

public abstract class Animal
{
    private string _name;
    private string _colour;
    private DateTime _birthDate;

    public Animal(string name, string colour, DateTime birthDate)
    {
        if (birthDate > DateTime.Now)
        {
            throw new ArgumentException("Geburtsdatum liegt in der Zukunft");
        }
        _name = name;
        _colour = colour;
        _birthDate = birthDate;
    }

    public string Name
    {
        get
        {
            string myLocalVar = "myLocalVar";
            return _name;
        }
    }

    public string Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }

    public DateTime BirthDate
    {
        get { return _birthDate; }
    }

    public int GetAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - _birthDate.Year;

        bool hadBirthdayThisYear =
            today.Month > _birthDate.Month ||
            (today.Month == _birthDate.Month && today.Day >= _birthDate.Day);

        if (!hadBirthdayThisYear)
        {
            age--;
        }
        return age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal sound");
    }
}

public class Cow : Animal
{
    public Cow(string name, string colour, DateTime birthDate)
        : base(name, colour, birthDate) { }

    public override void MakeSound()
    {
        Console.WriteLine("Muuuuh");
    }
}

public class Cat : Animal
{
    public Cat(string name, string colour, DateTime birthDate)
        : base(name, colour, birthDate) { }

    public override void MakeSound()
    {
        Console.WriteLine("Miau");
    }
}

public class Program
{
    public static void Main()
    {
        // Achtung: In JS sind Monate 0-basiert (4 = Mai, 11 = Dezember), in C# 1-basiert (5 = Mai, 12 = Dezember)!
        Cow myKuh = new Cow("Kuh1", "Weiß", new DateTime(2020, 5, 15));
        Cow myKuh1 = new Cow("Kuh2", "schwarz", new DateTime(2021, 1, 1));
        Cow myKuh2 = myKuh;
        Cat myCat = new Cat("Katze1", "grau", new DateTime(2023, 12, 1));

        myKuh.MakeSound();
        myCat.MakeSound();

        Console.WriteLine($"{myKuh.Name} ist {myKuh.GetAge()} Jahre alt");
        Console.WriteLine($"{myCat.Name} ist {myCat.GetAge()} Jahre alt");
        Console.WriteLine($"{myKuh.Name} wurde am {myKuh.BirthDate.ToString("d", new CultureInfo("de-DE"))} geboren");

        Console.WriteLine(myKuh2 == myKuh);
        Console.WriteLine(myKuh.Name);
        myKuh.Colour = "braun";
        Console.WriteLine(myKuh2.Colour);

        try
        {
            new Cat("Katze2", "grau", new DateTime(2099, 1, 1));
        }
        catch (Exception e)
        {
            Console.WriteLine("Fehler: " + e.Message);
        }
    }
} 

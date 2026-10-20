using System;
using System.Collections.Generic;
using System.IO; // Wichtig für die InvalidDataException
using System.Text;

namespace KuhTest2
{
    public class Kuh
    {
        string _name;
        string _colour;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public Kuh(string Name, string Colour)
        {
            // Hier wird die InvalidDataException geworfen, wenn der Name leer oder null ist
            if (string.IsNullOrEmpty(Name))
            {
                throw new InvalidDataException("Der Name darf nicht leer sein.");
            }

            _name = Name;
            _colour = Colour;
        }
    }
}

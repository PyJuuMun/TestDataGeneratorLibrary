using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TestDataGeneratorLibrary
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person()
        {
            
        }

        public static string[] FirstNameMales()
        {
            string[] firstname = { "Jaakko", "Tommi", "Juho", "Matias", "Niko", "Pertti", "Markus", "Eetu" };
            return firstname;
        }
    }
}

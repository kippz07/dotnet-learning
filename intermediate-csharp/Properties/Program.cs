using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1994, 02, 15));
            // person.Birthdate = new DateTime(1994, 02, 15); // setter is private so cannot set like this

            System.Console.WriteLine(person.Age);
        }
    }
}

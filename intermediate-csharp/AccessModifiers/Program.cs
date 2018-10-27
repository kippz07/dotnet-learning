using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(); // Cannot access birthdate using person.birthdate
            person.SetBirthdate(new DateTime(1994, 02, 15));
            System.Console.WriteLine(person.GetBirthdate());
        }
    }
}

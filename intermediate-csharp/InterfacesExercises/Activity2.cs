using System;

namespace InterfacesExercises
{
    public class Activity2 : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Just another generic activity");
        }
    }
}
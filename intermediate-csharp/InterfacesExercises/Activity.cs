using System;

namespace InterfacesExercises
{
    public class Activity : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("Just a generic activity");
        }
    }
}
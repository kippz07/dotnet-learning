using System;

namespace InterfacesExercises
{
    public class Uploading : IActivity
    {
        public void Execute()
        {
            System.Console.WriteLine("I am uploading");
        }
    }
}
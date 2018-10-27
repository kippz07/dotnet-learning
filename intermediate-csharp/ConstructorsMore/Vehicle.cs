using System;

namespace ConstructorsMore
{
    public class Vehicle
    {
        private readonly string _regNumber;
        public Vehicle()
        {
            System.Console.WriteLine("Vehicle is being initialised.");
        }

        public Vehicle(string regNumber)
        {
            _regNumber = regNumber;
            System.Console.WriteLine("Vehicle is being initialised. {0}", _regNumber);
        }
    }
}
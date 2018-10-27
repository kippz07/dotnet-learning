using  System;

namespace ConstructorsMore
{
    public class Car : Vehicle
    {
        // Will call the default constructorless Vehicle
        public Car()
        {
            System.Console.WriteLine("Car is being initilised.");
        }

        // If no default Vehicle constuctor, need to pass a parameter to base class
        public Car(string regNumber)
            : base(regNumber)
        {
            System.Console.WriteLine("Car is being initilised. {0}", regNumber);
        }
    }
}
using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Jenny");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}

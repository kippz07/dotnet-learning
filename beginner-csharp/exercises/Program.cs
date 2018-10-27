using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program.Exercise1();
            // Program.Exercise2();
            // Program.Exercise3();
            // Program.Exercise4();
            Program.Exercise5();
        }

        public static void Exercise1()
        {
            var divisByThree = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    divisByThree++; 
            }
            System.Console.WriteLine(divisByThree);
        }

        public static void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                System.Console.WriteLine("Enter a number or 'OK':");
                var response = Console.ReadLine();

                if (response == "OK")
                {
                    System.Console.WriteLine(sum);
                    break;
                }
                sum += int.Parse(response);
            }
        }

        public static void Exercise3()
        {
            System.Console.WriteLine("Enter a number:");
            var response = int.Parse(Console.ReadLine());
            var result = response;
            while (response > 1)
            {
                response--;
                result *= response;
            }
            System.Console.WriteLine(result);
        }

        public static void Exercise4()
        {
            var random = new Random().Next(1, 10);
            System.Console.WriteLine(random);
            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine("Try and guess the number:");
                var guess = int.Parse(Console.ReadLine());
                if (guess == random)
                {
                    System.Console.WriteLine("You won!");
                    break;
                }
                System.Console.WriteLine("Nope!");
            }
            System.Console.WriteLine("You lost!");
        }

        public static void Exercise5()
        {
            var max = 0;
            System.Console.WriteLine("Enter a series of numbers separated by commas:");
            var numbers = Console.ReadLine().Split(",");
            foreach (string num in numbers)
            {
                if (int.Parse(num) > max)
                    max = int.Parse(num);
            }
            System.Console.WriteLine(max);
        }
    }
}

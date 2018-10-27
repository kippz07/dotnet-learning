using System;
using System.Collections.Generic;

namespace arrays_lists
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
            var names = new List<string>();
            
            while (true)
            {
                System.Console.WriteLine("Enter a name: ");
                var entry = Console.ReadLine();
                if (entry == "")
                    break;
                names.Add(entry);
            }
            switch (names.Count)
            {   
                case 0: break;
                case 1: System.Console.WriteLine($"{names[0]} likes your post");
                    break;

                case 2: System.Console.WriteLine($"{names[0]} and {names[1]} like your post");
                    break;

                default: System.Console.WriteLine($"{names[0]} and {names[1]} and {names.Count -2} others like your post");
                    break;
            }
        }

        public static void Exercise2()
        {
            System.Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();
            var reverse = new char[name.Length];
            for (int i = name.Length; i > 0; i--)
            {
                reverse[name.Length - i] = name[i - 1];
            }
            System.Console.WriteLine(new string(reverse));
            
        }

        public static void Exercise3()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                System.Console.WriteLine("Enter a number: ");
                var num = int.Parse(Console.ReadLine());
                if (numbers.Contains(num)) 
                {
                    System.Console.WriteLine("Please enter a unique number.");
                    continue;
                }
                numbers.Add(num);
            }
            numbers.Sort();
            System.Console.WriteLine($"You entered: {numbers[0]}, {numbers[1]}, {numbers[2]}, {numbers[3]}, {numbers[4]}");
        }

        public static void Exercise4()
        {
            var numbers = new List<int>();
            var count = 0;
            while (true)
            {
                System.Console.WriteLine("Enter a number or 'Quit'");
                var response = Console.ReadLine();
                if (response == "Quit")
                {
                    System.Console.WriteLine($"You entered {count} unique numbers");
                    break;
                }
                var num = int.Parse(response);
                if (!numbers.Contains(num))
                {
                    numbers.Add(num);
                    count++;
                }
            }
        }

        public static void Exercise5()
        {
            string[] list;
            while (true)
            {
                System.Console.WriteLine("Enter numbers separated by commas: ");
                list = Console.ReadLine().Split(",");
                if (list.Length >= 5) 
                    break;
                
                System.Console.WriteLine("Invalid list.");
            }
            var numbers = new List<int>();
            foreach (string num in list)
            {
                numbers.Add(int.Parse(num));
            }
            numbers.Sort();
            System.Console.WriteLine($"Smallest three numbers: {numbers[0]}, {numbers[1]}, {numbers[2]}");
            
        }
    }
}

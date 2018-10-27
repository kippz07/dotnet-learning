using System;
using System.Collections.Generic;
using System.Text;

namespace strings
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
            System.Console.WriteLine("Enter numbers separated by a hyphen:");
            var numbers = Console.ReadLine().Split("-");
            var isConsecutive = true;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (Math.Abs(Convert.ToInt32(numbers[i-1]) - Convert.ToInt32(numbers[i])) != 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            if (isConsecutive)
                System.Console.WriteLine("Consecutive");
            else
                System.Console.WriteLine("Not Consecutive");

        }

        public static void Exercise2()
        {
            System.Console.WriteLine("Enter numbers separated by a hyphen:");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input)) 
                return;

            var numbers = input.Split("-");
            var uniques = new List<string>();
            foreach (string num in numbers)
            {
                if (uniques.Contains(num))
                {
                    System.Console.WriteLine("Duplicate");
                    return;
                }
                uniques.Add(num);
            }
        }

        public static void Exercise3()
        {
            System.Console.WriteLine("Enter a time in the 24hr format:");
            var input = Console.ReadLine();
            DateTime time;
            if (DateTime.TryParse(input, out time))
                System.Console.WriteLine(time + " OK");
            else
                System.Console.WriteLine("Invalid Time");
        }

        public static void Exercise4()
        {
            System.Console.WriteLine("Input some words separated by a space:");
            var input = Console.ReadLine().Split(" ");

            var result = new StringBuilder();
            foreach (string word in input)
            {
                result
                    .Append(word[0].ToString().ToUpper())
                    .Append(word.Substring(1).ToLower());
            }
            System.Console.WriteLine(result);
        }

        public static void Exercise5()
        {
            System.Console.WriteLine("Enter an English word:");
            var input = Console.ReadLine();
            var vowels = new List<char>() {'a', 'e', 'i', 'o', 'u'};
            var count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                    count++;
            }
            System.Console.WriteLine(count);
        }
    }
}

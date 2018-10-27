using System;

namespace Classes_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            for (int i = 0; i < 5; i++)
            {
                stack.Push(i);
            }

            stack.Clear();

            for (int i = 0; i < 5; i++)
            {
               System.Console.WriteLine(stack.Pop());
            }
        }
    }
}

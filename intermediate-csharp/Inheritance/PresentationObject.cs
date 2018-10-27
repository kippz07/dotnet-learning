using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            System.Console.WriteLine("Object was copied");
        }

        public void Paste()
        {
            System.Console.WriteLine("Object was pasted");
        }
    }
}
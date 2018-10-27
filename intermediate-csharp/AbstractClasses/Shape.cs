using System;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Shape Copied");
        }

        public void Select()
        {
            System.Console.WriteLine("Shape Selected");
        }
    }
}
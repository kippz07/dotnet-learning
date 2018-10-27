using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // text and shae are referencing the same space in memory
            Text text = new Text();
            Shape shape = text;

            // Both will change text.Width
            text.Width = 200;
            shape.Width = 100;

            // StreamReader reader = new StreamReader(new MemoryStream());
            
            // ArrayLists are not generic, each element can have a different type
            var list = new ArrayList();

            // Is generic, list has a specific type
            var anotherList = new List<int>();

            // Downcasting - moreText can access Text methods once cast to Text
            Shape newShape = new Text();
            Text moreText = (Text) shape;
            
        }
    }
}

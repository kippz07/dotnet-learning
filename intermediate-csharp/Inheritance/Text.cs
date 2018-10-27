using System;

namespace Inheritance
{
    // Inherits from PresentationObject
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddLink(string url)
        {
            System.Console.WriteLine("We added a link to " + url);
        }
    }
}
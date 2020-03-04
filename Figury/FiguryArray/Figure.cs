using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Figure
    {

        public string Color { get; private set; }
        public Figure(string color = "black")
        {
            Color = color;

        }
        public void Print()
        {
            Console.WriteLine($"Figure {this}, color = {Color}");        ///ta figura!
        }

         public void Drow() //rysowanie figury za pomocą plotera.
        {
            Console.WriteLine("");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    abstract public class Figure
    {
        public string Color { get; set; } //read-write

        public Figure(string color)
        {
            Color = color;
        }

        public void Print()
        {
            Console.WriteLine($"figure {this}, color = {Color}");
        }

        abstract public void Draw(); // rysowanie figurty za pomocą plottera

    }
}

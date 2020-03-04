﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public  class Circle
    {

        public class Circle : Figure
        {
            public double R { get; private set; }

            public Circle(double r = 1) : base("black")
            {
                if (r <= 0)
                    throw new ArgumentOutOfRangeException("promień musi byc dodatni");

                R = r;
            }

            public virtual double Perimeter => 2 * Math.PI * R;

            public virtual double Surface => Math.PI * R * R;

            public Circle Scale(double factor)
            {
                if (factor <= 0)
                    throw new ArgumentOutOfRangeException("wsp. musi być dodatni");

                return new Circle(R * factor);
            }

            public override string ToString()
            {
                return $"circle({R})";
            }

            public override void Draw()
            {
                Console.WriteLine("rysowanie kółka");
            }
        }
    }


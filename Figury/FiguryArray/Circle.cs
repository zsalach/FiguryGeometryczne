using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public  class Circle
    {

        public double R { get; private set; }

        public Circle(double r = 1)
        {
            if (r <= 0)
                throw new ArgumentOutOfRangeException("");
            R = r;
        }

        public virtual double Parimeter => 2 * Math.PI * R;
        public virtual  double Surface => Math.PI * R * R;
        public Circle Scale (double factor)
        {
            if(factor <=0)
                throw   new  ArgumentOutOfRangeException("Wspolczynnik skalowania musi być dodatni");
            return new Circle(R * factor);
        }

        public override string ToString()
        {
            return $"circle({R})";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{
    public class Sphere : Circle
    {
        public Sphere(double r = 1) : base(r) //odpowiednik super w javie
        {

        }

        public override string ToString()
        {
            return $"Sphere {R}";
        }

        public override double Surface => 4 * base.Surface;

        public new double Perimeter => throw new NotSupportedException("Sfera nie ma obwodu");

    }
}

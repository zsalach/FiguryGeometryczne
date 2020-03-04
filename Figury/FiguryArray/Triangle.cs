using System;
using System.Collections.Generic;
using System.Text;

namespace FiguryLibrary
{

    
    /// <summary>
    /// Trójkąt w wersji inmutable
    /// 
    /// </summary>
    public class Triangle : Figure
    {
        public double A { get; private set; } // A jest read only.

        public void Print()
        {
            throw new NotImplementedException();
        }

        public double B { get; private set; }
        public double C { get; private set; }


        public Triangle(double a = 1, double b = 1, double c = 1) // jeden konstruktor uniwersalny w zależnośći od tego jak go wywołamy.

        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Boki powinny być dodatnie");
            }
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Warunek trójkąta nie jest spełniony");
            }
            A = a;
            B = b;
            C = c;
        }
        public override string ToString()
        {
            return $"triangle{A}, {B}, {C}";
        }
        public double Paerimeter => A + B + C;



        public Triangle Scale(double factor) // scalowanie trójkąta
        {
            if (factor < 0)
            {
                throw new ArgumentOutOfRangeException("Wspolczynnik skalowania musi być dodatni");
            }
            return new Triangle(A * factor, B * factor, C * factor);
        }

       /* public override void Drow()
        {
            throw new NotImplementedException();
        }*/
    }
}

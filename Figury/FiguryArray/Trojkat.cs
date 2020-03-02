using System;

namespace FiguryArray
{
    public class Trojkat
    {
        // 1.  dane obiektu - pola obiektu (fields)

        double a;       //this.a
        double b;       //this.b
        double c;       //this.c

        // 2. konstruktory 

        public Trojkat()            //konstruktor domyślny nie posiada argumentów.
        {
            a = b = c = 1.0;
        }

        public Trojkat(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
    }
}

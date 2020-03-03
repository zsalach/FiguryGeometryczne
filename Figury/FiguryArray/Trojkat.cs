using System;

namespace FiguryArray
{
    public class Trojkat
    {
        // 1.  dane obiektu - pola obiektu (fields)
        // zmienne muszą być pwrywatne.
        private double a;       //this.a
        public double A // wstawiamy publiczne get i set
        {
            get { return a; }   //pobranie zmiennej a
            set                     //oprogramowanie zmiennej a;
                                    // jak wartość ustawiona za a jest prawidłowa to ja pobieramy. Jak nie jest właściwa to zwracamy wyjątek.
                                    // jak jest prawidłowa to przypisujemy wartość do zmiennej a. 
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Wartość A musi być dodatnia");
                else

                    if (isSpełnionyWarunekTrojkata(value, b, c))
                {
                    a = value;
                }
                else
                {
                    throw new ArgumentException("Niespełniony warunek trójkąta, przy próbie zmiany a");
                }
            }
        }

        private double b;       //this.b
        public double B
        {
            get { return b; }
            set         //set z tymi 
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Wartość B musi być dodatnia");
                else
                    if (isSpełnionyWarunekTrojkata(a, value, c))
                {
                    b = value;
                }
                else
                {
                    throw new ArgumentException("Niespełniony warunek trójkąta, przy próbie zmiany b");
                }
            }
        }
        private double c;       //this.c
        public double C
        {
            get { return c; } //{return c;}
            set
            {
                if (value <= 0)

                    throw new ArgumentOutOfRangeException("Wartość B musi być dodatnia");

                else

                    if (isSpełnionyWarunekTrojkata(a, b, value))
                {
                    c = value;
                }
                else
                {
                    throw new ArgumentException("Niespełniony warunek trójkąta, przy próbie zmiany c");
                }
            }
        }


        private bool isSpełnionyWarunekTrojkata(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // 2. konstruktory 
        //konstruktor domyślny nie posiada argumentów.
        public Trojkat()
        {
            a = b = c = 1.0;
        }

        public Trojkat(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentOutOfRangeException("boki muszą być dodatnie");

            if (!isSpełnionyWarunekTrojkata(a, b, c))
                throw new ArgumentException("nie jest spełniony warunek trójkata");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //tekstowa reprezentacja obiektu. Zostaje wyświetlony w konnsoli. 
        public override string ToString()       // funkcja, która wyrzuca z siebie napis.
        {
            //return base.ToString();   // nie o to nam chodzia
            return $"Trójkąt (a:{a}, b: {b}, c: {c})";
        }
        // 3. właściwości i metody w C# występuje coś czego nie ma w jawie a mianowicie Properties.
        // obwód


        public double GetObwod() // mETODA ZWRACAJĄCA OBWÓD TEGO TRÓJKATA.
        {
            return a + b + c;
        }


        public double Obwód => a + b + c; // TO JEST FUNKCJA PROPERTIES. ZWRACA OBÓWD TRÓJKĄTA. //Notacja Lampda. Notacja funkcyjna.

        public double GetPole() // JAVA style.
        {
            var p = (0.5 * GetObwod());
            var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return s;
        }


        public double Pole      //properties. C#
        {
            get//definiujemy jak czytamy wartośc
            {
                var p = 0.5 * Obwód;
                var s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return s;
            }
            set// definiujemy jak odczytujemy wartość.
            {

            }

        }
    }
}

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
                    a = value;
            }
        }

        private double b;       //this.b
        private double B
        {
            get => b;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Wartość B musi być dodatnia");
                else
                    b = value;
            }

    }
        private double c;       //this.c
        private double C
        {
            get => c;
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Wartość C musi być dodatnia");
                else
                    c = value;
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
            /*
            this.a = a;
            this.b = b;
            this.c = c;
            */
            
            if(a+b <= c || a+c <=b || b+c <=a)  //sprawdzamy warunek trójkąta czy z a,b,c można utworzyć trójkąt.
            {
                throw new ArgumentException("Niespełniony warumek trójkąta");
            }

            this.A = a;
            this.B = b;
            this.C = c;
// to jets kanalizacja kodu biore a z konstruktora i zapisuję poprzez seter A
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
            var s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
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

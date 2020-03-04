using System;
using FiguryLibrary;

namespace ConsoleAppFigury
{
    class Program
    {

        static void Main()
        {
            var t = new Triangle();
            Console.WriteLine(t);
            Console.WriteLine(t.Color);
            t.Print();

            var s = new Sphere(10);
            Console.WriteLine(s);

        }

        static void Main1(string[] args)
        {

        }
        /*
        Triangle t = new Triangle();
        Console.WriteLine(t);

        var t1 = new Triangle(1.5, 1, 1);
        Console.WriteLine(t1);

        var t2 = new Triangle(3):
        Console.WriteLine( t2);

        */
        /*
        Trojkat t1;
        t1 = new Trojkat();
        Console.WriteLine(t1);

        Console.WriteLine($"obwód = {t1.Obwód}");
        Console.WriteLine($"pole = {t1.GetPole()}");

        /*
         try
         {
             t1.A = -3; //zmienną a ustawiłem jako zmienną publiczną. W związku z tym mogę przypisywać jej nowe wartośći.
         }
         catch (ArgumentOutOfRangeException) {
             Console.WriteLine("Nie wolno bokom przypisywać wartości ujmenych");
         }
         */
        /*
       // Console.WriteLine(t1.Obwód);
       // Console.WriteLine($"pole = {t1.GetPole()}");
       Console.WriteLine("=============================================");

       var t2 = new Trojkat(3, 4, 5);
       Console.WriteLine(t2);
       // t2.A = 9;
       t2.A = 2;
       t1.B = 1;
       t2.C = 1;

       Console.WriteLine(t2);

       Console.WriteLine("========================================");
       Console.ReadKey();
       */


        static void Main2(string[] args)
        {

            Triangle t = new Triangle();
            Console.WriteLine(t);

            var t1 = new Triangle(1.5, 1, 1);
            Console.WriteLine(t1);

            var t2 = new Triangle(1);
            Console.WriteLine(t2);


            Circle C = new Circle(12);
            Console.WriteLine($"Circle {C}");

            Console.WriteLine($"Powierzchnia {C.Surface}.");
            Console.WriteLine($"Obwod {C.Parimeter}.");

            Console.WriteLine(C.Scale(12));


        }
    
    }

}

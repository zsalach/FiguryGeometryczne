using System;
using FiguryArray;

namespace ConsoleAppFigury
{
    class Program
    {
        static void Main(string[] args)
        {

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
        }
    }
}

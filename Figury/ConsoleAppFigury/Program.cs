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
            //Trojkat t2 = new Trojkat(1, 2, 3);
            //var t3 = new Trojkat(c: 1, b: 2, a: 2); //a:2
                                                    //Trojkat t3 = new Trojkat(c: 1, b: 2, a: 2);
            Console.WriteLine($"{ t1}");
            Console.WriteLine($"obwód = {t1.Obwód}");
            Console.WriteLine($"pole = {t1.GetPole()}");
            
            try
            {
                t1.A = -3; //zmienną a ustawiłem jako zmienną publiczną. W związku z tym mogę przypisywać jej nowe wartośći.
            }
            catch (ArgumentOutOfRangeException) {
                Console.WriteLine("Nie wolno bokom przypisywać wartości ujmenych");
            }

            Console.WriteLine(t1.Obwód);
            Console.WriteLine($"pole = {t1.GetPole()}");
            Console.WriteLine("=============================================");

            var t2 = new Trojkat(-1, 2, 1);
            Console.WriteLine(t2);
            Console.WriteLine(t2.A);

            Console.ReadKey();
        }
    }
}

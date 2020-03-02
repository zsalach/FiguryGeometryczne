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
            Trojkat t2 = new Trojkat(1, 2, 3);
            var t3 = new Trojkat(c: 1, b: 2, a: 2);
            //Trojkat t3 = new Trojkat(c: 1, b: 2, a: 2);
            Trojkat t4 = new Trojkat();

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.ReadKey();



        }
    }
}

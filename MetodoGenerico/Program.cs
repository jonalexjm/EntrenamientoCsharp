using System;

namespace MetodoGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 7;
            Console.WriteLine("x={0}, y={1}", x, y);
            Intercambio<int>(ref x, ref y);
            Console.WriteLine("x={0}, y={1}", x, y);
        }

        //static no es forzado
        //ref no es forzado tampoco
        static void Intercambio<T>(ref T a, ref T b)
        {
            T temporal;
            temporal = a;
            a = b;
            b = temporal;
        }
    }
}

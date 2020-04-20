using System;

namespace ClaseGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            // para CPunto trabajo como int
            CPunto<int> puntoI = new CPunto<int>(3, 4);

            // para CPunto trabajo como double
            CPunto<double> puntoD = new CPunto<double>(3.45, 4.89);

            // para CPunto trabajo como float
            CPunto<float> puntoF = new CPunto<float>(3.78f, 4.09f);

            Console.WriteLine(puntoI);
            Console.WriteLine(puntoD);
            Console.WriteLine(puntoF);

        }
    }
}

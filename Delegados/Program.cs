using System;
using System.Collections.Generic;
using System.Linq;
namespace Delegados
{
    class Program
    {
        delegate int BuscarMayorNumero(List<int> lst);
        static int BuscandoNemo(List<int> lst_)
        {
            return lst_.OrderByDescending(d => d).First();
        }
        static void Main(string[] args)
        {
            BuscarMayorNumero fn1 = BuscandoNemo;

            Console.WriteLine(fn1(new List<int> { 1, 2, 3, 4, 5,888,8,9,5 }));

        }
    }
}

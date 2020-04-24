using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 4, 5, 7, 5, 5, 3, 5 };   
            //hacemos el query
            var valores = from n in numeros
                          where n % 2 == 0
                          select n;
            
            //mostramos resultado
            foreach(var item in valores)
            {
                Console.WriteLine(item);
            }
            //guardamos como arreglo
            int[] arrayValores = (from n in numeros
                                  where n % 2 == 0
                                  select n).ToArray<int>();
            //guardamos como lista
            List<int> listValores = (from n in numeros
                                  where n % 2 == 0
                                  select n).ToList<int>();
            //mostramos
            Console.WriteLine("El arreglo");
            //mostramos los resultados
            foreach (int num in arrayValores)
                Console.WriteLine(num);

            numeros[0] = 28;
            Console.WriteLine("---  Se actualiza despues de la modificacion");
            //Mostramos los resultado
            foreach (int num in arrayValores)
                Console.WriteLine(num);
            Console.WriteLine("La lista");
            Console.WriteLine("---------------");
            foreach (int num in listValores)
                Console.WriteLine(num);



        }
    }
}

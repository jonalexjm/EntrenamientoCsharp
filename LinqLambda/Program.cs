using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] postres = {"pay de manzana",
                                "pastel de pollo",
                                "manzana caramelizada",
                                "fresas con crema",
                                "maracuya"
                                   };
            IEnumerable<string> encontrados = postres.Where(p => p.Contains("manzana"));

            //mostramos resultados
            foreach (string postre in encontrados)
            {
                Console.WriteLine(postre);
            }
            Console.WriteLine("----------------");
            //encadenamos operadores
            //Se van adicionando operadores

            IEnumerable<string> manzanas = postres
                                            .Where(p => p.Contains("manzana"))
                                            .OrderBy(p => p.Length)
                                            .Select(
                                                p => p.ToUpper()
                                            ); ;

            foreach (string postre in manzanas)
                Console.WriteLine(postre);


            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };



            // take : toma los valores que se requieran
            IEnumerable<int> desdeInicio = numeros.Take(5);
            //Mostramos los resultados
            foreach (int item in desdeInicio)
                Console.WriteLine(item);

            // any : true si tiene dato y false si no tiene
            Console.WriteLine("Tiene elementos: {0}", numeros.Any());


            //subQuery
            int[] numeros2 = { 19, 45, 6, 13, 6, 90, 10 };

            IEnumerable<int> nums = numeros
                                    .Where(n => n < numeros2.First());
            Console.WriteLine("resulado de subquery");
            foreach (int item in nums)
                Console.WriteLine(item);


            //operadores I

            //


        }


    }
}

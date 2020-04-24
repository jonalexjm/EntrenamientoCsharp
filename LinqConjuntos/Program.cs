using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> conjunto1 = new List<int> { 2, 4, 6, 8, 9 };
            List<int> conjunto2 = new List<int> { 2, 5, 6, 7, 9 };

            //Except nos da la diferencia entre dos contenedores
            var expt = (from n1 in conjunto1 select n1)
                .Except(from n2 in conjunto2 select n2);
            Console.WriteLine("Except");
            foreach (int num in expt)
                Console.WriteLine(num);

            //Intersect nos da lo comun entre los dos contenedores
            var ints = (from n1 in conjunto1 select n1)
               .Intersect (from n2 in conjunto2 select n2);
            Console.WriteLine("Intersect");
            foreach (int num in expt)
                Console.WriteLine(ints);

            //Concatenar 
            var cnt = (from n1 in conjunto1 select n1)
               .Intersect(from n2 in conjunto2 select n2);
            Console.WriteLine("Concat");
            foreach (int num in expt)
                Console.WriteLine(cnt);

            //Distinct, remueve los duplicados 
         
            Console.WriteLine("Distinct");
            foreach (int num in cnt.Distinct())
                Console.WriteLine(num);



        }
    }
}

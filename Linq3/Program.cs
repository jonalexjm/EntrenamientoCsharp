using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();

            lista.AddRange(new object[] { "hola", 34, false, 4, 2, 4, "saludo" });

            //obtenemos solo los enteros
            var enteros = lista.OfType<int>();

            foreach (int n in enteros)
                Console.WriteLine(n);
            Console.WriteLine("------------------");

          

            List<CEstudiantes> estudiantes = new List<CEstudiantes>
            {
                new CEstudiantes("ana", "Afghj", "Mercadotecnia", 10.0),
                new CEstudiantes("mariana", "0987654", "Mercadotecnia",6.0),
                new CEstudiantes("luis", "Afghj", "Mercadotecnia", 5.0),
                new CEstudiantes("fernando", "0987654", "Mercadotecnia", 1.0)
            };

            //tenemos que transformar el ArrayList a un tipo que 
            //implemente IEnumerable<T> para poder ser usado con LINQ
            var estL = estudiantes.OfType<CEstudiantes>();
            //ahora si usamos linq
            //encontramos reprobados
            var reprobados = from e in estL
                             where e.Promedio <= 5.0
                             select e;
            Console.WriteLine("Reprobados");
            foreach (CEstudiantes r in reprobados)
            {
                Console.WriteLine(r);
            }
            Console.WriteLine("-----------------------------");

            // Conteo
            int cantidad = (from e in estudiantes
                            where e.Promedio > 5
                            select e).Count();
            Console.WriteLine("La cantidad de aprobados es {0}", cantidad);
            Console.WriteLine("-------------------------------");

            //reversa
            var aprobados = from e in estudiantes
                            where e.Promedio > 5
                            select e;
            Console.WriteLine("Orden inverso");
            foreach (CEstudiantes est in aprobados.Reverse())
                Console.WriteLine(est);

            //ordenamiento
            Console.WriteLine("Ordenados");
            var ordenados = from e in estudiantes
                            orderby e.Promedio descending
                            select e;
            foreach (CEstudiantes est in ordenados)
                Console.WriteLine(est);
            Console.WriteLine("Ascendente");
            var ordenadosA = from e in estudiantes
                            orderby e.Promedio ascending
                            select e;
            foreach (CEstudiantes est in ordenadosA)
                Console.WriteLine(est);

            /*
             * funcion
             */

            int[] numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("-------------------------");
            //encontramos el maximo
            int maximo = (from n in numero select n).Max();
            Console.WriteLine("el maximo es {0}", maximo);
            //encontramos el minimo
            int minimo = (from n in numero select n).Min();
            Console.WriteLine("el maximo es {0}", maximo);
            //Encontramos el promedio
            double promedio = (from n in numero select n).Average();
            Console.WriteLine("el maximo es {0}", promedio);
            //Encontramos el promedio
            int sumatoria = (from n in numero select n).Sum();
            Console.WriteLine("el maximo es {0}", sumatoria);

        }

    }
}

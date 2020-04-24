using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos lista
            List<CEstudiante> estudiantes = new List<CEstudiante>
            { 
                new CEstudiante("ana", "Afghj", "Mercadotecnia", 10.0),
                new CEstudiante("mariana", "0987654", "Mercadotecnia",6.0),
                new CEstudiante("luis", "Afghj", "Mercadotecnia", 5.0),
                new CEstudiante("fernando", "0987654", "Mercadotecnia", 1.0)
            };

            var reprobados = from e in estudiantes
                             where e.Promedio <= 5.0
                             select e;
            //Mostramos los reprobados
            Console.WriteLine("Reprobados");
            foreach (CEstudiante r in reprobados)
            {
                Console.WriteLine(r);
            }
            //Mostramos solo un atributo
            Console.WriteLine("Reprobados Solo un atributo");
            foreach (CEstudiante r in reprobados)
            {
                Console.WriteLine(r.Nombre);
            }
            //encontramos solo los nombres de los de mercadotecnia
            var mercadotecnia = from e in estudiantes
                                 where e.Curso == "Mercadotecnia"
                                 select e.Nombre;
            //Mostramos los reprobados
            Console.WriteLine("Los de mercado tecnia");
            foreach (string n in mercadotecnia)
                Console.WriteLine(n);
        }
    }
}

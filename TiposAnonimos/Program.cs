using System;

namespace TiposAnonimos
{
    public class Program
    {
        static void Main(string[] args)
        {
            var equipo = new { Nombre = "America", Ligas = 1 };
            var nombreEquipo = equipo.Nombre;
            Test(equipo);
        }

        public static void Test(dynamic equipo)
        {
            Console.WriteLine(equipo.Nombre);
        }
    }
}

using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPieza cuadrado1 = new Cuadrado(5);
            //los dos funcionan igual
            //Cuadrado cuadrado1 = new Cuadrado(5);

            Console.WriteLine($"El area del cuadrado es {cuadrado1.Area()} y el perimetro es {cuadrado1.Perimetro()}");
        }
    }
}

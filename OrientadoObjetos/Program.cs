using System;
using System.Collections.Generic;
using System.Text;

namespace OrientadoObjetos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("Mercedez Benz", "2012", "4 Ruedas");
            Moto moto1 = new Moto("kawasaki", "2019", 1000);


            Console.WriteLine(coche1.Marca);
            Console.WriteLine(moto1.Marca);

            moto1.Arrancar();
            coche1.Arrancar();


        }
    }
}

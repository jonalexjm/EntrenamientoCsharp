using System;
using System.Collections.Generic;
using System.Text;

namespace OrientadoObjetos
{
    public class Coche :Vehiculo
    {
        public string Traccion { get; set; }
        public Coche(string marca, string modelo, string traccion) : base (marca, modelo)
        {
            Traccion = traccion;
        }

        /*
         * Utilizamos la palabra override para sobre escribir el metodo que viene por herencia
         * desde el padre
         */
        public override void Arrancar()
        {
            Console.WriteLine("Arrancar Coche");
        }
    }
}

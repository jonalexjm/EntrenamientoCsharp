using System;
using System.Collections.Generic;
using System.Text;

namespace OrientadoObjetos
{
    public class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public int NumeroRuedas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;

        }
        /*
         * la otra forma de polimorfismo es utilizar la palabra virtual en el metodo padre
         * y override en la el metodo de la clase hijo
         */
        public virtual void Arrancar()
        {
            Console.WriteLine("Arrancar Vehiculo");
        }
    }
}

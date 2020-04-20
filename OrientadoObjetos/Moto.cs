using System;
using System.Collections.Generic;
using System.Text;

namespace OrientadoObjetos
{
    public class Moto : Vehiculo
    {
        public int Cilindrada { get; set; }
        public Moto(string marca, string modelo, int cilindrada) : base( marca,  modelo)//base por que apunta la herencia del constructor
        {
            Cilindrada = cilindrada;
        }
        /*
        la palabra reservada new sobre escribe el metodo Arrancar que viene por herencia 
        desde vehiculo
        */
        public new void Arrancar()
        {
            Console.WriteLine("Arrancar Moto");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Cuadrado : IPieza
    {
        public decimal Lado { get; set; }        
        public Cuadrado(decimal lado)
        {
            Lado = lado;                                
        }
        public decimal Area()
        {
            return Lado * Lado;
        }

        public decimal Perimetro()
        {
            return Lado * 4;
        }
    }
}

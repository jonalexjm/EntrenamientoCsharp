using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseGenerica
{
    public class CPunto<T>
    {
        private T x;
        private T y;

        public CPunto(T px, T py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return string.Format("X={0}, Y={1}", x, y);
        }

        public void reset()
        {
            /*
             * colocamos el valor de default para el tipo T
             * Numericos 0
             * Referencias null
             */
            x = default(T);
            y = default(T);
        }

        public void EncuentraTipo()
        {
            if (typeof(T) == typeof(int))

                Console.WriteLine("Trabajo como entero");
            else
                Console.WriteLine("Soy otro Tipo");

        }
    }
}

using System;
using System.Collections;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable mitabla = new Hashtable();

            //adicion de elementos
            mitabla.Add(123, "hola");
            mitabla.Add(233, "carro");
            mitabla.Add(456, "moto");
            mitabla.Add(9876, "elefante");
            mitabla.Add(666, "system of down");

            //Mostramos los elementos
            foreach(DictionaryEntry elemento in mitabla)
            {
                //Console.WriteLine($"{elemento}");
                Console.WriteLine("{0}, {1}", elemento.Key, elemento.Value);
            }

        }


    }
}

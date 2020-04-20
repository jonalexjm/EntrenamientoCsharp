using System;
using System.Collections.Generic;
using System.Text;

namespace Listas
{
    public class Listas
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Listas instancia = new Listas();
            instancia.listas();


        }

        public void listas()
        {
            List<string> listCarros = new List<string>();

            listCarros.Add("mercedes benz");
            listCarros.Add("toyota");
            listCarros.Add("nissan");
            listCarros.Add("toyota");

            foreach (var item in listCarros)
            {
                Console.WriteLine(item);

            }
        }
    }
}

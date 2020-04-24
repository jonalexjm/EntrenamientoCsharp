using System;
using System.Threading;

namespace Multihilos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instaciamos el objeto thread / hilo y
            //lo colocamos el delegado que corresponde
            Thread miHilo = new Thread(Saludos);
            //ahora iniciamos 
            //ya que no arranca al instanciarse
            miHilo.Start();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Saludos desde main");
        }

        static void Saludos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saludos desde el hilo");
        }
    }
}

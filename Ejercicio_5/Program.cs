using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, acum = 0;

            Console.WriteLine("Ingrese cinco números ");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Número "+i+": ");
                n1 = Int32.Parse(Console.ReadLine());
                acum += n1;
            }
            Console.WriteLine("La suma de los 5 números es: "+acum);
        }
    }
}

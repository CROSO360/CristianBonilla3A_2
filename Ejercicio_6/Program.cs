using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, acum = 0;

            
            while(true)
            {
                Console.Write("Ingrese un número: ");
                n1 = Int32.Parse(Console.ReadLine());
                acum += n1;

                if (n1 == 0)
                {
                    break;
                }
            }
            
            Console.WriteLine("La suma de los números es: " + acum);
        }
    }
}

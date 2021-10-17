using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.Write("Ingrese un número: ");
            n1 = Int32.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.Write("El número es par.");
            }
            else
            {
                Console.Write("El número es impar.");
            }
        }
    }
}

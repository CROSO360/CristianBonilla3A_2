using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, fact = 1;
            Console.Write("Ingrese un número para sacar su factorial: ");
            n1 = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n1; i++)
            {
                fact *= i;
                Console.Write("("+i+")");
            }
            Console.Write(" = "+fact);
        }
    }
}

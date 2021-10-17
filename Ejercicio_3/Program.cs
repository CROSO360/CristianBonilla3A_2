using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            Console.WriteLine("Ingrese tres números: ");
            n1 = Int32.Parse(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1 + " Es el número mayor.");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine(n2 + " Es el número mayor.");
            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine(n3 + " Es el número mayor.");
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }
        }
    }
}

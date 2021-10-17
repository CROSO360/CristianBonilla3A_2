using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Ingrese dos números: ");
            n1 = Int32.Parse(Console.ReadLine());
            n2 = Int32.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine(n1+" Es el número mayor.");
            }
            else if (n2 > n1)
            {
                Console.WriteLine(n2 + " Es el número mayor.");
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }
        }
    }
}

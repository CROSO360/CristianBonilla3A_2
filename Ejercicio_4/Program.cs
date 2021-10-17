using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;

            while (true)
            {
                Console.WriteLine("Ingrese un número decimal: ");
                num = float.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                
            }
        }
    }
}

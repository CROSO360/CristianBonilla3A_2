using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0, suma = 0, promedio = 0, div = 0;

            while (true)
            {
                Console.Write("Ingrese un número: ");
                num = double.Parse(Console.ReadLine());

                suma += num;
                

                if (num == 0)
                {
                    break;
                }
                else
                {
                    div++;
                }

            }

            promedio = suma / div;

            Console.Write("El promedio de los número es: "+promedio);

        }
    }
}

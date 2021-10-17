using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, n3 = 0;
            string mensaje = "";

            while (true)
            {
                Console.WriteLine("Ingrese tres números. ");
                Console.Write("Número uno: ");
                n1 = Int32.Parse(Console.ReadLine());
                Console.Write("Número dos: ");
                n2 = Int32.Parse(Console.ReadLine());
                Console.Write("Número tres: ");
                n3 = Int32.Parse(Console.ReadLine());

                if (n1 == n2 && n1 == n3)
                {
                    Console.WriteLine("Triángulo equilátero.\n");
                }
                else if (n1 != n2 && n1 != n3)
                {
                    Console.WriteLine("Triángulo escaleno.\n");
                }
                else
                {
                    Console.WriteLine("Triángulo Isósceles.\n");
                }

                while (mensaje != "S" && mensaje != "N")
                {
                    Console.WriteLine("¿Quiere continuar?");
                    Console.WriteLine("Ingrese S o N");
                    mensaje = Console.ReadLine();
                    Console.WriteLine("");
                }

                if (mensaje == "N")
                {
                    break;
                }

                mensaje = "";
                
            }
            
        }
    }
}

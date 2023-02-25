using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1;
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("El valor ingresado no es un número entero. Inténtelo de nuevo:");
            }

            Console.WriteLine("Ingrese el segundo número:");
            int num2;
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("El valor ingresado no es un número entero. Inténtelo de nuevo:");
            }

            if (num1 == num2)
            {
                Console.WriteLine("Los dos números son iguales.");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("El número {0} es mayor que {1}.", num1, num2);
            }
            else
            {
                Console.WriteLine("El número {0} es mayor que {1}.", num2, num1);
            }

            Console.ReadLine();
        }
    }
}

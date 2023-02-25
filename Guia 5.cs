using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el valor inicial: ");
            int numi = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el valor final: ");
            int numf = int.Parse(Console.ReadLine());

            Console.WriteLine("Los números pares entre {0} y {1} son:", numi, numf);
            for (int i = numi; i <= numf; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
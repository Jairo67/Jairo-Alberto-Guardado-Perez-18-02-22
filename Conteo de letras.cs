using System;
namespace ContadorLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            string palabra;
            int cantidadLetras;

            // Captura de la palabra ingresada por el usuario
            Console.WriteLine("Ingrese una palabra:");
            palabra = Console.ReadLine();

            // Cálculo de la cantidad de letras
            cantidadLetras = ContarLetras(palabra);

            // Mostrar resultado
            Console.WriteLine("La cantidad de letras en la palabra es: " + cantidadLetras);
            Console.ReadKey();
        }

        // Método para contar las letras en una palabra
        static int ContarLetras(string palabra)
        {
            int cantidadLetras = 0;
            foreach (char letra in palabra)
            {
                if (Char.IsLetter(letra))
                {
                    cantidadLetras++;
                }
            }
            return cantidadLetras;
        }
    }
}
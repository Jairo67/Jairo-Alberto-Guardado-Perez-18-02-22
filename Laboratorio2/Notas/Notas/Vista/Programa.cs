using Notas.DAO;
using Notas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas.Vistas
{
    public class Vista
    {
        private Notum modelo;
        private NotaDao dao;

        public Vista()
        {
            this.modelo = new Notum();
            this.dao = new NotaDao();
        }

        public void Menu()
        {
            Console.WriteLine("1. Calcular notas");
            Console.WriteLine("2. Listar notas");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    CalcularNotas();
                    break;
                case 2:
                    ListarNotas();
                    break;
                case 3:
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción inválida, seleccione de nuevo.");
                    Menu();
                    break;
            }
        }

        public void CalcularNotas()
        {
            Console.WriteLine("Ingrese el nombre de la materia:");
            string materia = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del estudiante:");
            string estudiante = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del primer laboratorio:");
            double lab1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del primer parcial:");
            double parcial1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo laboratorio:");
            double parcial2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo parcial:");
            double lab2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del tercer laboratorio:");
            double lab3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del tercer parcial:");
            double parcial3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"La nota definitiva del estudiante {estudiante} en la materia {materia} es {definitiva}");
        }

        public void ListarNotas()
        {
            foreach (var nota in dao.ObtenerNotas())
            {
                Console.WriteLine($"Materia: {nota.Materia} - Estudiante: {nota.Estudiante} - Parcial 1: {nota.Parcial1} - Parcial 2: {nota.Parcial2} - Definitiva: {nota.Definitiva}");
            }
        }
    }
}

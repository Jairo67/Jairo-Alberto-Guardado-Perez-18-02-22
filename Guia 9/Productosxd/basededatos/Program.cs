using basededatos.CrudProductos;
using basededatos.Models;
using System;

namespace basededatos
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudProductosvv crudProductos = new CrudProductosvv();

            while (true)
            {
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1. Insertar un nuevo producto");
                Console.WriteLine("2. Listar todos los productos");
                Console.WriteLine("3. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del producto");
                        string nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese una descripcion del producto");
                        string descripcion = Console.ReadLine();

                        Console.WriteLine("Ingrese el precio del producto");
                        decimal precio = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese los stocks del producto");
                        int stock = int.Parse(Console.ReadLine());

                        Productosxd producto = new Productosxd()
                        {
                            Nombre = nombre,
                            Descripcion = descripcion,
                            Precio = precio,
                            Stock = stock
                        };

                        crudProductos.InsertarProducto(producto);
                        Console.WriteLine("Producto agregado con éxito");
                        break;

                    case 2:
                        var productos = crudProductos.ObtenerProductos();

                        foreach (var p in productos)
                        {
                            Console.WriteLine($"Nombre: {p.Nombre}, Descripción: {p.Descripcion}, Precio: {p.Precio}, Stock: {p.Stock}");
                        }
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opción inválida, intente nuevamente.");
                        break;
                }
            }
        }
    }
}

using Parcial1_Jairo_Alberto_Guardado_Perez.Entidades;
using Parcial1_Jairo_Alberto_Guardado_Perez.Negocio;
using System;
public class Program
{
    static void Main(string[] args)
    {

        ClsVentas clsventas = new ClsVentas();
        Ventas ventas = new Ventas();
        
        
        ClsUsuario clsusuario = new ClsUsuario();
        Usuario usuario = new Usuario("Usuario ", "123");


        Console.Write("Ingrese su nombre de usuario: ");
        usuario.Nombre = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        usuario.Contra = Console.ReadLine();

        Console.Write("Ingrese el ID del producto: ");
        ventas.IdProducto = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el nombre del producto: ");
        ventas.NombreProducto = Console.ReadLine();

        Console.Write("Ingrese la descripción del producto: ");
        ventas.Descripcion = Console.ReadLine();

        Console.Write("Ingrese el precio del producto: ");
        ventas.Precio = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad de productos: ");
        ventas.Cantidad = int.Parse(Console.ReadLine());

        clsusuario.Acceso(usuario.Nombre, usuario.Contra);
        clsventas.Cobro();
        

        Console.ReadKey();
    }
}
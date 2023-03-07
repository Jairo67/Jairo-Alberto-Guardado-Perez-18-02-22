using Parcial1_Jairo_Alberto_Guardado_Perez.Entidades;
using Parcial1_Jairo_Alberto_Guardado_Perez.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Jairo_Alberto_Guardado_Perez.Entidades
{
    public class Ventas
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Ventas(int idProducto, string nombre, string descripcion, double precio, int cantidad)
        {
            IdProducto = idProducto;
            NombreProducto = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}

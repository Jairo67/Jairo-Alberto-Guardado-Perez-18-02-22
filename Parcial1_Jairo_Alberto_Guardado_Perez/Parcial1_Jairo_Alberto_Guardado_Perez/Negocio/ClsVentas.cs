using Parcial1_Jairo_Alberto_Guardado_Perez.Entidades;
using Parcial1_Jairo_Alberto_Guardado_Perez.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Jairo_Alberto_Guardado_Perez.Negocio
{
    public class ClsVentas
    {

        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public void Cobro(Ventas ventas)
        {
            double precioTotal = ventas.Precio * ventas.Cantidad;

            if (precioTotal > 50)
            {
                double precioDescuento = precioTotal - 10;
                Console.WriteLine("Precio original: $" + precioTotal);
                Console.WriteLine("Precio con descuento: $" + precioDescuento);
                Console.WriteLine("Total a pagar: $" + precioDescuento);
            }
            else
            {
                Console.WriteLine("Total a pagar: $" + precioTotal);
            }
        }
    }
}
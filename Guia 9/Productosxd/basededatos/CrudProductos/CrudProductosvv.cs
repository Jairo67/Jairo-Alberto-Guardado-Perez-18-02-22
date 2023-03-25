using basededatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basededatos.CrudProductos
{
    public class CrudProductosvv
    {
        public void InsertarProducto(Productosxd producto)
        {
            using (ProductosContext db = new ProductosContext())
            {
                db.Productosxds.Add(producto);
                db.SaveChanges();
            }
        }

        public List<Productosxd> ObtenerProductos()
        {
            using (ProductosContext db = new ProductosContext())
            {
                return db.Productosxds.ToList();
            }
        }
    }
}


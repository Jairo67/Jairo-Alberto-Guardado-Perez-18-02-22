using Parcial1_Jairo_Alberto_Guardado_Perez.Entidades;
using Parcial1_Jairo_Alberto_Guardado_Perez.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Jairo_Alberto_Guardado_Perez.Entidades
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Contra { get; set; }

        public Usuario(string nombre, string contra)
        {
            Nombre = nombre;
            Contra = contra;
        }
    }
}

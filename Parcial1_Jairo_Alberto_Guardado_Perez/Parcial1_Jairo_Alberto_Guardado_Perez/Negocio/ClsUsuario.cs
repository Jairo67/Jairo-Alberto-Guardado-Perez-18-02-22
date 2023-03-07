using Parcial1_Jairo_Alberto_Guardado_Perez.Entidades;
using Parcial1_Jairo_Alberto_Guardado_Perez.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_Jairo_Alberto_Guardado_Perez.Negocio
{
    public class ClsUsuario
    {
        public bool Acceso(string nombre, string contra)
        {

            if (nombre == "Usuario" && contra == "123")
            {
                Console.WriteLine("Inicio de sesión correcto. Puedes continuar con el proceso de venta.");
                return true;
            }
            else
            {
                Console.WriteLine("Nombre de usuario incorrecto.");
                return false;
            }


        }
    }
}
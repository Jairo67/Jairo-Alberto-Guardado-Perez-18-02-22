using Laboratorio1_Jairo_Alberto_Guaradado_Perez.Entidades;
using Laboratorio1_Jairo_Alberto_Guaradado_Perez.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_Jairo_Alberto_Guaradado_Perez.Negocio
{
    public class Clspersonas
    {
        List<Personas> Per = new List<Personas>();

        public void AgregarPersonas(Personas per)
        {

            Per.Add(per);

        }

        public List<Personas> ListarPersonas()
        {

            return Per;
        }
    }
}

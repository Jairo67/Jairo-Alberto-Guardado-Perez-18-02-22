using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas.DAO
{
    public class NotaDao
    {
    
            private SqlConnection conexion;

            public NotaDao()
            {
                string cadenaConexion = "Data Source=(local);Initial Catalog=NotaEstudiante;Integrated Security=True";
                this.conexion = new SqlConnection(cadenaConexion);
            }

            public void GuardarNotas(string nombreMateria, string nombreEstudiante, decimal lab1, decimal parcial1, decimal lab2, decimal parcial2, decimal lab3, decimal parcial3, decimal resultadoFinal)
            {
                try
                {
                    this.conexion.Open();
                    SqlCommand comando = new SqlCommand("INSERT INTO Nota (NombreMateria, NombreEstudiante, Lab1, Parcial1, Lab2, Parcial2, Lab3, Parcial3, Resultado) VALUES (@NombreMateria, @NombreEstudiante, @Lab1, @Parcial1, @Lab2, @Parcial2, @Lab3, @Parcial3, @Resultado)", this.conexion);
                    comando.Parameters.AddWithValue("@NombreMateria", nombreMateria);
                    comando.Parameters.AddWithValue("@NombreEstudiante", nombreEstudiante);
                    comando.Parameters.AddWithValue("@Lab1", lab1);
                    comando.Parameters.AddWithValue("@Parcial1", parcial1);
                    comando.Parameters.AddWithValue("@Lab2", lab2);
                    comando.Parameters.AddWithValue("@Parcial2", parcial2);
                    comando.Parameters.AddWithValue("@Lab3", lab3);
                    comando.Parameters.AddWithValue("@Parcial3", parcial3);
                    comando.Parameters.AddWithValue("@Resultado", resultadoFinal);
                    comando.ExecuteNonQuery();
                    Console.WriteLine("Notas guardadas exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar las notas: " + ex.Message);
                }
                finally
                {
                    this.conexion.Close();
                }
            }

            public decimal CalcularResultadoFinal(decimal lab1, decimal parcial1, decimal lab2, decimal parcial2, decimal lab3, decimal parcial3)
            {
                decimal resultadoPeriodo1 = lab1 * 0.4m + parcial1 * 0.6m;
                decimal resultadoPeriodo2 = lab2 * 0.4m + parcial2 * 0.6m;
                decimal resultadoPeriodo3 = lab3 * 0.4m + parcial3 * 0.6m;

                decimal resultadoFinal = (resultadoPeriodo1 + resultadoPeriodo2 + resultadoPeriodo3) / 3;

                return resultadoFinal;
            }
        
    }

}


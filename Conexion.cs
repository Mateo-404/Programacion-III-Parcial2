using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PracticaForm
{
    public static class Conexion
    {
        // <-- Conexion BD -->
        public static bool registrarIngresanteBD(Ingresante estudiante)
        {
            // Al usar using  C# se encarga automáticamente de liberar los recursos utilizados dentro del bloque, incluso si se produce una excepción
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.AppSettings["conexionBD"]))
                try
                {
                    // Nos conectamos a la BD en base al valor almacenado en la clave de "conexionBD" en AppSettings
                    conexion.Open();
                    Console.WriteLine("CONEXION A BASE DE DATOS EXITOSA");

                    SqlCommand comando = new SqlCommand("INSERT INTO Ingresantes(Nombre, Direccion, Edad, Cuit, Genero, Pais, Curso1, Curso2, Curso3) VALUES (@Nombre, @Direccion, @Edad, @Cuit, @Genero, @Pais, @Curso1, @Curso2, @Curso3)", conexion);
                    //  Almacenamos Estudiante en BD
                    comando.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                    comando.Parameters.AddWithValue("@Direccion", estudiante.Direccion);
                    comando.Parameters.AddWithValue("@Edad", estudiante.Edad);
                    comando.Parameters.AddWithValue("@Cuit", estudiante.Cuit);
                    comando.Parameters.AddWithValue("@Genero", estudiante.Genero);
                    comando.Parameters.AddWithValue("@Pais", estudiante.Pais);
                    comando.Parameters.AddWithValue("@Curso1", estudiante.Curso[0]);
                    comando.Parameters.AddWithValue("@Curso2", estudiante.Curso[1]);
                    comando.Parameters.AddWithValue("@Curso3", estudiante.Curso[2]);

                    comando.ExecuteNonQuery(); 
                    return true;
                }
                catch (System.Exception e)
                {

                    Funciones.mError(Form1.ActiveForm, "Ocurrio un error al conectar con la Base de Datos: " + e.Message);
                    return false;
                }
                finally
                {
                    // Liberamos Recursos
                    conexion.Close();
                }
        }


    }
}

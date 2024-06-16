using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaForm
{
    public class Ingresante
    {
        string nombre;
        string direccion;
        int edad;
        string cuit;
        string genero;
        string pais;
        string[] curso;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Pais { get => pais; set => pais = value; }
        public string[] Curso { get => curso; set => curso = value; }
        public string Cuit { get => cuit; set => cuit = value; }

        public Ingresante(string nombre, string direccion, int edad,string cuit, string genero, string pais, string[] curso)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;
            this.Cuit = cuit;
            this.Genero = genero;
            this.Curso = curso;
            this.Pais = pais;
        }


        public Ingresante() { }

        public override String ToString()
        {
            return Nombre + "\n" + Direccion + "\n" + "edad: " + Edad + "\n" + " Cuit:" + Cuit + "\n" + "Genero :" + Genero + "\n" + Pais;
        }

        public String ToStringCursos() {
            return "Los cursos seleccionados son: \n" + curso[0] + "\n" + curso[1] + "\n" + curso[2];
        }


        public void Guardar(List<Ingresante> ingresantes, List<string> cursos)
        {
            
            //guardar en archivo 
            try
            {
                foreach (string curso in cursos)
                {
                    string filePath = $"{curso}.txt";

                    // Verificar si el archivo ya existe
                    bool fileExists = File.Exists(filePath);

                    // Abrir el archivo en modo de escritura, con la opción de agregar al final si ya existe
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        // Iterar sobre los inscriptos en el curso actual
                        foreach (Ingresante ingresante in ingresantes)
                        {
                            // Verificar si el ingresante ya existe en el archivo
                            if (!fileExists || !File.ReadAllLines(filePath).Contains(ingresante.Nombre))
                            {
                                // Verificar si hay menos de 40 inscriptos en el curso
                                if (ingresantes.Count < 40)
                                {
                                    // Guardar el ingresante en el archivo, separado por el carácter "|"
                                    writer.WriteLine(ingresante.ToString());
                                }
                                else
                                {
                                    // Lanzar una excepción si hay más de 40 inscriptos en el curso
                                    throw new Exception($"El curso {curso} ya tiene 40 inscriptos.");
                                }
                            }
                            else
                            {
                                // Lanzar una excepción si el ingresante ya existe en el curso
                                throw new Exception($"La persona {ingresante.Nombre} ya está inscripta en el curso {curso}.");
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error de E/S: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally {


            }
            
        }


    }
}

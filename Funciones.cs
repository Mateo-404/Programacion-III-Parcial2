using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;

namespace PracticaForm
{
    internal static class Funciones
    {
        /*
      <summary>
       Calcula el dígito verificador dado un CUIT completo o sin él.
       </summary>
       <param name="cuit">El CUIT como String sin guiones</param>
       <returns>El valor del dígito verificador calculado.</returns>
       */

        private static int CalcularDigitoCuit(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;

            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }

            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }


        /* <summary>
         Valida el CUIT ingresado.
         </summary>
         <param name="cuit" />Número de CUIT como string con o sin guiones
         <returns>True si el CUIT es válido y False si no.</returns>
        */
        public static bool ValidaCuit(string cuit)
        {
            if (cuit == null)
            {
                return false;
            }
            //Quito los guiones, el cuit resultante debe tener 11 caracteres.
            cuit = cuit.Replace("-", string.Empty);
            if (cuit.Length != 11)
            {
                return false;
            }
            else
            {
                int calculado = CalcularDigitoCuit(cuit);
                int digito = int.Parse(cuit.Substring(10));
                return calculado == digito;
            }
        }

        //Funcion de guardar de estudiante
        public static bool guardarEstudiante(string nombreCurso, Ingresante estudiante)
        {
            StreamWriter escritor = null;
            try
            {
                string archivoCurso = nombreCurso + ".txt";
                // Se crea Estudiante con el Formato apto para Guardar
                StringBuilder estudianteFormato = new StringBuilder();
                estudianteFormato.Append(estudiante.Nombre)
                                .Append("|")
                                .Append(estudiante.Direccion)
                                .Append("|")
                                .Append(estudiante.Edad)
                                .Append("|")
                                .Append(estudiante.Cuit)
                                .Append("|")
                                .Append(estudiante.Pais)
                                .Append("|")
                                .Append(estudiante.Genero)
                                .Append("|")
                                .Append(nombreCurso)
                                .Append("|");



                // Verificar SI el archivo del CURSO ya EXISTE
                if (File.Exists(archivoCurso))
                {
                    // Lee el Archivo linea por linea
                    string[] lineas = File.ReadAllLines(archivoCurso);

                    // Contar la cantidad de Líneas, para verificar el límite de 40 Inscriptos
                    if (lineas.Length >= 40)
                    {
                        throw new Exception($"El curso '{nombreCurso}' ya tiene 40 inscriptos, NO se pueden agregar más estudiantes.");
                    }

                    // Verificar si el estudiante ya está inscrito en este curso
                    foreach (string linea in lineas)
                    {

                        if (estudianteFormato.ToString().Equals(linea))
                        {
                            throw new Exception("El estudiante ya está inscripto en este curso.");
                        }

                    }

                    // SI TODO ESTÁ EN ORDEN anexamos nuevos Estudiantes al Archivo
                    escritor = new StreamWriter(archivoCurso, true);
                    escritor.WriteLine(estudianteFormato.ToString());

                    //! ESCRIBIR ESTUDIANTE EN BD
                    
                }
                // Caso de que el Archivo NO EXISTA
                else
                {

                    // Crear el Archivo del CURSO
                    // Escribir los datos del estudiante en el archivo del curso
                    File.WriteAllText(archivoCurso, estudianteFormato.ToString() + "\n");
                    //! ESCRIBIR ESTUDIANTE EN BD

                }

                return true;
            }
            catch (Exception e)
            {
                //Lanza la excepcion personalizada
                Funciones.mError(Form3.ActiveForm, e.Message);
                return false;
            }
            finally
            {
                // Liberamos Recursos
                escritor.Close();
                escritor.Dispose();
            }
        }

        // <-- SERIALIZACIONES -->
        // Retornar lista de Alumnos a Partir de Archivo.txt
        public static List<Ingresante> deserializarIngresanteTXT(string archivo)
        {
            StreamReader _lector = null;
            try
            {
                // Si el Archivo existe
                if (File.Exists(archivo))
                {
                    List<Ingresante> _ListaAlumnos = new List<Ingresante>();
                    _lector = new StreamReader(archivo);
                    // Leer Linea por Linea hasta el Fin del archivo
                    while (!_lector.EndOfStream)
                    {
                        string linea = _lector.ReadLine();
                        string[] campos = linea.Split('|');

                        Ingresante _ingresante = new Ingresante();
                        _ingresante.Nombre = campos[0];
                        _ingresante.Direccion = campos[1];
                        _ingresante.Edad = int.Parse(campos[2]);
                        _ingresante.Cuit = campos[3];
                        _ingresante.Pais = campos[4];
                        _ingresante.Genero = campos[5];
                        // Cursos como Lista de Strings
                        string[] _cursos = { campos[6] };
                        _ingresante.Curso = _cursos;

                        _ListaAlumnos.Add(_ingresante);
                    }
                    return _ListaAlumnos;
                }
                else { throw new DirectoryNotFoundException("No se encontro el archivo " + archivo); }
            }
            catch (FileLoadException e)
            {
                Funciones.mError(Form3.ActiveForm, "Archivo existe pero no se puede cargar, intente cerrarlo y vuelva a enviar el Formulario");
                return null;
            }
            catch (System.Security.SecurityException e)
            {
                Funciones.mError(Form3.ActiveForm, "No tiene permisos para leer el archivo, revise las propiedades y vuelva a enviar el Formulario");
                return null;
            }
            catch (InvalidOperationException e)
            {
                Funciones.mError(Form3.ActiveForm, "Operación no permitida, revisar el archivo y vuelva a enviar el Formulario");
                return null;
            }
            catch (IOException e)
            {
                Funciones.mError(Form3.ActiveForm, "Error al cargar Archivo, intente enviarlo de nuevo o modificar las propiedades del Archivo");
                return null;
            }
            catch (Exception e)
            {

                Funciones.mError(Form3.ActiveForm, e.Message);
                Funciones.mAdvertencia(Form3.ActiveForm, "Recomendamos que revise el archivo y vuelva a enviar el Formulario");
                return null;
            }
            finally
            {
                // Liberar Recursos
                if (_lector != null)
                {
                    _lector.Close();
                    _lector.Dispose();
                }
            }
        }
        // XML
        public static bool serializarIngresanteXML(List<Ingresante> _listaAlumnos, string nombre_archivo)
        {
            StreamWriter escritor = null;
            try
            {
                escritor = new StreamWriter(nombre_archivo + ".xml");

                XmlSerializer serializador = new XmlSerializer(typeof(List<Ingresante>));
                serializador.Serialize(escritor, _listaAlumnos);

                return true;
            }
            catch (IOException e)
            {
                Funciones.mError(Form3.ActiveForm, "Error al intentar acceder a la información: " + e.Message);
                return false;
            }
            catch (Exception e)
            {
                Funciones.mError(Form3.ActiveForm, e.Message);
                Funciones.mAdvertencia(Form3.ActiveForm, "Recomendamos que revise el archivo y vuelva a enviar el Formulario");
                return false;
            }
            finally
            {
                // Liberar Recursos
                if (escritor != null)
                {
                    escritor.Close();
                    escritor.Dispose();
                }
            }
        }


        // JSON
        public static bool serializarIngresanteJSON(List<Ingresante> _listaAlumnos, string nombre_archivo)
        {
            StreamWriter _escritor = null;
            try
            {
                _escritor = new StreamWriter(nombre_archivo + ".json");
                //Genero el objeto de configuración de la serialización.
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;
                _escritor.Write(JsonSerializer.Serialize(_listaAlumnos, opciones));
                return true;
            }
            catch (IOException e)
            {
                Funciones.mError(Form3.ActiveForm, "Error al intentar acceder a la información: " + e.Message);
                return false;
            }
            catch (Exception e)
            {
                Funciones.mError(Form3.ActiveForm, e.Message);
                Funciones.mAdvertencia(Form3.ActiveForm, "Recomendamos que revise el archivo y vuelva a enviar el Formulario");
                return false;
            }
            finally
            {
                // Liberar Recursos
                if (_escritor != null)
                {
                    _escritor.Close();
                    _escritor.Dispose();
                }
            }
        }

        // <-- MENSAJES -->
        public static void mError(Form actual, string mensaje)
        {
            MessageBox.Show(actual, mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //Para mostrar mensaje de confirmación
        public static void mOk(Form actual, string mensaje)
        {
            MessageBox.Show(actual, mensaje, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public static bool mConsulta(Form actual, string mensaje)
        {
            if (MessageBox.Show(actual, mensaje, "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
            // MessageBox.Show(actual, mensaje, "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            // MessageBox.Show ("Do you want to exit?", "My Application",  MessageBoxButtons.YesNo, MessageBoxIcon.Question)  
        }

        public static void mAdvertencia(Form actual, string mensaje)
        {
            MessageBox.Show(actual, mensaje, "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }




    }
}

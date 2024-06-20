using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

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

        //Referencia de los archicos de cada curso
        private static string carpetaCursos = @"C:\Users\diazs\OneDrive\Escritorio\repo\Programacion-III-Parcial2\bin\Debug\net6.0-windows";
        //Funcion de guardar de estudiante
        public static bool guardarEstudiante(string nombreCurso, Ingresante estudiante)
        {
            try
            {
                // Verificar y crear la carpeta si no existe
                if (!Directory.Exists(carpetaCursos))
                {
                    Directory.CreateDirectory(carpetaCursos);
                }

                string archivoCurso = Path.Combine(carpetaCursos, nombreCurso + ".txt");
                string estudianteFormato = $"{estudiante.Nombre}|{estudiante.Direccion}|{estudiante.Edad}|{estudiante.Cuit}|{estudiante.Pais}|{estudiante.Genero}|{nombreCurso}|";


                // Verificar si el archivo del curso ya existe
                if (File.Exists(archivoCurso))
                {
                    // Lee el archivo linea por linea
                    var lineas = File.ReadAllLines(archivoCurso);
                    // Contar la cantidad de líneas para verificar el límite de 40 inscriptos
                    if (lineas.Length >= 40)
                    {
                        throw new Exception("El curso ya tiene 40 inscriptos, no se pueden agregar más estudiantes.");
                    }

                    // Verificar si el estudiante ya está inscrito en este curso
                    foreach (string linea in lineas)
                    {

                        if (estudianteFormato.ToString().Equals(linea))
                        {
                            throw new Exception("El estudiante ya está inscripto en este curso.");
                        }

                    }
                }

                // Escribir los datos del estudiante en el archivo del curso
                using StreamWriter streamWriter = new StreamWriter(archivoCurso, true);
                {
                    streamWriter.WriteLine(estudianteFormato.ToString());
                }

                return true;
            }
            catch (Exception)
            {
                //Lanza la excepcion personalizada
                throw;
            }
        }

    // <-- SERIALIZACIONES -->
    // Retornar lista de Alumnos a Partir de Archivo.txt
    public static List<Ingresante> deserializarIngresanteTXT(string archivo){
            // Si el Archivo existe
            try
            {
                if (File.Exists(archivo))
                {
                    List<Ingresante> _ListaAlumnos = new List<Ingresante>();
                    StreamReader _lector = new StreamReader(archivo);
                    // Leer Linea por Linea hasta el Fin del archivo
                    while (!_lector.EndOfStream){
                        string linea = _lector.ReadLine();
                        string[] campos = linea.Split('|');

                        Ingresante _ingresante = new Ingresante();
                        _ingresante.Nombre = campos[0];
                        _ingresante.Direccion = campos[1];
                        _ingresante.Edad = int.Parse(campos[2]);
                        _ingresante.Cuit = campos[3];
                        _ingresante.Genero = campos[4];
                        _ingresante.Pais = campos[5];
                        // Cursos como Lista de Strings
                        string[] _cursos = {campos[6]};
                        _ingresante.Curso = _cursos;

                        _ListaAlumnos.Add(_ingresante);
                    }
                    return _ListaAlumnos;
                }else{throw new Exception("No se encontro el archivo " + archivo);}
            }
            catch (Exception e)
            {
                
                Funciones.mError(Form3.ActiveForm, e.Message);
                Funciones.mAdvertencia(Form3.ActiveForm, "Recomendamos que revise el archivo y vuelva a enviar el Formulario");
                return null;
            }
        }
        // XML
        public static bool serializarIngresanteXML(List<Ingresante> _listaAlumnos, string nombre_archivo){
            try
            {
                StreamWriter escritor = new StreamWriter(nombre_archivo + ".xml");
            
                XmlSerializer serializador = new XmlSerializer(typeof(List<Ingresante>));
                serializador.Serialize(escritor, _listaAlumnos);
            
                return true;
            }
            catch (Exception e)
            {
                Funciones.mError(Form3.ActiveForm, e.Message);
                Funciones.mAdvertencia(Form3.ActiveForm, "Recomendamos que revise el archivo y vuelva a enviar el Formulario");
                return false;
            }
        }


        // JSON
        public static bool serializarIngresanteJSON(List<Ingresante> _listaAlumnos, string nombre_archivo){
           
            try
            {
                StreamWriter _escritor = new StreamWriter(nombre_archivo +".json");
                //Genero el objeto de configuración de la serialización.
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;
                _escritor.Write(JsonSerializer.Serialize(_listaAlumnos, opciones));
                _escritor.Close();
                _escritor.Dispose();
                return true;
            }
            catch (Exception e)
            {
                Funciones.mError(Form3.ActiveForm, e.Message);
                Funciones.mAdvertencia(Form3.ActiveForm, "Recomendamos que revise el archivo y vuelva a enviar el Formulario");
                return false;
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

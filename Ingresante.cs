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


        public void Guardar()
        {
            /*
            //guardar en archivo 

            try
            {

            }
            catch ()
            {

            }
            catch ()
            {

            }
            finally {


            }
            */
        }


    }
}

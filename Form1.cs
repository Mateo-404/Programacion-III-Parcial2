using System;
using System.Drawing.Text;
using System.Data.SqlClient;

namespace PracticaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btoIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            int edad = (int)nupEdad.Value;
            string cuit = mtbCUIT.Text.Trim();
            if (Funciones.ValidaCuit(cuit))
            {
                string genero = "";
                if (rbFemenino.Checked) genero = rbFemenino.Text.Trim();
                if (rbMasculino.Checked) genero = rbMasculino.Text.Trim();
                if (rbNoBinario.Checked) genero = rbNoBinario.Text.Trim();

                string c1 = chkc.Checked ? chkc.Text.Trim() : "";
                string c2 = chkCplus.Checked ? chkCplus.Text.Trim() : "";
                string c3 = chkJavaScript.Checked ? chkJavaScript.Text.Trim() : "";

                string[] curso = new string[3];
                if (c1 == "" && c2 == "" && c3 == "")
                {
                    MessageBox.Show("Seleccione una opcion para curso");
                }
                else
                {
                    curso[0] = c1;
                    curso[1] = c2;
                    curso[2] = c3;
                }

                string pais = lbPais.Text.Trim();

                Ingresante ing = new Ingresante(nombre, direccion, edad, cuit, genero, pais, curso);


                //  Consulta si los Datos son Correctos
                if (Funciones.mConsulta(this, "Datos Ingresante \n" + ing.ToString()))
                {
                    // Consulta SI los Cursos a los que se Inscribió son Correctos 
                    if (MessageBox.Show(ing.ToStringCursos(), "Cursos Inscripto", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        // Para notificar los cursos que se guardaron con éxito
                        string[] cursosGuardados = new string[3];
                        // Guardamos Cursos
                        for (int i = 0; i < 3; i++)
                        {
                            //Verificamos que Curso no este vacio y el guardado sea exitoso
                            if (!curso[i].Equals("") && Funciones.guardarEstudiante(curso[i], ing))
                            {
                                cursosGuardados[i] = curso[i];
                            }
                        }

                        Funciones.mOk(this, "Los cursos Guardados (Localmente) con Exito fueron: " + cursosGuardados[0] + "\n" + cursosGuardados[1] + "\n" + cursosGuardados[2]);
                        // Almacenar en BD
                        if (Conexion.registrarIngresanteBD(ing))
                        {
                            Funciones.mOk(this, "Estudiante Guardado con Exito en la Base de Datos");
                        }
                        else
                        {
                            Funciones.mError(this, "No se pudo registrar el Estudiante en la Base de Datos");
                        }
                        this.Vaciar();
                    }
                    else
                    {
                        MessageBox.Show("Verifique los Datos e intente nuevamente");
                    }

                }
                else
                {
                    MessageBox.Show("Datos Descartados");

                    this.Vaciar();

                }
            }
            else
            {
                MessageBox.Show("Ingrese un Cuit Valido");
            }

        }

        internal void Vaciar()
        {
            txtDireccion.Text = "";
            txtNombre.Text = "";
            nupEdad.Value = 18;
            mtbCUIT.Text = "";
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbNoBinario.Checked = false;
            chkc.Checked = false;
            chkCplus.Checked = false;
            chkJavaScript.Checked = false;
            lbPais.Text = "";
        }

        private void chkCplus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Drawing.Text;

namespace PracticaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                string c3 = chkJavaScript.Checked ? chkCplus.Text.Trim() : "";

                string[] curso = new string[3];
                if (c1 == "" && c2 == "" && c3 == "")
                {
                    MessageBox.Show("Seleccione una opci�n para curso");
                }
                else
                {
                    curso[0] = c1;
                    curso[1] = c2;
                    curso[2] = c3;
                }

                string pais = lbPais.Text.Trim();

                Ingresante ing = new Ingresante(nombre, direccion, edad, cuit, genero, pais, curso);

       

          //      if (MessageBox.Show(ing.ToString(), "Datos Ingresante", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                if (Funciones.mConsulta(this, "Datos Ingresante \n" + ing.ToString()))
                {
                    if (MessageBox.Show(ing.ToStringCursos(), "Cursos Inscripto", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        //ing.Guardar();
                        this.Vaciar();
                    }
                    else
                    {
                        MessageBox.Show("verifique los datos e intente nuevamente");
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
    }
}
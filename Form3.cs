using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clbExpCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Si Ninguno de los 2 Tpos de Serializaciones está Seleccionado
                if (!rbXML.Checked && !rbJSON.Checked) { throw new Exception("Debe seleccionar un tipo de Serialización"); }
                bool xml, json;
                xml = json = false;
                
                if (rbXML.Checked) xml = true; if (rbJSON.Checked) json = true;

                // <-- C# -->
                if (cbCExp.Checked)
                {
                    // Si existe el archivo C#.txt
                    if (File.Exists("C#.txt"))
                    {
                        // Si no hay error al momento de Deserializar
                        if (Funciones.deserializarIngresanteTXT("C#.txt") != null)
                        {
                            // <-- SERIALIZACIONES -->
                            // XML
                            if (xml) Funciones.serializarIngresanteXML(Funciones.deserializarIngresanteTXT("C#.txt"), "cursosC#");
                            // JSON
                            if (json) Funciones.serializarIngresanteJSON(Funciones.deserializarIngresanteTXT("C#.txt"), "cursosC#");

                        }
                    }
                    else { throw new Exception("No se encontro el archivo C#.txt"); }
                }

                // <-- C++ -->
                if (cbExpCPlus.Checked)
                {
                    if (File.Exists("C++.txt"))
                    {
                        if (Funciones.deserializarIngresanteTXT("C++.txt") != null)
                        {
                            if (xml) Funciones.serializarIngresanteXML(Funciones.deserializarIngresanteTXT("C++.txt"), "cursosC++");
                            if (json) Funciones.serializarIngresanteJSON(Funciones.deserializarIngresanteTXT("C++.txt"), "cursosC++");
                        }
                    }
                    else { throw new Exception("No se encontro el archivo C++.txt"); }
                }
                // <-- JavaScript -->
                if (cbExpJavaScript.Checked)
                {
                    if (File.Exists("JavaScript.txt"))
                    {
                        if (Funciones.deserializarIngresanteTXT("JavaScript.txt") != null)
                        {
                            if (xml) Funciones.serializarIngresanteXML(Funciones.deserializarIngresanteTXT("JavaScript.txt"), "cursosJS");
                            if (json) Funciones.serializarIngresanteJSON(Funciones.deserializarIngresanteTXT("JavaScript.txt"), "cursosJS");
                        }
                    }
                    else { throw new Exception("No se encontro el archivo JavaScript.txt"); }
                }
                Funciones.mOk(this, "¡Exportacion realizada con exito!");
            }
            catch (Exception ex)
            {
                Funciones.mAdvertencia(this, ex.Message);
            }
        }
    }
}

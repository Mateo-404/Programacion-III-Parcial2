//Impostaciones necesarias
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //funcion para que el metodo ocupe toda la pantalla
            this.WindowState = FormWindowState.Maximized;
        }

        //metodo para abrir forms para realizar un nuevo regisitro al sistema
        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            catch (Exception ex)
            {
                Funciones.mError(this, ex.Message);
            }
        }

        //metodo de modificar/eliminar que no realizada accion alguna
        private void modificareliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            catch (Exception ex)
            {
                Funciones.mError(this, ex.Message);
            }
        }
    }
}

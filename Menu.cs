using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_5_proyecto_formularios_biblioteca
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void usuariosFrecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usufrecuentes facercade = new usufrecuentes ();
            facercade.ShowDialog();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prestamos facercade = new prestamos();
            facercade.ShowDialog();
        }

        private void acerca_Click(object sender, EventArgs e)
        {
            acercade acerca = new acercade();
            acerca.ShowDialog();

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empleados empleados = new empleados();
            empleados.ShowDialog();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editoriales editorial = new editoriales();
            editorial.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Libros_Nuevos libros_nuevos = new Libros_Nuevos();
            libros_nuevos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Libros_Recomendados ventana = new Libros_Recomendados();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Libros_Nuevos ventana = new Libros_Nuevos();
            ventana.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            proveedores t = new proveedores();
            t.ShowDialog();
        }

        private void reservacionDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reservacion r = new reservacion();
            r.ShowDialog();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda ayuda = new ayuda();
            ayuda.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libros CG = new libros();
            CG.ShowDialog();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autores AT = new autores();
            AT.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ayudaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda_del_Sistema sistemaAyuda = new Ayuda_del_Sistema();
            sistemaAyuda.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ayuda_Click(object sender, EventArgs e)
        {

        }

        private void medioAmbienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medio_Ambiente sistemaAyuda = new Medio_Ambiente ();
            sistemaAyuda.ShowDialog();
        }
    }
}

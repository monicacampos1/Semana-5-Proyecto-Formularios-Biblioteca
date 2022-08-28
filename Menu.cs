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
            Usufrecuentes facercade = new Usufrecuentes ();
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
            Empleados empleados = new Empleados();
            empleados.ShowDialog();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editoriales editorial = new Editoriales();
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
            Proveedores t = new Proveedores();
            t.ShowDialog();
        }

        private void reservacionDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservación r = new Reservación();
            r.ShowDialog();
        }
    }
}

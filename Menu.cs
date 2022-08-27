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
    }
}

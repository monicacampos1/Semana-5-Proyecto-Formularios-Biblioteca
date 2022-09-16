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
    public partial class Editoriales : Form
    {
        public Editoriales()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Editoriales_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Añadir_editorial nuevaEditorial = new Añadir_editorial();
            nuevaEditorial.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}

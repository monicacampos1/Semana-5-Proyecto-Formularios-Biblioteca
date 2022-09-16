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
    public partial class Añadir_empleados : Form
    {
        public Añadir_empleados()
        {
            InitializeComponent();
        }

        private void Añadir_empleados_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Empleados atrasEmpleados = new Empleados();
            atrasEmpleados.ShowDialog();
        }
    }
}

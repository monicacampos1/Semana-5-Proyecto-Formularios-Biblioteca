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
    public partial class Ayuda_del_Sistema : Form
    {
        public Ayuda_del_Sistema()
        {
            InitializeComponent();
        }

        string carpeta = Application.StartupPath + @"\Carpeta ayuda";
        string archivo = @"\Ayuda.txt";


        private void Ayuda_del_Sistema_Load(object sender, EventArgs e)
        {

        }

        private void btnLeer_Click_2(object sender, EventArgs e)
        {
            string ubicacion = carpeta + archivo;

            string leer = System.IO.File.ReadAllText(ubicacion);
            textContenedor.Text = leer;
        }
    }
}

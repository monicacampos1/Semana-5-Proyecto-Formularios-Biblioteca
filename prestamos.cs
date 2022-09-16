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
    public partial class prestamos : Form
    {
        public prestamos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            datosprestamos facercade = new datosprestamos();
            facercade.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}

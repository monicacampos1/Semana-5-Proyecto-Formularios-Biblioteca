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
    public partial class Medio_Ambiente : Form
    {
        public Medio_Ambiente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acción_1 sistemaAyuda = new Acción_1();
            sistemaAyuda.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acción_2 sistemaAyuda = new Acción_2();
            sistemaAyuda.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Acción_3 sistemaAyuda = new Acción_3();
            sistemaAyuda.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Acción_4 sistemaAyuda = new Acción_4();
            sistemaAyuda.ShowDialog();
        }
    }
}

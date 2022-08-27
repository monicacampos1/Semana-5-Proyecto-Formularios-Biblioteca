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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuariosFrecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 facercade = new Form2 ();
            facercade.ShowDialog();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 facercade = new Form3();
            facercade.ShowDialog();
        }
    }
}

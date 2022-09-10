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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusu.Text == "Admin" || txtcontra.Text == "12345")
            {
                Menu f1 = new Menu ();
                f1.Show();
                this.Hide();


            }
            else
                MessageBox.Show("usuario o contraseña incorrecta", " Nose encontro usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
    

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
            if ((label2.Text != "") && (label3.Text != "")) ;
            {
                if ((label2.Text != "Admin") && (label3.Text != "12345")) ;
                {

                    Menu ventana = new Menu();
                    ventana.Show();
                    MessageBox.Show(" Bienvenido al programa");
                    this.Hide();

                }
            }
        }
    }
    }


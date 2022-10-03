using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Semana_5_proyecto_formularios_biblioteca
{
    public partial class usuacces : Form
    {

        // Crear la variable para la conexión 
        public OleDbConnection miconexion;

        // Crear la variable para saber cuál actualizar 
        public string usuario_modificar;


        public usuacces()
        {
            miconexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MINEDUCYT\Source\Repos\Semana-5-Proyecto-Formularios-Biblioteca2.2\sistemausu.mdb");
            InitializeComponent();
        }

        private void fusuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemausuDataSet.tusuario' Puede moverla o quitarla según sea necesario.
            this.tusuarioTableAdapter.Fill(this.sistemausuDataSet.tusuario);
            // Desabilitar campos,se activan al crear nuevo registro
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtnivel.Enabled = false;
            // TODO: estilínea de código carga datos en la tabla
            //Puede moverla o quitarla según sea necesario.
            //this,tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);"sistemaDataSet,tusuario
            // TODO: esta línea de código carga datos en la tabla 'sistemausuDataSet.tusuario' Puede moverla o quitarla según sea necesario.
            this.tusuarioTableAdapter.Fill(this.sistemausuDataSet.tusuario);

        }

        private void bprimero_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveFirst();
        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MovePrevious();
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveNext();
        }
    

        private void bultimo_Click(object sender, EventArgs e)
        {
            this.tusuarioBindingSource.MoveLast();
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtusu.Enabled = true;
            txtclave.Enabled = true;
            txtnivel.Enabled = true;
            txtusu.Text = "";
            txtclave.Text = "";
            txtnivel.Text = "Seleccione nivel";
            txtusu.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbCommand guardar = new OleDbCommand();
                miconexion.Open();

                guardar.Connection = miconexion;
                guardar.CommandType = CommandType.Text;

                guardar.CommandText = "INSERT INTO tusuario ([nombre], [clave],[nivel]) Values('" + txtusu.Text.ToString() + "', '" + txtclave.Text.ToString() + "','" + txtnivel.Text.ToString() + "')";

                guardar.ExecuteNonQuery();

                miconexion.Close();

                bnuevo.Visible = true;
                bguardar.Visible = false;

                //Deshabilitar campos, se activan al crear nuevo registro 
                txtusu.Enabled = false;
                txtclave.Enabled = false;
                txtnivel.Enabled = false;
                bnuevo.Focus();

                //Mensaje que se guardó correctamente 
                MessageBox.Show("Usuario agregado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tusuarioTableAdapter.Fill(this.sistemausuDataSet.tusuario);
                this.tusuarioBindingSource.MoveLast();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusu.Enabled = true;
            txtclave.Enabled = true;
            txtnivel.Enabled = true;
            txtusu.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtusu.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;

                string nom = txtusu.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = txtnivel.Text;

                //Podemos actualizar todos los campos de una vez 
                actualizar.CommandText = "UPDATE tusuario SET nombre = '" + nom + "', clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";

                //Otra forma es utilizar el comando UPDATE para cada campo 
                //actualizar.CommandText = "UPDATE tusuario set nombre = '" + nom + "' 
                //WERE nombre = '" + usuario_modificar + "'"; 
                //actualizar.CommandText = "UPDATE tusuario set clave = '" + cla + "' 
                //WERE nombre = '" + usuario_modificar + "'"; 
                //actualizar.CommandText = "UPDATE tusuario set nivel = '" + niv + "' 
                //WERE nombre = '" + usuario_modificar + "'"; 

                actualizar.ExecuteNonQuery();
                miconexion.Close();

                bmodificar.Visible = true;
                bactualizar.Visible = false;

                txtusu.Enabled = false;
                txtclave.Enabled = false;
                txtnivel.Enabled = false;

                //Mensaje que se guardó correctamente 
                MessageBox.Show("Usuario actualizado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    OleDbCommand eliminar = new OleDbCommand();
                    miconexion.Open();
                    eliminar.Connection = miconexion;
                    eliminar.CommandType = CommandType.Text;

                    eliminar.CommandText = "DELETE FROM tusuario WHERE nombre = '" +
                    txtusu.Text.ToString() + "'";

                    eliminar.ExecuteNonQuery();
                    this.tusuarioBindingSource.MoveNext();
                    miconexion.Close();

                    //Mensaje que se guardó correctamente 
                    MessageBox.Show("Usuario eliminado con éxito", "Ok",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);  
                    this.tusuarioBindingSource.MovePrevious();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
    }

        private void bsalir_Click(object sender, EventArgs e)
        {
            flogin fm = new flogin();
            fm.Show(); //abrir menu 
            this.Hide();//ocultar el formulario de login 
        }
    }
}




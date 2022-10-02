using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Semana_5_proyecto_formularios_biblioteca
{
    public partial class mysqlusu : Form
    {


        //Variables globales
        public string cadena_conexion = "server=localhost;user id=biblioteca1;password=monica9010;database=biblioteca1";

        //Estas variables pueden ir en el boton que corresponde
        //Pero es mas efectivo que sean publicas globales
        public string usuario_modificar;
        public string usuario_eliminar;

        public mysqlusu()
        {
            InitializeComponent();
        }

        private void mysqlusu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'biblioteca1DataSet.usus' Puede moverla o quitarla según sea necesario.
            this.ususTableAdapter.Fill(this.biblioteca1DataSet.usus);
            //Desabilitar campos, se activan al crear nuevo registro
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtnivel.Enabled = false;

            try
            {

                string consulta = "select * from usus";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);

                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "biblioteca1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "biblioteca1";

            }
            catch (MySqlException)
            {

                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void bprimero_Click(object sender, EventArgs e)
        {

          this.ususBindingSource.MoveFirst();
        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.ususBindingSource.MovePrevious();
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {
            this.ususBindingSource.MoveNext();
        }

        private void bultimo_Click(object sender, EventArgs e)
        {
            this.ususBindingSource.MoveLast();
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
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO usus(nombre,clave,nivel) Values(?nombre,?clave,?nivel)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusu.Text;
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 75).Value = txtclave.Text;
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 11).Value = txtnivel.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from usus";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "biblioteca1");
                dataGridView1.DataSource = ds;
                //dataGridView1.DataMember = "bilioteca1";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtnivel.Enabled = false;
            bnuevo.Focus();
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
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string nom = txtusu.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = txtnivel.Text;

                //Hay dos formas de pasar los valores

                //Primera forma de pasar los valores
                //string myInsertQuery = "UPDATE usuarios SET nombre = ?nombre, clave = ?clave, nivel = ?nivel Where nombre = " + usuario_modificar + "";

                //Segunda forma de pasar los valores, usaremos esto
                string myInsertQuery = "UPDATE usus SET nombre = '" + nom + "', clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";

                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                //En caso de usar primera forma, se pasan estos parámetros.
                //myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusuario.Text;
                //myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 75).Value = txtclave.Text;
                //myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 11).Value = lstnivel.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from usus";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "biblioteca1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "biblioteca1";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al modificar el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bmodificar.Visible = true;
            bactualizar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtnivel.Enabled = false;
            bmodificar.Focus();
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "select * from usus Where idusuario = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                myCommand.Connection = myConnection;
                myConnection.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtusu.Text = (myReader.GetString(1));
                    txtclave.Text = (myReader.GetString(2));
                    txtnivel.Text = (myReader.GetString(3));
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myReader.Close();
                myConnection.Close();

            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtnivel.Enabled = false;
            bmodificar.Focus();

            //Finalizada la busqueda y llenado de campos
            //guardamos el contenido de txtusuario.Text por si se quiere eliminar por medio del usuario
            //usuario_eliminar = txtusuario.Text;
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "delete from usus Where idusuario = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from usus";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "biblioteca1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "biblioteca1";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al eliminar el usuario, primero realice búsqueda del usuario y después puede eliminar.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusu.Enabled = false;
            txtclave.Enabled = false;
            txtnivel.Enabled = false;

            txtusu.Text = "";
            txtclave.Text = "";
            txtnivel.Text = "Seleccione nivel";
            txtbuscar.Focus();


        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            flogin fm = new flogin();
            fm.Show(); //abrir menu 
            this.Hide();//ocultar el formulario de login 
        }
    }
}




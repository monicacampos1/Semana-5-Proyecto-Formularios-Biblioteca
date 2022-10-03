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
    public partial class Libros : Form
    {


        //Variables globales
        public string cadena_conexion = "server=localhost;user id=biblioteca1;password=monica9010;database=biblioteca1;persistsecurityinfo=True";

        //Estas variables pueden ir en el boton que corresponde
        //Pero es mas efectivo que sean publicas globales
        public string usuario_modificar;
        public string usuario_eliminar;

        public Libros()
        {

            InitializeComponent();
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'biblioteca1DataSet.libros' Puede moverla o quitarla según sea necesario.
            //this.librosTableAdapter.Fill(this.biblioteca1DataSet.libros);


            //Desabilitar campos, se activan al crear nuevo registro
            txtnombre.Enabled = false;
            txtautor.Enabled = false;
            txtcate.Enabled = false;
            txteditorial.Enabled = false;
            txtestante.Enabled = false;
            txttotal.Enabled = false;


            try
            {

                string consulta = "select * from libros";

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
            this.librosBindingSource.MoveFirst();
        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.librosBindingSource.MovePrevious();
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {
            this.librosBindingSource.MoveNext();
        }

        private void bultimo_Click(object sender, EventArgs e)
        {
            this.librosBindingSource.MoveLast();
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txtautor.Enabled = true;
            txtcate.Enabled = true;
            txteditorial.Enabled = true;
            txtestante.Enabled = true;
            txttotal.Enabled = true;
            txtnombre.Text = "";
            txtautor.Text = "";
            txtcate.Text = "";
            txteditorial.Text = "";
            txtestante.Text = "";
            txttotal.Text = "";
            txtnombre.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "INSERT INTO libros (nombre,autor,editorial,categoria,estante,total) Values(?nombre,?autor,?editorial,?categoria,?estante,?total)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 50).Value = txtnombre.Text;
                myCommand.Parameters.Add("?autor", MySqlDbType.VarChar, 50).Value = txtautor.Text;
                myCommand.Parameters.Add("?editorial", MySqlDbType.VarChar, 50).Value = txteditorial.Text;
                myCommand.Parameters.Add("?categoria", MySqlDbType.VarChar, 50).Value = txtcate.Text;
                myCommand.Parameters.Add("?estante", MySqlDbType.VarChar, 50).Value = txtestante.Text;
                myCommand.Parameters.Add("?total", MySqlDbType.Int32, 11).Value = txttotal.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from libros";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "biblioteca1");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "biblioteca1";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro

            txtnombre.Enabled = false;
            txtautor.Enabled = false;
            txtcate.Enabled = false;
            txteditorial.Enabled = false;
            txtestante.Enabled = false;
            txttotal.Enabled = false;
            bnuevo.Focus();
        }


        //El boton nuevo solo habilita el formulario para actualizar el registro actual
        private void bmodificar_Click(object sender, EventArgs e)
        {

            txtnombre.Enabled = true;
            txtautor.Enabled = true;
            txtcate.Enabled = true;
            txteditorial.Enabled = true;
            txtestante.Enabled = true;
            txttotal.Enabled = true;

            txtnombre.Focus();

            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtnombre.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string nom = txtnombre.Text.ToString();
                string aut = txtautor.Text.ToString();
                string cate = txtcate.Text.ToString();
                string edi = txteditorial.Text.ToString();
                string estan = txtestante.Text.ToString();
                string tot = txttotal.Text.ToString();


                //Hay dos formas de pasar los valores

                //Primera forma de pasar los valores
                //string myInsertQuery = "UPDATE usuarios SET nombre = ?nombre, clave = ?clave, nivel = ?nivel Where nombre = " + usuario_modificar + "";

                //Segunda forma de pasar los valores, usaremos esto
                string myInsertQuery = "UPDATE libros SET nombre = '" + nom + "', autor = '" + aut + "',categoria = '" + cate + "',editorial = '" + edi + "',estante = '" + estan + "',total= '" + tot + "' WHERE nombre = '" + usuario_modificar + "'";

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

                string consulta = "select * from libros";

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
            txtnombre.Enabled = false;
            txtautor.Enabled = false;
            txtcate.Enabled = false;
            txteditorial.Enabled = false;
            txtestante.Enabled = false;
            txttotal.Enabled = false;
            bmodificar.Focus();

        }

        private void bbuscar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                string myInsertQuery = "select * from libros Where idlibro = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);

                myCommand.Connection = myConnection;
                myConnection.Open();

                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {

                    txtnombre.Text = (myReader.GetString(1));
                    txtautor.Text = (myReader.GetString(2));
                    txtcate.Text = (myReader.GetString(3));
                    txteditorial.Text = (myReader.GetString(4));
                    txtestante.Text = (myReader.GetString(5));
                    txttotal.Text = (myReader.GetString(6));
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
            txtnombre.Enabled = false;
            txtautor.Enabled = false;
            txtcate.Enabled = false;
            txteditorial.Enabled = false;
            txtestante.Enabled = false;
            txttotal.Enabled = false;
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

                string myInsertQuery = "delete from libros Where idlibro = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string consulta = "select * from libros";

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

            txtnombre.Enabled = false;
            txtautor.Enabled = false;
            txtcate.Enabled = false;
            txteditorial.Enabled = false;
            txtestante.Enabled = false;
            txttotal.Enabled = false;
            txtnombre.Text = "";
            txtautor.Text = "";
            txtcate.Text = "";
            txteditorial.Text = "";
            txtestante.Text = "";
            txttotal.Text = "";
            txtbuscar.Focus();


        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bmodificar_Click_1(object sender, EventArgs e)
        {


            txtnombre.Enabled = true;
            txtautor.Enabled = true;
            txtcate.Enabled = true;
            txteditorial.Enabled = true;
            txtestante.Enabled = true;
            txttotal.Enabled = true;
            txtnombre.Focus();

            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtnombre.Text.ToString();





        }
    }
}
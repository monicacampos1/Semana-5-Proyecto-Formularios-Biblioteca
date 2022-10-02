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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Semana_5_proyecto_formularios_biblioteca
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void flogin_Load(object sender, EventArgs e)
        {

        }

        private void bsql_Click(object sender, EventArgs e)
        {
            try

            {
                //crear la conexion 
                SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-NFDMETJ;Initial Catalog=sistema;Integrated Security=True");

                //abrir conexion 
                conexion.Open();

                //cadena de consulta 
                string consultax;

                consultax = "select nombre, clave from tusuarios where nombre = '" + txtusu.Text + "'And clave = '" + txtclave.Text + "' ";

                SqlCommand consulta = new SqlCommand(consultax, conexion);

                //ejecuta una instruccion de sql devolviendo el numero de filas encontradas 
                consulta.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(consulta);

                //Llenando el dataAdapter con los datos de la tabla 
                da.Fill(ds, "tusuarios");

                //fila de la tabla con la que se trabajara 
                DataRow registro;
                registro = ds.Tables["tusuarios"].Rows[0];

                //evaluando que clave y usuario sean correctos 
                if ((txtusu.Text == registro["nombre"].ToString()) || (txtclave.Text == registro["clave"].ToString()))
                {
                    //llamando formulario principal llamado menu 
                    Menu fm = new Menu();
                    fm.Show(); //abrir menu 
                    this.Hide();//ocultar el formulario de login 
                }

            }

            catch
            {
                //en caso que la clave sea incorrecta mostrar mensaje de error 
                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }

        private void baccess_Click(object sender, EventArgs e)
        {
            try
            {

                //Creado la variable para la nueva conexion 
                OleDbConnection conexion_access = new OleDbConnection();
                //Cadena de conexión para la base de datos 
                //Se recomienda generar la cadena de conexion para evitar errores 
                conexion_access.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MINEDUCYT\Source\Repos\Semana-5-Proyecto-Formularios-Biblioteca2.2\sistemausu.mdb";
                //Abriendo conexion 
                conexion_access.Open();

                //Consulta a tabla de usuarios en la base de datos 
                //Para encontrar fila que tiene los datos del usuario y clave ingresados 
                OleDbDataAdapter consulta = new OleDbDataAdapter("SELECT * FROM tusuario",
                conexion_access);

                //OleDbDataReader reader = command.ExecuteReader(); 
                DataSet resultado = new DataSet();
                consulta.Fill(resultado);

                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    if ((txtusu.Text == registro["nombre"].ToString()) && (txtclave.Text == registro["clave"].ToString()))
                    {
                        //llamando formulario principal llamado menu 
                        Menu fm = new Menu();
                        fm.Show(); //abrir menu 
                        this.Hide();//ocultar el formulario de login 
                    }

                } //Cierre de ciclo for 

            } //Cierre de Try 

            //Si la conexión falla muestra mensaje de error 
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                //en caso que usuario y clave sean incorrectos mostrar mensaje de error 
                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtusu.Focus();
            }

            //Finalizando la conexión 
            //conexion_access.Close();

        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            fusuarios fm = new fusuarios();
            fm.Show(); //abrir menu 
            this.Hide();//ocultar el formulario de login 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlusu fm = new mysqlusu();
            fm.Show(); //abrir menu 
            this.Hide();//ocultar el formulario de login 
        }

        private void brmysql_Click(object sender, EventArgs e)
        {
            mysqlusu fm = new mysqlusu();
            fm.Show(); //abrir menu 
            this.Hide();//ocultar el formulario de login 

        }

        private void bmysql_Click(object sender, EventArgs e)
        {

            try

            {

                MySqlConnection conn = new MySqlConnection("server=localhost;user id=biblioteca1;password=monica9010;database=biblioteca1");

                conn.Open();

                MySqlCommand Pedir = new MySqlCommand("Select nombre, clave from usus where nombre = '" + txtusu.Text + "'And clave = '" + txtclave.Text + "'", conn);
                Pedir.ExecuteNonQuery();
                DataSet fe = new DataSet();
                MySqlDataAdapter te = new MySqlDataAdapter(Pedir);

                te.Fill(fe, "usus");

                DataRow res;
                res = fe.Tables["usus"].Rows[0];

                if ((txtusu.Text == res["nombre"].ToString()) || (txtclave.Text == res["clave"].ToString()))
                {

                    Menu fprincipal = new Menu();
                    fprincipal.Show();
                    this.Hide();
                }

            }
            catch
            {


                txtusu.Clear();
                txtclave.Clear();

                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
    }

    

  
    
    


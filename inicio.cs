﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;


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

        private void button3_Click(object sender, EventArgs e)
        {
            try

            {

                //Creado la variable para la nueva conexion 
                OleDbConnection conexion = new OleDbConnection();

                //Cadena de conexión para la base de datos 
                //Se recomienda generar la cadena de conexion para evitar errores 
                //conexion.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data 
                //System.LocalDataStoreSlot Source  = C:\Users\MINEDUCYT\Desktop\Ciclo 2\Programacion 1\base\login1.mdb; Persist Security Info = False; "; 

                conexion.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\MINEDUCYT\Desktop\CICLO 2\Programación computacional I\basededatos\computo2.accdb";

                //Abriendo conexion 
                conexion.Open();

                //Consulta a tabla de usuarios en la base de datos 
                //Para encontrar fila que tiene los datos del usuario y clave ingresados 
                OleDbDataAdapter consulta = new OleDbDataAdapter("SELECT * FROM usuario",
                 conexion);

                //OleDbDataReader reader = command.ExecuteReader(); 
                DataSet resultado = new DataSet();
                consulta.Fill(resultado);

                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    if ((txtusu.Text == registro["nombre"].ToString()) && (txtcontra.Text ==
                    registro["clave"].ToString()))
                    {
                        //llamando formulario principal llamado menu 
                        Menu fm = new Menu();
                        fm.Show(); //abrir menu 
                        this.Hide();//ocultar el formulario de login 
                    }

                } //Cierre de ciclo for 

            } //Cierre de Try 

            //Si la conexion falla muestra mensaje de error 
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                //en caso que usuario y clave sean incorrectos mostrar mensaje de error 
                MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtusu.Focus();
            }

            //Finalizando la conexión 
            // conexion.Close();

        }
    }

    }

    

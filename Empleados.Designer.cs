﻿
namespace Semana_5_proyecto_formularios_biblioteca
{
    partial class empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textEmpleado = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bactualizar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.banterior = new System.Windows.Forms.Button();
            this.bprimero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tabla de empleados";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(206, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 26);
            this.textBox1.TabIndex = 58;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(187, 93);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(0, 20);
            this.labelFecha.TabIndex = 56;
            this.labelFecha.Visible = false;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Jefe",
            "Administrador",
            "Empleado"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(206, 241);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(254, 28);
            this.comboBoxCategoria.TabIndex = 55;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // textEmpleado
            // 
            this.textEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmpleado.Location = new System.Drawing.Point(206, 149);
            this.textEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.textEmpleado.Name = "textEmpleado";
            this.textEmpleado.Size = new System.Drawing.Size(254, 26);
            this.textEmpleado.TabIndex = 54;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(206, 197);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(254, 26);
            this.textBoxTelefono.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Cargo Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Numero de teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Nombre de empleado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Fecha de registro";
            // 
            // bbuscar
            // 
            this.bbuscar.BackColor = System.Drawing.Color.PaleGreen;
            this.bbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscar.Location = new System.Drawing.Point(783, 90);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(86, 29);
            this.bbuscar.TabIndex = 111;
            this.bbuscar.Text = "Buscar";
            this.bbuscar.UseVisualStyleBackColor = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(580, 93);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(180, 20);
            this.txtbuscar.TabIndex = 110;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(558, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 253);
            this.dataGridView1.TabIndex = 109;
            // 
            // bactualizar
            // 
            this.bactualizar.BackColor = System.Drawing.Color.PaleGreen;
            this.bactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bactualizar.Location = new System.Drawing.Point(303, 407);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(86, 29);
            this.bactualizar.TabIndex = 121;
            this.bactualizar.Text = "Actualizar ";
            this.bactualizar.UseVisualStyleBackColor = false;
            this.bactualizar.Visible = false;
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.PaleGreen;
            this.bguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Location = new System.Drawing.Point(41, 407);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(86, 29);
            this.bguardar.TabIndex = 120;
            this.bguardar.Text = "Guardar ";
            this.bguardar.UseVisualStyleBackColor = false;
            this.bguardar.Visible = false;
            // 
            // bsalir
            // 
            this.bsalir.BackColor = System.Drawing.Color.PaleGreen;
            this.bsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.Location = new System.Drawing.Point(444, 354);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(86, 29);
            this.bsalir.TabIndex = 119;
            this.bsalir.Text = "Salir ";
            this.bsalir.UseVisualStyleBackColor = false;
            // 
            // bmodificar
            // 
            this.bmodificar.BackColor = System.Drawing.Color.PaleGreen;
            this.bmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodificar.Location = new System.Drawing.Point(303, 354);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(86, 29);
            this.bmodificar.TabIndex = 118;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = false;
            // 
            // beliminar
            // 
            this.beliminar.BackColor = System.Drawing.Color.PaleGreen;
            this.beliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.Location = new System.Drawing.Point(167, 354);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(86, 29);
            this.beliminar.TabIndex = 117;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = false;
            // 
            // bnuevo
            // 
            this.bnuevo.BackColor = System.Drawing.Color.PaleGreen;
            this.bnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo.Location = new System.Drawing.Point(41, 354);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(86, 29);
            this.bnuevo.TabIndex = 116;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = false;
            // 
            // bultimo
            // 
            this.bultimo.BackColor = System.Drawing.Color.PaleGreen;
            this.bultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bultimo.Location = new System.Drawing.Point(444, 299);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(86, 29);
            this.bultimo.TabIndex = 115;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = false;
            // 
            // bsiguiente
            // 
            this.bsiguiente.BackColor = System.Drawing.Color.PaleGreen;
            this.bsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiguiente.Location = new System.Drawing.Point(303, 299);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(86, 29);
            this.bsiguiente.TabIndex = 114;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = false;
            // 
            // banterior
            // 
            this.banterior.BackColor = System.Drawing.Color.PaleGreen;
            this.banterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banterior.Location = new System.Drawing.Point(167, 299);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(86, 29);
            this.banterior.TabIndex = 113;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = false;
            // 
            // bprimero
            // 
            this.bprimero.BackColor = System.Drawing.Color.PaleGreen;
            this.bprimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprimero.Location = new System.Drawing.Point(41, 299);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(86, 29);
            this.bprimero.TabIndex = 112;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = false;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(995, 486);
            this.Controls.Add(this.bactualizar);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.bprimero);
            this.Controls.Add(this.bbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.textEmpleado);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sistema Bibliotecario Lectores sin rumbo - Formulario empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox textEmpleado;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.Button bprimero;
    }
}

namespace Semana_5_proyecto_formularios_biblioteca
{
    partial class mysqlusu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mysqlusu));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtnivel = new System.Windows.Forms.ComboBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.bbuscar = new System.Windows.Forms.Button();
            this.biblioteca1DataSet = new Semana_5_proyecto_formularios_biblioteca.biblioteca1DataSet();
            this.ususBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ususTableAdapter = new Semana_5_proyecto_formularios_biblioteca.biblioteca1DataSetTableAdapters.ususTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ususBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bactualizar
            // 
            this.bactualizar.BackColor = System.Drawing.Color.PaleGreen;
            this.bactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bactualizar.Location = new System.Drawing.Point(274, 367);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(86, 29);
            this.bactualizar.TabIndex = 95;
            this.bactualizar.Text = "Actualizar ";
            this.bactualizar.UseVisualStyleBackColor = false;
            this.bactualizar.Visible = false;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.PaleGreen;
            this.bguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Location = new System.Drawing.Point(12, 367);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(86, 29);
            this.bguardar.TabIndex = 94;
            this.bguardar.Text = "Guardar ";
            this.bguardar.UseVisualStyleBackColor = false;
            this.bguardar.Visible = false;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bsalir
            // 
            this.bsalir.BackColor = System.Drawing.Color.PaleGreen;
            this.bsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.Location = new System.Drawing.Point(415, 314);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(86, 29);
            this.bsalir.TabIndex = 93;
            this.bsalir.Text = "Salir ";
            this.bsalir.UseVisualStyleBackColor = false;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.BackColor = System.Drawing.Color.PaleGreen;
            this.bmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodificar.Location = new System.Drawing.Point(274, 314);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(86, 29);
            this.bmodificar.TabIndex = 92;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = false;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // beliminar
            // 
            this.beliminar.BackColor = System.Drawing.Color.PaleGreen;
            this.beliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.Location = new System.Drawing.Point(138, 314);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(86, 29);
            this.beliminar.TabIndex = 91;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = false;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.BackColor = System.Drawing.Color.PaleGreen;
            this.bnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo.Location = new System.Drawing.Point(12, 314);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(86, 29);
            this.bnuevo.TabIndex = 90;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = false;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // bultimo
            // 
            this.bultimo.BackColor = System.Drawing.Color.PaleGreen;
            this.bultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bultimo.Location = new System.Drawing.Point(415, 259);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(86, 29);
            this.bultimo.TabIndex = 89;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = false;
            this.bultimo.Click += new System.EventHandler(this.bultimo_Click);
            // 
            // bsiguiente
            // 
            this.bsiguiente.BackColor = System.Drawing.Color.PaleGreen;
            this.bsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiguiente.Location = new System.Drawing.Point(274, 259);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(86, 29);
            this.bsiguiente.TabIndex = 88;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = false;
            this.bsiguiente.Click += new System.EventHandler(this.bsiguiente_Click);
            // 
            // banterior
            // 
            this.banterior.BackColor = System.Drawing.Color.PaleGreen;
            this.banterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banterior.Location = new System.Drawing.Point(138, 259);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(86, 29);
            this.banterior.TabIndex = 87;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = false;
            this.banterior.Click += new System.EventHandler(this.banterior_Click);
            // 
            // bprimero
            // 
            this.bprimero.BackColor = System.Drawing.Color.PaleGreen;
            this.bprimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprimero.Location = new System.Drawing.Point(12, 259);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(86, 29);
            this.bprimero.TabIndex = 86;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = false;
            this.bprimero.Click += new System.EventHandler(this.bprimero_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // txtnivel
            // 
            this.txtnivel.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.ususBindingSource, "nivel", true));
            this.txtnivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ususBindingSource, "nivel", true));
            this.txtnivel.FormattingEnabled = true;
            this.txtnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.txtnivel.Location = new System.Drawing.Point(311, 195);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(180, 21);
            this.txtnivel.TabIndex = 84;
            // 
            // txtclave
            // 
            this.txtclave.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.ususBindingSource, "clave", true));
            this.txtclave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ususBindingSource, "clave", true));
            this.txtclave.Location = new System.Drawing.Point(311, 130);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(180, 20);
            this.txtclave.TabIndex = 83;
            // 
            // txtusu
            // 
            this.txtusu.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.ususBindingSource, "nombre", true));
            this.txtusu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ususBindingSource, "nombre", true));
            this.txtusu.Location = new System.Drawing.Point(311, 71);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(180, 20);
            this.txtusu.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 81;
            this.label5.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 80;
            this.label4.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Usuario";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(518, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 253);
            this.dataGridView1.TabIndex = 96;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(552, 73);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(180, 20);
            this.txtbuscar.TabIndex = 97;
            // 
            // bbuscar
            // 
            this.bbuscar.BackColor = System.Drawing.Color.PaleGreen;
            this.bbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbuscar.Location = new System.Drawing.Point(760, 73);
            this.bbuscar.Name = "bbuscar";
            this.bbuscar.Size = new System.Drawing.Size(86, 29);
            this.bbuscar.TabIndex = 98;
            this.bbuscar.Text = "Buscar";
            this.bbuscar.UseVisualStyleBackColor = false;
            this.bbuscar.Click += new System.EventHandler(this.bbuscar_Click);
            // 
            // biblioteca1DataSet
            // 
            this.biblioteca1DataSet.DataSetName = "biblioteca1DataSet";
            this.biblioteca1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ususBindingSource
            // 
            this.ususBindingSource.DataMember = "usus";
            this.ususBindingSource.DataSource = this.biblioteca1DataSet;
            // 
            // ususTableAdapter
            // 
            this.ususTableAdapter.ClearBeforeFill = true;
            // 
            // mysqlusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(965, 442);
            this.Controls.Add(this.bbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mysqlusu";
            this.Text = "Sistema Bibliotecario Lectores sin rumbo - Formulario login MySql";
            this.Load += new System.EventHandler(this.mysqlusu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioteca1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ususBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox txtnivel;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button bbuscar;
        private biblioteca1DataSet biblioteca1DataSet;
        private System.Windows.Forms.BindingSource ususBindingSource;
        private biblioteca1DataSetTableAdapters.ususTableAdapter ususTableAdapter;
    }
}
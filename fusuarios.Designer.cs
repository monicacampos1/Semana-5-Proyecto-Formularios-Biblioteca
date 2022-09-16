
namespace Semana_5_proyecto_formularios_biblioteca
{
    partial class fusuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fusuarios));
            this.label6 = new System.Windows.Forms.Label();
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
            this.sistemausuDataSet = new Semana_5_proyecto_formularios_biblioteca.sistemausuDataSet();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.tusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tusuarioTableAdapter = new Semana_5_proyecto_formularios_biblioteca.sistemausuDataSetTableAdapters.tusuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemausuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Registro de usuarios ";
            // 
            // bactualizar
            // 
            this.bactualizar.BackColor = System.Drawing.Color.PaleGreen;
            this.bactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bactualizar.Location = new System.Drawing.Point(306, 382);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(86, 29);
            this.bactualizar.TabIndex = 76;
            this.bactualizar.Text = "Actualizar ";
            this.bactualizar.UseVisualStyleBackColor = false;
            this.bactualizar.Visible = false;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // bguardar
            // 
            this.bguardar.BackColor = System.Drawing.Color.PaleGreen;
            this.bguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Location = new System.Drawing.Point(44, 382);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(86, 29);
            this.bguardar.TabIndex = 75;
            this.bguardar.Text = "Guardar ";
            this.bguardar.UseVisualStyleBackColor = false;
            this.bguardar.Visible = false;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bsalir
            // 
            this.bsalir.BackColor = System.Drawing.Color.PaleGreen;
            this.bsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.Location = new System.Drawing.Point(447, 329);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(86, 29);
            this.bsalir.TabIndex = 74;
            this.bsalir.Text = "Salir ";
            this.bsalir.UseVisualStyleBackColor = false;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.BackColor = System.Drawing.Color.PaleGreen;
            this.bmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmodificar.Location = new System.Drawing.Point(306, 329);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(86, 29);
            this.bmodificar.TabIndex = 73;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = false;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // beliminar
            // 
            this.beliminar.BackColor = System.Drawing.Color.PaleGreen;
            this.beliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beliminar.Location = new System.Drawing.Point(170, 329);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(86, 29);
            this.beliminar.TabIndex = 72;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = false;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.BackColor = System.Drawing.Color.PaleGreen;
            this.bnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnuevo.Location = new System.Drawing.Point(44, 329);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(86, 29);
            this.bnuevo.TabIndex = 71;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = false;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // bultimo
            // 
            this.bultimo.BackColor = System.Drawing.Color.PaleGreen;
            this.bultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bultimo.Location = new System.Drawing.Point(447, 274);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(86, 29);
            this.bultimo.TabIndex = 70;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = false;
            this.bultimo.Click += new System.EventHandler(this.bultimo_Click);
            // 
            // bsiguiente
            // 
            this.bsiguiente.BackColor = System.Drawing.Color.PaleGreen;
            this.bsiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsiguiente.Location = new System.Drawing.Point(306, 274);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(86, 29);
            this.bsiguiente.TabIndex = 69;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = false;
            this.bsiguiente.Click += new System.EventHandler(this.bsiguiente_Click);
            // 
            // banterior
            // 
            this.banterior.BackColor = System.Drawing.Color.PaleGreen;
            this.banterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banterior.Location = new System.Drawing.Point(170, 274);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(86, 29);
            this.banterior.TabIndex = 68;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = false;
            this.banterior.Click += new System.EventHandler(this.banterior_Click);
            // 
            // bprimero
            // 
            this.bprimero.BackColor = System.Drawing.Color.PaleGreen;
            this.bprimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprimero.Location = new System.Drawing.Point(44, 274);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(86, 29);
            this.bprimero.TabIndex = 67;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = false;
            this.bprimero.Click += new System.EventHandler(this.bprimero_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // txtnivel
            // 
            this.txtnivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sistemausuDataSet, "tusuario.nivel", true));
            this.txtnivel.FormattingEnabled = true;
            this.txtnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.txtnivel.Location = new System.Drawing.Point(343, 210);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(180, 21);
            this.txtnivel.TabIndex = 65;
            // 
            // sistemausuDataSet
            // 
            this.sistemausuDataSet.DataSetName = "sistemausuDataSet";
            this.sistemausuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtclave
            // 
            this.txtclave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sistemausuDataSet, "tusuario.clave", true));
            this.txtclave.Location = new System.Drawing.Point(343, 145);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(180, 20);
            this.txtclave.TabIndex = 64;
            // 
            // txtusu
            // 
            this.txtusu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tusuarioBindingSource, "nombre", true));
            this.txtusu.Location = new System.Drawing.Point(343, 86);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(180, 20);
            this.txtusu.TabIndex = 63;
            // 
            // tusuarioBindingSource
            // 
            this.tusuarioBindingSource.DataMember = "tusuario";
            this.tusuarioBindingSource.DataSource = this.sistemausuDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(256, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Usuario";
            // 
            // tusuarioTableAdapter
            // 
            this.tusuarioTableAdapter.ClearBeforeFill = true;
            // 
            // fusuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.label6);
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
            this.Name = "fusuarios";
            this.Text = "fusuarios";
            this.Load += new System.EventHandler(this.fusuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemausuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tusuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
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
        private sistemausuDataSet sistemausuDataSet;
        private System.Windows.Forms.BindingSource tusuarioBindingSource;
        private sistemausuDataSetTableAdapters.tusuarioTableAdapter tusuarioTableAdapter;
    }
}
﻿
namespace Semana_5_proyecto_formularios_biblioteca
{
    partial class flogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flogin));
            this.baccess = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bsql = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // baccess
            // 
            this.baccess.BackColor = System.Drawing.Color.PaleGreen;
            this.baccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baccess.Location = new System.Drawing.Point(327, 223);
            this.baccess.Name = "baccess";
            this.baccess.Size = new System.Drawing.Size(117, 31);
            this.baccess.TabIndex = 31;
            this.baccess.Text = "Iniciar con Access";
            this.baccess.UseVisualStyleBackColor = false;
            this.baccess.Click += new System.EventHandler(this.baccess_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // bsql
            // 
            this.bsql.BackColor = System.Drawing.Color.PaleGreen;
            this.bsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsql.Location = new System.Drawing.Point(186, 223);
            this.bsql.Name = "bsql";
            this.bsql.Size = new System.Drawing.Size(117, 31);
            this.bsql.TabIndex = 29;
            this.bsql.Text = "Iniciar SQL Server ";
            this.bsql.UseVisualStyleBackColor = false;
            this.bsql.Click += new System.EventHandler(this.bsql_Click);
            // 
            // bsalir
            // 
            this.bsalir.BackColor = System.Drawing.Color.PaleGreen;
            this.bsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsalir.Location = new System.Drawing.Point(22, 223);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(132, 31);
            this.bsalir.TabIndex = 28;
            this.bsalir.Text = "Registrar con Access";
            this.bsalir.UseVisualStyleBackColor = false;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(209, 129);
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '*';
            this.txtclave.Size = new System.Drawing.Size(151, 20);
            this.txtclave.TabIndex = 27;
            this.txtclave.Tag = "";
            // 
            // txtusu
            // 
            this.txtusu.Location = new System.Drawing.Point(209, 77);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(151, 20);
            this.txtusu.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Inicio de sesion ";
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 303);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baccess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bsql);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "flogin";
            this.Text = "flogin";
            this.Load += new System.EventHandler(this.flogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baccess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bsql;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}